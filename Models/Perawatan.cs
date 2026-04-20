using System.ComponentModel.DataAnnotations.Schema;

namespace PAA_LKM1.Models
{
    [Table("perawatan")]
    public class Perawatan
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pasien_id")]
        public int Pasien_id { get; set; }

        [Column("dokter_id")]
        public int Dokter_id { get; set; }

        [Column("jenis_perawatan")]
        public string? Jenis_perawatan { get; set; }

        [Column("harga")]
        public decimal Harga { get; set; }  

        [Column("tanggal")]
        public DateTime Tanggal { get; set; }

        [ForeignKey("Pasien_id")]
        public Pasien? Pasien { get; set; }

        [ForeignKey("Dokter_id")]
        public Dokter? Dokter { get; set; }
    }
}