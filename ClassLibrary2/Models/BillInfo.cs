namespace ClassLibrary2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string idBillOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string idProduce { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string totalPrice { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string totalPayment { get; set; }

        public DateTime? createdDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }

        public virtual BillOrder BillOrder { get; set; }

        public virtual Produce Produce { get; set; }
    }
}
