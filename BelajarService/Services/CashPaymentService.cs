using BelajarService.Interfaces;

namespace BelajarService.Services;

public class CashPaymentService : IPaymentService
{
    public decimal CalculatePayment(decimal price)
    {
        return price;
    }
}
