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
    string GetProductName();

    Guid GetId();
}
