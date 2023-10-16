using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Model.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }
    }
}
