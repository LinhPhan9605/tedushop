namespace ClassLibrary2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Provider")]
    public partial class Provider
    {
        [StringLength(10)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [Required]
        [StringLength(10)]
        public string idCategory { get; set; }

        public DateTime? createdDate { get; set; }

        [Required]
        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }

        public virtual Category Category { get; set; }
    }
}
