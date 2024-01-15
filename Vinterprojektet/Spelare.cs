
namespace Vinterprojektet;

public class Spelare
{
    public int skotxPosition;
    public int skotyPosition;

    public Skepp playerSkot = new();
    public List<Skepp> skots = new List<Skepp>();
    public void PlayerHasShot()
    {
        skots.Add(playerSkot);
    }


    public Skepp  skepp1a = new(); 
    public Skepp  skepp2a = new(); 
    public Skepp  skepp3a = new(); 
    public Skepp  skepp4a = new(); 
    public Skepp  skepp5a = new(); 
    public Skepp  skepp1b = new(); 
    public Skepp  skepp2b = new(); 
    public Skepp  skepp3b = new(); 
    public Skepp  skepp4b = new(); 
    public Skepp  skepp5b = new(); 

    public int  spelareH = new();  
}
