using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;

namespace Proyecto1.Controllers;

public class Ejercicio2 : Controller
{

    private String[] Cadenas = new string[] {" ","Hola", "Que tal", "Como esta", "Hi", "Hola, Amigos"};
    public String Index(int id)
    {
        return Cadenas[id];
    }

    public String Comparar(String id)
    {

        for (int i = 0; i < 5; i++)
        {
            if (id.Equals(Cadenas[i]))
            {

                return "Cadena encontrada: " + Cadenas[i];

            }

        } 

       return "No existe";
       
    }



}