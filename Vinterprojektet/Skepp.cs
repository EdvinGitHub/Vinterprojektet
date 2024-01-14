namespace Vinterprojektet;

public class Skepp
{
    public int skotxPosition;
    public int skotyPosition;

    public Skepp playerSkot = new();
    public List<Skepp> skots = new List<Skepp>();
    public void PlayerHasShot()
    {
        
        
        skots.Add(playerSkot);
    }
}
