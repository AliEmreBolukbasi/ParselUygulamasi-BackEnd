using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace parseluygulamasi.Entities
{
    public class Parsel
    {
        [Key ,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength (50)]
        public string Ulke { get; set; }
        [StringLength(50)]
        public string Sehir { get; set; }
        [StringLength(50)]
        public string Ilce { get; set; }
    }
}
