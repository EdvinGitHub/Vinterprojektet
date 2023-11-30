
using Vinterprojektet;

Skepp[,] rutnät = new Skepp[10, 10];


Spelare spe = new Spelare();
rutnät[4,4] = spe.spelare1x;
// rutnät[3,4] = spe.spelare1y;


while(true)
{

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


    Console.ReadLine();
}