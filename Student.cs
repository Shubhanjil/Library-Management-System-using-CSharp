using System;

// CHILD CLASS
public class Student: User, IBorrowable{
    public int Grade {get; set;}
    
    public Student(string name, string userID, int grade) : base(name, userID) {
        Grade = grade ;
    }
    
    
    // OVERRIDING 
    public override string GetUserType() {
        return "Student";
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