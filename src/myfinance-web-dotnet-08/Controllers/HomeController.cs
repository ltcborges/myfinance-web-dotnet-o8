using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet_08.Infrastructure;
using myfinance_web_dotnet_08.Models;

namespace myfinance_web_dotnet_08.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MyFinanceDbContext_banco;

    public HomeController(ILogger<HomeController> logger; MyFinanceDbContext banco)
    {
        _logger = logger;
        _banco = banco;
    }

    public IActionResult Index()
    {
       var nomePrimeiroItemPlanoConta = _banco.PlanoConta.FirstOrDefault().Nome;
       ViewBag.Teste = nomePrimeiroItemPlanoConta;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
