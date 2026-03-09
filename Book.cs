using System;

public class Book {
    public string Title {get; set;} 
    public string Author {get; set;} 
    public string ISBN {get; private set; }  // ISBN will be immutable(read only)
    public bool IsAvailable {get; private set; } 
    
    // CONSTRUCTOR: to initialize the details
    public Book(string title, string author, string isbn) {
        Title = title ;
        Author = author ;
        ISBN = isbn ;
        IsAvailable = true ;
    }
    
    // ENCAPSULATION: CONTROL ACCESS 
    public void markBorrowed(){
        IsAvailable = false ;
        Console.WriteLine($"\nBORROWED: {ISBN}- {Title}");
    }
    public void markReturned(){
        IsAvailable = true ;
        Console.WriteLine($"\nRETURNED: {ISBN}- {Title}");
    }
}