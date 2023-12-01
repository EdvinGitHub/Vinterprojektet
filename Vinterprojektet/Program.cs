
using Vinterprojektet;

Skepp[,] rutnät = new Skepp[10, 10];
Skepp[,] rutnätEnemy = new Skepp[10, 10];


Spelare spe = new Spelare();
int xPosition;
int yPosition;
int xPositionB;
int yPositionB;
string g;

for(int i=5; i>0;i--)
{
g = Console.ReadLine();
xPosition = System.Convert.ToInt32(g);

g = Console.ReadLine();
yPosition = System.Convert.ToInt32(g);

g = Console.ReadLine();
spe.spelareH =  System.Convert.ToInt32(g);

xPositionB = xPosition;
yPositionB = yPosition;

if(spe.spelareH == 1 )
{yPositionB++;}
if(spe.spelareH == 2 )
{yPositionB--;}
if(spe.spelareH == 3 )
{xPositionB++;}
if(spe.spelareH == 4 )
{xPositionB--;}

if(i==4)
{rutnät[xPosition,yPosition] = spe.skepp1a;
rutnät[xPositionB,yPositionB] = spe.skepp1b;}

if(i==3)
{rutnät[xPosition,yPosition] = spe.skepp2a;
rutnät[xPositionB,yPositionB] = spe.skepp2b;}

if(i==2)
{rutnät[xPosition,yPosition] = spe.skepp3a;
rutnät[xPositionB,yPositionB] = spe.skepp3b;}

if(i==1)
{rutnät[xPosition,yPosition] = spe.skepp4a;
rutnät[xPositionB,yPositionB] = spe.skepp4b;}

if(i==0)
{rutnät[xPosition,yPosition] = spe.skepp5a;}
rutnät[xPositionB,yPositionB] = spe.skepp5b;
}


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
    for (int x = 0; x < rutnätEnemy.GetLength(0); x++)
    {
        for (int y = 0; y < rutnätEnemy.GetLength(1); y++)
        {
            Console.SetCursorPosition(x, y);
            if (rutnätEnemy[x, y] is Skepp)
            {
                Console.Write("s");
            }
            else
            {
                Console.Write("o");
            }
        }
    }


    Console.ReadLine();
}