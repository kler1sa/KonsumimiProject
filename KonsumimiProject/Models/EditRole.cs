using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KonsumimiProject.Models
{
    public class EditRoleModel
    {
        public string Id { get; set; }

        [Display(Name = "Role")]
        
        public string Name { get; set; }
    }
}
