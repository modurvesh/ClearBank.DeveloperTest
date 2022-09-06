using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Services;
using ClearBank.DeveloperTest.Types;
using FizzWare.NBuilder;
using FluentAssertions;
using Xunit;

namespace ClearBank.DeveloperTest.Tests
{
    public class CalculatorServiceTests
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void DeductPaymentAmountFromAccountBalance_WithDeductRequest_Success()
        {
            // Arrange
            var account = Builder<Account>.CreateNew().With(x => x.Balance = 100).Build();

            // Act
            _calculatorService.DeductPaymentAmountFromAccountBalance(account, 10);

            // Assert
            account.Balance.Should().Be(90);
        }
    }
}
