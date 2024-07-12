using UnityEngine;

public interface ITracker
{
    // Object to change
    public void AddCombatante();
    public void RemoveCombatant(GameObject o);
    public void NextAction();
    public void RollInitiative();
}