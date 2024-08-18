public abstract class ArmyUnit
{

    public string name;

    public int power;
    public int movement;
    public int toughness;
    public int range;
    
    public bool belongsToPlayer;
    public string getName(){return name;}
    public bool getBelongsToPlayer(){return belongsToPlayer;}

    virtual public void takeDamage(int damage)
    {
        toughness -= damage;
        if (!isDead()){
            
        }
    }
    private bool isDead()
    {
        if (toughness <= 0){ return true;}
        return false;
    }

    // Visually update the stats of the unit.
    // private void updateStats(){}


}