using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InitiativeTracker
{
    public class Tracker : MonoBehaviour, ITracker
    {
        // Initiative structure
        // combat value | name | initiative

        public static bool isCombat = false;
        Combatants active = new Combatants();
        Turn tracker = new Turn();
        IEnumerator<Combatants> ie;

        void Start()
        {
            AddCombatante();
        }

        public void AddCombatante()
        {
            // Temp data
            #region Temp
            Combatants a = new Combatants(20, 2, "Grek1");
            Combatants b = new Combatants(16, 3, "Grek4");
            Combatants c = new Combatants(16, 4, "Grek3");
            Combatants d = new Combatants(13, 2, "Grek5");
            Combatants e = new Combatants(18, 3, "Grek2");

            tracker.AddCombatant(a);
            tracker.AddCombatant(b);
            tracker.AddCombatant(c);
            tracker.AddCombatant(d);
            tracker.AddCombatant(e);
            #endregion

            ie = tracker.GetEnumerator();
            tracker.SortTracker();
            tracker.StartTurn();

            // Moving pointer to the first element
            NextAction();
            
            for(int i=0; i<10; i++)
            {
                // Infinite interation via resetting the pointer
                if (ie.Current == tracker.Last()) ie = tracker.GetEnumerator();
                
                NextAction();
            }
        }
        public void RemoveCombatant(GameObject o)
        {
            // For further change
            // if (turn.Contains(o)) turn.Remove(o);
        }

        public void NextAction() // emits a signal when all modifications have been completed, allowing the code to continue
        {
            if(ie.MoveNext())
                active = ie.Current;
            Debug.Log($"{active.characterName}, {active.initiative}");
        }

        public void RollInitiative() 
        { 
            //foreach(Combatants c in turn) 
            //    Rrrrrrrrroooooll iiiiinitiative
        }
    }
}