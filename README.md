# 🔧 .NetBackendProject

`.NetBackendProject`, **ASP.NET Core Web API (.NET 6)** kullanılarak geliştirilmiş, katmanlı mimariye sahip bir backend altyapı projesidir. Temiz kod, sürdürülebilir yapı ve genişletilebilirlik ön planda tutularak hazırlanmıştır. Özellikle öğrenme, geliştirme veya projeye hızlı başlama (boilerplate) amaçlı idealdir.

---

## 📌 Proje Özeti

- ✔️ ASP.NET Core 6 Web API mimarisi
- 🧱 Katmanlı yapı: Controller, Service, Repository, DTO
- 📦 Entity Framework Core (EF Core) ile veritabanı işlemleri
- 📘 Swagger UI ile REST API dokümantasyonu ve test
- 🔄 Generic Repository ve Service yapıları
- 🛡️ Model validation ve hata yönetimi altyapısı
- 🔗 Kolayca genişletilebilir yapı (JWT, AutoMapper, Serilog gibi)

---

## 🗂️ Kullanılan Teknolojiler

| Teknoloji          | Açıklama                               |
|--------------------|----------------------------------------|
| .NET 6             | Modern ve performanslı backend platformu |
| ASP.NET Core Web API | RESTful servis mimarisi               |
| Entity Framework Core | ORM – Veritabanı işlemleri için       |
| SQL Server         | Veritabanı (LocalDB veya tam sürüm)    |
| Swagger (Swashbuckle) | API dokümantasyonu ve test aracı     |

---

## 🧱 Katmanlı Mimari

```text
.NetBackendProject
│
├── Controllers/         => API endpoint’leri (Request alır, Service’e iletir)
├── Services/            => İş mantığı (Business Logic)
├── Repositories/        => Veritabanı işlemleri (EF Core ile)
├── Models/              => Entity sınıfları (veritabanı modelleri)
├── DTOs/                => Veri taşıma nesneleri (Request/Response için)
├── Data/                => DbContext ve Migration yönetimi
├── Program.cs           => Giriş noktası, service registration
├── appsettings.json     => Ayarlar (veritabanı bağlantısı vb.)
└── .NetBackendProject.sln
