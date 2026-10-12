using TokoSaya.Interfaces;
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
// ===== Depedency Injection (DI) Container =====
// berfungsi untuk Registration / Mendaftarkan Interface / Service dan jika di minta, DI akan memberikan Object nya
// Registration untuk Interface & Service Product
builder.Services.AddScoped<IProductService, ProductService>(); // Artinya Kalau ada yang meminta IProductService → berikan ProductService

// builder.Services.AddScoped<IProductService, FakeProductService>();  // Artinya Kalau ada yang meminta IProductService → berikan FakeProductService

// Registration Interface & Service Notification
/*
    Bacanya: Ketika ada bagian aplikasi meminta INotificationService, DI Container menyediakan EmailNotificationService.
    Sedangkan AddScoped menentukan lifetime service: satu instance untuk setiap scope, yang pada request HTTP ASP.NET Core biasanya berarti satu instance per request.
*/
// Registration pertama: Email
builder.Services.AddScoped<INotificationService, EmailNotificationService>();

// Registration kedua: SMS
builder.Services.AddScoped<INotificationService, SmsNotificationService>();

// Registrasi factory yang memilih implementation.
builder.Services.AddScoped<NotificationServiceFactory>();

// Registration untuk Service Product
// builder.Services.AddScoped<ProductService>();
// builder.Services.AddTransient<ProductService>();
// builder.Services.AddSingleton<ProductService>();

// Registration untuk ProductCheckerService
builder.Services.AddScoped<ProductCheckerService>();

// builder.Services.AddScoped<IProductService, MockProductService>();
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
