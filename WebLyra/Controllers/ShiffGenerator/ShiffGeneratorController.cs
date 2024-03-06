using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLyra.Data;
using WebLyra.Models;

namespace WebLyra.Controllers.ShiffGenerator
{
    public class ShiffGeneratorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ShiffGeneratorController(ApplicationDbContext context) {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public IActionResult Ticket()
		{
			int turn = _context.Database.SqlQuery<int>($"exec sp_FolioTurn").AsEnumerable().FirstOrDefault();
			DateTime currentDate = DateTime.Now;
			Shiff newShiff = new();
			newShiff.FolioNumber = turn;
			newShiff.Status = turn;
			newShiff.CreationDate = currentDate;
			newShiff.Comments = "prueba";
			_context.Add(newShiff);
			_context.SaveChanges();			
			return Json(new { folio = turn,date= newShiff.CreationDate.ToLongDateString() });
		}
		[HttpGet]
		public IActionResult ShiffList()
		{
			DateTime currentDate = DateTime.Now;
			var shiffList = _context.Shiff.Where(x => x.CreationDate.Date == currentDate.Date).ToList();
			return PartialView("~/Views/ShiffGenerator/ShiffList.cshtml", shiffList);
		}
	}
}
