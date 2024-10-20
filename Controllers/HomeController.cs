using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhpetMVC.Models;

namespace LhpetMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias de tipo cliente
        Cliente cliente1 = new Cliente(01, "Pedro Campos", "857.033.432-01", "pepo@gmail.com", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Gates", "957.044.465-11", "wilg@microsoft.com", "Digo");
        Cliente cliente3 = new Cliente(03, "Steve Jogbs", "053.345.323-02", "steve@me.com", "Clara");
        Cliente cliente4 = new Cliente(04, "Peter Pan", "095.444.453-04", "peter@pan.com", "Nan");
        Cliente cliente5 = new Cliente(05, "Ted Foster", "434.433.232-03", "ted@ted.com", "Pin");

        //lista de clientes e atribuição dos clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        
        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Face Dogs", "14.123.102/0001-80", "face@dogs.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.356.144/0001-89", "alt@dog.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Tik Dogs", "33.432.332/0001-23", "tik@dogs.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Pet Tech", "45.343.145/0001-45", "pet@tech.com");
        Fornecedor fornecedor5 = new Fornecedor(01, "Fan Pet", "56.545.145/0001-34", "fan@pet.com");

        //lista de fornecedores
        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = ListaFornecedores; 

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
