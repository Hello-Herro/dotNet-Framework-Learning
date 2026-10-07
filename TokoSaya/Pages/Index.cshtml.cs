using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TokoSaya.Services; // agar C# tau kita ingin menggunakan ProductService
using TokoSaya.Interfaces;

namespace TokoSaya.Pages;

// ============================================================
// IndexModel adalah class yang digunakan oleh:
// Pages/Index.cshtml
//
// Class ini mewakili logic dari halaman Index.
// ============================================================
public class IndexModel : PageModel
{
    // ========================================================
    // FIELD / DEPENDENCY
    // ========================================================
    // ILogger adalah dependency bawaan yang diberikan
    // oleh ASP.NET Core.
    //
    // Untuk sekarang kita belum fokus pada ILogger.
    // ========================================================
    private readonly ILogger<IndexModel> _logger;

    // ========================================================
    // FIELD / DEPENDENCY
    // ========================================================
    // ProductService adalah DEPENDENCY dari IndexModel.
    //
    // Mengapa?
    // Karena IndexModel membutuhkan ProductService
    // untuk mendapatkan informasi Product.
    // ========================================================
    private readonly IProductService _productService;

    private readonly ProductCheckerService _productCheckerService;

    // ========================================================
    // CONSTRUCTOR
    // ========================================================
    // Constructor dijalankan ketika object IndexModel dibuat.
    //
    // Constructor menerima dua dependency:
    //
    // 1. ILogger<IndexModel>
    // 2. ProductService
    //
    // ASP.NET Core DI Container akan menyediakan kedua
    // dependency tersebut kepada IndexModel.
    //
    // Proses memberikan dependency melalui constructor
    // disebut CONSTRUCTOR INJECTION.
    // ========================================================
    public IndexModel(
        ILogger<IndexModel> logger,
        IProductService productService,
        ProductCheckerService productCheckerService
    ) // ProductService productService Ini adalah dependency yang diterima constructor.
    {
        _logger = logger; // Menyimpan ILogger ke field _logger.
        _productService = productService; // Menyimpan ProductService ke field _productService.
        _productCheckerService = productCheckerService;
    }

    // ========================================================
    // PROPERTY
    // ========================================================
    // Property untuk menyimpan nama Product yang akan
    // ditampilkan pada halaman.
    // ========================================================

    // public string ProductName { get; private set; } = "";

    // ========================================================
    // PROPERTY
    //
    // Property ini akan menyimpan ID dari ProductService
    // yang nantinya ditampilkan oleh Index.cshtml
    // ========================================================
    public string ProductId { get; private set; } = "";
    public string ProductCheckerId { get; private set; } = "";

    public void OnGet()
    {
        // Mengambil ID langsung dari ProductService
        ProductId = _productService.GetId().ToString();

        // Mengambil ID ProductService melalui ProductCheckerService
        ProductCheckerId = _productCheckerService.GetProductServiceId().ToString();

        // Memanggil method GetProductName()
        // dari ProductService.
        //
        // Hasil:
        // "Laptop ASUS"
        //
        // Kemudian hasilnya disimpan ke ProductName.
        // ProductName = _productService.GetProductName();
    }
}
