using System;
using TokoSaya.Interfaces;

namespace TokoSaya.Services;

// ============================================================
// CLASS
// FakeProductService merupakan implementation dari
// interface IProductService.
// ============================================================
public class FakeProductService : IProductService
{
    // ========================================================
    // FIELD
    // Menyimpan ID untuk object FakeProductService ini.
    // ========================================================
    private readonly Guid _id;  // _id digunakan untuk menyimpan ID object. Tipe Guid merupakan tipe data untuk nilai identitas unik.

    // ========================================================
    // CONSTRUCTOR
    // Membuat ID ketika object dibuat.
    // ========================================================
    public FakeProductService() // Constructor ini, Ketika object FakeProductService dibuat, constructor membuat ID baru dan menyimpannya di _id.
    {
        _id = Guid.NewGuid();   
    }

    // ========================================================
    // METHOD
    // Mengimplementasikan method pertama dari IProductService.
    // ========================================================
    public string GetProductName()
    {
        return "Product Testing";
    }

    // ========================================================
    // METHOD
    // Mengimplementasikan method kedua dari IProductService.
    // ========================================================
    public Guid GetId() // Method ini mengembalikan ID yang sudah tersimpan.
    {
        return _id;
    }
    // Mengapa tidak langsung menulis return Guid.NewGuid() di dalam GetId()?
    // Karena setiap pemanggilan method tersebut akan menghasilkan ID baru. Kita ingin ID tetap sama selama menggunakan object yang sama, sehingga bisa menguji perilaku service lifetime dengan benar.
}
