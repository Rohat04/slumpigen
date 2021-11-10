using System;

Console.WriteLine("Klicka på valfri knapp");
Console.ReadKey();

int mariohp = 100;
int luigihp = 100;

//Namn registrering
string name = Console.ReadLine();


while (name != "mario" && name != "luigi")
{
    Console.WriteLine("Välj din karaktär! mario/luigi!");
    name = Console.ReadLine();
}

//Countdown!
int i = 10;

while (i > 0)
{
    Console.WriteLine(i);
    i -= 1;
}

Console.WriteLine("Fight!");
Console.ReadLine();

// name = "";
// while (name != "mario" || name != "luigi")
// {
//     Console.WriteLine("fight!");
//     Console.ReadLine();
// }

Console.ReadLine();

while (mariohp > 0 && luigihp > 0)
{
    Random generator = new Random();
    int mariodamage = generator.Next(0, 10);
    int luigidamage = generator.Next(0, 10);

    mariohp -= luigidamage;
    luigihp -= mariodamage;

    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
    Console.WriteLine($"mario har nu {mariohp} hp och luigi har {luigihp} hp");
    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
    Console.ReadLine();
    //Console.WriteLine("Klicka på valfri knapp för att forsätta!");
    Console.ReadLine();
}


if (mariohp < 0 && luigihp < 0)
{
    Console.ReadLine();
}

if (mariohp < 0)
{
    Console.WriteLine("luigi vann!");
    Console.ReadKey();
}

if (luigihp < 0)
{
    Console.WriteLine("mario vann!");
    Console.ReadKey();
}


if (luigihp == mariohp)
{
    Console.WriteLine("Oavgjort!");
    Console.ReadLine();
}



/*Random generator = new Random();

int woodInForest = 1000;

int howMuchWood = generator.Next(100);

Console.WriteLine(howMuchWood);

woodInForest -= howMuchWood;

if (howMuchWood < 50)
{
    Console.WriteLine("Not enough wood!");
}
else
{
    Console.WriteLine("A whole lotta wood!");
}

*/
//LOOP
