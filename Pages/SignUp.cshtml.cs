using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlazorApp.Services;
using BlazorApp.Models;

namespace BlazorApp.Pages
{
    public class SignUp : PageModel
    {

    
    public List<Emisor> listaEmisor = new List<Emisor>();


        public void OnGetAsync(APIservice aPIservice)
        {
            listaEmisor =  aPIservice.GetEmisor().Result;
            //listaEmisor.Add(new Emisor { Codigo = 1, NombreEmisor = "si", Ruc = "1" });
            //listaEmisor.Add(new Emisor { Codigo = 2, NombreEmisor = "si", Ruc = "1" });
            //listaEmisor.Add(new Emisor { Codigo = 3, NombreEmisor = "si", Ruc = "1" });
        }

    }
}
