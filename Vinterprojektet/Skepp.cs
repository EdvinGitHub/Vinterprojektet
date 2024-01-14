namespace Vinterprojektet;

public class Skepp
{
    Enemy GetEnemy = new Enemy();
    public List<Skepp> skot = new List<Skepp>();
    public Skepp playerGoodShot = new();
    public void PlayerHasShot()
    {
        
        playerGoodShot = GetEnemy.playerSkot;
        skot.Add(playerGoodShot);
    }
}
