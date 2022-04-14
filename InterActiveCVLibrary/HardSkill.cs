using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InteractiveCVLibrary.KnowledgeEnum;

namespace InteractiveCVLibrary
{
    public class HardSkill : IExample
    {
        public string Name { get; private set; }
        public int SkillLevel { get; private set; }
        public TextSkillLevel SkillLevelText { get; private set; }

        public HardSkill(string name, int skillLevel)
        {
            Name = name;
            SkillLevel = skillLevel;
            SkillLevelText = (TextSkillLevel) skillLevel;
        }

        public override string ToString()
        {
            return Name + " " + SkillLevelText;
        }
    }
}
