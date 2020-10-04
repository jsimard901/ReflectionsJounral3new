using System;
using System.ComponentModel.DataAnnotations;

namespace ReflectionsJournal.Models
{
    public class EntryModel
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        [Required(ErrorMessage = "Entry Date is require")]
        [Display(Name = "Entry Date (mm/dd/yyyy")]
        public string entryDate {get; set;}

        [Required(ErrorMessage = "Entry Text is Required")]
        [Display(Name = "Entry Text")]
        public string entryText {get; set;}

        [Required(ErrorMessage = "Confidence level is required and must be either low, medium, or high")]
        [Display(Name = "Confidence Level (Low, Medium, or High)")]
        public Confidence confidenceLevel {get; set;}

    }

    public enum Confidence 
    {
        Low, Medium, High
    }

}
