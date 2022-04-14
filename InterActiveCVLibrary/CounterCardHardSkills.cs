using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace InteractiveCVLibrary
{
    public class CounterCardHardSkills : ICounterCard
    {
        public List<IExample> exampleList { get; set; }
        public CounterCardHardSkills()
        {
            GetExamples();
        }

        public void GetExamples()
        {
            exampleList = new List<IExample>();
            //Hier komt nog een laad fucntie, die de bestanden inlaad uit een extern bestand.
            string[] examples = LoadFile.LoadNewFile("HardSkill.txt");
            foreach (string example in examples)
            {
                string skill = example.Substring(0, example.IndexOf(':'));
                int skillLevel = int.Parse(example.Substring(example.IndexOf(':')+1));
                exampleList.Add(new HardSkill(skill, skillLevel));
            }
        }

        public List<IExample> Counter()
        {
            if (exampleList == null)
                GetExamples();
            return exampleList;
        }
    }
}
