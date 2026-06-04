# Muze-Otomasyonu

Muze-Otomasyonu: Dijital Müze ve Koleksiyon Yönetim Sistemi
Proje Tanımı ve Amaç
Muze-Otomasyonu, müze ve sanat galerisi gibi kurumsal yapıların envanter yönetimi, sanatçı arşivleme ve sergileme süreçlerini dijitalleştirmek için tasarlanmış kapsamlı bir masaüstü otomasyon çözümüdür. Bu projenin temel amacı, klasik müze yönetimi süreçlerinde karşılaşılan veri karmaşasını ortadan kaldırmak; sanat eserleri, sanatçılar ve koleksiyonlar arasındaki ilişkisel veriyi merkezi bir sistemde, yüksek doğruluk ve sürdürülebilirlik ile yönetmektir.

Teknik Mimari ve Geliştirme Süreci
Proje, modülerlik ve ölçeklenebilirlik hedefleri gözetilerek Katmanlı Mimari (N-Tier Architecture) prensipleri ile geliştirilmiştir. Bu sayede sunum katmanı (UI), iş mantığı (Business Logic) ve veri erişim katmanı (Data Access) birbirinden ayrıştırılarak kodun bakımı ve geliştirilmesi kolaylaştırılmıştır.

Ön Yüz (User Interface): Windows Forms kullanılarak, kullanıcı dostu ve hızlı erişilebilir bir arayüz tasarlanmıştır.

Veri Erişim Katmanı (Data Access Layer): Veritabanı ile uygulama arasındaki iletişim, Entity Framework (EF) kullanılarak yönetilmiştir. Bu sayede ORM (Object-Relational Mapping) yapısı sayesinde veritabanı işlemleri nesne yönelimli bir yaklaşımla gerçekleştirilmiştir.

Veritabanı Yönetimi: MS SQL Server kullanılarak, verilerin ilişkisel bütünlüğü (Referential Integrity) Foreign Key ve Primary Key yapısı ile güvence altına alınmıştır.

Veri İşleme ve Sorgulama: Karmaşık veri raporlamaları ve istatistiksel analizler için LINQ (Language Integrated Query) sorguları tercih edilerek, sistemin performanslı ve hatasız çalışması sağlanmıştır.

Temel Fonksiyonel Yetenekler
Sistem, bir müze yönetiminin ihtiyaç duyabileceği tüm kritik işlemleri kapsamaktadır:

Gelişmiş CRUD İşlemleri: Sanatçı portföyleri, sanat eseri detayları ve müze envanteri üzerinde tüm ekleme, güncelleme, listeleme ve silme işlemleri, veri tutarlılığı kuralları çerçevesinde yürütülmektedir.

İstatistiksel Analiz Modülü: Koleksiyon verileri üzerinde gerçekleştirilen istatistiksel hesaplamalar ile sanatçı bazlı eser sayıları, dönemsel dağılımlar gibi kritik veriler görselleştirilebilir hale getirilmiştir.

İlişkisel Veri Sorgulama: Sanatçı-Eser-Müze üçlüsü arasındaki tüm bağlantılar, SQL JOIN işlemleri ve ilişkisel haritalama teknikleri ile optimize edilmiştir.
