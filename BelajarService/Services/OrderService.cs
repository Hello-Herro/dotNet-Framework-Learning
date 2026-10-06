namespace BelajarService.Services;

// ============================================================
// CLASS
// ============================================================
// OrderService adalah sebuah CLASS.
//
// Tanggung jawab:
// Mengatur proses perhitungan total sebuah Order.
//
// Order membutuhkan:
// - DiscountService
// - TaxService
//
// Kedua object tersebut merupakan DEPENDENCY dari OrderService.
// ============================================================

public class OrderService
{
    // ========================================================
    // FIELD
    // ========================================================
    // Field adalah variable yang disimpan sebagai bagian
    // dari object/class.
    //
    // DiscountService adalah DEPENDENCY
    // dari OrderService karena OrderService membutuhkannya.
    // ========================================================

    private DiscountService discountService;

    // ========================================================
    // FIELD
    // ========================================================
    // TaxService juga merupakan DEPENDENCY
    // dari OrderService.
    // ========================================================

    private TaxService taxService;

    // ========================================================
    // CONSTRUCTOR
    // ========================================================
    // Constructor adalah method khusus yang otomatis dijalankan
    // ketika object OrderService dibuat menggunakan "new".
    //
    // Constructor ini membutuhkan:
    // - DiscountService
    // - TaxService
    //
    // Kedua dependency tersebut DIKIRIM/DIBERIKAN
    // dari luar kepada OrderService.
    //
    // Proses memberikan dependency dari luar inilah yang
    // disebut DEPENDENCY INJECTION.
    // ========================================================

    public OrderService(DiscountService discountService, TaxService taxService) // ini adalah Constructor
    {
        // ====================================================
        // MENYIMPAN DEPENDENCY
        // ====================================================
        // "this.discountService" → field milik OrderService
        //
        // "discountService" → parameter constructor
        //
        // Jadi dependency yang diberikan dari luar disimpan
        // agar bisa digunakan oleh method di dalam OrderService.
        // ====================================================

        this.discountService = discountService;

        // Menyimpan TaxService yang diberikan dari luar atau menyimpan dependency tersebut ke dalam object OrderService
        this.taxService = taxService;
    }

    // ========================================================
    // METHOD
    // ========================================================
    // CalculateTotal adalah METHOD.
    //
    // Tugasnya:
    // menghitung total order setelah diskon dan pajak.
    // ========================================================

    public decimal CalculateTotal(decimal price, decimal discountPercentage, decimal taxPercentage)
    {
        // ====================================================
        // MEMANGGIL DEPENDENCY
        // ====================================================
        // OrderService meminta DiscountService menghitung
        // nilai diskon.
        // ====================================================

        decimal discount = discountService.CalculateDiscount(price, discountPercentage);

        // ====================================================
        // MEMANGGIL DEPENDENCY
        // ====================================================
        // OrderService meminta TaxService menghitung
        // nilai pajak setelah diskon.
        // ====================================================

        decimal tax = taxService.CalculateTaxPay(price, discount, taxPercentage);

        // Mengembalikan total akhir:
        //
        // harga - diskon + pajak
        // ====================================================

        return (price - discount) + tax;
    }
}
