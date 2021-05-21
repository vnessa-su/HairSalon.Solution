using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> stylistList = _db.Stylists.Include(stylist => stylist.Clients).ToList();
      return View(stylistList);
    }

    public ActionResult Create()
    {
      ViewBag.StylistLevelNames = new SelectList(Stylist.StylistLevelNames);
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist selectedStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(selectedStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist selectedStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(selectedStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Stylist selectedStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(selectedStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist selectedStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(selectedStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}