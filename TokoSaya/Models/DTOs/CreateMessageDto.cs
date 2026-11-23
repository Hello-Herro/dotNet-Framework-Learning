namespace TokoSaya.Models.DTOs;

// ============================================================
// DTO (DATA TRANSFER OBJECT)
// Membawa data pesan dari PageModel ke MessageService.
// ============================================================
public class CreateMessageDto
{
    // Data nama pengguna.
    public string Name { get; set; } = string.Empty;

    // Data pesan pengguna.
    public string Message { get; set; } = string.Empty;
}

/*
    Mengapa tidak kita tambahkan [Required]?
    Karena validasi input sudah berada di MessageFormModel. 
    DTO yang sedang kita buat bertugas membawa data yang telah lolos validasi.
*/
