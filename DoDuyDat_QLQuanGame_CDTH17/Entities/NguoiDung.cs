//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoDuyDat_QLQuanGame_CDTH17.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            this.ChiTietSuDungs = new HashSet<ChiTietSuDung>();
        }
    
        public string ID_User { get; set; }
        public string ID_Password { get; set; }
        public Nullable<int> ID_Money { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDungs { get; set; }
        public virtual QuanTri QuanTri { get; set; }
    }
}
