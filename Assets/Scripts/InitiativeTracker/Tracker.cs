using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InitiativeTracker
{
    public class Tracker : MonoBehaviour, ITracker
    {
        // To change
        List<GameObject> combatants;

        public void AddCombatant(GameObject o)
        {
            if (!combatants.Contains(o)) combatants.Add(o);
        }

        public void RemoveCombatant(GameObject o)
        {
            if (combatants.Contains(o)) combatants.Remove(o);
        }

        public void MoveCombatant(GameObject o)
        {

        }

        public void NextAction() // emits a signal when all modifications have been completed, allowing the code to continue
        {

        }

        public void RollInitiative() 
        { 
        
        }
    }
}