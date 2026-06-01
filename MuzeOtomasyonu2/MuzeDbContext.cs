using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MuzeOtomasyonu2
{
    internal class MuzeDbContext : DbContext
    {
        // 1. ADIM: Constructor (Yapıcı Metot)
        // App.config dosyasında verdiğimiz "MuzeDbContext" ismini buraya yazarak bağlantıyı kuruyoruz.
        public MuzeDbContext() : base("name=MuzeDbContext")
        {

        }

        // 2. ADIM: DbSet Tanımlamaları
        // Model sınıflarımızı veritabanı tabloları olarak tanıtıyoruz.
        public DbSet<Eserler> Eserler { get; set; }     
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Sanatcılar> Sanatcılar { get; set; }
        public virtual DbSet<Muze> Muzeler { get; set; }


    }
}
