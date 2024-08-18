using System.Reflection.Metadata.Ecma335;

class PlayerData
{

    //initGold is the gold at the start of the game.
    int initGold = 10;

    public static PlayerData instance;

    //10 is a filler number for some amount of possible structures.
    Structure[] createdStructures = new Structure[GlobalVariables.numTotalStructures];

    public int playerGold;

    public PlayerData()
    {
        playerGold = initGold;
        
    }


    //Implementation of the Singleton design pattern - there should never be more than one PlayerData at a time.
    public static PlayerData getPlayerData()
    {
        if(instance == null){
            instance = new PlayerData();
        }
        return instance;
    }
}