using myfinance_web_dotnet_08.Domain;

namespace myfinance_web_dotnet_08.Services
{
    public interface IPlanoContaService
    {
        List<PlanoConta> ListarRegistros();
        void Salvar(PlanoConta registro);
        void Excluir(int id);
        PlanoConta RetornarRegistro(int id);
    }
}