using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_SannaHöglund
{
    internal class Book
    {

        /// <summary>
        /// The properties of the class Book. With the get and set syntax i will be able to retrieve and also modify these properties.
        /// </summary>
        public string Title { get; set; }
        public string Author { get; set; }
        public int IsbnNumber { get; set; }
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Constructor to create objects of the class book with these parameters. For each book-object you add to the class you have to enter these specific properties.
        /// </summary>
        /// <param name="title">Title of the book (string input)</param>
        /// <param name="author">Author of the book(string input)</param>
        /// <param name="isbnNumber"> ISBN-number of the bok. (int- input) Will generate an error message if the user enters string-input.</param>
        /// <param name="isAvailable">I choose to always put this to true automatically ion this project. i could also ask the user to choose if its available or lent out.</param>
        public Book(string title, string author, int isbnNumber, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            IsbnNumber = isbnNumber;
            IsAvailable = isAvailable;
        }
    }
}
