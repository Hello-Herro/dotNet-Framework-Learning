using TokoSaya.Interfaces;

namespace TokoSaya.Services;

// ============================================================
// SERVICE
// ============================================================
// ProductService adalah class yang bertanggung jawab
// menyediakan informasi Product.
// ============================================================

public class ProductService : IProductService
{
    // Field untuk menyimpan ID Object
    private readonly Guid _id;

    // Constructor
    public ProductService()
    {
        _id = Guid.NewGuid();
    }

    // ========================================================
    // METHOD
    // Memenuhi contract IProductService
    // ========================================================
    public string GetProductName()
    {
        return "Laptop ASUS";
    }

    // ========================================================
    // METHOD
    // Memenuhi contract IProductService
    // ========================================================

    public Guid GetId()
    {
        return _id;
    }
}
