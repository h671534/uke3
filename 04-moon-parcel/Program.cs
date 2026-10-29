


using System.Dynamic;

Parcel first = new Parcel("MX-101", "Luna Station", 12); //sette directly i constructor etter new
Parcel second = new Parcel("MX-102", "Crater Lab", 7);
Parcel third = new Parcel("", "", 22);




// eller sette inn i liste og hjelpe metode som lager objektet og legger det til i listen

List<Parcel> parcels = new List<Parcel>();

Parcel parcel1 = new Parcel("mn", "jonard", 88);
Parcel parcel2 = new Parcel("mb", "joli", 89);
Parcel parcel3 = new Parcel("cv", "bela", 48);

// parcel1.TrackingCode = "";
// parcel1.Destination = "";
// parcel1.Weight = 234;

parcel1.ToString();
parcel2.ToString();
parcel3.ToString();


parcels.Add(parcel1);
parcels.Add(parcel2);
parcels.Add(parcel3);




foreach (Parcel p in parcels)
{

    Console.WriteLine("Parceler er :" + p);
}




//named arguments

first.TrackingCode = "mj-101"; //setter direkte i property 
first.Destination = "jona station";
first.Weight = 22;



second.TrackingCode = "mj-102";
second.Destination = "crater lab";
second.Weight = 17;

third.TrackingCode = "kodehode";
third.Destination = "jolui";
third.Weight = 44;

// Parcel("MX-101", "Luna Station", 12); // kan ikke bruke som metode
// skal sendes inn gjennom constructoren 



Console.WriteLine($"Parcel 1: {first.TrackingCode} -> {first.Destination} ({first.Weight} kg)");
Console.WriteLine($"Parcel 2: {second.TrackingCode} -> {second.Destination} ({second.Weight} kg)");











//Parcel("MX-101", "Luna Station", 12); kan ikke bruke som metode

