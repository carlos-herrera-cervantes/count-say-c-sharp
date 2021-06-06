using CountSayDomain.Models;
using Xunit;

namespace CountSayTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void CountAndSay_Should_Return_Counter()
        {
            var number = 4;
            const string ExpectedResult = "1211";

            var result = SuperInteger.CountAndSay(number);

            Assert.Equal(result, ExpectedResult);
        }
    }
}