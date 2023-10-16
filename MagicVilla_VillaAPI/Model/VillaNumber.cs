using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Model
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }
         //Foreign key relationship for one to many relationship
        [ForeignKey("Villa")]        //this is the name foreign key mapper
        public int VillaID { get; set; }      //VillaId will be aforeign key to the ID in the Villa table
        public Villa Villa { get; set; } //navigation property which means property is in Villa Model and we call it as Villa


        public string SpecialDetails { get;set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}

    }
}
