List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

//1
Console.WriteLine("-----------");
var firstEruptionFromChile = eruptions.FirstOrDefault(eru => eru.Location == "Chile");

Console.WriteLine(firstEruptionFromChile);
//2
Console.WriteLine("-----------");

var firstEruptionHawai = eruptions.FirstOrDefault(eru => eru.Location == "Hawaiian Is");
if (firstEruptionHawai ==null)
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}else{

Console.WriteLine(firstEruptionHawai);
}

//3
Console.WriteLine("-----------");

IEnumerable<Eruption> newZeland = eruptions.Where(c => c.Year >1900 && c.Location == "New Zealand");
PrintEach(newZeland);

//4

Console.WriteLine("-----------");

IEnumerable<Eruption> VolcEleve = eruptions.Where(c => c.ElevationInMeters >2000);
PrintEach(VolcEleve);

//5

Console.WriteLine("-----------");

IEnumerable<Eruption> allWithL = eruptions.Where(c => c.Volcano.StartsWith ("L"));
PrintEach(allWithL,$"Number of eruptions where volcano's name starts with 'L': {allWithL.Count()}");

//6
Console.WriteLine("-----------");
var higEl = eruptions.Max(eru => eru.ElevationInMeters);

Console.WriteLine(higEl);

//7
Console.WriteLine("-----------");
var higElVol = eruptions.Where(eru => eru.ElevationInMeters == higEl);

PrintEach(higElVol);


//8
Console.WriteLine("-----------");

IEnumerable<Eruption> volNamesAlpha = eruptions.OrderBy(V => V.Volcano);
PrintEach(volNamesAlpha);

//9
Console.WriteLine("-----------");

IEnumerable<Eruption> volNamesAlphaMil = eruptions.OrderBy(V => V.Volcano).Where(V => V.Year < 1000);
PrintEach(volNamesAlphaMil);
//10
Console.WriteLine("-----------");

IEnumerable<Eruption> volNamesAlphaMilDos = eruptions.OrderBy(V => V.Volcano).Where(V => V.Year < 1000);
PrintEach(volNamesAlphaMilDos.Select(v => v.Volcano));






