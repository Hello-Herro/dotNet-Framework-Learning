using TokoSaya.Interfaces;
using TokoSaya.Models;

namespace TokoSaya.Services;

// ============================================================
// CLASS / IMPLEMENTATION
// Simulasi pengiriman notifikasi melalui SMS.
// ============================================================
public class SmsNotificationService : INotificationService
{
    // PROPERTY
    // Menandakan implementation ini menggunakan SMS.
    public NotificationChannel Channel => NotificationChannel.Sms;

    // METHOD
    // Menjalankan simulasi notifikasi melalui SMS.
    public string SendNotification(string recipient, string message)
    {
        return $"SIMULASI SMS kepada {recipient}: {message}";
    }
}
