using System.Collections;
using System.Collections.Generic;
using CharacterSheet;
using UnityEngine;

namespace CharacterSheet
{
    public class CharacterProficiencies
    {
        private Dictionary<Skills, int> SkillProficiencies = new Dictionary<Skills, int>
        {
            {Skills.Acrobatics, 0},
            {Skills.AnimalHandling, 0},
            {Skills.Arcana, 0},
            {Skills.Athletics, 0},
            {Skills.Deception, 0},
            {Skills.History, 0},
            {Skills.Insight, 0},
            {Skills.Intimidation, 0},
            {Skills.Investigation, 0},
            {Skills.Medicine, 0},
            {Skills.Nature, 0},
            {Skills.Perception, 0},
            {Skills.Performance, 0},
            {Skills.Persuasion, 0},
            {Skills.Religion, 0},
            {Skills.SleightOfHand, 0},
            {Skills.Stealth, 0},
            {Skills.Survival, 0}
        };

        private Dictionary<Stats, int> SaveProficiencies = new Dictionary<Stats, int>
        {
            {Stats.Strength, 0},
            {Stats.Strength, 0},
            {Stats.Constitution, 0},
            {Stats.Intelligence, 0},
            {Stats.Wisdom, 0},
            {Stats.Charisma, 0}
        };

        public void SetSkillProficiency(Skills skill, int prof = 1)
        {
            if (prof>1 || prof<0)
            {
                Debug.Log($"Proficiency should be set to either 0 or 1, given was: {prof}");
                return;
            }
            SkillProficiencies[skill] = prof;
        }
        
        public void SetSaveProficiency(Stats stat, int prof = 1)
        {
            if (prof>1 || prof<0)
            {
                Debug.Log($"Proficiency should be set to either 0 or 1, given was: {prof}");
                return;
            }
            SaveProficiencies[stat] = prof;
        }

        public int GetProficiencyForSkill(Skills skill)
        {
            return SkillProficiencies[skill];
        }
        
        public int GetProficiencyForSave(Stats stat)
        {
            return SaveProficiencies[stat];
        }

        public CharacterProficiencies(List<Skills> skills, List<Stats> saves)
        {
            foreach (Skills skill in skills)
            {
                SkillProficiencies[skill] = 1;
            }
            foreach (Stats save in saves)
            {
                SaveProficiencies[save] = 1;
            }
        }
    }
}
