using TokoSaya.Models;

namespace TokoSaya.Interfaces;

// ============================================================
// INTERFACE
// Contract untuk seluruh layanan notifikasi.
// ============================================================
public interface INotificationService
{
    // METHOD CONTRACT

    // Menentukan channel yang digunakan implementation.
    NotificationChannel Channel { get; }

    // Setiap implementation harus menyediakan method ini.
    string SendNotification(string recipient, string message);

    /*
        Mengapa interface tidak mempunyai isi method?
        Karena interface ini berfungsi mendefinisikan kemampuan yang harus disediakan, bukan menentukan detail cara menjalankannya.
        Berbeda dengan IProductService, kali ini contract-nya berkaitan dengan pengiriman notifikasi.
    */
}
    