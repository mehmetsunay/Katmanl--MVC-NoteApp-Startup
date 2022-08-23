using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notes.Business.Abstract;
using Notes.Business.Concrete;
using Notes.Entities;
using NotesProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NotesProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INoteService _noteService;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _noteService = new NoteManager();
        }

        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Notes()
        {
            var notes = _noteService.GetAllNotes();
            return View(notes);
        }


        public IActionResult AddNote(Note note)
        {
            _noteService.CreateNote(note);

            return RedirectToAction(nameof(Notes));
        }
        public IActionResult RemoveNote(int id)
        {
            _noteService.DeleteNote(id);
            return RedirectToAction(nameof(Notes));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
