using myfinance_web_dotnet_08.Domain;
using myfinance_web_dotnet_08.Infrastructure;

namespace myfinance_web_dotnet_08.Services
{
    public class PlanoContaService : IPlanoContaService
    {

        private readonly MyFinanceDbContext _banco;
        public PlanoContaService(MyFinanceDbContext banco);
        {
            _banco = banco;
        }

        public void Excluir(int id)
        {
            var item = RetornarRegistro(id);
            _banco.Attach(item);
            _banco.Remove(item);
            _banco.SaveChanges();
        }

        public List<PlanoConta> ListarRegistros()
        {
            var item = _banco.PlanoConta.ToList();
            return item;
        }

        public PlanoConta RetornarRegistro(int id)
        {
            var item = _banco.PlanoConta.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }
        public void Salvar(PlanoConta registro)
        {
            if (registro.Id == null)
            {
                _banco.PlanoConta.Add(registro);
            }
            else
            {
                _banco.PlanoConta.Attach(registro);
                _banco.Entry(registro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _banco.SaveChanges();
        }
    }
}