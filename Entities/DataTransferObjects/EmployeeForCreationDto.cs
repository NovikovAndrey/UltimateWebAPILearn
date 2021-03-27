using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class EmployeeForCreationDto
    {
        [Required(ErrorMessage = "Employee name is a required field")]
        [MaxLength(30, ErrorMessage ="Maximum length for the Name is 30")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is a required field")]
        [Range(18, int.MaxValue, ErrorMessage = "Age is required and it can't be lower than 18")]

        public int Age { get; set; }

        [Required(ErrorMessage = "Position  is a required field")]
        [MaxLength(20, ErrorMessage ="Maximum length 20")]
        public string Position { get; set; }
    }
}
