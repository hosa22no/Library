namespace Inlämningsuppgift1_SannaHöglund
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            ///Creating an object of the library class. 
           Library library = new Library();
            library.Start(); //Calling the method Start(); from the library class to start the program.
        }
    }
}