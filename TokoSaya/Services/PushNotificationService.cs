using TokoSaya.Interfaces;
using TokoSaya.Models;

namespace TokoSaya.Services;

public class PushNotificationService : INotificationService
{
    // PROPERTY
    // Menentukan channel yang digunakan implementation ini.
    public NotificationChannel Channel => NotificationChannel.Push;

    // METHOD
    // Menjalankan simulasi Push Notification.
    public string SendNotification(string recipient, string message)
    {
        return $"SIMULASI PUSH kepada {recipient}: {message}";
    }
}
