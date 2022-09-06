using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IAccountService _accountService;
        private readonly ICalculatorService _calculatorService;
        private readonly IPaymentsValidatorService _paymentsValidator;

        public PaymentService(IAccountService accountService, ICalculatorService calculatorService, IPaymentsValidatorService paymentsValidator)
        {
            _accountService = accountService;
            _calculatorService = calculatorService;
            _paymentsValidator = paymentsValidator;
        }

        public MakePaymentResult MakePayment(MakePaymentRequest request)
        {
            Account account = _accountService.GetAccount(request.DebtorAccountNumber);
            MakePaymentResult makePaymentResult = _paymentsValidator.ValidatePayment(request.PaymentScheme, account, request.Amount);

            if (!makePaymentResult.Success)
                return makePaymentResult;

            _calculatorService.DeductPaymentAmountFromAccountBalance(account, request.Amount);
            _accountService.UpdateAccount(account);

            return makePaymentResult;
        }
    }
}
