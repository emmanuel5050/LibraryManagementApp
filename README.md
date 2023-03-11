# LibraryManagementApp


You are to Create a simple library management app with the following details (API):

Entities 

- Author
- Book
- Publisher

It has a number of relationships

- Relationship between author and publisher is one publisher to many authors
- Relationship between author and book is many to many

**Publisher**

With the app you should be able to first create a publisher who can create multiple authors attached to them. If adding an author without a publisher, the author would not be added to the system.

**Author**

Create an Author only when a publisher they’d be attached to already exist. If not, Create the publisher first then attach that publisher to the Author

**Book**

You should be able to create a book only when they are attached to an author same as requirements for author

**Endpoints Needed**

Publisher - Create, GetAPublisher, GetAllPublishers, GetAuthorsAttachedToAPublisher

Author - Create, GetAnAuthor, GetAllAuthors, GetBooksAttachedToAnAuthor

Book- Create, GetABook, GetAllBooks
