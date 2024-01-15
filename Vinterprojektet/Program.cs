
using Vinterprojektet;

Skepp[,] rutnät = new Skepp[10, 10];
// Skepp[,] rutnätEnemy = new Skepp[10, 10];

Enemy enemy = new Enemy();
Spelare spe = new Spelare();
Skepp skep = new Skepp();
string skot;
int xPosition;
int yPosition;
int xPositionB;
int yPositionB;
string g;

for(int i=5; i>0; i--)
{
Console.Clear();
for (int x = 0; x < rutnät.GetLength(0); x++)
    {
        for (int y = 0; y < rutnät.GetLength(1); y++)
        {
            Console.SetCursorPosition(x, y);
            if (rutnät[x, y] is Skepp)
            {
                Console.Write("s");
            }
            else
            {
                Console.Write("o");
            }
        }
    }
Console.WriteLine();
Console.WriteLine("på vilken x");
g = Console.ReadLine();
xPosition = System.Convert.ToInt32(g);
Console.WriteLine("på vilken y");

g = Console.ReadLine();
yPosition = System.Convert.ToInt32(g);
Console.WriteLine("åt villket håll");

g = Console.ReadLine();
spe.spelareH =  System.Convert.ToInt32(g);

xPositionB = xPosition;
yPositionB = yPosition;

if(spe.spelareH == 1 )
{yPositionB--;}
if(spe.spelareH == 2 )
{yPositionB++;}
if(spe.spelareH == 3 )
{xPositionB++;}
if(spe.spelareH == 4 )  
{xPositionB--;}

if(i==5)
{rutnät[xPosition,yPosition] = spe.skepp1a;
rutnät[xPositionB,yPositionB] = spe.skepp1b;}

if(i==4)
{rutnät[xPosition,yPosition] = spe.skepp2a;
rutnät[xPositionB,yPositionB] = spe.skepp2b;}

if(i==3)
{rutnät[xPosition,yPosition] = spe.skepp3a;
rutnät[xPositionB,yPositionB] = spe.skepp3b;}

if(i==2)
{rutnät[xPosition,yPosition] = spe.skepp4a;
rutnät[xPositionB,yPositionB] = spe.skepp4b;}

if(i==1)
{rutnät[xPosition,yPosition] = spe.skepp5a;}
rutnät[xPositionB,yPositionB] = spe.skepp5b;

}

enemy.EnemyPosition();
while(true)
{
    Console.Clear();
    for (int x = 0; x < rutnät.GetLength(0); x++)
    {
        for (int y = 0; y < rutnät.GetLength(1); y++)
        {
            Console.SetCursorPosition(x, y);
            if (rutnät[x, y] is Skepp)
            {
                Console.Write("s");
            }
            else
            {
                Console.Write("o");
            }
        }
    }
    Console.WriteLine();
    Console.ReadLine();
    Skepp xy= new();
    int blok;
    for (int x = 0; x < enemy.rutnätEnemy.GetLength(0); x++)
    {
        for (int y = 0; y < enemy.rutnätEnemy.GetLength(1); y++)
        {
            enemy.rutnätEnemy[x,y] = xy;    
            Console.SetCursorPosition(x, y);
            if (enemy.rutnätEnemy[x, y] is Skepp)
            {
                
                for (int i = 0;i < spe.skots.Count; i++)
                {
                blok=i;
                blok--;
                if (spe.skots[i] ==xy)
                {Console.WriteLine("x");}
                }
                Console.Write("s");

            }
            else
            {
                for (int i = 0; i < spe.skots.Count; i++)
                {
                if(spe.skots[i] == xy)
                {Console.WriteLine("p");}
                }
                for (int i = 0; i <= spe.skots.Count; i++)
                {
                if(spe.skots[i] != xy)
                {
                Console.Write("o");
                }
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("På vilken x vill du skuta");
    skot = Console.ReadLine();
    spe.skotxPosition =  System.Convert.ToInt32(skot);
    Console.WriteLine("På vilken y vill du skuta");
    skot = Console.ReadLine();
    spe.skotyPosition =  System.Convert.ToInt32(skot);
    enemy.rutnätEnemy[spe.skotxPosition,spe.skotyPosition] = spe.playerSkot;
    spe.PlayerHasShot();

    Console.ReadLine();
}