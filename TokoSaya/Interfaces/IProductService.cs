namespace TokoSaya.Interfaces;

// ============================================================
// INTERFACE
//
// IProductService adalah contract untuk ProductService.
// ============================================================
public interface IProductService
{
    // ========================================================
    // METHOD CONTRACT
    // ========================================================
    string GetProductName();    // Method untuk Mengembalikan "Product Testing" atau "Laptop Asus" sesuai Depedency yang digunakan/didaftarkan jika ingin dipanggil

    Guid GetId();   // Mengembalikan _id
}
