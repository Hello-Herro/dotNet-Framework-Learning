using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TokoSaya.Pages.Products;

// ============================================================
// PAGE MODEL
// Menangani request untuk halaman detail produk.
// ============================================================
public class DetailsModel : PageModel
{
    // PROPERTY
    // Menyimpan ID produk dari route parameter.
    public int ProductId { get; private set; }

    // PROPERTY
    // Menyimpan nama produk untuk ditampilkan.
    public string ProductName { get; private set; } = string.Empty;

    // ========================================================
    // METHOD: OnGet()
    // Menerima Product ID dari route parameter.
    // ========================================================
    public void OnGet(int id)
    {
        // Menyimpan ID yang diterima dari URL.
        ProductId = id;

        // Data sementara untuk latihan.
        ProductName = $"Produk dengan ID {id}";
    }
}
