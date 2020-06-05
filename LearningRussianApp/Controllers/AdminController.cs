using LearningRussianApp.Models;
using LearningRussianApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Controllers
{
    public class AdminController:Controller
    {
        private readonly IMethods _methods;

        public AdminController(IMethods methods)
        {
            _methods = methods;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNouns()
        {
            return View(_methods.GetAllNouns());
        }


        public IActionResult AddUpdateNoun(int id)
        {
            if (id == 0)
                return View(new Noun());
            else
                return View(_methods.findNoun(id));
        }
        [HttpPost]
        public IActionResult AddUpdateNoun(Noun Noun)
        {
            if (ModelState.IsValid)
            {
                if (Noun.id == 0)
                    _methods.AddNoun(Noun);
                else
                    _methods.updateNoun(Noun);
            }
            return RedirectToAction(nameof(AddUpdateNoun));

        }


        public IActionResult DeleteNoun(int id)
        {
            _methods.deleteNoun(id);
            return RedirectToAction(nameof(AllNouns));
        }

        public IActionResult AllVerbs()
        {
            return View(_methods.GetAllVerbs());
        }


        public IActionResult AddUpdateVerb(int id)
        {
            if (id == 0)
                return View(new Verb());
            else
                return View(_methods.findVerb(id));
        }
        [HttpPost]
        public IActionResult AddUpdateVerb(Verb Verb)
        {
            if (ModelState.IsValid)
            {
                if (Verb.id == 0)
                    _methods.AddVerb(Verb);
                else
                    _methods.updateVerb(Verb);
            }
            return RedirectToAction(nameof(AddUpdateVerb));

        }


        public IActionResult DeleteVerb(int id)
        {
            _methods.deleteVerb(id);
            return RedirectToAction(nameof(AllVerbs));
        }


        public IActionResult AllAdjectives()
        {
            return View(_methods.GetAllAdjectives());
        }


        public IActionResult AddUpdateAdjective(int id)
        {
            if (id == 0)
                return View(new Adjective());
            else
                return View(_methods.findAdjective(id));
        }
        [HttpPost]
        public IActionResult AddUpdateAdjective(Adjective Adjective)
        {
            if (ModelState.IsValid)
            {
                if (Adjective.id == 0)
                    _methods.AddAdjective(Adjective);
                else
                    _methods.updateAdjective(Adjective);
            }
            return RedirectToAction(nameof(AddUpdateAdjective));

        }


        public IActionResult DeleteAdjective(int id)
        {
            _methods.deleteAdjective(id);
            return RedirectToAction(nameof(AllAdjectives));
        }
    }
}
