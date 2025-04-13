using Ardalis.GuardClauses;

namespace GuardClausesInASPNETCore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ThrowsArgumentNullExceptionIfNullOrEmptyEmail()
        {
            string? emailAddress = null;
            Assert.Throws<ArgumentNullException>(() => 
                { 
                    Guard.Against.InvalidEmailAddress(emailAddress, nameof(emailAddress)); 
                }
            );
        }

        [Fact]
        public void ThrowsArgumentExceptionIfEmailDoesNotEndInCorrectSuffix()
        {
            string? emailAddress = "customer@example.net";

            Assert.Throws<ArgumentException>(() =>
            { 
                Guard.Against.InvalidEmailAddress(emailAddress, nameof(emailAddress)); 
            }
            );
        }

        [Fact]
        public void ReturnsEmailAddressGivenValidEmail()
        {
            string? emailAddress = "customer@example.com";

            var result = Guard.Against.InvalidEmailAddress(emailAddress, nameof(emailAddress)); 

            Assert.Equal(result, emailAddress);
        }
    }
}