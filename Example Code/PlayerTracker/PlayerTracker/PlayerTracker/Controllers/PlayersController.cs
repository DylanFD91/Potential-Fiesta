using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerTracker.Data;
using PlayerTracker.Models;

namespace PlayerTracker.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;
        public PlayersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var players = _context.Players.Include(m => m.Team).ToList();

            return View(players);
        }
        public IActionResult Details(int id)
        {
            var player = _context.Players.Include(m => m.Team).SingleOrDefault(m => m.Id == id);

            return View(player);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var teams = _context.Teams.ToList();
            Player player = new Player()
            {
                Teams = teams
            };
            return View(player);
        }
        [HttpPost]
        public IActionResult Create(Player player)
        {
            if (player.Id == 0)
            {
                _context.Players.Add(player);
            }
            else
            {
                var playerInDB = _context.Players.Single(m => m.Id == player.Id);
                playerInDB.FirstName = player.FirstName;
                playerInDB.LastName = player.LastName;
                playerInDB.TeamId = player.TeamId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Players");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var player = _context.Players.SingleOrDefault(m => m.Id == id);
            player.Teams = _context.Teams.ToList();
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }
        [HttpPost]
        public IActionResult Edit(Player player)
        {
            // Tracking changes
            var playerInDB = _context.Players.Single(m => m.Id == player.Id);
            playerInDB.FirstName = player.FirstName;
            playerInDB.LastName = player.LastName;
            playerInDB.TeamId = player.TeamId;
            playerInDB.Teams = _context.Teams.ToList();
            _context.SaveChanges();
            return RedirectToAction("Index", "Players");
        }
        public IActionResult Delete(int id)
        {
            var player = _context.Players.SingleOrDefault(m => m.Id == id);
            _context.Players.Remove(player);
            _context.SaveChanges();
            var players = _context.Players.Include(m => m.Team).ToList();
            return View("Index", players);
        }
    }
}