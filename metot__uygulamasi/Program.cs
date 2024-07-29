using System;
class Program
{
    //geriye değer döndürmeyen metot
    static void Music()
    {
        Console.WriteLine("Deli sevdaymış, yolu bilmezmiş, zora gelmezmiş, ay inanmıyorum");

    }
    //Geriye Tamsayı Döndüren Bir metot
    //Rastgele sayı üretip sayının 2'ye bölümünden kalanı geri döndürsün
    static void PrintRandom()
    {
        Random rnd = new Random();
        int number = rnd.Next();
        Console.WriteLine("random sayını -> " + number + " 2'ye bölümünden kalan -> " + (number % 2));

    }

    //Parametre alan ve geriye değer döndüren bir metot

    public int RandomNumber()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 30);
        int remainder = number % 2;
        return remainder;
    }

    //Çarpma işlemi yapan metor
    public int Multiplication(int a, int b)
    {
        int total = a * b;
        return total;
    }

    //isim soy isim methodu - parametre alıp geriye değer döndürmeyen
    static void NameSurname(string name, string surname)
    {
        Console.WriteLine("Hoşgeldiniz " + name + " " + surname);
    }


}