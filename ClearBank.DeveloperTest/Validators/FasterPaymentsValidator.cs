using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Validators
{
    public class FasterPaymentsValidator : IValidator
    {
        public MakePaymentResult Validate(Account account, decimal requestAmount = 0)
        {
            var result = new MakePaymentResult();
            if (account != null && account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.FasterPayments) &&
                requestAmount != 0 && account.Balance > requestAmount)
            {
                result.Success = true;
            }
            return result;
        }
    }
}
