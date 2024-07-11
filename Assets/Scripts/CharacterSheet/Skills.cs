using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterSheet
{
    public static class SkillBlock
    {
        public static readonly Dictionary<Skills, Stats> SkillsDictionary = new Dictionary<Skills, Stats>
        {
            {Skills.Acrobatics, Stats.Dexterity},
            {Skills.AnimalHandling, Stats.Wisdom},
            {Skills.Arcana, Stats.Intelligence},
            {Skills.Athletics, Stats.Strength},
            {Skills.Deception, Stats.Charisma},
            {Skills.History, Stats.Intelligence},
            {Skills.Insight, Stats.Wisdom},
            {Skills.Intimidation, Stats.Charisma},
            {Skills.Investigation, Stats.Intelligence},
            {Skills.Medicine, Stats.Wisdom},
            {Skills.Nature, Stats.Intelligence},
            {Skills.Perception, Stats.Wisdom},
            {Skills.Performance, Stats.Charisma},
            {Skills.Persuasion, Stats.Charisma},
            {Skills.Religion, Stats.Intelligence},
            {Skills.SleightOfHand, Stats.Dexterity},
            {Skills.Stealth, Stats.Dexterity},
            {Skills.Survival, Stats.Wisdom}
        };
    }
    public enum Skills
    {
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SleightOfHand,
        Stealth,
        Survival
    }
}