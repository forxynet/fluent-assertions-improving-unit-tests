using Loans.Domain.Applications.Values;
using NUnit.Framework;
using FluentAssertions;

namespace Loans.Tests
{
    public class LoanAmountShould
    {
        [Test]
        public void StoreCurrencyCode()
        {
            var sut = new LoanAmount("USD", 100_000);

            //Assert.That(sut.CurrencyCode, Is.EqualTo("USD"));
            sut.CurrencyCode.Should().Be("USD");
            sut.CurrencyCode.Should().Contain("U");
            sut.CurrencyCode.Should().Match("*D");
            sut.CurrencyCode.Should().BeOneOf("USD", "AUD", "GBP");
                    

        }
    }
}
