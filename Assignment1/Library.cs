using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Library
    {
        private List<Book> bookCollection;
        public Library()
        {
            bookCollection = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (bookCollection.Exists(b => b.Title.Equals(book.Title, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Buku dengan judul {book.Title} sudah ada \n");
            }
            else
            {
                bookCollection.Add(book);
                Console.WriteLine($"Buku {book.Title} berhasil ditambah \n");
            }
                
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Daftar Buku Tersedia : ");
            foreach (Book book in bookCollection)
            {
                Console.WriteLine("Judul : {0}", book.Title);
                Console.WriteLine("Author : {0}", book.Author);
                Console.WriteLine("Publication Year : {0} \n", book.PublicationYear);
            }
        }

        public void RemoveBook(string title)
        {
            Book removeBook = bookCollection.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if(removeBook != null)
            {
                bookCollection.Remove(removeBook);
                Console.WriteLine($"Buku {title} berhasil dihapus \n");
            }
            else
            {
                Console.WriteLine($"Buku dengan judul {title} tidak ditemukan \n");
            }
            
        }
    }
}
