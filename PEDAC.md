Problem: 

Model and create a database (Library)
  Start a Library console app, to store our books and authors info in a database.

C R U D
  - Create: Create Authors and Books
  - Read: View the Books, Authors, and Books by Specific Authors
  - Update: Not Really Updating Specific Info
  - Delete: Delete a Book

Examples:

Add a Book
Add a Author
Delete a Book

Data Structure:

Books Info:   
  - Id SERIAL 
  - Title TEXT
  - Genre TEXT 
  - IsSeries BOOL
  - YearPublished INT
  - Completed BOOL
  - AuthorID INTEGER REFERENCES

Authors Info:
  - Id SERIAL
  - Name TEXT

- Create a Class for Book w/ the above properties
- Create a Class for Author w/ the above properties
- Create a Class for Context

Algorithm:

Create a database (Library)
Create a table called "Authors"
Create a table called "Books"

Insert some Authors into the "Authors" table
Insert some Books into the "Books" table

Welcome to the App 
var context = new LibraryContext();

While the user has not chosen to quit
  Bool = false

Offer Menu Options:
  - Add
  - View
  - Delete
  - Quit

Ask the user which they would like to choose
Read the answer and set to a variable  

If the user chooses ADD
  Ask the user if they want to add a new book or add a new author
  Read the answer and set to a variable

  If the user chooses Add a New Author
    Ask the user what is the Author's Name
    Read the answer and set to a variable
    Make a new instance of an author (using the answer)
    var newAuthor = new Author {
      Name = 
    }

    Add the Author to the table of Authors
    context.Authors.Add(newAuthor);
    context.SaveChanges();

  If the user chooses Add a New Book
    Ask the user which Author they want to add the Book to
    Read the answer and set to a variable
      (var author = context.Authors.First(author = author.Name == "variable"))
    Ask the user the title of the Book
    Read the answer and set to a variable
    Ask the user the genre of the Book 
    Read the answer and set to a variable
    Ask the user if the Book is a part of a series (T or F)
    Read the answer and set to a variable (parse to Bool)
    Ask the user for the year the book was published 
    Read the answer and set to a variable (parse to int)
    Ask the user if they completed reading the Book (T or F)
    Read the answer and set to a variable (parse to Bool)
    
    Make a new instance of a book (using the answers)
    var newBook = new Book {
      Title =
      Genre = 
      IsSeries = 
      YearPublished =
      Completed = 
      AuthorId = author.Id
    }

    Add the Book to the table of Books
    context.Books.Add(newBook);
    context.SaveChanges();

If the user chooses VIEW
  Ask the user if they want to view all the authors, view all the books by the year published, or view all the books by a specific author
  Read the answer and set to a variable

  If the user chooses view all the authors
  foreach (var author in context.Authors) {
    Print out all the authors
  } 

  If the user chooses view all the books by the year published
  var booksInOrder = books.OrderBy(book => book.YearPublished);
  foreach (var book in booksInOrder) {
    Print out all the books
  }

  If the user chooses view all the books for a specific author
  Ask the user which author they want to choose
  Read the answer and set to a variable
  foreach (var books in context.Books.Include(author => author.Name == "answer")) {
    Print out the books for a specific author
  }

If the user chooses DELETE
  Ask the user which book they would like to delete
  Read the answer and set to a variable
    (var book = context.Books.First(book = book.Title == "variable"))

  Save the changes
  context.Books.Delete(book);
  context.SaveChanges();

If the user chooses QUIT
  set Bool = true

Say Goodbye!

