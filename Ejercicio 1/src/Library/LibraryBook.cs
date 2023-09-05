using System;

namespace SRP
{
    /// <summary>
    /// Clase que gestiona un libro y su ubicacion en la biblioteca.
    /// </summary>
    public class LibraryBook
    {
        public Book Book { get; }
        public LibrarySector Sector { get; set; }
        public LibraryShelve Shelve { get; set; }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="book"></param>
        public LibraryBook(Book book)
        {
            Book = book;
        }

        /// <summary>
        /// Asigna un sector y estante a un libro.
        /// </summary>
        /// <param name="sector"></param>
        /// <param name="shelve"></param>
        public void ShelveBook(LibrarySector sector, LibraryShelve shelve)
        {
            Sector = sector;
            Shelve = shelve;
        }
    }
}