using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      Dictionary<string, int> StatusDict = new Dictionary<string, int>({"Operational", 1}, {"Malfunctioning", 2}, {"In rapair", 3});
      ViewBag.StatusTypes = StatusDict;
      return View();
    }
  }
}