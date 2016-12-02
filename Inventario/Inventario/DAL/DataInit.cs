using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Inventario.DAL
{
    public class DataInit : DropCreateDatabaseIfModelChanges<AtivoContext>
    {
        protected override void Seed(AtivoContext context)
        {
            var usuario = new Usuario
            {
                Nome = "Administrador",
                Email = "admin@inventorio.local,
                Senha = "4dministrador=1nventario"
            };

            context.SaveChanges();
        }
    }
}