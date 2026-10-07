// ============================================================
// USING
// ============================================================
// Memberitahu C# bahwa kita ingin menggunakan class yang
// berada di namespace BelajarService.Services.
//
// Di dalam namespace tersebut terdapat:
// - DiscountService
// - TaxService
// - OrderService
// ============================================================
using BelajarService.Interfaces;
using BelajarService.Services;

// ============================================================
// OBJECT
//
// Membuat object ProductService.
// Membuat object cashPayment.
// Membuat object transferPayment.
// ============================================================
ProductService productService = new ProductService();
IPaymentService cashPayment = new CashPaymentService();
IPaymentService transferPayment = new TransferPaymentService();

// ============================================================
// MEMBUAT OBJECT DISCOUNT SERVICE
// ============================================================
// "new DiscountService()" membuat OBJECT baru
// dari class DiscountService.
//
// discountService adalah variable yang menyimpan object tersebut.
// ============================================================
DiscountService discountService = new DiscountService(); // huruf kapital untuk mengikuti konvensi penamaan disebut PascalCase untuk Class

// ============================================================
// MEMBUAT OBJECT TAX SERVICE
// ============================================================
TaxService taxService = new TaxService(); // huruf kapital untuk mengikuti konvensi penamaan disebut camelCase untuk Variabel

// ============================================================
// DEPENDENCY INJECTION SECARA MANUAL
// ============================================================
// OrderService membutuhkan:
// - DiscountService
// - TaxService
//
// Kedua object tersebut kita berikan kepada constructor
// OrderService.
//
// Inilah yang disebut DEPENDENCY INJECTION.
//
// Program.cs bertugas membuat dependency,
// kemudian memberikannya kepada OrderService.
// ============================================================
OrderService orderService = new OrderService(discountService, taxService);

// ============================================================
// METHOD CALL
// ============================================================
Console.WriteLine("=== Interface + Service ===");
string productName = productService.GetProductName();

Console.WriteLine(productName);

// ============================================================
// METHOD CALL Contract yang sama
// ============================================================
decimal cashResult = cashPayment.CalculatePayment(100000);

decimal transferResult = transferPayment.CalculatePayment(100000);

Console.WriteLine($"Cash        : {cashResult}");
Console.WriteLine($"Transfer    : {transferResult}\n");

// ============================================================
// DATA ORDER
// ============================================================
decimal price = 100000;
decimal discountPercentage = 10;
decimal taxPercentage = 11;

// ============================================================
// MENGGUNAKAN DISCOUNT SERVICE
// ============================================================
// Meminta DiscountService menghitung nilai diskon.
//
// Hasilnya disimpan ke variable "discount".
// ============================================================
decimal discount = discountService.CalculateDiscount(price, discountPercentage); // Kita meminta object discountService menjalankan: method CalculateDiscount()

// ============================================================
// MENGGUNAKAN TAX SERVICE
// ============================================================
// Menghitung pajak berdasarkan harga awal.
//
// Variable "tax" menyimpan nilai pajak.
// ============================================================
decimal tax = taxService.CalculateTax(price, taxPercentage);

// ============================================================
// MENGGUNAKAN TAX SERVICE SETELAH DISKON
// ============================================================
// Menghitung pajak berdasarkan harga setelah diskon.
//
// Ini digunakan untuk menampilkan informasi tambahan.
// ============================================================
decimal taxpay = taxService.CalculateTaxPay(price, discount, taxPercentage);

// ============================================================
// MENGGUNAKAN ORDER SERVICE
// ============================================================
// Sekarang kita meminta OrderService menghitung total.
//
// OrderService sendiri akan:
// 1. Meminta DiscountService menghitung diskon
// 2. Meminta TaxService menghitung pajak
// 3. Menghitung total akhir
// ============================================================
decimal total = orderService.CalculateTotal(price, discountPercentage, taxPercentage);

// ============================================================
// OUTPUT
// ============================================================
Console.WriteLine("=== Discount Service ===");
Console.WriteLine($"Harga           : Rp. {price}");
Console.WriteLine($"Diskon          : {discountPercentage}%");
Console.WriteLine($"Nilai diskon    : {discount}");
Console.WriteLine($"Harga akhir     : Rp. {price - discount}\n");

Console.WriteLine("=== Tax Service ===");
Console.WriteLine($"Harga           : Rp. {price}");
Console.WriteLine($"Tax             : {taxPercentage}%");
Console.WriteLine($"Nilai pajak     : Rp. {tax}");
Console.WriteLine($"Harga akhir     : Rp. {price + tax}\n");

Console.WriteLine("=== Discount + Tax ===");
Console.WriteLine($"Harga                   : Rp. {price}");
Console.WriteLine($"Diskon                  : Rp. {discountPercentage}");
Console.WriteLine($"Harga setelah diskon    : Rp. {price - discount}");
Console.WriteLine($"Pajak                   : Rp. {taxpay}");
Console.WriteLine($"Total                   : RP. {(price - discount) + taxpay}\n");

Console.WriteLine("=== ORDER ===");
Console.WriteLine($"Harga       : Rp. {price}");
Console.WriteLine($"Diskon      : {discountPercentage}%");
Console.WriteLine($"Pajak       : {taxPercentage}%");
Console.WriteLine($"Total       : Rp. {total}\n");
