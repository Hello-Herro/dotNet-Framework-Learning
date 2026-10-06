using TokoSaya.Services;

// ============================================================
// CREATE BUILDER
// ============================================================
// Membuat builder yang digunakan untuk menyiapkan dan mengkonfigurasi aplikasi ASP.NET Core.
// ============================================================
var builder = WebApplication.CreateBuilder(args); // var builder adalah default variabel dengan tipe data var yang dibuat secara otomatis, beserta method bawaan yaitu "WebApplication.CreateBuilder(args);"

// args adalah parameter command-line yang diterima oleh aplikasi.
// CreateBuilder() artinya membuat sebuah builder, yaitu object yang akan kita gunakan untuk menyiapkan dan mengatur aplikasi sebelum aplikasi dibuat dan dijalankan.

// ============================================================
// SERVICE REGISTRATION
// ============================================================
// Mendaftarkan ProductService ke DI Container ASP.NET Core.
//
// Artinya:
// "ASP.NET Core, ProductService adalah service yang dapat
// digunakan oleh aplikasi."
//
// AddScoped akan kita pelajari secara khusus nanti.
// Untuk sekarang cukup pahami bahwa ProductService
// sedang DIDAFTARKAN ke DI Container.
// ============================================================
builder.Services.AddScoped<ProductService>();

// ============================================================
// RAZOR PAGES REGISTRATION
// ============================================================
// Mendaftarkan kebutuhan Razor Pages.
// ============================================================
builder.Services.AddRazorPages(); // AddRazorPages() digunakan untuk mendaftarkan/mengaktifkan kebutuhan Razor Pages pada aplikasi.

// ============================================================
// BUILD APPLICATION
// ============================================================
// Membentuk aplikasi berdasarkan konfigurasi
// yang sudah kita siapkan melalui builder.
// ============================================================
var app = builder.Build(); // Artinya: Setelah konfigurasi yang diperlukan disiapkan melalui builder, sekarang buat/bentuk aplikasi app berdasarkan konfigurasi tersebut.

// ============================================================
// DEVELOPMENT / PRODUCTION CONFIGURATION
// ============================================================
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Menangani error ketika aplikasi berjalan
    // pada environment selain Development.
    app.UseExceptionHandler("/Error");

    // Mengaktifkan HTTP Strict Transport Security.
    app.UseHsts();
}

// ============================================================
// MIDDLEWARE
// ============================================================
// Bagian ini mengatur bagaimana HTTP request diproses
// oleh aplikasi.
//
// Kita akan membahas middleware secara khusus nanti.
// Untuk sekarang jangan dipelajari semuanya.
// ============================================================

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ============================================================
// RAZOR PAGES
// ============================================================
// Memberitahu aplikasi bahwa Razor Pages digunakan
// untuk menangani request halaman.
// ============================================================
app.MapRazorPages();

app.Run(); // Artinya: memerintahkan aplikasi untuk mulai berjalan dan menerima HTTP request.
