using Domain.Entities;
using Infrastructure.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;

namespace TOIMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : Controller
    {
        private readonly IUnitOfWork _unitofwork;
        public BankController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Bank bank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _unitofwork.Bank.CreateAsync(bank);
            await _unitofwork.CommitAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var banks = await _unitofwork.Bank.GetAllAsync();
            return Ok(banks);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetbyId(int bankId)
        {
            var banks = await _unitofwork.Bank.GetById(bankId);
            return Ok(banks);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int bankId)
        {
            var bankData = await _unitofwork.Bank.GetById(bankId);
            if (bankData != null)
            {
                await _unitofwork.Bank.DeleteAsync(bankData);
                await _unitofwork.CommitAsync();
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int bankId, Bank bank)
        {
            var bankData = await _unitofwork.Bank.GetById(bankId);

            if (bankData != null)
            {
                bankData.Branch = bank.Branch;
                bankData.BankName = bank.BankName;
                
                _unitofwork.Bank.Update(bankData);

                await _unitofwork.CommitAsync();
                return Ok();
            }
            return BadRequest();
        }
    }
}
