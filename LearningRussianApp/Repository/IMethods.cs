using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningRussianApp.Models;

namespace LearningRussianApp.Repository
{
    public interface IMethods
    {
        IEnumerable<Noun> GetAllNouns();
        Noun findNoun(int id);
        void AddNoun(Noun newNoun);
        void updateNoun(Noun Noun);
        void deleteNoun(int id);

        IEnumerable<Verb> GetAllVerbs();
        Verb findVerb(int id);
        void AddVerb(Verb newVerb);
        void updateVerb(Verb Verb);
        void deleteVerb(int id);

    }
}

