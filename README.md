# Muze-Otomasyonu
Muze-Otomasyonu (Dijital Müze ve Koleksiyon Arşiv Sistemi)
Proje Hakkında
Dijital Müze ve Koleksiyon Arşiv Sistemi, müze envanterlerinin, sanatçı portföylerinin ve koleksiyon verilerinin yönetimini dijitalleştirmek amacıyla geliştirilmiş kapsamlı bir masaüstü uygulamasıdır. Proje, verilerin sistematik bir şekilde arşivlenmesini sağlamak için modern yazılım geliştirme prensiplerini temel alarak; veri bütünlüğü, hızlı veri erişimi ve analitik raporlama yetenekleri sunar.

Temel Özellikler
Tam CRUD İşlemleri: Sanatçılar, sanat eserleri ve müzeler için veri oluşturma, okuma, güncelleme ve silme (CRUD) işlemlerinin eksiksiz yönetimi.

Gelişmiş İstatistiksel Raporlama: Koleksiyon dağılımını ve sanatçı trendlerini analiz etmeye olanak tanıyan entegre raporlama modülleri.

Veri Odaklı Mimari: Büyük ölçekli veri setleri için optimize edilmiş, ilişkisel veritabanı şeması.

Kullanıcı Dostu Arayüz: İdari iş akışları için optimize edilmiş, Windows Forms tabanlı sezgisel bir kullanıcı deneyimi.

Kullanılan Teknolojiler
Programlama Dili: C# (.NET Framework)

Framework'ler: Windows Forms, Entity Framework (EF)

Veritabanı Yönetimi: MS SQL Server

Veri Sorgulama: LINQ to Entities

Mimari: Katmanlı Mimari (N-Tier Architecture) sayesinde kodun modülerliği ve sürdürülebilirliği sağlanmıştır.

Teknik Detaylar
Sistem, MS SQL Server üzerinde normalize edilmiş bir ilişkisel veritabanı şeması kullanmaktadır. Projenin teknik altyapısı şu noktalar üzerine kuruludur:

İlişkisel Haritalama: Sanatçı, eser ve müze tabloları arasında kurulan güçlü Foreign Key (Yabancı Anahtar) bağlantıları ile veri tutarlılığı sağlanmıştır.

Veri Sorgulama: Veritabanı ile uygulama katmanı arasında, Entity Framework aracılığıyla ORM (Object-Relational Mapping) yapısı kullanılarak LINQ sorguları ile esnek ve güvenli veri çekme işlemleri gerçekleştirilmiştir.

Güvenlik ve Performans: Saklı yordamlar (Stored Procedures) ve kısıtlamalar (constraints) kullanılarak veritabanı güvenliği ve işlem hızı optimize edilmiştir.
