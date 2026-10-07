using BelajarService.Interfaces;

namespace BelajarService.Services;
// ============================================================
// CLASS
//
// ProductService adalah implementasi dari
// IProductService.
// ============================================================
public class ProductService : IProductService
{
    // ========================================================
    // METHOD
    //
    // Karena ProductService mengimplementasikan
    // IProductService, maka method ini wajib tersedia.
    // ========================================================
    public string GetProductName()
    {
        return "Laptop ASUS";
    }
}