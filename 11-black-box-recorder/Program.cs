using System.Text;

string path = "blackbox.txt";


if (!File.Exists(path))
{

    string[] box = { "nbv ", "mtv", "samsung" };

    File.WriteAllLines(path, box, Encoding.UTF8);
}

String[] redTxt = File.ReadAllLines(path, Encoding.UTF8);


foreach (var m in redTxt)
{

    Console.WriteLine(m);
}

// TODO: Hvis filen ikke finnes, skriv eksempeldata.
// TODO: Les så alle linjene og skriv dem ut.
