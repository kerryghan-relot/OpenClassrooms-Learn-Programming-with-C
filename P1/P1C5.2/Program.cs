// TODO: Replace the ?? by the proper code to create an ArrayList of string
IList <string> guests = new List<string>();
// This would work as well:
// List<string> guests = new List<string>();
// IList<string> guests = ["1", "2", "3"];



// TODO: Add Joey, Martin and Marie to the list
guests.Add("Joey");
guests.Add("Martin");
guests.Add("Marie");


// TODO: Complete the following statement by replacing the ?? to display the size of the list
Console.WriteLine(guests.Count);

// TODO: Replace Martin with John in the list
guests[1] = "John";

// TODO: Remove Joey from the list
guests.RemoveAt(0);
bool a = guests.Remove("Joey");  // This also works. We can observe that if the value is not in the list, nothing happens, the method returns False
Console.WriteLine(a);

// Display the content of the list
Console.WriteLine("The guests are:");
foreach (string guest in guests)
{
    Console.WriteLine(guest);
}