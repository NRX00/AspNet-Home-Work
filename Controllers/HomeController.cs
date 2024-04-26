using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kitap_modeli.Models;

namespace Kitap_modeli.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Kitap books = new Kitap();
        books.book_name = "Sefiller";
        books.writer_name = "VICTOR HUGO";
        books.publication_date = "1862'de Yayınlandı";
        books.type = "Roman, Trajedi, Tarihî Kurgu, Epik, Macera";
        books.book_Number_of_pages = 496;
        return View(books);
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
