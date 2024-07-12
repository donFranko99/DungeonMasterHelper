using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Turn : IEnumerable<Combatants>
{
    List<Combatants> combatants = new List<Combatants>();
    List<Combatants> combatantsCopy = new List<Combatants>();

    public void StartTurn() => combatants = combatantsCopy;

    public void AddCombatant(Combatants c) => combatantsCopy.Add(c);

    // Remove only when preparing
    // Also questionable try ... catch
    public void RemoveCombatant(Combatants c)
    {
        try
        {
            if(InitiativeTracker.Tracker.isCombat) 
                combatantsCopy.Remove(c);
        } catch (Exception e)
        {
            Debug.LogError("An error has occured while removing a character from the tracker.");
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<Combatants> GetEnumerator()
    {
        foreach(Combatants c in combatantsCopy) 
            yield return c;
    }

    public void SortTracker()
    {
        combatantsCopy = combatantsCopy.OrderByDescending(x => x.initiative).ThenByDescending(x => x.initiativeModifier).ThenBy(x => x.characterName).ToList();
        foreach(var a in combatantsCopy) Debug.Log(a.characterName);
    }
}
