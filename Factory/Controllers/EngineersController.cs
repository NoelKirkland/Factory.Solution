using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.MachineId = new SelectList(_db.Categories, "MachineId", "MachineName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Imagineer imagineer, int MachineId)
    {
      _db.Imagineers.Add(imagineer);
      if (MachineId != 0)
      {
        _db.MachineImagineer.Add(new EngineerMachine() { MachineId = MachineId, ImagineerId = imagineer.ImagineerId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}