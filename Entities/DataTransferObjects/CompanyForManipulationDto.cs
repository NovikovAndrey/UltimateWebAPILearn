using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class CompanyForManipulationDto
    {
        [Required(ErrorMessage = "Employee name is a required field")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is a required field")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Position  is a required field")]
        [MaxLength(20, ErrorMessage = "Maximum length 20")]
        public string Country { get; set; }

        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
