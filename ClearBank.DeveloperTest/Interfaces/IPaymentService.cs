using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Interfaces
{
    public interface IPaymentService
    {
        /// <summary>
        /// This method makes a payment from an account.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The payment result.</returns>
        MakePaymentResult MakePayment(MakePaymentRequest request);
    }
}
