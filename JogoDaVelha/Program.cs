
/*
 
S | S | S
---------
S | S | S
---------
S | S | S

*/


string[,] tabuleiro =
{
    { " ", " ", " " },
    { " ", " ", " " },
    { " ", " ", " " }
};

bool jogadorX = true;

bool flag = true;


while (flag)
{

    Console.WriteLine("----------");

    for (int i = 0; i < 3; i++)
    {
        Console.Write("|");

        for (int j = 0; j < 3; j++)
        {
            Console.Write($"{tabuleiro[i, j]} |");
        }

        Console.WriteLine();

        Console.WriteLine("----------");
    }

    string jogadorDaVez = jogadorX ? "X" : "O";

    Console.WriteLine($"A vez é do jogaro: {jogadorDaVez}!");

    Console.WriteLine("Digite a linha:");
    int entradaI = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a coluna:");
    int entradaJ = Convert.ToInt32(Console.ReadLine());

    entradaI--;
    entradaJ--;

    if (!(entradaI < 0 || entradaJ < 0 || entradaI > 2 || entradaJ > 2 || entradaI < 0 || entradaJ < 0 || entradaI > 2 || entradaJ > 2))
    {
        if (tabuleiro[entradaI, entradaJ] == " ")
        {
            tabuleiro[entradaI, entradaJ] = jogadorDaVez;

            if (jogadorX)
            {
                jogadorX = false;
            }
            else
            {
                jogadorX = true;
            }
        }
        else
        {
            Console.WriteLine("escolha um espaço valido");
        }
    }
    else
    {
        Console.WriteLine("escolha um espaço valido");
    }

}