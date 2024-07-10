using UnityEngine;

public interface ITracker
{
    // Object to change
    public void AddCombatant(GameObject o);
    public void RemoveCombatant(GameObject o);
    public void MoveCombatant(GameObject o);
    public void NextAction();

    public void RollInitiative();
}