namespace Ardalis.GuardClauses
{
    public static class CustomGuardClauses
    {
        public static string InvalidEmailAddress(this IGuardClause guardClause, string email, string parameterName)
        {
            Guard.Against.NullOrEmpty(email, nameof(email), "Email address cannot be null or empty.");
            var emailSuffix = ".com";
            if (!email.EndsWith(emailSuffix, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException($"Email address must end in {emailSuffix}.");
            }
            return email;
        }

        public static string InvalidEmailAddressWithCustomEmailSuffix(this IGuardClause guardClause, string email, string customEmailAddressSuffix, string parameterName)
        {
            Guard.Against.NullOrEmpty(customEmailAddressSuffix, nameof(customEmailAddressSuffix), "Custom email address suffix cannot be null.");
            Guard.Against.NullOrEmpty(email, nameof(email), "Email address cannot be null or empty.");
            if (!email.EndsWith(customEmailAddressSuffix, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentNullException($"Email address must end in { customEmailAddressSuffix}.");
            }
            return email;
        }
    }
}
