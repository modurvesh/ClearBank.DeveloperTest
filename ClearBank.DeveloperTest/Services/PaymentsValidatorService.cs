using System.Collections.Generic;
using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Validators;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Services
{
    public class PaymentsValidatorService : IPaymentsValidatorService
    {
        public Dictionary<PaymentScheme, IValidator> Validators { get; set; }

        public PaymentsValidatorService()
        {
            Validators = new Dictionary<PaymentScheme, IValidator>
            {
                {PaymentScheme.Bacs, new BacsValidator()},
                {PaymentScheme.FasterPayments, new FasterPaymentsValidator()},
                {PaymentScheme.Chaps, new ChapsValidator()}
            };
        }

        public MakePaymentResult ValidatePayment(PaymentScheme paymentScheme, Account account, decimal amount = 0)
        {
            return Validators[paymentScheme].Validate(account, amount);
        }
    }
}
