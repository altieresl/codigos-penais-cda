using Business.InterfaceCriminalCode;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.CodigoPenal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.CriminalCodeRepositorio
{
    public class RepositorioCriminalCode : RepositoryGenerics<CriminalCodeViewModel>, ICriminalCode
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositorioCriminalCode()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public new async Task<List<CriminalCodeViewModel>> List(string order)
        {
            using (var db = new ContextBase(_OptionsBuilder))
            {
                if (order.ToLower() == "name")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.Name).ToListAsync();
                }
                else if (order.ToLower() == "description")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.Description).ToListAsync();
                }
                else if (order.ToLower() == "penalty")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.Penalty).ToListAsync();
                }
                else if (order.ToLower() == "prisiontime")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.PrisionTime).ToListAsync();
                }
                else if (order.ToLower() == "statusid")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.StatusId).ToListAsync();
                }
                else if (order.ToLower() == "createdate")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.CreateDate).ToListAsync();
                }
                else if (order.ToLower() == "updatedate")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.UpdateDate).ToListAsync();
                }
                else if (order.ToLower() == "createuserid")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.CreateUserId).ToListAsync();
                }
                else if (order.ToLower() == "updateuserid")
                {
                    return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.UpdateUserId).ToListAsync();
                }
                return await db.Set<CriminalCodeViewModel>().OrderBy(criminalCode => criminalCode.Id).ToListAsync();
            }
        }
    }
}
