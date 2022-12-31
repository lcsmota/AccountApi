using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AccountApi.DTOs;
using AccountApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AccountApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
[Produces("application/json")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;
    public AuthController(UserManager<IdentityUser> userManager,
                          SignInManager<IdentityUser> signInManager,
                          IMapper mapper,
                          IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
        _configuration = configuration;
    }

    [HttpPost("Register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> RegisterUserAsync(UserDTO userDTO)
    {
        var user = _mapper.Map<IdentityUser>(userDTO);

        var result = await _userManager.CreateAsync(user, userDTO.Password);

        if (!result.Succeeded)
            return BadRequest(result.Errors);

        await _signInManager.SignInAsync(user, isPersistent: false);

        return Ok();
    }

    [HttpPost("Login")]
    [ProducesResponseType(typeof(UserToken), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> LoginAsync(UserDTO userDTO)
    {
        var result = await _signInManager.PasswordSignInAsync(userDTO.Email, userDTO.Password, isPersistent: false, lockoutOnFailure: false);

        return result.Succeeded
            ? Ok(GenerateToken(userDTO))
            : BadRequest("Invalid login!");
    }

    private UserToken GenerateToken(UserDTO userDTO)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.UniqueName, userDTO.Email),
            new Claim("Rest Api", ".NET Core 6"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var exp = _configuration.GetSection("TokenConf:ExpireMinutes").Value;
        var expiration = DateTime.UtcNow.AddMinutes(double.Parse(exp));

        var token = new JwtSecurityToken(
            issuer: _configuration.GetSection("TokenConf:Iss").Value,
            audience: _configuration.GetSection("TokenConf:Aud").Value,
            claims: claims,
            expires: expiration,
            signingCredentials: creds);

        return new UserToken
        {
            Authenticated = true,
            Expiration = expiration,
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Message = "Token JWT OK"
        };
    }
}
