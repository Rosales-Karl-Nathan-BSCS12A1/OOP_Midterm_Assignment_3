using static System.Reflection.Metadata.BlobBuilder;

namespace TestProject1;

public partial class ClassRelationshipsTest
{
    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return books; 
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public Book SearchBook(string title)
        {
            foreach (var book in books) 
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) 
                {
                    return book; 
                }
            }

            return null; 
        }


    }
}