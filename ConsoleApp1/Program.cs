//a) 1 5 9 13 17 21 25 29 ...

int osm = 12;

void A(int input)
{
    Console.Write("a) ");
    int cislo = 1;
    for (int i = 0; i < input; i++)
    {
        cislo += 4;
        Console.Write($"{cislo}, ");
    }
    Console.WriteLine();
}


// b) 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 ...
void B(int input)
{
    int cislo = 2;
    int pocet;
    Console.Write("b) ");
    for (int i = 0; i < input; i++)
    {
        pocet = 0;
        if (cislo % 2 == 0)
        {
            if (cislo == 2)
            {
                Console.Write($"{cislo}, ");
            }
            cislo += 1;
        }
        else
        {
            for (int k = 1; k <= cislo; k++)
            {
                if (cislo % k == 0)
                {
                    pocet += 1;
                }
            }

            if (pocet == 2)
            {
                Console.Write($"{cislo}, ");
                cislo += 1;
            }
            else
            {
                cislo += 1;
            }
        }
    }
    Console.WriteLine();
}


// c) 1 2 4 7 11 16 ...
void C(int input)
{
    int cislo = 1;
    Console.Write("c) ");
    for (int i = 0; i < input; i++)
    {
        cislo += i;
        Console.Write($"{cislo}, ");
    }
    Console.WriteLine();
}

// d) 1 1 2 1 2 3 1 2 3 4 1 2 ...
void D(int input)
{
    int cislo = 0;
    int pocet = 0;
    Console.Write("d) ");
    for (int i = 0; i < input; i++)
    {
        for (int k = 1; k < i; k++)
        {
            pocet += 1;
            if (pocet <= input)
            {
                Console.Write($"{k}, ");
            }
            else
            {
                break;
            }

        }
    }
    Console.WriteLine();
}

// e) 1 2 4 7 9 12 18 24 32 38 42 50 56 64 71 73 75 81 ...
void E(int input)
{
    int cislo = 1;
    int pocet = 0;
    Console.Write("e) ");
    for (int i = 0; i < input; i++)
    {
        for (int k = 1; k <= cislo; k++)
        {
            if (cislo % k == 0)
            {
                pocet += 1;
            }
        }
        cislo += pocet;
        Console.Write($"{cislo}, ");
        pocet = 0;
    }
    Console.WriteLine();
}

// f) 1 3 5 7 9 11...
void F(int input)
{
    Console.Write("f) ");
    int cislo = 1;
    for (int i = 0; i < input; i++)
    {
        cislo += 2;
        Console.Write($"{cislo}, ");
    }
    Console.WriteLine();
}

// g) 1 2 4 8 16 32 ...
void G(int input)
{
    Console.Write("g) ");
    int cislo = 1;
    for (int i = 0; i < input; i++)
    {
        cislo += cislo;
        Console.Write($"{cislo}, ");
    }
    Console.WriteLine();
}

// h) 0 1 1 2 3 5 8 13 21 34 55 89 ...
void H(int input)
{
    int cislo = 0;
    int druhecislo = 1;
    int treticislo;
    Console.Write("h) ");
    for (int i = 0; i < input; i++)
    {
        treticislo = cislo + druhecislo;
        Console.Write($"{cislo}, ");
        cislo = druhecislo;
        druhecislo = treticislo;
    }
    Console.WriteLine();
}
// i) 1 2 3 4 5 6 ...
void I(int input)
{
    Console.Write("i) ");
    for (int i = 0; i < input; i++)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}

// j) 1 11 21 1211 111221 312211 13112221 1113213211 ...
void J(int input)
{
    
}

// k) 1 2 6 24 120 ...
void K(int input)
{
    Console.Write("k) ");
    int cislo = 1;
    for (int i = 2; i < input; i++)
    {
        Console.Write($"{cislo}, ");
        cislo *= i;
    }
    Console.WriteLine();
}

A(osm);
B(osm);
C(osm);
D(osm);
E(osm);
F(osm);
G(osm);
H(osm);
I(osm);
//j
K(osm);
//l