using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Boud.Data
{
    public class Bowler
    {

        [Key]
        public int BowlerID { get; set; }
        [Required]
        public string BowlerLastName { get; set; }
        [Required]
        public string BowlerFirstName { get; set; }
        public char? BowlerMiddleInit {  get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        public string BowlerState { get; set; }
        [Required]
        public int BowlerZip { get; set; }
        [Required]
        public string BowlerPhoneNumber { get; set; }

        //Connecting other table
        [ForeignKey("TeamID")]
        public int TeamID { get; set; }

        public Team Teams { get; set; }
    }
}
