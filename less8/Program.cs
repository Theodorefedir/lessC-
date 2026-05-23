namespace less8
{
    internal class Program
    {
        class Book {
            public string Title { get; set; }
            public string Author { get; set; }
            public override string ToString()
            {
                return $"Title: {Title}, Author: {Author}";
            }
        }
        class Library {
            private Book[] books;
            public Library(int index) { 
                books = new Book[index];
            }
            public Book this[int index]
            {
                get {
                    if (index >= 0 && index < books.Length)
                    {
                        return books[index];
                    }
                    else { 
                        throw new IndexOutOfRangeException();
                    }
                }
                set {
                    if (index >= 0 && index < books.Length)
                    {
                        books[index] = value;
                    }
                    else {
                        throw new IndexOutOfRangeException();
                    }
                }
            }
            public Book this[string Title]
            {
                get
                {
                    foreach (var book in books)
                    {
                        if(book.Title == Title){ 
                            return book;
                        }                       
                    }
                    return null;
                }
                set
                {
                    for(int i = 0; i<books.Length; i++)
                    {
                        if (books[i].Title == Title)
                        {
                            books[i] = value;
                            break;
                        }
                    }
                    
                }
            }
        }
        static void Main(string[] args)
        {
            Library lb = new Library(2);
            lb[0] = new Book();
            Console.WriteLine(lb[0]);
        }
    }
}
