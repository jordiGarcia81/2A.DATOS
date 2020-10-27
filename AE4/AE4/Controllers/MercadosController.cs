﻿using AE4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE4.Controllers
{
    public class MercadosController : ApiController
    {

        MercadoRepository mer = new MercadoRepository();

        public IEnumerable<Mercado> eventosIdEvento(int eventosIdEvento, double overUnder)
        {
            
            Mercado m = new Mercado();
            List<Mercado> mercados = mer.RetrieveEventosIdEvento(m);
            return mercados;

         

        }

        public IEnumerable<MercadoDTO> Get()
        {
            
            List<MercadoDTO> mercados = mer.RetrieveDTO();
            return mer.RetrieveDTO();
        }


    }
}
