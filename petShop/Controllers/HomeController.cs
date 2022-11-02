using System.Diagnostics;
using petShop.Filters;
using petShop.Helpers;
namespace petShop.Controllers;


// Filtro para não acessar a rota home se não hover usuário logado
[PaginaParaUsuarioLogado]
public class HomeController : Controller
{
    private readonly ISessao _sessao;
    public HomeController ( ISessao sessao){
            _sessao = sessao; 
    }

    public IActionResult Index()
    {
        return View(_sessao.buscarSessaoDoUsuario());
    }

    public IActionResult Pets(){
        return RedirectToAction("Index","Pets");
    }
    public IActionResult Agend(){
        return RedirectToAction("Index", "Agend");
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
