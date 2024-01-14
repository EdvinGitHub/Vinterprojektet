namespace Vinterprojektet;

public class Enemy
{
    public Skepp[,] rutnätEnemy = new Skepp[10, 10];
    int xPosition;
    int yPosition;
    public int skotxPosition;
    public int skotyPosition;
    int xPositionB;
    int yPositionB;


    public Skepp playerSkot = new();
    private Skepp enemy1x = new();
    private Skepp enemy2x = new();
    private Skepp enemy3x = new();
    private Skepp enemy4x = new();
    private Skepp enemy5x = new();
    private Skepp enemy1h = new();
    private Skepp enemy2h = new();
    private Skepp enemy3h = new();
    private Skepp enemy4h = new();
    private Skepp enemy5h = new();
    public void EnemyPosition()
    {
        int patorn;
        for (int i = 5; i > 0; i--)
        {
            patorn = Random.Shared.Next(10);
            xPosition = patorn;
            patorn = Random.Shared.Next(10);
            yPosition = patorn;
            patorn = Random.Shared.Next(4);
            if(yPosition == 0)
            {if(patorn == 1){patorn++;}}
            if(yPosition == 10)
            {if(patorn == 2){patorn--;}}
            if(xPosition == 0)
            {if(patorn == 4){patorn--;}}
            if(xPosition == 10)
            {if(patorn == 3){patorn++;}}
        
        yPositionB = yPosition;
        xPositionB = xPosition;

            if(patorn == 1 )
            {yPositionB--;}
            
            if(patorn == 2 )
            {yPositionB++;}

            if(patorn == 3 )
            {xPositionB++;}
            
            if(patorn == 4 )
            {xPositionB--;}
            
            
   

            if(i==5)
            {rutnätEnemy[xPosition,yPosition] = enemy1x;
            rutnätEnemy[xPositionB,yPositionB] = enemy1h;}
            if(i==4)
            {rutnätEnemy[xPosition,yPosition] = enemy2x;
            rutnätEnemy[xPositionB,yPositionB] = enemy2h;}
            if(i==3)
            {rutnätEnemy[xPosition,yPosition] = enemy3x;
            rutnätEnemy[xPositionB,yPositionB] = enemy3h;}
            if(i==2)
            {rutnätEnemy[xPosition,yPosition] = enemy4x;
            rutnätEnemy[xPositionB,yPositionB] = enemy4h;}
            if(i==1)
            {rutnätEnemy[xPosition,yPosition] = enemy5x;
            rutnätEnemy[xPositionB,yPositionB] = enemy5h;}
        }

    }
}
