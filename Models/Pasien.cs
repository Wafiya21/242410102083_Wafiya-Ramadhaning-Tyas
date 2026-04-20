using System.ComponentModel.DataAnnotations.Schema;

namespace PAA_LKM1.Models
{
    [Table("pasien")]
    public class Pasien
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nama")]
        public string? Nama { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("no_hp")]
        public string? No_hp { get; set; }
    }
}