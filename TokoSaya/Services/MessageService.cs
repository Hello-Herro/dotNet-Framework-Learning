using TokoSaya.Models.DTOs;

namespace TokoSaya.Services;

// ============================================================
// SERVICE
// Bertanggung jawab memproses data pesan yang diterima.
// ============================================================
public class MessageService
{
    // METHOD
    // Menerima DTO dan menghasilkan informasi hasil pemrosesan.
    public string CreateMessage(CreateMessageDto dto)
    {
        return $"Data diterima: Nama = {dto.Name}; Pesan = {dto.Message}";
    }
}

/*
        'public string CreateMessage(CreateMessageDto dto)'
    Artinya, MessageService menerima sebuah object bertipe CreateMessageDto.
    Service tidak perlu mengetahui apakah data tersebut berasal dari Razor Page, API, atau bagian aplikasi lainnya.
    Itulah salah satu manfaat DTO.
    Untuk sekarang, method ini baru menghasilkan string sebagai simulasi pemrosesan. Belum ada database atau penyimpanan permanen.
*/
