using System;
using System.Collections.Generic;
using System.Linq;

public class Library{
    public List<Book> Books { get; set; }
    public Dictionary<string, User> Users { get; set; }

    public Library(){
        Books = new List<Book>();
        Users = new Dictionary<string, User>();
    }

    public void AddBook(Book book){
        Books.Add(book);
        Console.WriteLine($"{book.Title} added to library.");
    }

    public void AddUser(User user){
        Users[user.UserId] = user;
        Console.WriteLine($"{user.Name} added as {user.GetUserType()}.");
    }

    public Book FindBook(string title){
        return Books.FirstOrDefault(b => b.Title == title);
    }
}
