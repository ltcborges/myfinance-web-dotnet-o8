using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myfinance_web_dotnet_08.Domain
{
    public class PlanoConta
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }

}        