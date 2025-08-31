using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;

namespace Proyecto1.Controllers;

public class Ejercicio1 : Controller
{

    public String Index(String id)
    {


        id = new string(id.ToUpper().Reverse().ToArray());



        return id;
    }

    public String Comparar(String id, String cadena)
    {

        if (id.Equals(cadena))
        {

            return "Son iguales";

        }
        else
        {
            return "Son diferentes";
        }

    }

    public IActionResult Perfil()
    {
        return View("~/Views/Home/Perfil.cshtml");
    }


}