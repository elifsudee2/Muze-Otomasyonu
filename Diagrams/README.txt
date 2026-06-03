Models.puml: PlantUML format UML diagram for the EF model classes in this project.

Nasýl kullanýlýr:

1) Visual Studio Class Designer (sizde eklenti yüklü):
   - Visual Studio'da Solution Explorer üzerinde proje adýnýza sað týklayýn.
   - Add -> New Item -> Class Diagram (.cd) seçin.
   - Oluþan .cd dosyasýný açýn ve Class View penceresinden (View -> Class View) ilgili sýnýflarý sürükleyip diyagrama býrakýn.
   - Özellikler ve iliþkiler otomatik olarak görünmelidir.

2) PlantUML (.puml) dosyasýný kullanmak isterseniz:
   - VS Code kullanýyorsanýz "PlantUML" uzantýsýný yükleyin ve `Diagrams/Models.puml` dosyasýný açýn. Önizleme için "Preview Current Diagram" seçeneðini kullanýn.
   - Alternatif olarak online PlantUML sunucusu veya yerel PlantUML jar ile .png çýktýsý oluþturabilirsiniz.

Notlar:
 - `Diagrams/Models.puml` dosyasý proje içindeki `Eserler.cs`, `Kategori.cs`, `Sanatcýlar.cs`, `Muze.cs`, `MuzeDbContext.cs` dosyalarýndan otomatik olarak oluþturulmuþtur.
 - Eðer Visual Studio Class Designer (.cd) dosyasý isterseniz, istek bildirirseniz .cd dosyasý oluþturmaya çalýþýrým. Ancak .cd formatý Visual Studio'ya özgü ve elle hazýrlamak daha hassas olabilir; en güvenli yöntem IDE içinde otomatik oluþturmadýr.

Hazýr diagramlar üretmemi isterseniz söyleyin (örneðin PlantUML PNG veya SVG üretimi).