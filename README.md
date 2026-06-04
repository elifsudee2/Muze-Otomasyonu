# Muze-Otomasyonu
🏛️ Müze Otomasyon Sistemi (Museum Automation System)
Bu proje, bir müzedeki eserlerin, sanatçıların, kategorilerin ve müze lokasyonlarının yönetimini dijitalleştirmek amacıyla geliştirilmiş bir Masaüstü Otomasyon Sistemidir.

Proje, ilişkisel veritabanı mantığını ve Entity Framework 6 (EF6) mimarisini temel alarak modern yazılım geliştirme standartlarına uygun olarak tasarlanmıştır.

🚀 Öne Çıkan Özellikler
İlişkisel Veri Yönetimi: Eserler, Sanatçılar, Kategoriler ve Müzeler arasındaki 1-N (One-to-Many) ilişkilerin profesyonel yönetimi.

Dinamik Listeleme: DataGridView üzerinden veritabanındaki tüm kayıtların anlık olarak görüntülenmesi.

Akıllı Veri Girişi: ComboBox entegrasyonu sayesinde kullanıcıların ID girmek yerine isim üzerinden (Sanatçı, Müze vb.) seçim yapabilmesi.

Veri Güvenliği (Data Annotations): Model seviyesinde kısıtlamalar ([Key], [Required], [MaxLength]) ile veritabanı tutarlılığının korunması.

Hata Yönetimi: Try-Catch blokları ve veritabanı bağlantı kontrolleri ile kesintisiz kullanıcı deneyimi.

🛠️ Kullanılan Teknolojiler
Programlama Dili: C# (.NET Framework)

Arayüz: Windows Forms (WinForms)

Veritabanı: Microsoft SQL Server (MSSQL)

ORM: Entity Framework 6 (Code-First / Database-First Mapping)

Kütüphaneler:

System.Data.Entity

System.ComponentModel.DataAnnotations

📊 Veritabanı Mimarisi
Sistem 4 ana tablodan oluşmaktadır:

Eserler: Müzede bulunan eserlerin adı, yılı ve ilişkili olduğu diğer tabloların kimlikleri.

Sanatçılar: Eseri yaratan sanatçının adı ve köken bilgisi.

Kategoriler: Eserin türü (Resim, Heykel, Arkeolojik Eser vb.).

Müzeler: Eserin sergilendiği fiziksel konum ve şehir bilgisi.


📝 Geliştirici Notu
Bu proje, Entity Framework mimarisini öğrenme sürecimin bir parçası olarak geliştirilmiştir. Veri modellerinin oluşturulması, ilişkisel tabloların yönetimi ve DbContext yapılandırması üzerinde detaylı çalışmalar içerir.

Geliştirici: Elif Sude Güneş
