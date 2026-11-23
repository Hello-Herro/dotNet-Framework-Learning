using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TokoSaya.Pages;

// ============================================================
// PAGE MODEL
// Menampilkan informasi HTTP Request yang diterima server.
// ============================================================
public class RequestDemoModel : PageModel
{
    // PROPERTY: menyimpan HTTP method.
    public string RequestMethod { get; private set; } = string.Empty;

    // PROPERTY: menyimpan path request.
    public string RequestPath { get; private set; } = string.Empty;

    // PROPERTY: menyimpan query string.
    public string RequestQueryString { get; private set; } = string.Empty;

    // PROPERTY: menyimpan parameter name.
    public string NameParameter { get; private set; } = string.Empty;

    // PROPERTY: menyimpan parameter channel.
    public string ChannelParameter { get; private set; } = string.Empty;

    // PROPERTY: menyimpan status code response.
    public int ResponseStatusCode { get; private set; }

    // ========================================================
    // METHOD: OnGet()
    // Dijalankan saat Razor Page menerima HTTP GET request.
    // ========================================================
    public void OnGet(string? name, string? channel)
    {
        // Mengambil informasi dari HTTP Request.
        RequestMethod = HttpContext.Request.Method;
        RequestPath = HttpContext.Request.Path;

        RequestQueryString = HttpContext.Request.QueryString.HasValue
            ? HttpContext.Request.QueryString.Value!
            : "(tidak ada query string)";

        // Parameter ini diikat dari query string oleh ASP.NET Core.
        NameParameter = string.IsNullOrWhiteSpace(name) ? "(tidak diberikan)" : name;

        ChannelParameter = string.IsNullOrWhiteSpace(channel) ? "(tidak diberikan)" : channel;

        // Status code saat ini. Untuk request yang berhasil,
        // umumnya nilainya 200.
        ResponseStatusCode = HttpContext.Response.StatusCode;
    }
}
