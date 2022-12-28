using AccountApi.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IMapper _mapper;
    public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMapper mapper)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
    }

    [HttpPost("Register")]
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
    public async Task<ActionResult> LoginAsync(UserDTO userDTO)
    {
        var result = await _signInManager.PasswordSignInAsync(userDTO.Email, userDTO.Password, isPersistent: false, lockoutOnFailure: false);

        return result.Succeeded
            ? Ok()
            : BadRequest("Invalid login!");
    }
}
