public class Combatants
{
    public int initiativeModifier { get; private set; }
    public int initiative { get; private set; }
    public string characterName { get; private set; }
    public bool isDead { get; private set; } = false;
    public bool isSurprised { get; private set; } = false;
    public bool isStunned { get; private set; } = false;

    public Combatants(int initiative = 0, int initiativeModifier = 0, string characterName = "")
    {
        this.initiative = initiative;
        this.initiativeModifier = initiativeModifier;
        this.characterName = characterName;
    }

    public void Dead() => isDead = true;
    public void Surprised() => isSurprised = !isSurprised;
    public void Stunned() => isStunned = !isStunned;
}
