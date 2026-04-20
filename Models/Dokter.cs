using System.ComponentModel.DataAnnotations.Schema;

namespace PAA_LKM1.Models
{
    [Table("dokter")]
    public class Dokter
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nama")]
        public string? Nama { get; set; }

        [Column("spesialis")]
        public string? Spesialis { get; set; }
    }
}