using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetsApi.DataAccess.Models
{
    [Table("assets")]
    public class Asset
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}