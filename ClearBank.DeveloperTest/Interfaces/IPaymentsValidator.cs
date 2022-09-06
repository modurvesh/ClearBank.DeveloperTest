using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Interfaces
{
    public interface IPaymentsValidatorService
    {
        /// <summary>
        /// This method validates a payment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The payment result.</returns>
        MakePaymentResult ValidatePayment(PaymentScheme paymentScheme, Account account, decimal amount = 0);
    }
}
