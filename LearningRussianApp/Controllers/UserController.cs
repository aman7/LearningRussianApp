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
            return View(_methods.GetAllNonFinishedNouns());
        }

        public IActionResult ReviewNouns()
        {
            return View(_methods.GetAllReviewNouns());
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
                Noun.status = "Finished";
                Noun.reviewDate = DateTime.Now.AddDays(4);
                _methods.updateNoun(Noun);
            }
            return RedirectToAction(nameof(AllNouns));

        }

        public IActionResult AddUpdateNounReview(int id)
        {
            //if (id == 0)
            //    return View(new Noun());
            //else
            return View(_methods.findNoun(id));
        }
        [HttpPost]
        public IActionResult AddUpdateNounReview(Noun Noun)
        {
            if (ModelState.IsValid)
            {
                //if (Noun.id == 0)
                //    _methods.AddNoun(Noun);
                //else
                Noun.status = "Finished";
                Noun.reviewDate = DateTime.Now.AddDays(4);
                _methods.updateNoun(Noun);
            }
            return RedirectToAction(nameof(ReviewNouns));

        }



        public IActionResult AllVerbs()
        {
            return View(_methods.GetAllNonFinishedVerbs());
        }

        public IActionResult ReviewVerbs()
        {
            return View(_methods.GetAllReviewVerbs());
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
                Verb.status = "Finished";
                Verb.reviewDate = DateTime.Now.AddDays(4);
                _methods.updateVerb(Verb);
            }
            return RedirectToAction(nameof(AllVerbs));

        }

        public IActionResult AddUpdateVerbReview(int id)
        {
            //if (id == 0)
            //    return View(new Verb());
            //else
            return View(_methods.findVerb(id));
        }
        [HttpPost]
        public IActionResult AddUpdateVerbReview(Verb Verb)
        {
            if (ModelState.IsValid)
            {
                //if (Verb.id == 0)
                //    _methods.AddVerb(Verb);
                //else
                Verb.status = "Finished";
                Verb.reviewDate = DateTime.Now.AddDays(4);
                _methods.updateVerb(Verb);
            }
            return RedirectToAction(nameof(ReviewVerbs));

        }


    }
}
