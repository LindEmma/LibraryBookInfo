namespace LibraryBookInfo
{
    internal class Book
    {
        public string _title;
        public string _author;
        public string _summary;

        public Book(string title, string author, string summary)
        {
            _title = title;
            _author = author;
            _summary = summary;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine("\nBoken {0} är skriven av {1} och kan sammanfattas som: \n{2}",
                _title, _author, _summary);
        }
    }
}
