using TokoSaya.Interfaces;

namespace TokoSaya.Services;

// ============================================================
// CLASS
//
// ProductCheckerService adalah service kedua yang juga
// membutuhkan IProductService.
//
// ProductCheckerService tidak bergantung langsung pada
// ProductService.
// ============================================================
public class ProductCheckerService
{
    // ========================================================
    // FIELD / DEPENDENCY
    // ========================================================
    // IProductService adalah dependency dari
    // ProductCheckerService.
    //
    // Kita bergantung pada INTERFACE / CONTRACT,
    // bukan class konkret.
    // ========================================================
    private readonly IProductService _productService;

    // ========================================================
    // CONSTRUCTOR
    //
    // Constructor menerima IProductService melalui
    // Constructor Injection.
    // ========================================================
    public ProductCheckerService(IProductService productService)
    {
        _productService = productService;
    }

    // ========================================================
    // METHOD
    //
    // Mengambil ID dari ProductService melalui
    // contract IProductService.
    // ========================================================
    public Guid GetProductServiceId()
    {
        return _productService.GetId();
    }
}