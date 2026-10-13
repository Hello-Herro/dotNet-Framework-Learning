using TokoSaya.Models;

namespace TokoSaya.Interfaces;

// ============================================================
// INTERFACE
// Contract untuk pemilihan notification service.
// ============================================================
public interface INotificationServiceFactory
{
    // METHOD CONTRACT
    // Mencari service berdasarkan channel yang diminta.
    // Hasil bisa null jika service tidak ditemukan.
    INotificationService? GetService(NotificationChannel channel);

    // GetService() berarti konsumen dapat meminta service berdasarkan channel.
    // dan Parameternya yang menunjukan channel yang dicari, misalnya Email, Sms, atau Push. 
}
