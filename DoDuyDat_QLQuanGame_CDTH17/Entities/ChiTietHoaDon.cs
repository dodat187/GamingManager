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
    
    public partial class ChiTietHoaDon
    {
        public string MaHD { get; set; }
        public string MaCTHD { get; set; }
        public string MaDV { get; set; }
        public Nullable<int> SoluongDV { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    
        public virtual DichVu DichVu { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}