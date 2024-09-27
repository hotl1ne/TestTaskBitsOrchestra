using System.ComponentModel.DataAnnotations;


namespace testtask.Models.PersonModel
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter this field")]
        public DateTime DateOfBirth { get; set; }

        public bool Married { get; set; }

        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }

        [Range(0, 1000000)]
        [Required(ErrorMessage = "Please enter your salary")]
        public decimal Salary { get; set; }

    }
}
