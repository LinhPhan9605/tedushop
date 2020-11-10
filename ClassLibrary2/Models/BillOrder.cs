namespace ClassLibrary2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillOrder")]
    public partial class BillOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOrder()
        {
            BillInfo = new HashSet<BillInfo>();
            Delivery = new HashSet<Delivery>();
        }

        [StringLength(10)]
        public string id { get; set; }

        [Column(TypeName = "date")]
        public DateTime billCheckIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? billCheckOut { get; set; }

        [Required]
        [StringLength(10)]
        public string idCustomer { get; set; }

        [Required]
        [StringLength(20)]
        public string totalPrice { get; set; }

        [Required]
        [StringLength(20)]
        public string totalPayment { get; set; }

        public DateTime? createdDate { get; set; }

        [Required]
        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
