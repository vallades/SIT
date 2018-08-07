using MelhorPrecoSempreIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MelhorPrecoSempreIT.Services
{
    public class PratosDAL
    {
        private RestaurantesDBContext db = new RestaurantesDBContext();

        public List<Pratos> ObterPratos()
        {
            return db.Pratos.ToList();
        }

        public List<Pratos> ObterPrato(Pratos pratos)
        {
            var getPratos = this.ObterPratos();
            var prato = from p in getPratos
                          where p.ValorPratoDe >= pratos.ValorPratoDe && p.ValorPratoPara <= pratos.ValorPratoPara && p.Ativo == true
                          select p;

            return prato.ToList();
             
        }
    }
}