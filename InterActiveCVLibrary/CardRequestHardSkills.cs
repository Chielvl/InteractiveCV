using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveCVLibrary
{
    public class CardRequestHardSkills : ICard
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICounterCard CounterCard {get; set;}

        public CardRequestHardSkills()
        {
            Name = "Skill check!";
            Description = "Does Chiel have the necessary skills? Let's see";
            CounterCard = new CounterCardHardSkills();
        }

        public ICounterCard Play()
        {
            Debug.WriteLine("Played Hard Skills");
            return CounterCard;
        }

        
    }
}
