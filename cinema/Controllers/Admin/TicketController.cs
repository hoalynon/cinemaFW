﻿using cinema.Context;
using cinema.Models;
using cinema.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cinema.Controllers.Admin
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository _TicketRepository;
        private readonly CinemaDbContext _dbContext;
        public TicketController(ITicketRepository TicketRepository, CinemaDbContext dbContext)
        {
            _TicketRepository = TicketRepository;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> List()
        {

            ViewData["Title"] = "Danh sách vé xem phim";
            ViewData["Tickets"] = await _TicketRepository.GetAll();

            return View("~/Views/Admin/Ticket/List.cshtml");
        }

        public async Task<IActionResult> Detail(string ticketid, string slotid, string seatid)
        {

            ViewData["Title"] = "Chi tiết vé xem phim ";
            Ticket Ticket = await _TicketRepository.GetTicket(ticketid, slotid, seatid);


            return View("~/Views/Admin/Ticket/Detail.cshtml", Ticket);
        }

        public IActionResult Delete(string ticketid, string slotid, string seatid)
        {
            bool result = _TicketRepository.Destroy(ticketid, slotid, seatid);

            ViewData["Title"] = "Danh sách vé xem phim";

            return RedirectToAction("List", "Ticket", new { area = "" });
        }
    }
}
