using TokoSaya.Interfaces;
using TokoSaya.Models;

namespace TokoSaya.Services;

// ============================================================
// CLASS / IMPLEMENTATION
// Simulasi pengiriman notifikasi melalui email.
// ============================================================
public class EmailNotificationService : INotificationService
/*
    Tanda : menyatakan bahwa class tersebut mengimplementasikan interface.
    Karena INotificationService mewajibkan SendNotification(), class ini harus menyediakan method tersebut.
*/
{
    // PROPERTY
    // Menandakan implementation ini menggunakan Email.
    public NotificationChannel Channel => NotificationChannel.Email; // Artinya, jika ada bagian program yang menanyakan channel milik EmailNotificationService, jawabannya adalah NotificationChannel.Email.

    // METHOD
    // Menjalankan simulasi notifikasi melalui email.
    public string SendNotification(string recipient, string message)
    {
        return $"SIMULASI EMAIL kepada {recipient}: {message}";
        // Tanda $ sebelum string memungkinkan kita menyisipkan nilai variabel menggunakan {}.
    }
}
