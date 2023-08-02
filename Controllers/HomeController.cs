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
        //Clientes//
        Cliente cliente1 = new Cliente(01, "Lucas E. de Araujo", "088.065.264-01", "lucasemanueldearaujo@gmail.com","Bolinha");
        Cliente cliente2 = new Cliente(02, "Elizete M.de Araujo", "079.123.423-02", "elizetemariadeaaraujo@gmail.com", "Luna");
        Cliente cliente3 = new Cliente(03, "Luiz H. de araujo", "088.472.294-06", "luizhenriquedearaujo@gmil.com", "Caramelo");
        Cliente cliente4 = new Cliente(04, "Jose A. de Macedo", "078.281.391-00", "josearaujodemacedo@gmail.com", "Frederico");
        Cliente cliente5 = new Cliente(05, "Luana J. Souza", "088.913.322-03", "luanajosefinadesouza@gmail.com", "Alana");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //Fornecedores 
        Fornecedor fornecedor1 = new Fornecedor(01, "Pet Shower", "88.064.284/0001-23", "lucasemanueldearaujo@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Allegra Pet", "09.113.453/0001-15", "elizetemariadeaaraujo@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Canto do Pet.", "08.332.294/0001-32", "luizhenriquedearaujo@gmil.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "King Pet", "78.211.337/0001-12", "josearaujodemacedo@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Vip Pet Shop", "28.913.322/0001-63", "luanajosefinadesouza@gmail.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores; 

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
