using System.ComponentModel.DataAnnotations;

namespace WebLyra.Models
{
    public class Shiff
    {
        [Key]
        public int ShiffId { get; set; }
        public int FolioNumber { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public string Comments { get; set; }
    }
}
