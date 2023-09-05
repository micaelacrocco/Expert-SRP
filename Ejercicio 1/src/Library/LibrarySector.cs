using System;

namespace SRP
{
    /// <summary>
    /// Clase que representa un sector de la biblioteca.
    /// </summary>
    public class LibrarySector
    {
        public string Sector { get; }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="sector"></param>
        public LibrarySector(string sector)
        {
            Sector = sector;
        }
    }
}