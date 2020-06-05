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
                if (Noun.answer == "Correct")
                {
                    Noun.reviewDate = DateTime.Now.AddDays(10);
                }

                if (Noun.answer == "Wrong")
                {
                    Noun.reviewDate = DateTime.Now.AddDays(4);
                }

                Noun.status = "Finished";
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
                if (Verb.answer == "Correct")
                {
                    Verb.reviewDate = DateTime.Now.AddDays(10);
                }

                if (Verb.answer == "Wrong")
                {
                    Verb.reviewDate = DateTime.Now.AddDays(4);
                }
                Verb.status = "Finished";
                
                _methods.updateVerb(Verb);
            }
            return RedirectToAction(nameof(ReviewVerbs));

        }


        public IActionResult AllAdjectives()
        {
            return View(_methods.GetAllNonFinishedAdjectives());
        }

        public IActionResult ReviewAdjectives()
        {
            return View(_methods.GetAllReviewAdjectives());
        }


        public IActionResult AddUpdateAdjective(int id)
        {
            //if (id == 0)
            //    return View(new Adjective());
            //else
            return View(_methods.findAdjective(id));
        }
        [HttpPost]
        public IActionResult AddUpdateAdjective(Adjective Adjective)
        {
            if (ModelState.IsValid)
            {
                //if (Adjective.id == 0)
                //    _methods.AddAdjective(Adjective);
                //else
                Adjective.status = "Finished";
                Adjective.reviewDate = DateTime.Now.AddDays(4);
                _methods.updateAdjective(Adjective);
            }
            return RedirectToAction(nameof(AllAdjectives));

        }

        public IActionResult AddUpdateAdjectiveReview(int id)
        {
            //if (id == 0)
            //    return View(new Adjective());
            //else
            return View(_methods.findAdjective(id));
        }
        [HttpPost]
        public IActionResult AddUpdateAdjectiveReview(Adjective Adjective)
        {
            if (ModelState.IsValid)
            {
                //if (Adjective.id == 0)
                //    _methods.AddAdjective(Adjective);
                //else
                if (Adjective.answer == "Correct")
                {
                    Adjective.reviewDate = DateTime.Now.AddDays(10);
                }

                if (Adjective.answer == "Wrong")
                {
                    Adjective.reviewDate = DateTime.Now.AddDays(4);
                }

                Adjective.status = "Finished";
                _methods.updateAdjective(Adjective);
            }
            return RedirectToAction(nameof(ReviewAdjectives));

        }


    }
}
