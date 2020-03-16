﻿using LearningRussianApp.Data;
using LearningRussianApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Repository
{
    public class Methods : IMethods
    {
        private LearningRussianDbContext _context;
        public Methods(LearningRussianDbContext context)
        {
            _context = context;
        }
        public void AddNoun(Noun newNoun)
        {
            _context.nouns.Add(newNoun);
            _context.SaveChanges();
        }

        public void AddVerb(Verb newVerb)
        {
            _context.verbs.Add(newVerb);
            _context.SaveChanges();
        }

        public void deleteNoun(int id)
        {
            var server = _context.nouns.Find(id);
            _context.nouns.Remove(server);
            _context.SaveChanges();
        }

        public void deleteVerb(int id)
        {
            var server = _context.verbs.Find(id);
            _context.verbs.Remove(server);
            _context.SaveChanges();
        }

        public Noun findNoun(int id)
        {
            return _context.nouns.FirstOrDefault(i => i.id == id);
        }

        public Verb findVerb(int id)
        {
            return _context.verbs.FirstOrDefault(i => i.id == id);
        }

        public IEnumerable<Noun> GetAllNouns()
        {
            return _context.nouns.ToList();
        }

        public IEnumerable<Verb> GetAllVerbs()
        {
            return _context.verbs.ToList();
        }


        public void updateNoun(Noun Noun)
        {
            _context.Attach(Noun).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void updateVerb(Verb Verb)
        {
            _context.Attach(Verb).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
