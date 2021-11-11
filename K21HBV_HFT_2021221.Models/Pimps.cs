using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace K21HBV_HFT_2021221.Models
{
    [Table("pimps")]
    public class Pimps
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(35)]
        [Required]
        public string Name { get; set; }

        [MaxLength(3)]
        [Required]
        public int CustomerRating { get; set; }

        [NotMapped]
        public virtual ICollection<Prostitutes> Prostitutes { get; }

        [NotMapped]
        public virtual ICollection<Customers> Customers { get; }


        public Pimps()
        {
            this.Prostitutes = new HashSet<Prostitutes>();
            this.Customers = new HashSet<Customers>();
        }
    }
}
