using AccountApi.DTOs;
using AccountApi.Interfaces;
using AccountApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AccountsController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetAccountsAsync()
    {
        try
        {
            var accounts = await _unitOfWork.AccountRepository.GetAccountsAsync();

            return Ok(accounts);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal Server Error");
        }
    }

    [HttpGet("{id:guid}", Name = "GetAccountById")]
    public async Task<ActionResult> GetAccountAsync(Guid id)
    {
        try
        {
            var account = await _unitOfWork.AccountRepository.GetAccountByIdAsync(id);

            if (account is null) return NotFound("Account not found.");

            return Ok(account);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal Server Error");
        }

    }

    [HttpGet("{id:guid}/WithOwner")]
    public async Task<ActionResult> GetAccountsWithOwnerAsync(Guid id)
    {
        try
        {
            var accounts = await _unitOfWork.AccountRepository.GetAccountsByOwner(id);

            return Ok(accounts);
        }
        catch (System.Exception)
        {
            return StatusCode(500, "Internal Server Error");
        }
    }

    [HttpPost]
    public async Task<ActionResult> InsertAccountAsync(AccountDTO accountDTO)
    {
        try
        {
            if (accountDTO is null) return BadRequest("Check the field(s) and try again.");

            var accountDb = _mapper.Map<Account>(accountDTO);

            _unitOfWork.AccountRepository.InsertAccount(accountDb);
            await _unitOfWork.CommitAsync();

            var accountDto = _mapper.Map<AccountDTO>(accountDb);

            return CreatedAtRoute("GetAccountById", new { id = accountDto.AccountId }, accountDto);
        }
        catch (System.Exception ex)
        {
            return StatusCode(500, $"Internal Server Error: {ex}");
        }
    }
}