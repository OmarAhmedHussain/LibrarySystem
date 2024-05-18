namespace LibrarySystem.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public DateTime PublishYear { get; set; }
        
        [MaxLength(13)]
        public string ISBN { get; set; }

        public ICollection<BorrowingRecord>? borrowingRecords { get; set;}

    }
}
