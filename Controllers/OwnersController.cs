using AccountApi.DTOs;
using AccountApi.Interfaces;
using AccountApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OwnersController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public OwnersController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllOwnersAsync()
    {
        try
        {
            var owners = await _unitOfWork.OwnerRepository.GetOwnersAsync();

            var onwersDtos = _mapper.Map<IEnumerable<OwnerDTO>>(owners);

            return Ok(onwersDtos);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}", Name = "GetOwnerById")]
    public async Task<ActionResult> GetOwnerAsync(Guid id)
    {
        try
        {
            var owner = await _unitOfWork.OwnerRepository.GetOwnerByIdAsync(id);

            if (owner is null) return NotFound("Owner not found.");

            var onwerDto = _mapper.Map<OwnerDTO>(owner);

            return Ok(onwerDto);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}/WithAccounts")]
    public async Task<ActionResult> GetOwnerWithAccountsAsync(Guid id)
    {
        try
        {
            var owner = await _unitOfWork.OwnerRepository.GetOwnerWithDetailsAsync(id);

            if (owner is null) return NotFound("Owner not found.");

            var onwerDto = _mapper.Map<OwnerDTO>(owner);

            return Ok(onwerDto);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }
}
