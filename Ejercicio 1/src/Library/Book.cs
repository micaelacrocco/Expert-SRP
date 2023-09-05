using System;

namespace SRP
{
    /// <summary>
    /// Clase que representa un libro.
    /// </summary>
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        /*public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }*/

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="code"></param>
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/

    }
    // Book tiene la responsabilidad de almacenar los datos de un libro y de asignarle un sector y estante en la biblioteca, por lo que no cumple con el principio SRP.
    // Para cumplir con SRP, Book va a tener la responsabilidad de almacenar los datos de un libro.
}
