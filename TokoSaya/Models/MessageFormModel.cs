using System.ComponentModel.DataAnnotations; // Namespace ini menyediakan attribute seperti Required dan StringLength.

namespace TokoSaya.Models;

// Fungsi dari Class MessageFormModel: Menampung data input pengguna beserta aturan validasinya.
// Sebelumnya aturan validasi ini ada di FormDemoModel, tapi sekarang dipindahkan ke class ini agar lebih rapi dan terpisah dari logika halaman.
// Note: tidak mengubah aturan validasinya. hanya memindahkan tempat deklarasinya.

// ============================================================
// MODEL CLASS
// Merepresentasikan data yang dikirim melalui form pesan.
// ============================================================
public class MessageFormModel
{
    // ========================================================
    // PROPERTY: NAME
    // Menyimpan nama pengguna.
    // ========================================================
    [Required(ErrorMessage = "Nama wajib diisi.")]
    [StringLength(
        50,
        MinimumLength = 2,
        ErrorMessage = "Nama harus terdiri dari 2 sampai 50 karakter."
    )]
    public string Name { get; set; } = string.Empty;

    // ========================================================
    // PROPERTY: MESSAGE
    // Menyimpan pesan pengguna.
    // ========================================================
    [Required(ErrorMessage = "Pesan wajib diisi.")]
    [StringLength(
        300,
        MinimumLength = 5,
        ErrorMessage = "Pesan harus terdiri dari 5 sampai 300 karakter."
    )]
    public string Message { get; set; } = string.Empty;
}
