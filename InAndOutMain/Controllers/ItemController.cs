using InAndOutMain.Data;
using InAndOutMain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InAndOutMain.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> itemList = _db.Items;
             return View(itemList);
        }
        //GET Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
