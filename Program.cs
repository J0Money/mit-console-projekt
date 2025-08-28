// See https://aka.ms/new-console-template for more information



/*
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast bredde på trekant: ");
        int bredde = int.Parse(Console.ReadLine());

        int areal = Trekant.areal(bredde);

        Console.WriteLine($"Arealet af trekanten med bredde {bredde} er: {areal}");
    }
}

class Trekant
{
    public static int areal(int bredde)
    {
        int resultat;
        if (bredde == 1)
        {
            resultat = 1;
        }
        else
        {
            resultat = bredde + areal(bredde - 1);
        }

        return resultat;
    }
}
*/

/*
Console.WriteLine(Opgave3.Faculty(5)); 

class Opgave3
{
    public static int Faculty(int n)
    {
        if (n <= 0) 
        {
            return 1;
        }
        else
        {
            return n * Faculty(n - 1);
        }
    }
}
*/

/*Console.WriteLine(Opgave4.sfd(10, 15));
class Opgave4
{
    public static int sfd(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        if (a < b)
        {
            return sfd(b, a);
        }
        return sfd (b, a % b);
    }

*/



    // delopgave 2
/*
    public static int potens(int n, int p)
    {
        if (p == 0)
        {
            return 1 
        }
        potens(n - 1, p);
    }
*/

// delopgave 3
/*
public static int gange 
*/


// delopgave 4
    /*
public static string Reverse(string s)
    {
        if (s.Length <= 1) return s;
        else return Reverse(s.Substring(1)) + s[0];
    }
}
*/


using mit_console_projekt;

/* Opgave 1.1
var modul = new modul2();
modul.SamletAlder();
*/

/*Opgave 1.2
var modul = new modul2();
modul.CountNielsen();
*/

/*Opgave 1.3
 var modul = new modul2();
modul.FindÆdste();
*/

/*Opgave 2
var modul = new modul2();
    modul.FindPersonFraNummer();
*/

var modul = new modul2();
modul.FindOver30();