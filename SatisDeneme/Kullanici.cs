//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatisDeneme
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanici
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kullanici_adi { get; set; }
        public string Sifre { get; set; }
        public Nullable<bool> Rapor { get; set; }
        public Nullable<bool> Satis { get; set; }
        public Nullable<bool> Stok { get; set; }
        public Nullable<bool> UrunGırıs { get; set; }
        public Nullable<bool> Ayarlar { get; set; }
        public Nullable<bool> FiyatGuncelle { get; set; }
        public Nullable<bool> Yedekleme { get; set; }
    }
}
