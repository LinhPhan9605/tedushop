namespace ClassLibrary2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Migrations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int batch { get; set; }

        [StringLength(500)]
        public string migration { get; set; }

        public DateTime? createdDate { get; set; }

        [Required]
        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }
    }
}
