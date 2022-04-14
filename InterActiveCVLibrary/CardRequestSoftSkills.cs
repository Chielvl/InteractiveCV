using InteractiveCVLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveCVLibrary
{
    public class CardRequestSoftSkills : ICard
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICounterCard CounterCard { get; set; }

        public CardRequestSoftSkills()
        {
            Name = "Soft skills";
            Description = "How about Soft skills, let's see if Chiel has those!";

        }

        public ICounterCard Play()
        {
            return CounterCard;
        }


    }
}

