﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreCC2.Models;

namespace AspNetCoreCC2.Data
{
    public static class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();
            if (context.Departamentos.Any())
            {
                return;
            }

            var departamentos = new Departamento[]
            {
                new Departamento {Nome="Ciência da Computação"},
                new Departamento {Nome="Ciência de Alimentos"}
            };

            foreach(Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();

            if (context.Instituicoes.Any())
            {
                return;
            }

            var instituicoes = new Instituicao[]
            {
                new Instituicao {Nome="UniRio"},
                new Instituicao {Nome="UniCampinas"}
            };

            foreach (Instituicao i in instituicoes)
            {
                context.Instituicoes.Add(i);
            }
            context.SaveChanges();
        }
    }
}
