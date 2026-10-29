Beacon one = new Beacon(101);
Beacon two = new Beacon(205);
Beacon three = new Beacon(330);
Beacon four = new Beacon(450);


// eller sette inn i tabel [] og bruke for løkke med øke count



Console.WriteLine(one.Frequency);
Console.WriteLine(two.Frequency);
Console.WriteLine(three.Frequency);
Console.WriteLine(four.Frequency);


Console.WriteLine($"Created Beacons er: {Beacon.CreatedCount}");
