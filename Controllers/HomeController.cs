using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur", "122.222.333.-90", "caca@hotmail.com", "Cachorro");
        Cliente cliente2 = new Cliente(02, "Samuel", "122.222.333.-80", "sasa@hotmail.com", "gato");
        Cliente cliente3 = new Cliente(03, "Barbara", "122.222.333.-70", "baba@hotmail.com", "rato");
        Cliente cliente4 = new Cliente(04, "Samanta", "122.222.333.-60", "sara@hotmail.com", "cobra");
        Cliente cliente5 = new Cliente(05, "Livia", "122.222.333.-50", "lala@hotmail.com", "passaro");

        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);
        

        ViewBag.listaCliente = listaCliente;

        Fornecedor fornecedor1 = new Fornecedor(01,"casadoaco","90.923.284.0001-90", "lula@lula.com");
        Fornecedor fornecedor2 = new Fornecedor(02,"casadoferro","90.923.284.0001-80", "lula@lula.com");
        Fornecedor fornecedor3 = new Fornecedor(03,"casadasportas","90.923.284.0001-70", "lula@lula.com");
        Fornecedor fornecedor4 = new Fornecedor(04,"casadocimento","90.923.284.0001-60", "lula@lula.com");
        Fornecedor fornecedor5 = new Fornecedor(05,"casadotelhado","90.923.284.0001-50", "lula@lula.com");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listaFornecedor;


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
