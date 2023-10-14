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
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        Fornecedor Fornecedor1 = new Fornecedor(01, "C# PET S/A", "857.032.950-41", "c-sharp@pet.org");
        Fornecedor Fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "039.618.250-09", "ctrl@alt.dog.br");
        Fornecedor Fornecedor3 = new Fornecedor(03, "BootsPet INC", "800.777.920-50", "boots.pet@gatomania.us");
        Fornecedor Fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "933.622.400-03", "noisnamidia@tiktokdogs.uk");
        Fornecedor Fornecedor5 = new Fornecedor(05, "Bifinho Forever", "911.702.988-00", "contato@bff.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(Fornecedor1);
        listaFornecedores.Add(Fornecedor2);
        listaFornecedores.Add(Fornecedor3);
        listaFornecedores.Add(Fornecedor4);
        listaFornecedores.Add(Fornecedor5);

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
