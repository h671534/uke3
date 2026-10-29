Creature first = new Creature(); // Oppretter tre nytt Creature-objekt    samme navn class
Creature second = new Creature();
Creature third = new Creature();

first.Name = "Fido";
first.Species = "Dog";
first.Energy = 100;

second.Name = "Whiskers";
second.Species = "Cat";
second.Energy = 80;

third.Name = "Tweety";
third.Species = "Bird";
third.Energy = 44;

Console.WriteLine($"Name 1: {first.Name}, Species: {first.Species}, Energy: {first.Energy}");
Console.WriteLine($"Name 2: {second.Name}, Species: {second.Species}, Energy: {second.Energy}");
Console.WriteLine($"Name 3: {third.Name}, Species: {third.Species}, Energy: {third.Energy}");


// TODO: Sett properties til ulike verdier.
// TODO: Skriv verdiene for alle tre objektene.
