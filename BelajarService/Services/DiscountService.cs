namespace BelajarService.Services;

// ============================================================
// CLASS
// ============================================================
// DiscountService adalah sebuah CLASS.
// Tugas/tanggung jawab class ini:
// menghitung nilai diskon.
// ============================================================

public class DiscountService
{
    // ========================================================
    // METHOD
    // ========================================================
    // CalculateDiscount adalah METHOD.
    //
    // Method ini menerima:
    // - price             → harga barang
    // - discountPercentage → persentase diskon
    //
    // Method mengembalikan nilai bertipe decimal.
    // ========================================================

    public decimal CalculateDiscount(decimal price, decimal discountPercentage)
    {
        // Menghitung nilai diskon.
        return price * discountPercentage / 100;
    }
}
