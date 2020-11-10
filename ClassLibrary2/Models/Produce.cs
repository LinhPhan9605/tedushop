namespace ClassLibrary2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produce")]
    public partial class Produce
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produce()
        {
            BillInfo = new HashSet<BillInfo>();
            DeliveryInfo = new HashSet<DeliveryInfo>();
        }

        [StringLength(10)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(20)]
        public string price { get; set; }

        [Required]
        [StringLength(50)]
        public string unit { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryInfo> DeliveryInfo { get; set; }
    }
}
