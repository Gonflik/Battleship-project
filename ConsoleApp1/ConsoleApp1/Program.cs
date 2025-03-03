using static System.Formats.Asn1.AsnWriter;

/* #1
 * 
 * int cels = Convert.ToInt32(Console.ReadLine());
int far = cels * 9 / 5 + 32;

Console.WriteLine(far);*/

/* #2
 * 
 * string str = Console.ReadLine();
string simvol = Console.ReadLine();
string res = str.Replace(" ", simvol);

Console.WriteLine(res);*/



/* #3
 * 
 * string input = Console.ReadLine();
int scoro = 0;
bool isDigitPresent = input.Any(num => char.IsDigit(num));

for (int i = 0; i < input.Length; i++)
{
    scoro++;
}

if (scoro != 3)
{
    Console.WriteLine("Yor ender no 3 number");
}
else
{
    string num = Console.ReadLine();
    if (isDigitPresent)
    {
        Console.WriteLine("Text contains number.");
    }
    else
    {
        Console.WriteLine("Text doesn't contain number.");
    }
}*/


/* #5
 * 
 * string input = Console.ReadLine();
int scoro = 0;

for (int i = 0; i < input.Length; i++)
{
    scoro++;
}

if (scoro != 5)
{
    Console.WriteLine("Yor ender no 5 number");
}
else
{
    scoro = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == input[4 - i])
        {
            scoro += 1;
        }
    }
    if (scoro != 5)
    {
        Console.WriteLine("Number isn't palindrome");
    }
    else
    {
        Console.WriteLine("Number is palindrome");
    }
}*/