namespace LibrarySystem.Models
{
    public class BorrowingRecord
    {

        public int Id { get; set; }

        public int BookID { get; set; }

        public int PatronID { get; set; }

        public DateTime borrowDate { get; set; }

        public DateTime returnDate { get; set;}

        public Book? book { get; set; }

        public Patron? patron { get; set; }

    }
}
