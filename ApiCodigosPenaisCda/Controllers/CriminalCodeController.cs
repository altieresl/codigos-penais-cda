using Business.InterfaceCriminalCode;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.CodigoPenal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCodigosPenaisCda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriminalCodeController : ControllerBase
    {
        private readonly ICriminalCode _ICriminalCode;

        public CriminalCodeController(ICriminalCode ICriminalCode)
        {
            _ICriminalCode = ICriminalCode;
        }

        [HttpGet("GetCriminalCodes")]
        public async Task<List<CriminalCodeViewModel>> GetCriminalCodes(string ? order)
        {
            if (order != null && order != "")
                return await _ICriminalCode.List(order);
            return await _ICriminalCode.List();
        }

        [HttpGet("GetCriminalCode")]
        public async Task<CriminalCodeViewModel> GetCriminalCode(int id)
        {
            return await _ICriminalCode.GetEntityById(id);
        }

        [HttpPost("AddCriminalCode")]
        public async Task AddCriminalCode(CriminalCodeViewModel criminalCode)
        {
            await _ICriminalCode.Add(criminalCode);
        }

        [HttpPost("UpdateCriminalCode")]
        public async Task UpdateCriminalCode(CriminalCodeViewModel criminalCode)
        {
            await _ICriminalCode.Update(criminalCode);
        }

        [HttpPost("DeleteCriminalCode")]
        public async Task DeleteCriminalCode(CriminalCodeViewModel criminalCode)
        {
            await _ICriminalCode.Delete(criminalCode);
        }

    }
}
