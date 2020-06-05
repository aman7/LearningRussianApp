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
        IEnumerable<Noun> GetAllNonFinishedNouns();
        IEnumerable<Noun> GetAllReviewNouns();
        Noun findNoun(int id);
        void AddNoun(Noun newNoun);
        void updateNoun(Noun Noun);
        void deleteNoun(int id);

        IEnumerable<Verb> GetAllVerbs();
        IEnumerable<Verb> GetAllNonFinishedVerbs();
        IEnumerable<Verb> GetAllReviewVerbs();
        Verb findVerb(int id);
        void AddVerb(Verb newVerb);
        void updateVerb(Verb Verb);
        void deleteVerb(int id);

        IEnumerable<Adjective> GetAllAdjectives();
        IEnumerable<Adjective> GetAllNonFinishedAdjectives();
        IEnumerable<Adjective> GetAllReviewAdjectives();
        Adjective findAdjective(int id);
        void AddAdjective(Adjective newAdjective);
        void updateAdjective(Adjective Adjective);
        void deleteAdjective(int id);

    }
}

