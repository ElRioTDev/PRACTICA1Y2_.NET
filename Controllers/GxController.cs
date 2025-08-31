using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;
using Newtonsoft.Json;


namespace Proyecto1.Controllers;

public class GxController : Controller
{
    public List<Gx> lstgx = null;
    public GxController()
    {
        var myJsonString = System.IO.File.ReadAllText("Models/gx.json");

        // Deserializar al contenedor
        GxContainer hardware = JsonConvert.DeserializeObject<GxContainer>(myJsonString);

        // Obtener la lista de GPUs
        lstgx = hardware.GPUs;
    }

    public IActionResult Index()
    {
        return View(lstgx);
    }

    public IActionResult Find(string Gx)
    {
        List<Gx> lstResultGx = new List<Gx>();
        foreach (var item in lstgx)
        {
            if (item.Modelo.ToLower().Contains(Gx.ToLower()))
            {
                lstResultGx.Add(item);
            }

        }

        return View("Index", lstResultGx);
    }

    public IActionResult Details(int id)
    {
        var item = lstgx.FirstOrDefault(x => x.Id == id);
        if (item == null)
        {
            return NotFound(); // Mejor que devolver un Gx vacío
        }
        return View(item);
    }
}