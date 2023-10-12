===================================
              Book
-----------------------------------
    - string _author
    - string _name
    - int _timesRead
    - boolean _available
-----------------------------------
    + HasAuthor
    + Display
    + IsAvailable
    + TimesRead
    + CheckOut
    + CheckIn
===================================


===================================
            Bookcase
-----------------------------------
    - List<Book> _books
-----------------------------------
    + ShowBooks()
    + AddBook(book)
    + FindBookByAuthor(author)
    + CountBooks()
    + ShowPopularBooks(count)
===================================