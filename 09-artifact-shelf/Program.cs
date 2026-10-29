using System.ComponentModel;
using System.Security.Cryptography;

List<Artifact> artifacts = new List<Artifact>();

// Artifact a1 = new Artifact("", "", 44);  // kan bruke ToString medtode og sette inn liste og for løkke
// Artifact a2 = new Artifact("", "", 44);
// Artifact a3 = new Artifact("", "", 44);
// Artifact a4 = new Artifact("", "", 44);



Console.WriteLine("Antall artifacts :" + artifacts.Count);


artifacts.Add(new Artifact("Ancient Vase", "high", 1200));
artifacts.Add(new Artifact("Ancient Vase", "medium", 99));
artifacts.Add(new Artifact("Ancient Vase", "sterck", 900));
artifacts.Add(new Artifact("Ancient Vase", "laow", 44));

Console.WriteLine("Antall artifacts " + artifacts.Count);

foreach (Artifact arti in artifacts)
{
    Console.WriteLine(arti.Name + " " + arti.Origin + " " + arti.Risk);

}

Console.WriteLine("Add ny artifact : ");

artifacts.Add(new Artifact("uknow", "laow", 44));


Console.WriteLine("Etter Add ny artifacts Count er " + artifacts.Count);









//lage objecter








// TODO: Opprett minst fire Artifact-objekter og legg dem i listen.
// TODO: Skriv Count og alle objektene.
// TODO: Legg til ett ekstra objekt og skriv Count igjen.
