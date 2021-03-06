using Loans.Domain.Applications.Values;
using NUnit.Framework;
using System;
using FluentAssertions;

namespace Loans.Tests
{
    public class LoanTermShould
    {
        [Test]        
        public void ReturnTermInMonths()
        {
            var sut = new LoanTerm(1);

            //Assert.That(sut.ToMonths(), Is.EqualTo(12));
            sut.ToMonths().Should().Be(12,"there are 12 in a year");
        }


        [Test]
        public void StoreYears()
        {
            var sut = new LoanTerm(1);

            Assert.That(sut.Years, Is.EqualTo(1));
        }


        [Test]
        public void RespectValueEquality()
        {
            var a = new LoanTerm(1);
            var b = new LoanTerm(1);

            Assert.That(a, Is.EqualTo(b));
        }


        [Test]
        public void RespectValueInequality()
        {
            var a = new LoanTerm(1);
            var b = new LoanTerm(2);

            Assert.That(a, Is.Not.EqualTo(b));
        }


        [Test]
        public void NotAllowZeroYears()
        {
            //Assert.That(() => new LoanTerm(0), 
            //            Throws.TypeOf<ArgumentOutOfRangeException>()
            //                  .With
            //                  .Matches<ArgumentOutOfRangeException>(
            //                           ex => ex.ParamName == "years"));

            Action action = () => new LoanTerm(0);
            action.Should().Throw<ArgumentOutOfRangeException>()
                .And
                .ParamName.Should().Be("years");
        }


        [Test]
        public void FloatingPointExample() {
            double pie = 1;
            double people = 3;
            double sliceOfPie = pie / people;

            //sliceOfPie.Should().Be(0.33);
            sliceOfPie.Should().BeApproximately(0.33, 0.004);
        }
    }
}
