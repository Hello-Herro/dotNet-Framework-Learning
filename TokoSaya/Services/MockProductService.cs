using TokoSaya.Interfaces;

namespace TokoSaya.Services;

// ============================================================
// CLASS
//
// MockProductService adalah implementasi lain dari
// IProductService.
//
// Tujuannya untuk membuktikan bahwa implementation dapat
// diganti melalui DI Container.
// ============================================================
public class MockProductService : IProductService
{
    // ========================================================
    // FIELD
    // ========================================================
    private readonly Guid _id;

    // ========================================================
    // CONSTRUCTOR
    // ========================================================
    public MockProductService()
    {
        _id = Guid.NewGuid();
    }

    // ========================================================
    // METHOD
    //
    // Memenuhi contract IProductService.
    // ========================================================
    public string GetProductName()
    {
        return "Mock Product";
    }

    // ========================================================
    // METHOD
    //
    // Memenuhi contract IProductService.
    // ========================================================
    public Guid GetId()
    {
        return _id;
    }
}