using System.ComponentModel.DataAnnotations;

namespace WebLyra.Models
{
    public class FolioControl
    {
        [Key]
        public int FolioControlId { get; set; }
        public int CurrentDay { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentYear { get; set; }
    }
}
