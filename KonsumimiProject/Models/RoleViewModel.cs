using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KonsumimiProject.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string Name { get; set; }
    }
}
