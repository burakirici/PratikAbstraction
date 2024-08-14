# Çalışan Görevleri Uygulaması

Bu C# uygulaması, bir şirketin çalışanlarını temsil eden sınıfları içerir. Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmakla birlikte, her çalışanın pozisyonuna göre görev tanımı farklıdır. Bu görev tanımları, **abstraction** ve **inheritance** (miras) kavramları kullanılarak kodlanmıştır.

## İçerik

- `Employees` (Abstract Class): Çalışanların ortak özelliklerini ve görev metodunu içerir.
- `SoftwareDeveloper` (Class): Yazılım geliştiriciler için özel görev metodunu içerir.
- `SalesRepresentative` (Class): Satış temsilcileri için özel görev metodunu içerir.
- `Program` (Main Class): Çalışan sınıflarının örneklerini oluşturur ve görev metodlarını çağırarak çıktıları görüntüler.

## Kullanım

Bu uygulama, çalışanların pozisyonlarına göre ne iş yaptıklarını konsol ekranında göstermek amacıyla tasarlanmıştır.

### Örnek Kullanım

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Employee projeYoneticisi = new ProjeYoneticisi("Hasan", "Çıldırmış", "Yönetim");
        Employee yazilimGelistirici = new YazilimGelistirici("Ayşe", "Kaya", "Yazılım");
        Employee satisTemsilcisi = new SatisTemsilcisi("Mehmet", "Yıldız", "Satış");

        projeYoneticisi.Gorev();  // Proje yöneticisi olarak çalışıyorum.
        yazilimGelistirici.Gorev();  // Yazılım geliştirici olarak çalışıyorum.
        satisTemsilcisi.Gorev();  // Satış temsilcisi olarak çalışıyorum.
    }
}
