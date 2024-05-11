using System.ComponentModel.DataAnnotations;

namespace VALIDATION_PLAYERINFO.Models
{
    public class Player
    {
      
            [Key]
            public int Id { get; set; }
            [Required(ErrorMessage ="Name is required")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Phone is required")]
            [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]([0-9]{3})[-. ]([0-9]{4})$", ErrorMessage = "Invalid Phone Number")]
            public string Phone { get; set; }
            [Required(ErrorMessage = "Phone is required")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60.")]
        public int age {  get; set; }

            [Required]
            public string GameName { get; set; }

            public string Achievements { get; set; }


    }
}
