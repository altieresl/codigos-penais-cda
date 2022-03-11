﻿using Business.InterfaceCriminalCode;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.CodigoPenal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.CriminalCodeRepositorio
{
    public class RepositorioCriminalCode : RepositoryGenerics<CriminalCodeViewModel>, ICriminalCode
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositorioCriminalCode()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
