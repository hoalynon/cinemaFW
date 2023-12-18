﻿using cinema.Context;
using cinema.Models;
using cinema.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cinema.Controllers.Admin
{
    public class BillController : Controller
    {
        private readonly IBillRepository _BillRepository;
        private readonly CinemaDbContext _dbContext;
        public BillController(IBillRepository BillRepository, CinemaDbContext dbContext)
        {
            _BillRepository = BillRepository;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> List()
        {

            ViewData["Title"] = "Danh sách hóa đơn";
            ViewData["Bills"] = await _BillRepository.GetAll();
            ViewData["Customers"] = _dbContext.Customers.OrderBy(p => p.cus_id).ToList();

            return View("~/Views/Admin/Bill/List.cshtml");
        }

        public async Task<IActionResult> Detail(string id)
        {

            ViewData["Title"] = "Chi tiết hóa đơn";
            Bill bill = await _BillRepository.GetBill(id);
            ViewData["Customers"] = _dbContext.Customers.OrderBy(p => p.cus_id).ToList();
            ViewData["Tickets"] = _dbContext.Tickets.OrderBy(p => p.tk_id).Where(x => x.bi_id == id).ToList();
            ViewData["Discounts"] = _dbContext.Discounts.OrderBy(p => p.dis_id).ToList();
            ViewData["ChosenDiscounts"] = _dbContext.ApplyDiscounts.OrderBy(p => p.dis_id).Where(x => x.bi_id == id).ToList();

            return View("~/Views/Admin/Bill/Detail.cshtml", bill);
        }

        public IActionResult Delete(string id)
        {
            bool result = _BillRepository.Destroy(id);

            ViewData["Title"] = "Danh sách hóa đơn";

            return RedirectToAction("List", "Bill", new { area = "" });
        }
    }
}
