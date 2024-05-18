namespace LibrarySystem.Models
{
    public class Patron
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ContactInfo { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<BorrowingRecord>? borrowingRecords { get; set;}

    }
}
