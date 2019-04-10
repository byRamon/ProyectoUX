using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoUX.Models;

namespace ProyectoUX.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Peliculas> lstPeliculas = ProyectoUX.Data.SeedData.Contenido();
            List<string> lstCategorias = new List<string>();
            foreach(var categoria in lstPeliculas)
            {
                string[] categoriasPelicula = categoria.Genero;
                foreach(var categoriaPelicula in categoriasPelicula)
                {
                    if (categoriaPelicula != "")
                    {
                        if (!lstCategorias.Exists(x => x == categoriaPelicula))
                        {
                            lstCategorias.Add(categoriaPelicula);
                        }
                    }
                }
            }
            ViewBag.lstCategorias = string.Join(".", lstCategorias);
            return View(lstPeliculas);
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
        public IActionResult MostrarImagen(string imagen)
        {
            System.IO.MemoryStream returnStream = new System.IO.MemoryStream();
            try
            {
                string Ubicacion = "./wwwroot/images/img-no-disponible.png";
                if (System.IO.File.Exists("./" + imagen))
                    Ubicacion = "./" + imagen;
                using (System.IO.FileStream fileStream = System.IO.File.OpenRead(Ubicacion))
                {
                    returnStream.SetLength(fileStream.Length);
                    fileStream.Read(returnStream.GetBuffer(), 0, (int)fileStream.Length);
                }
            }
            catch (Exception Ex)
            { }
            return new FileStreamResult(returnStream, "image/Jpeg");
        }
    }
}
