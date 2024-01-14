namespace Vinterprojektet;

public class Skepp
{
    Enemy GetEnemy = new Enemy();
    private List<Skepp> skot = new List<Skepp>();
    private Skepp playerGoodShot = new();
    public void PlayerHasShot()
    {
        
        playerGoodShot = GetEnemy.playerSkot;
        skot.Add(playerGoodShot);
    }
}
