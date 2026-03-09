using System;

// CHILD CLASS
public class Teacher: User{
    public string Subject {get; set;}
    
    public Teacher(string name, string userID, string subject) : base(name, userID) {
        Subject = subject ;
    }
    
    // OVERRIDING 
    public override string GetUserType() {
        return "Teacher";
    }

    public void BorrowBook(Book book){
        if (book.IsAvailable){
            book.MarkAsBorrowed();
            Console.WriteLine($"{Name} borrowed {book.Title}");
        }
        else{
            Console.WriteLine($"{book.Title} is not available.");
        }
    }

    public void ReturnBook(Book book){
        book.MarkAsReturned();
        Console.WriteLine($"{Name} returned {book.Title}");
    }
}