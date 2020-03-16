﻿using LearningRussianApp.Models;
using LearningRussianApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Controllers
{
    public class UserController: Controller
    {
        private readonly IMethods _methods;

        public UserController(IMethods methods)
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
            //if (id == 0)
            //    return View(new Noun());
            //else
                return View(_methods.findNoun(id));
        }
        [HttpPost]
        public IActionResult AddUpdateNoun(Noun Noun)
        {
            if (ModelState.IsValid)
            {
                //if (Noun.id == 0)
                //    _methods.AddNoun(Noun);
                //else
                    _methods.updateNoun(Noun);
            }
            return RedirectToAction(nameof(AllNouns));

        }



        public IActionResult AllVerbs()
        {
            return View(_methods.GetAllVerbs());
        }


        public IActionResult AddUpdateVerb(int id)
        {
            //if (id == 0)
            //    return View(new Verb());
            //else
                return View(_methods.findVerb(id));
        }
        [HttpPost]
        public IActionResult AddUpdateVerb(Verb Verb)
        {
            if (ModelState.IsValid)
            {
                //if (Verb.id == 0)
                //    _methods.AddVerb(Verb);
                //else
                    _methods.updateVerb(Verb);
            }
            return RedirectToAction(nameof(AllVerbs));

        }


    }
}
