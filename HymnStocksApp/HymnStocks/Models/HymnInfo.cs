using System.ComponentModel.DataAnnotations;

namespace HymnStocks.Models
{
    public class HymnInfo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Hymn Name")]
        [DataType(DataType.Text)]
        public string? HymnName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Copyright Belong To")]
        [DataType(DataType.Text)]
        public string? CopyRight { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Language")]
        [DataType(DataType.Text)]
        public string? HymnLanguage { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateOnly PublishDate { get; set; }

        [MaxLength(250)]
        [Display(Name = "Remarks")]
        [DataType(DataType.Text)]
        public string? Remarks { get; set; }
    }
}
