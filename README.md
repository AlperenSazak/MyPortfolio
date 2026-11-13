<div align="center">

# 🌿 MYAcademy Portfolio

**Kişisel portföy sitesi + tam yönetim paneli**

İçerik tamamen veritabanından gelir. Admin panelinde yapılan her değişiklik anasayfaya canlı yansır.

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-5C2D91?logo=dotnet&logoColor=white)
![EF Core](https://img.shields.io/badge/EF%20Core-Code%20First-0A7EA4)
![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?logo=microsoftsqlserver&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?logo=bootstrap&logoColor=white)

*Murat Yücedağ Academy (.NET) case çalışması kapsamında geliştirilmiştir.*

<br>

<img src="https://github.com/user-attachments/assets/bc227935-9c40-46f4-bbba-581260f974af" width="90%" alt="Anasayfa" />

</div>

<details>
<summary><b>📸 Daha fazla ekran görüntüsü</b></summary>
<br>

<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/b37479d7-4b2d-4179-968c-4859f12f39c0" /></td>
    <td><img src="https://github.com/user-attachments/assets/e82df88a-8a79-4c59-bb73-2fefffa924cc" /></td>
    <td><img src="https://github.com/user-attachments/assets/a9a43330-82a1-49ee-a191-5a00d9e19e7c" /></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/486f3e81-37e3-4b17-9e28-06a1ced83f0c" /></td>
    <td><img src="https://github.com/user-attachments/assets/12d5f401-ba7f-47c6-bbf2-ebb3f6711693" /></td>
    <td><img src="https://github.com/user-attachments/assets/2d90f3f8-e020-4669-b965-de0882b0e3e2" /></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/158a2ce0-d878-415a-abe3-9b1d59de7415" /></td>
    <td></td>
    <td></td>
  </tr>
</table>

</details>

---

## ✨ Proje Özeti

| Yüzey | Amaç |
| --- | --- |
| 🌐 **Public site** (`/`) | Ziyaretçinin gördüğü tek sayfalık portföy |
| 🛠️ **Admin panel** (`/Admin/Dashboard`) | Tüm içeriğin CRUD ile yönetildiği panel |

```
Admin CRUD  →  SQL Server  →  ViewComponent  →  Razor View  →  Public UI
```

Kodu değiştirmeden içerik güncellenir: yeni proje ekle, unvanı değiştir, mesajları oku. Hepsi panelden.

---

## 🧰 Teknolojiler

| Katman | Kullanılanlar |
| --- | --- |
| ⚙️ **Backend** | ASP.NET Core MVC, EF Core (Code First), Areas, ViewComponents, Dependency Injection, Data Annotations |
| 🎨 **Frontend** | Razor Views, Bootstrap 5, Bootstrap Icons, Vanilla JS (typewriter, filtre, scroll reveal) |
| 🗄️ **Veritabanı** | SQL Server LocalDB |

---

## 🌐 Public Site

Tek sayfa, her bölüm bağımsız bir **ViewComponent**:

- 👋 **Hero**: karşılama, typewriter unvanlar, sosyal ikonlar
- 🙋 **About**: biyografi, istatistikler, CV indirme
- 💡 **Skills**: yetenek kartları ve alt teknolojiler
- 💼 **Experience**: zaman çizelgesi
- 🗂️ **Projects**: kategori filtreli proje grid'i
- 🎓 **Education**: eğitim kartları
- ✉️ **Contact**: iletişim bilgileri ve mesaj formu

Aktif içerik `IsActive` filtresiyle gösterilir.

---

## 🛠️ Admin Panel

- 📊 **Dashboard**: proje, yetenek, deneyim, eğitim ve mesaj istatistikleri, son mesajlar, kategori grafiği
- 🏠 **Hero / About / Contact / Social Media** yönetimi
- 🧩 **Skills, Experience, Education, Projects, Categories**: CRUD, arama, aktif/pasif geçişi
- 🖼️ **Projeler**: görsel yükleme, kategori / durum / sıralama filtreleri
- 📬 **Mesajlar**: listeleme, detay, okundu işaretleme, toplu işlem, silme

---

## 🔍 Öne Çıkan Teknik Detaylar

- 🧱 **ViewComponent mimarisi**: veri C# tarafında çekilir, sunum Razor'da kalır. Sayfa şişmez, bakım kolaylaşır.
- 🔗 **İlişkisel veri**: `Project → Category` (N-1), `Skill → SkillItems` (1-N), EF Core `Include` ile yüklenir.
- 🖼️ **ImageUploadService**: uzantı kontrolü (`jpg`, `jpeg`, `png`, `webp`), en fazla 2 MB, `Guid` ile güvenli dosya adı, eski dosya temizliği.
- ✅ **Validasyon**: `[Required]`, `[StringLength]`, `[EmailAddress]`, `[Url]`, `[Range]`, `[Phone]`.
- 🗂️ **Areas** ile Admin / Public ayrımı, admin layout'u da ViewComponent'lerle parçalanmış.

---

## 📁 Proje Yapısı

```
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
```

---

## 🚀 Çalıştırma

**Gereksinimler:** .NET 10 SDK, SQL Server LocalDB

```bash
cd MYAcademy_Portfolio
dotnet ef database update
dotnet run
```

| Adres | Açıklama |
| --- | --- |
| `https://localhost:{port}/` | 🌐 Public portföy |
| `https://localhost:{port}/Admin/Dashboard` | 🛠️ Yönetim paneli |

---

## 📚 Neler Öğrendim

ASP.NET Core MVC ile katmanlı mimari, EF Core Code First ve Migration, ViewComponent tabanlı yapı, ilişkisel veri modelleme, güvenli dosya yükleme, dashboard istatistikleri ve CRUD / filtreleme / durum yönetimi.

---

<div align="center">

### 👨‍💻 Geliştirici

**Alperen Sazak**

.NET Portföy Case

⭐ Beğendiysen yıldızlamayı unutma!

</div>
