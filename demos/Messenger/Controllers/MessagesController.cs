using System;
using System.Linq;
using System.Net;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Messenger.Models;

namespace Messenger.Controllers
{
    public class MessagesController : Controller, IDisposable
    {
        private readonly MessengerDataContext _db;

        public MessagesController(MessengerDataContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Messages.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Message message)
        {
            if (ModelState.IsValid)
            {
            	message.DatePosted = DateTime.Now;
                _db.Messages.Add(message);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(message);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}