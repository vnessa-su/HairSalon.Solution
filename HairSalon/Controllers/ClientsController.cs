using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> clientList = _db.Clients.Include(client => client.Stylist).ToList();
      return View(clientList);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client selectedClient = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
      return View(selectedClient);
    }

    public ActionResult Edit(int id)
    {
      Client selectedClient = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(selectedClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Client selectedClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(selectedClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Client selectedClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(selectedClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}