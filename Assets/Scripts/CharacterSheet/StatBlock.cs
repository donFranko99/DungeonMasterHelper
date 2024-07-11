using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterSheet
{
    public class StatBlock
    {
        private int[] stats = new int[6];
        
        public int Strength => stats[0];
        public int Dexterity => stats[1];
        public int Constitution => stats[2];
        public int Intelligence => stats[3];
        public int Wisdom => stats[4];
        public int Charisma => stats[5];

        public StatBlock(int[] stats)
        {
            for (int i = 0; i < 6; i++)
            {
                if (stats[i]<0 || stats[i]>50)
                {
                    Debug.Log($"Ability score out of range: {i} was {stats[i]}");
                    return;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                this.stats[i] = stats[i];
            }
            Debug.Log("Stats has been set");
        }

        public int GetStatScore(Stats stat)
        {
            return stats[StatIndex[stat]];
        }

        public static readonly Dictionary<Stats, int> StatIndex = new Dictionary<Stats, int>
        {
            {Stats.Strength, 0},
            {Stats.Dexterity, 1},
            {Stats.Constitution, 2},
            {Stats.Intelligence, 3},
            {Stats.Wisdom, 4},
            {Stats.Charisma, 5}
        };
    }

    public enum Stats
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }
}

