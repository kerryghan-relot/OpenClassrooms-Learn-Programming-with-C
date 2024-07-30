// TODO Step 1:
// Create a startingDay variable with a value of 3
int startingDay = 3;

// TODO Step 2:
// Create a daysInWeek constant with a value of 7
const int daysInWeek = 7;

// TODO Step 3:
// Add the value of the daysInWeek variable to the startingDay variable, using a shortcut operator
startingDay += daysInWeek;

// Display the result 
Console.WriteLine("There are " + daysInWeek + " days in a week.");
Console.WriteLine("Your starting day in the month is: " + startingDay);

/// Now, let's do some test boiz ! 

// As you can see, we cannot modify a constant (quite logical shall we say)
const int numberOfMonthsInAYear = 12;
// If you uncomment the following line, you'll get an error
// numberOfMonthsInAYear = numberOfMonthsInAYear - 1;
Console.WriteLine(numberOfMonthsInAYear);

// You can assign a constant to another constant
const int yearDivision = numberOfMonthsInAYear;
Console.WriteLine(yearDivision);

// But you cannot assign a variable to a constant (for some reason???)
// const int initialStartingDay = startingDay;

// This lead me to wonder : When you assign a variable to another variable ad change the original one, does the change reflect on the latter?
int originalVariable = 666;
int secondVariable = originalVariable;
Console.WriteLine(originalVariable + " " + secondVariable);
originalVariable = 69;
Console.WriteLine(originalVariable + " " + secondVariable);
// Apparently not, so that is weird that we can't assign a variable to a constant if the further change is not reflected in the initial declaration.
