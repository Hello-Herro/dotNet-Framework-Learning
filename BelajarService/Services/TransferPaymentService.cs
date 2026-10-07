using BelajarService.Interfaces;

namespace BelajarService.Services;
// ============================================================
// CLASS
//
// TransferPaymentService juga mengimplementasikan
// IPaymentService.
// ============================================================
public class TransferPaymentService : IPaymentService
{
    // ========================================================
    // METHOD
    // ========================================================
    public decimal CalculatePayment(decimal price)
    {
        return price + 2500;
    }
}
