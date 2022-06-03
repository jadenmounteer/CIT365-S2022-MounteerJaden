using System;
using System.ComponentModel.DataAnnotations;


namespace RazorPagesScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Required]
        public string Reference { get; set; }

        [Required]
        public string Note { get; set; }

        [Display(Name ="Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
    }
}
