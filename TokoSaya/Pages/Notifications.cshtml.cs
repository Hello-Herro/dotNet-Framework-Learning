using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TokoSaya.Models;
using TokoSaya.Services;

namespace TokoSaya.Pages;

// ============================================================
// PAGE MODEL / CONSUMER
// Menggunakan INotificationService melalui constructor injection.
// Meminta satu implementation berdasarkan channel yang dipilih.
// ============================================================
public class NotificationsModel : PageModel
{
    // FIELD / DEPENDENCY
    // Menyimpan factory yang diterima melalui constructor injection.
    private readonly NotificationServiceFactory _notificationServiceFactory;

    // Menyimpan kumpulan implementation dari INotificationService.
    // private readonly IEnumerable<INotificationService> _notificationServices;

    // PROPERTY: hasil simulasi yang akan ditampilkan di halaman.
    public string Result { get; private set; } = string.Empty;

    // PROPERTY
    // Menyimpan channel yang sedang digunakan.
    public string SelectedChannel { get; private set; } = "Email";

    // Menyimpan seluruh hasil simulasi notifikasi.
    // Hasil ini akan ditampilkan pada halaman Razor.
    // public List<string> Results { get; private set; } = new List<string>();

    // CONSTRUCTOR INJECTION
    // public NotificationsModel(INotificationService notificationService)
    // {
    //     _notificationService = notificationService;
    // }

    /*
    Constructor Kode tersebut meminta satu implementation, bukan semua implementation yang terdaftar.
    Constructor yang meminta satu INotificationService akan menerima implementation yang didaftarkan terakhir.
    Karena meminta satu INotificationService, consumer hanya mendapatkan satu implementation.
    */

    // ========================================================
    // CONSTRUCTOR INJECTION
    // DI Container menyediakan kumpulan service yang terdaftar.
    // ========================================================
    // public NotificationsModel(IEnumerable<INotificationService> notificationServices)
    // {
    //     _notificationServices = notificationServices;
    // }

    // ========================================================
    // CONSTRUCTOR INJECTION
    // ASP.NET Core DI Container menyediakan factory ini.
    // ========================================================
    public NotificationsModel(NotificationServiceFactory notificationServiceFactory)
    {
        _notificationServiceFactory = notificationServiceFactory;
    }

    // METHOD: dipanggil saat halaman menerima GET request.
    // public void OnGet()
    // {
    //     Result = _notificationService.SendNotification("Tera", "Pesanan berhasil dibuat.");
    // }

    // public void OnGet()
    // {
    //     // Mengulang setiap implementation yang diterima.
    //     foreach (INotificationService notificationService in _notificationServices)
    //     {
    //         // Memanggil method pada implementation tersebut.
    //         string result = notificationService.SendNotification(
    //             "Tera",
    //             "Pesanan berhasil dibuat."
    //         );

    //         // Menyimpan hasil agar dapat ditampilkan di halaman.
    //         Results.Add(result);
    //     }
    // }

    // ========================================================
    // METHOD: OnGet()
    // Menerima pilihan channel dari query string.
    // ========================================================
    public void OnGet(string? channel)
    {
        // Menggunakan Email jika channel tidak diberikan.
        if (string.IsNullOrWhiteSpace(channel))
        {
            channel = nameof(NotificationChannel.Email);
        }

        // Mengubah teks menjadi enum NotificationChannel.
        if (
            !Enum.TryParse<NotificationChannel>(channel, true, out var selectedChannel)
            || !Enum.IsDefined(typeof(NotificationChannel), selectedChannel)
        )
        {
            Result = "Channel tidak valid. Silakan pilih Email atau SMS.";
            return;
        }

        // Meminta factory mencari implementation yang sesuai.
        var notificationService = _notificationServiceFactory.GetService(selectedChannel);

        // Menangani kondisi ketika service tidak ditemukan.
        if (notificationService is null)
        {
            Result = $"Service untuk channel {selectedChannel} belum terdaftar.";
            return;
        }

        // Menyimpan channel yang terpilih.
        SelectedChannel = selectedChannel.ToString();

        // Menjalankan implementation yang telah dipilih.
        Result = notificationService.SendNotification("Tera", "Pesanan berhasil dibuat.");
    }
}
