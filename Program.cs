using System;
class Program {
    static void Main() {
        Library library = new Library();
        // ADD BOOKS
        library.AddBook(new Book("Murder on the Orient Express", "Agatha Christie", "BOOK111"));
        library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", "BOOK222"));
        // ADD USERS
        library.AddUser(new Student("Amy", "USER0001", 6));
        library.AddUser(new Teacher("Martin", "USER0002", "Maths"));
        Book searchResult = library.FindBook("The Hobbit");
        if (searchResult != null){
            Console.WriteLine($"Found book: {searchResult.Title} by {searchResult.Author}");
        }
        else{
            Console.WriteLine("Book not found.");
        }
        List<User> users = new List<User>();
        users.Add(new Student("Amy", "USER0001", 6));
        users.Add(new Teacher("Martin", "USER0002", "Maths"));
        foreach (var user in users){
            Console.WriteLine($"{user.Name} is a {user.GetUserType()}");
        }
    }
}   