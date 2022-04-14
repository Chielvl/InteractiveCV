using InteractiveCVLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveCVLibrary
{
   public interface ICard
    {
        string Name { get; set; }
        string Description { get; set; }

        ICounterCard CounterCard { get; set; }

        ICounterCard Play();
    }
}
