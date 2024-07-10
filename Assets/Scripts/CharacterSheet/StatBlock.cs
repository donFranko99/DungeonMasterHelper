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
        
    }

    public enum Stats
    {
        Strength=0,
        Dexterity=1,
        Constitution=2,
        Intelligence=3,
        Wisdom=4,
        Charisma=5
    }
}

