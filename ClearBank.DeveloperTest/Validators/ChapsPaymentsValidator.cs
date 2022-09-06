using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Validators
{
    public class ChapsValidator : IValidator
    {
        public MakePaymentResult Validate(Account account, decimal requestAmount = 0)
        {
            var result = new MakePaymentResult();
            if (account != null && account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Chaps) &&
                account.Status == AccountStatus.Live)
            {
                result.Success = true;
            }
            return result;
        }
    }
}
