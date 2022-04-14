using System.Collections;
using System.Collections.Generic;

namespace InteractiveCVLibrary
{
    public interface ICounterCard
    {
        List<IExample> exampleList { get; set; }
        List<IExample> Counter();

        void GetExamples();
    }
}
