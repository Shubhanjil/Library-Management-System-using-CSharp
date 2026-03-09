using System;

// INTERFACE
public interface IBorrowable {

    // IMPLEMENT IN STUDENT AND TEACHER
    void borrowBook(Book book);
    void returnBook(Book book);
}