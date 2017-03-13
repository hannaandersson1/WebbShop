//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webbshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Size
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Size()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }

        public int Id { get; set; }

        [Display(Name = "Storlek")]
        [Required(ErrorMessage = "Storlek beh�vs")]
        [RegularExpression(@"^[A-Z������]+[-a-zA-Z_/\\.,������\s]*$", ErrorMessage = "Inga siffror och b�rja med versal")]
        public string Size1 { get; set; }
        [Display(Name = "Product")]
        public int Product_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Product Product { get; set; }
    }
}
