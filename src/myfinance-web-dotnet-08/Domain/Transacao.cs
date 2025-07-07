using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myfinance_web_dotnet_08.Domain
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Historico { get; set; }
        public DateOnly Data { get; set; }
        public double Valor { get; set; }
        public int PlanoContaID { get; set; }
        public PlanoConta PlanoConta { get; set; }
    }
}