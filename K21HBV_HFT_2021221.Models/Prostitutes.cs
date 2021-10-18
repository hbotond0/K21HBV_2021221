using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace K21HBV_HFT_2021221.Models
{
    [Table("prostitutes")]
    public class Prostitutes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public string Category { get; set; }

        [Required]
        public int Price { get; set; }


        [Required]
        public bool STDs { get; set; }

        [NotMapped]
        public virtual Pimps Pimp { get; set; }

        [ForeignKey(nameof(Pimp))]
        public int? PimpId { get; set; }
    }
}