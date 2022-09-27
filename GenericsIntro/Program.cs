// See https://aka.ms/new-console-template for more information
using GenericsIntro;
using System.Globalization;

MyList<string> isimler = new MyList<string>();
isimler.Add("Engin");
isimler.Add("Derin");
isimler.Add("Salih");

Console.WriteLine(isimler.Length);
for (int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine(isimler.Items[i]);
}
foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}


Console.ReadLine();  // Keep the console window open in debug mode.

