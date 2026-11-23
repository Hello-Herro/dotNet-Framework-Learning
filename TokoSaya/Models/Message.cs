namespace TokoSaya.Models;

// ============================================================
// ENTITY
// Merepresentasikan data pesan dalam aplikasi.
// ============================================================
public class Message
{
    // Primary Key (nantinya dipetakan oleh EF Core).
    public int Id { get; set; }

    // Nama pengirim pesan.
    public string Name { get; set; } = string.Empty;

    // Isi pesan.
    public string MessageText { get; set; } = string.Empty;

    // Waktu pesan dibuat.
    public DateTime CreatedAt { get; set; }
}
/*
    Perhatikan bahwa nama MessageText berbeda dari Message pada Form Model dan DTO. 
    Ini tidak masalah karena mapping akan menentukan bagaimana nilai tersebut dipindahkan.
    Id nantinya dapat menjadi Primary Key melalui konvensi EF Core, 
    sedangkan CreatedAt dapat diisi oleh aplikasi ketika pesan dibuat.
*/