using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            LibrarySector sectorA = new LibrarySector("A");
            LibrarySector sectorB = new LibrarySector("B");

            LibraryShelve shelve7 = new LibraryShelve("7");
            LibraryShelve shelve3 = new LibraryShelve("3");

            LibraryBook libraryBook1 = new LibraryBook(book1);
            LibraryBook libraryBook2 = new LibraryBook(book2);

            libraryBook1.ShelveBook(sectorA, shelve7);
            libraryBook2.ShelveBook(sectorB, shelve3);
        }
    }
}