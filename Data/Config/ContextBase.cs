using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using Model.CodigoPenal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<CriminalCodeViewModel> CriminalCodeViewModel { get; set; }

        private string GetStringConnectionConfig()
        {
            string connectionString = "Server=localhost;Database=codigo_penal_cda;Uid=root;Password='%COD_penal;cda2';";
            return connectionString;
        }
    }
}
