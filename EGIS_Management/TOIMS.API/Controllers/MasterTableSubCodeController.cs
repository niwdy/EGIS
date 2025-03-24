using Domain.Entities;
using Infrastructure.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;

namespace TOIMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterTableSubCodeController : Controller
    {
        private readonly IUnitOfWork _unitofwork;
        public MasterTableSubCodeController(IUnitOfWork unitofwork)
        {
               _unitofwork = unitofwork;
        }

        [HttpPost]
        public async Task<IActionResult> Create(MasterTableSubCode tableSubCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _unitofwork.SubCode.CreateAsync(tableSubCode);
            await _unitofwork.CommitAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mCode = await _unitofwork.SubCode.GetAllAsync();
            return Ok(mCode);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetbyId(int masterSubCodeId)
        {
            var mCodes = await _unitofwork.SubCode.GetById(masterSubCodeId);
            return Ok(mCodes);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int masterSubCodeId)
        {
            var mCodeData = await _unitofwork.SubCode.GetById(masterSubCodeId);
            if (mCodeData != null)
            {
                await _unitofwork.SubCode.DeleteAsync(mCodeData);
                await _unitofwork.CommitAsync();
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int masterSubCodeId, MasterTableSubCode masterSubCode)
        {
            var mSubCodeData = await _unitofwork.SubCode.GetById(masterSubCodeId);

            if (mSubCodeData != null)
            {
               mSubCodeData.Description1 = masterSubCode.Description1;
                mSubCodeData.SubCode= masterSubCode.SubCode;
                mSubCodeData.Description2 = masterSubCode.Description2;
                mSubCodeData.Description3 = masterSubCode.Description3;
                mSubCodeData.Description4 = masterSubCode.Description4;
                mSubCodeData.Description5 = masterSubCode.Description5;
                mSubCodeData.Description6 = masterSubCode.Description6;
                mSubCodeData.Description7 = masterSubCode.Description7;

                return Ok();
            }
            return BadRequest();
        }

    }
}

