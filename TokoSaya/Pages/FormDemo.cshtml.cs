using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TokoSaya.Models;
using TokoSaya.Models.DTOs;
using TokoSaya.Services;

namespace TokoSaya.Pages;

// Fungsi dari Class FormDemoModel: Menangani request GET/POST, binding, validasi, dan alur halaman.

// ============================================================
// PAGE MODEL
// Menangani HTTP GET, POST, Model Binding, dan Validation.
// ============================================================
public class FormDemoModel : PageModel
{
    // FIELD / DEPENDENCY
    // Service yang akan memproses DTO.
    private readonly MessageService _messageService;

    // ========================================================
    // BIND PROPERTY
    // Menerima seluruh data dari MessageFormModel.
    // ========================================================
    [BindProperty]
    public MessageFormModel Input { get; set; } = new MessageFormModel();

    // Sebelumnya mempunyai dua property Name dan Message, sekarang diganti menjadi satu property Input yang menampung seluruh data dari MessageFormModel.
    // Kita membuat object MessageFormModel dan menyimpannya dalam property bernama Input.

    // PROPERTY
    // Menyimpan HTTP Method yang sedang diproses.
    public string RequestMethod { get; private set; } = string.Empty;

    // PROPERTY
    // Menyimpan hasil pemrosesan form.
    public string Result { get; private set; } = string.Empty;

    // CONSTRUCTOR INJECTION
    public FormDemoModel(MessageService messageService)
    {
        _messageService = messageService;
    }

    // ========================================================
    // HANDLER: HTTP GET
    // Dijalankan ketika halaman dibuka.
    // ========================================================
    public void OnGet()
    {
        RequestMethod = HttpContext.Request.Method;
    }

    // ========================================================
    // HANDLER: HTTP POST
    // Dijalankan ketika pengguna mengirim form.
    // ========================================================
    public void OnPost()
    {
        RequestMethod = HttpContext.Request.Method;

        // Memeriksa seluruh aturan validasi property.
        if (!ModelState.IsValid)
        {
            return;
        }
        // ModelState adalah objek yang menyimpan informasi hasil model binding dan validasi.
        // Sedangkan:
        //      'ModelState.IsValid'
        // menghasilkan nilai boolean:
        // - true: tidak ada kesalahan validasi yang tercatat.
        // - false: terdapat kesalahan model binding atau validasi.
        // Tanda ! berarti negasi atau kebalikan.
        // dibaca: Jika ModelState tidak valid, hentikan pemrosesan berikutnya.

        // Membuat DTO berdasarkan data form.
        var dto = new CreateMessageDto { Name = Input.Name, Message = Input.Message };

        // Mengirim DTO kepada MessageService.
        Result = _messageService.CreateMessage(dto);

        // Sebelumnya, kita membuat hasil pemrosesan langsung di PageModel:
        // // Jika semua validasi lolos, proses data.
        // Result = $"Data diterima: Nama = {Input.Name}; Pesan = {Input.Message}";

        /*
            Sekarang, kita mengubahnya menjadi tiga tahap.
            1. Membuat DTO berdasarkan data form.
            2. Mengirim DTO kepada MessageService.
            3. MessageService memproses DTO dan mengembalikan hasilnya.            
        */
    }
}
