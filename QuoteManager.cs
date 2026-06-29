namespace MegaDeskDemo
{
    public static class QuoteManager
    {
        private static readonly List<DeskQuote> quotes = new List<DeskQuote>();

        public static IReadOnlyList<DeskQuote> Quotes => quotes;

        public static void AddQuote(DeskQuote quote)
        {
            quotes.Add(quote);
        }
    }
}
