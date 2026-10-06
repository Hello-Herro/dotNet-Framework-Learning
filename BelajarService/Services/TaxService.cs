namespace BelajarService.Services;

// ============================================================
// CLASS
// ============================================================
// TaxService adalah sebuah CLASS.
//
// Tanggung jawabnya:
// menghitung pajak.
// ============================================================

public class TaxService
{
    // ========================================================
    // METHOD
    // ========================================================
    // CalculateTaxPay digunakan untuk menghitung pajak
    // berdasarkan harga SETELAH diskon.
    //
    // Parameter:
    // - price          → harga awal
    // - discount       → nilai diskon
    // - taxPercentage  → persentase pajak
    //
    // Return:
    // - nilai pajak
    // ========================================================

    public decimal CalculateTaxPay(decimal price, decimal discount, decimal taxPercentage)
    {
        // Harga setelah diskon dikalikan persentase pajak.
        return (price - discount) * taxPercentage / 100;
    }

    // ========================================================
    // METHOD
    // ========================================================
    // CalculateTax digunakan untuk menghitung pajak
    // langsung dari harga awal.
    //
    // Parameter:
    // - price          → harga
    // - taxPercentage  → persentase pajak
    //
    // Return:
    // - nilai pajak
    // ========================================================

    public decimal CalculateTax(decimal price, decimal taxPercentage)
    {
        return price * taxPercentage / 100;
    }
}
