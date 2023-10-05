namespace LibraryBookInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hej, välkommen till ditt personliga bibliotek!\nSkriv titeln på din bok: ");
            string title = Console.ReadLine();

            Console.Write("Skriv bokens författare: ");
            string author = Console.ReadLine();

            Console.Write("Skriv en kort sammanfattning av boken: ");
            string summary = Console.ReadLine();

            Book book1 = new Book(title, author, summary);

            book1.PrintBookInfo();

        }
    }
}