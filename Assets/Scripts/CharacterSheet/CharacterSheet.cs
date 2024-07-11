using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterSheet
{
    public class CharacterSheet
    {
        private StatBlock statBlock;
        private CharacterProficiencies characterProficiencies;
        private int level;
        private string name;
        private int hitPointsTotal;
        private int hitPointsCurrent;
        private int tmpHitPoints;
        private int speed;
        private bool isDowned;
        private bool inspiration;
        private int proficencyBonus;

        private int GetModForStat(Stats stat)
        {
            return statBlock.GetStatScore(stat) / 2 - 5;
        }

        private int GetModForSkill(Skills skill)
        {
            return GetModForStat(SkillBlock.SkillsDictionary[skill]) + characterProficiencies.GetProficiencyForSkill(skill)*ProficiencyBonus;
        }
        
        public int Strength => statBlock.Strength;
        public int Dexterity => statBlock.Dexterity;
        public int Constitution => statBlock.Constitution;
        public int Intelligence => statBlock.Intelligence;
        public int Wisdom => statBlock.Wisdom;
        public int Charisma => statBlock.Charisma;

        public int StrengthMod => GetModForStat(Stats.Strength);
        public int DexterityMod => GetModForStat(Stats.Dexterity);
        public int ConstitutionMod => GetModForStat(Stats.Constitution);
        public int IntelligenceMod => GetModForStat(Stats.Intelligence);
        public int WisdomMod => GetModForStat(Stats.Wisdom);
        public int CharismaMod => GetModForStat(Stats.Charisma);

        public int Initiative => DexterityMod;

        public int HitPointsTotal => hitPointsTotal;
        public int ProficiencyBonus => (level-1)/4 + 2;

        public int HitPointsCurrent => hitPointsCurrent;
        //skill proficiencies
        //save proficiencies
        //proficiency bonus
        //ac
        //initiative
        //level
        //hitPoints
        //tmpHitPoints
        //name
        //background
        //playerName
        //race
        //speed
        //hitDice
        //deathSaves
        //passivePerception
        //passiveInsight
        //inspiration
        //backstoryShit (personality/ideals/bonds/flaws)
        //...
        //equipment
        //spellcasting:
        //scAbility
        //spellSaveDC
        //SpellAttackBonus
        //Constructor
        //
    }

    public enum Classes
    {
        Artificer,
        Barbarian,
        Bard,
        BloodHunter,
        Cleric,
        Druid,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
    }
}

