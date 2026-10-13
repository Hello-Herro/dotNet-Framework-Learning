using System.Collections.Generic;
using System.Linq;
using TokoSaya.Interfaces;
using TokoSaya.Models;

namespace TokoSaya.Services;

// ============================================================
// FACTORY / SELECTOR
// Bertugas memilih notification service berdasarkan channel.
// ============================================================
public class NotificationServiceFactory : INotificationServiceFactory
    /*
    Sekarang, NotificationServiceFactory adalah class konkret yang memenuhi contract INotificationServiceFactory.
    Method GetService() yang sudah kamu buat sebelumnya menjadi implementasi method yang diwajibkan interface tersebut.
    */
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
            Misalnya channel yang dicari adalah NotificationChannel.Sms:
                EmailNotificationService → Channel = Email → Tidak cocok
                SmsNotificationService   → Channel = Sms   → Cocok
        */
        return _notificationServices.FirstOrDefault(service => service.Channel == channel);
        /*  FirstOrDefault() mencari item pertama yang memenuhi kondisi. Ekspresi: service => service.Channel == channel
            adalah lambda expression yang menyatakan kondisi pencarian: channel milik service harus sama dengan channel yang diminta.
            
            Jika channel yang dicari Email:
            EmailNotificationService → cocok

            Jika channel yang dicari Sms:
            EmailNotificationService → tidak cocok
            SmsNotificationService   → cocok

            Kita tidak perlu menulis if/else secara manual untuk membandingkan setiap implementation.
            Kondisi pencariannya cukup ditulis sekali.
        */
    }
}
