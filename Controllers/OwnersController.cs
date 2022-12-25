using AccountApi.DTOs;
using AccountApi.Interfaces;
using AccountApi.Models;
using AccountApi.Pagination;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

            var ownersDtos = _mapper.Map<IEnumerable<OwnerDTO>>(owners);

            return Ok(ownersDtos);
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

            var ownerDto = _mapper.Map<OwnerDTO>(owner);

            return Ok(ownerDto);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("WithPagination")]
    public async Task<ActionResult> GetAllOwnersWithPaginationAsync([FromQuery] OwnersParameters ownerParameters)
    {
        try
        {
            var owners = await _unitOfWork.OwnerRepository.GetOwnersWithPaginationAsync(ownerParameters);

            var metadata = new
            {
                owners.TotalCount,
                owners.CurrentPage,
                owners.TotalPages,
                owners.PageSize,
                owners.HasPrevious,
                owners.HasNext
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            var ownersDtos = _mapper.Map<IEnumerable<OwnerDTO>>(owners);

            return Ok(ownersDtos);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("WithFiltering")]
    public async Task<ActionResult> GetAllOwnersWithFilteringAsync([FromQuery] OwnersParameters ownerParameters)
    {
        try
        {
            if (!ownerParameters.ValidYearRange)
                return BadRequest("Max year of birth can't be less than min year of birth");

            var owners = await _unitOfWork.OwnerRepository.GetOwnersWithFilteringAsync(ownerParameters);

            var metadata = new
            {
                owners.TotalCount,
                owners.CurrentPage,
                owners.TotalPages,
                owners.PageSize,
                owners.HasPrevious,
                owners.HasNext
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            var ownersDtos = _mapper.Map<IEnumerable<OwnerDTO>>(owners);

            return Ok(ownersDtos);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("WithSearching")]
    public async Task<ActionResult> GetAllOwnersWithSearchingAsync([FromQuery] OwnersParameters ownerParameters)
    {
        try
        {
            var owners = await _unitOfWork.OwnerRepository.GetOwnersWithSearchingAsync(ownerParameters);

            var metadata = new
            {
                owners.TotalCount,
                owners.CurrentPage,
                owners.TotalPages,
                owners.PageSize,
                owners.HasPrevious,
                owners.HasNext
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            var ownersDtos = _mapper.Map<IEnumerable<OwnerDTO>>(owners);

            return Ok(ownersDtos);
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

            var ownerDto = _mapper.Map<OwnerDTO>(owner);

            return Ok(ownerDto);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost]
    public async Task<ActionResult> InsertOwnerAsync(OwnerDTO ownerDTO)
    {
        try
        {
            if (ownerDTO is null) return BadRequest("Check the field(s) and try again.");

            var ownerDb = _mapper.Map<Owner>(ownerDTO);

            _unitOfWork.OwnerRepository.InsertOwner(ownerDb);
            await _unitOfWork.CommitAsync();

            var ownerDto = _mapper.Map<OwnerDTO>(ownerDb);

            return CreatedAtRoute("GetOwnerById", new { id = ownerDto.OwnerId }, ownerDto);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateOwnerAsync(Guid id, OwnerDTO ownerDTO)
    {
        try
        {
            if (id != ownerDTO.OwnerId || ownerDTO is null)
                return BadRequest("Check the field(s) and try again.");

            var ownerDb = _mapper.Map<Owner>(ownerDTO);

            _unitOfWork.OwnerRepository.UpdateOwner(ownerDb);
            await _unitOfWork.CommitAsync();

            return NoContent();
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteOwnerAsync(Guid id)
    {
        try
        {
            var ownerDb = await _unitOfWork.OwnerRepository.GetOwnerByIdAsync(id);
            if (ownerDb is null) return NotFound("Owner not found.");

            _unitOfWork.OwnerRepository.DeleteOwner(ownerDb);
            await _unitOfWork.CommitAsync();

            return NoContent();

        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal service error");
        }
    }
}
