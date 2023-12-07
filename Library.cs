using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_SannaHöglund
{
    internal class Library
    {
        /// <summary>
        /// This method is accesible from other classes. The rest is set to private as a part of object orientation encapsulation (to make the code more robust and avoid the data to be 
        /// unintentionally manipulated).
        /// It's also an abstraction of the code to give the user necessary details to use the class without showing all the internal details.
        /// </summary>
        public void Start()
            {
            PrintMenu();
            }

        private List<Book> bookList = new List<Book>();

        //Declaration of instance variables only accessible in this class. 

        private string? title;
        private string? author;
        private int isbnNumber;
        private bool isAvailable = true;
        
       
        /// <summary>
        /// This method lets the user Add a book with several properties to the class book. I choose to make all the books available in the library by default.
        /// </summary>
        private void AddBook()
            {

            Console.WriteLine("Title of your book:");
            title = Console.ReadLine();
            Console.WriteLine("Author:");
            author = Console.ReadLine();
            Console.WriteLine("ISBN number (maximum 9 numbers):");
            while (!int.TryParse(Console.ReadLine(), out isbnNumber))
                {
                Console.WriteLine("Invalid input. Please enter a valid ISBN number:");
                }
            isAvailable = true;              
            Book book = new Book(title, author, isbnNumber, isAvailable);
            bookList.Add(book);
            Console.WriteLine(book.Title + " added to the library.");
            ClearConsole();
            }

        /// <summary>
        /// Method to remove a book by its title if the user input matches the added books title. Otherwise an error text will be shown.
        /// </summary>
        private void RemoveBook()
            {
            Console.WriteLine("Please write the title of the book you want to remove from the library:");
            string? removeBookTitle = Console.ReadLine();
            //Searching for the book in the list with Find-method. If the user input removeBookTitle is equal to a title in the list, it will be removed. StringComparison.OrdinalIgnoreCase
            //means that it doesn't matter if the user writes with big or small letters.
            Book bookToRemove = bookList.Find(book => book.Title.Equals(removeBookTitle, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)  
                {

                bookList.Remove(bookToRemove);
                Console.WriteLine("You removed the book " + removeBookTitle + ".");
                ClearConsole();
                }
            else
                {  
                Console.WriteLine(removeBookTitle + " can't be found in the library.");
                ClearConsole();
                }

            }
        /// <summary>
        /// This method lists all the books added to the list using a foreach-loop that loops though the list and prints all the properties of every item.
        /// </summary>
        private void ListBooks()
            {
            Console.WriteLine("These are the books in the library:");

            foreach (Book addedBook in bookList)
                {
                Console.WriteLine("Title: " + addedBook.Title);
                Console.WriteLine("Author: " + addedBook.Author);
                Console.WriteLine("ISBN Number: " + addedBook.IsbnNumber);
                Console.WriteLine("Book is available: " + addedBook.IsAvailable);
                Console.WriteLine();
                }
           
            ClearConsole();
            }

        /// <summary>
        /// A method I'm using to print a message to the user and clear the console after each switch-case.
        /// </summary>
       private void ClearConsole()
            {
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
            Console.Clear();
            MenuChoices();
            }

        /// <summary>
        /// Method to print the choices of the Menu. User chooses input from 1-4.
        /// </summary>
        private void MenuChoices()
            {
            Console.WriteLine("Welcome to the library, what do you want to do today?");
            Console.WriteLine("[1] Add a book to the library");
            Console.WriteLine("[2] Remove a book from the library");
            Console.WriteLine("[3] Check which books are in the library");
            Console.WriteLine("[4] Leave library");
            }


        /// <summary>
        /// This method contains the menu where the user can choose what to do in the library. The switch-cases leads to a separate method exept case 4 that closes the program and 
        /// default thats stops the program from crashing if the user prints wrong input.
        /// </summary>
       private void PrintMenu()
            {
            
            MenuChoices();

            while (true) 
                {
                
                    string? userChoice = Console.ReadLine();

                    switch (userChoice)
                    { 
                    
                        case "1":

                        AddBook();

                            break;

                        case "2":

                        RemoveBook();

                            break;

                        case "3":

                        ListBooks();

                            break;

                        case "4":

                        Console.WriteLine("Leaving the library. Welcome back!");

                            return;

                        default:
        
                        Console.WriteLine("Wrong input, choose a number beetween 1 and 4.");

                            break;

                    }
                }
            }
        }
}
