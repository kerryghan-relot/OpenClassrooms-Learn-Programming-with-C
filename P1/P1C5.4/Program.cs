IDictionary<string, int> months = new Dictionary<string, int>();

// TODO: replace names with constant (final) String variables
const string keyJune = "June", keySeptembre = "Septembre", keyMarch = "March";
months.Add(keyJune, 6);
months.Add(keySeptembre, 9);
months.Add(keyMarch, 5);

// TODO: Fix March with the proper value (3)
months[keyMarch] = 3;

// TODO: Remove June
months.Remove(keyJune);

// Display the contents of the dictionary
Console.WriteLine("This is our months list:");
foreach (KeyValuePair<string, int> keyPair in months)
{
    Console.WriteLine(keyPair.Key + " is month number " + keyPair.Value + " of the year ");
}