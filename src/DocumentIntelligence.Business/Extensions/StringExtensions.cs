namespace DocumentIntelligence.Business.Extensions
{
    public static class StringExtensions
    {
        public static string GetMimeTypeFromBase64(this string base64String)
        {
            int indexOfMime = base64String.IndexOf("data:", StringComparison.OrdinalIgnoreCase);
            int indexOfBase64 = base64String.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);

            if (indexOfMime >= 0 && indexOfBase64 > indexOfMime)
            {
                return base64String.Substring(indexOfMime + 5, indexOfBase64 - indexOfMime - 6);
            }

            throw new FormatException("The base64 string does not contain a valid MIME type prefix.");
        }

        public static string GetCompatibleBase64String(this string base64String)
        {
            int indexOfBase64 = base64String.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);

            if (indexOfBase64 >= 0)
            {
                return base64String.Substring(indexOfBase64 + 7);
            }

            throw new FormatException("The base64 string does not contain a valid Data URI prefix.");
        }
    }
}
