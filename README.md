🌿 MYAcademy Portfolio

Kişisel portföy sitesi + tam yönetim paneli İçerik tamamen veritabanından gelir. Admin panelinde yapılan her değişiklik anasayfaya canlı yansır.

<img width="1334" height="917" alt="Ekran görüntüsü 2026-11-13 163346" src="https://github.com/user-attachments/assets/bc227935-9c40-46f4-bbba-581260f974af" />

<img width="1524" height="910" alt="Ekran görüntüsü 2026-11-13 163356" src="https://github.com/user-attachments/assets/b37479d7-4b2d-4179-968c-4859f12f39c0" />

<img width="1335" height="924" alt="Ekran görüntüsü 2026-11-13 163413" src="https://github.com/user-attachments/assets/e82df88a-8a79-4c59-bb73-2fefffa924cc" />

<img width="1115" height="935" alt="Ekran görüntüsü 2026-11-13 163434" src="https://github.com/user-attachments/assets/a9a43330-82a1-49ee-a191-5a00d9e19e7c" />

<img width="1207" height="926" alt="Ekran görüntüsü 2026-11-13 163518" src="https://github.com/user-attachments/assets/486f3e81-37e3-4b17-9e28-06a1ced83f0c" />

<img width="1877" height="934" alt="Ekran görüntüsü 2026-11-13 163543" src="https://github.com/user-attachments/assets/12d5f401-ba7f-47c6-bbf2-ebb3f6711693" />

<img width="1885" height="898" alt="Ekran görüntüsü 2026-11-13 163558" src="https://github.com/user-attachments/assets/2d90f3f8-e020-4669-b965-de0882b0e3e2" />

<img width="1879" height="931" alt="Ekran görüntüsü 2026-11-13 163612" src="https://github.com/user-attachments/assets/a2e2bcc8-ad29-4aa1-ad3b-a9d5e46e374a" />

<img width="1878" height="871" alt="Ekran görüntüsü 2026-11-13 163629" src="https://github.com/user-attachments/assets/158a2ce0-d878-415a-abe3-9b1d59de7415" />

Murat Yücedağ Academy (.NET) case çalışması kapsamında geliştirilmiştir.


✨ Proje Özeti
Yüzey	Amaç
🌐 Public site (/)	Ziyaretçinin gördüğü tek sayfalık portföy
🛠️ Admin panel (/Admin/Dashboard)	Tüm içeriğin CRUD ile yönetildiği panel
Admin CRUD  →  SQL Server  →  ViewComponent  →  Razor View  →  Public UI

Kodu değiştirmeden içerik güncellenir: yeni proje ekle, unvanı değiştir, mesajları oku. Hepsi panelden.

🧰 Teknolojiler
Katman	Kullanılanlar
⚙️ Backend	ASP.NET Core MVC, EF Core (Code First), Areas, ViewComponents, Dependency Injection, Data Annotations
🎨 Frontend	Razor Views, Bootstrap 5, Bootstrap Icons, Vanilla JS (typewriter, filtre, scroll reveal)
🗄️ Veritabanı	SQL Server LocalDB
🌐 Public Site

Tek sayfa, her bölüm bağımsız bir ViewComponent:

👋 Hero: karşılama, typewriter unvanlar, sosyal ikonlar
🙋 About: biyografi, istatistikler, CV indirme
💡 Skills: yetenek kartları ve alt teknolojiler
💼 Experience: zaman çizelgesi
🗂️ Projects: kategori filtreli proje grid'i
🎓 Education: eğitim kartları
✉️ Contact: iletişim bilgileri ve mesaj formu

Aktif içerik IsActive filtresiyle gösterilir.

🛠️ Admin Panel
📊 Dashboard: proje, yetenek, deneyim, eğitim ve mesaj istatistikleri, son mesajlar, kategori grafiği
🏠 Hero / About / Contact / Social Media yönetimi
🧩 Skills, Experience, Education, Projects, Categories: CRUD, arama, aktif/pasif geçişi
🖼️ Projeler: görsel yükleme, kategori / durum / sıralama filtreleri
📬 Mesajlar: listeleme, detay, okundu işaretleme, toplu işlem, silme
🔍 Öne Çıkan Teknik Detaylar
🧱 ViewComponent mimarisi: veri C# tarafında çekilir, sunum Razor'da kalır. Sayfa şişmez, bakım kolaylaşır.
🔗 İlişkisel veri: Project → Category (N-1), Skill → SkillItems (1-N), EF Core Include ile yüklenir.
🖼️ ImageUploadService: uzantı kontrolü (jpg, jpeg, png, webp), en fazla 2 MB, Guid ile güvenli dosya adı, eski dosya temizliği.
✅ Validasyon: [Required], [StringLength], [EmailAddress], [Url], [Range], [Phone].
🗂️ Areas ile Admin / Public ayrımı, admin layout'u da ViewComponent'lerle parçalanmış.
📁 Proje Yapısı
MYAcademy_Portfolio/
├── Areas/Admin/       # Yönetim paneli
├── Controllers/       # Public DefaultController
├── Context/           # PortfolioContext (EF Core)
├── Entities/          # Domain modelleri
├── Migrations/        # Code First migration'lar
├── Models/            # DashboardViewModel vb.
├── Services/          # ImageUploadService
├── ViewComponents/    # Public site bileşenleri
└── wwwroot/           # CSS, JS, uploads


🚀 Çalıştırma
Gereksinimler: .NET 10 SDK, SQL Server LocalDB

bash
cd MYAcademy_Portfolio
dotnet ef database update
dotnet run

Adres	Açıklama
https://localhost:{port}/	🌐 Public portföy
https://localhost:{port}/Admin/Dashboard	🛠️ Yönetim paneli

📚 Neler Öğrendim

ASP.NET Core MVC ile katmanlı mimari, EF Core Code First ve Migration, ViewComponent tabanlı yapı, ilişkisel veri modelleme, güvenli dosya yükleme, dashboard istatistikleri ve CRUD / filtreleme / durum yönetimi.

👨‍💻 Geliştirici
Alperen Sazak · .NET Portföy Case
