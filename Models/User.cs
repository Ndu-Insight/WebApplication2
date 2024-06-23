using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("FirstName")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Column("Surname")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Column("WhatsAppID")]
        [StringLength(20)]
        public string WhatsAppID { get; set; }

        [Required]
        [Column("email")]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        // This property is used in the application
        [NotMapped]
        public bool Active { get; set; }

        // This property maps to the database column
        [Column("Active")]
        public short ActiveInt { get; set; }

        [Column("AdminFlag")]
        public int AdminFlag { get; set; }
    }
}
