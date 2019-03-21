using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SC.BL;
using SC.BL.Domain;
using SC.UI.Web.MVC.Models;

namespace SC.UI.Web.MVC.Controllers
{
    public class TicketController : Controller
    {
        private ITicketManager mgr;

        private readonly IMemoryCache cache;

        internal static int? previousTicket = null;
        internal static bool StateChanged = false;

        public TicketController(IMemoryCache memoryCache)
        {
            mgr = new TicketManager();
            cache = memoryCache;
        }


        // GET: /Ticket
        public IActionResult Index()
        {
            var cachKey = "TicketList";
            IEnumerable<Ticket> tickets;
            if (cache.TryGetValue(cachKey, out tickets) && !StateChanged)
            {
                ViewBag.CacheTest = "Dit is gecashed";
            }
            else
            {
                tickets = mgr.GetTickets();
                cache.Set(cachKey, tickets);
                ViewBag.CacheTest = "Dit is niet gecashed";
            }
            StateChanged = false;
            return View(tickets);
        }

        // GET: /Ticket/Details/<ticket_number>
        public IActionResult Details(int id)
        {
            var cachKey = "TicketDetail";
            Ticket ticket;
            if (cache.TryGetValue(cachKey, out ticket) && previousTicket == id)
            {
                //return View(ticket);
                ViewBag.Responses = ticket.Responses;
                ViewBag.CacheTest = "Dit is gecashed";
            }
            else
            {
                ticket = mgr.GetTicket(id);
                ViewBag.Responses = mgr.GetTicketResponses(ticket.TicketNumber);
                cache.Set(cachKey, ticket);
                ViewBag.CacheTest = "Dit is niet gecashed";
            }
                        
            previousTicket = id;
            
            return View(ticket);
        }

        // GET: /Ticket/Edit/<ticket_number>
        public IActionResult Edit(int id)
        {
            Ticket ticket = mgr.GetTicket(id);
            return View(ticket);
        }

        // POST: /Ticket/Edit/<ticket_number>
        [HttpPost]
        public IActionResult Edit(int id, Ticket ticket)
        {
            if (!ModelState.IsValid)
                return View(ticket);

            mgr.ChangeTicket(ticket);
            cache.Remove("TicketList");
            cache.Remove("TicketDetail");
            
            return RedirectToAction("Details", new {id = ticket.TicketNumber});
        }

        // GET: /Ticket/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Ticket/Create
        [HttpPost]
        public IActionResult Create( /*int accId, string problem*/ CreateTicketViewModel createTicket)
        {
            Ticket newTicket = mgr.AddTicket( /*accId*/createTicket.AccId, /*problem*/createTicket.Problem);
            cache.Remove("TicketList");
            return RedirectToAction("Details", new {id = newTicket.TicketNumber});
        }

        // GET: /Ticket/Delete/<ticket_number>
        public IActionResult Delete(int id)
        {
            Ticket ticket = mgr.GetTicket(id);
            return View(ticket);
        }

        // POST: /Ticket/Delete/<ticket_number>
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            mgr.RemoveTicket(id);
            return RedirectToAction("Index");
        }
    }
}