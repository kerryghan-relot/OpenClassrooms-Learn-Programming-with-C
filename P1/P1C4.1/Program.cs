﻿using P1C4; // For some reason, we must include that line to make our program work.

// TODO Step 1 - instantiate an object of class Book and assign it to a variable named myBook
Book myBook = new Book();

// TODO Step 2 - assign a value to the title, author and numberOfPages fields of your object.
myBook.Title = "The Title";
myBook.Author = "The Author";
myBook.NumberOfPages = 415;

// Display the values 
Console.WriteLine("The title of the book is " + myBook.Title);
Console.WriteLine("Its author is " + myBook.Author);
Console.WriteLine("It contains " + myBook.NumberOfPages);
