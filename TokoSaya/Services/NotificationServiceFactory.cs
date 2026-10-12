using System.Collections.Generic;
using System.Linq;
using TokoSaya.Interfaces;
using TokoSaya.Models;

namespace TokoSaya.Services;

// ============================================================
// FACTORY / SELECTOR
// Bertugas memilih notification service berdasarkan channel.
// ============================================================
public class NotificationServiceFactory
{
    // FIELD / DEPENDENCY
    // Menyimpan seluruh implementation yang diberikan oleh DI.
    private readonly IEnumerable<INotificationService> _notificationServices;

    // CONSTRUCTOR INJECTION
    public NotificationServiceFactory(IEnumerable<INotificationService> notificationServices)
    /*
       Artinya: Factory menerima kumpulan implementation dari DI Container. Ia tidak membuat sendiri object email dan SMS menggunakan new.
    */
    {
        _notificationServices = notificationServices;
    }

    // METHOD
    // Mencari implementation sesuai channel yang diminta.
    public INotificationService? GetService(NotificationChannel channel)
    /*
        GetService() artinya menerima pilihan channel
        Method ini menerima satu parameter, misalnya: NotificationChannel.Email atau NotificationChannel.Sms
        Tanda ? pada INotificationService? menunjukkan bahwa method boleh mengembalikan null jika implementation untuk channel yang dicari tidak ditemukan.
    */
    {
    /*
        Bagian ini meminta .NET mencari implementation pertama yang mempunyai Channel sesuai pilihan.
        isalnya channel yang dicari adalah NotificationChannel.Sms:
            EmailNotificationService → Channel = Email → Tidak cocok
            SmsNotificationService   → Channel = Sms   → Cocok
    */
        return _notificationServices.FirstOrDefault(service => service.Channel == channel);
    }
}
