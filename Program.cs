using System.Runtime.InteropServices;

string Name;
Console.WriteLine("What is your name?");
Name = Console.ReadLine();
string[] letters = new string[Name.Length];

for (int i = 0; i < Name.Length; i++)
{
    letters[i] = Name[i].ToString();
}

string[] backletters = new string[letters.Length];

for (int e = 0; e < letters.Length; e++)
{
    backletters[e] = letters[(letters.Length - 1) - e];
}

string backname = "";

for (int c = 0; c < letters.Length; c++)
{
    backname += backletters[c];
}

Console.WriteLine("Your name backwards is: " + backname);

