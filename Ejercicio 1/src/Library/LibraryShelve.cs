using System;

namespace SRP
{
    /// <summary>
    /// Clase que representa un estante de la biblioteca.
    /// </summary>
    public class LibraryShelve
    {
        public string Shelve { get; }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="shelve"></param>
        public LibraryShelve(string shelve)
        {
            Shelve = shelve;
        }
    }
}