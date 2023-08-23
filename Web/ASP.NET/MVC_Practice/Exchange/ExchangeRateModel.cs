namespace ExchangeRateApp.Models
{
    public class ExchangeRateModel
    {
        public double Dallar { get; set; }
        public double Euro { get; set; }
        public double Yen { get; set; }
        public double Yuan { get; set; }

        private const double DALLAR_PER_WON = 0.00075;
        private const double EURO_PER_WON = 1448.93;
        private const double YEN_PER_WON = 9.21;
        private const double YUAN_PER_WON = 185.65;

        public double getWON_PER_DALLAR()
        {
            return DALLAR_PER_WON;
        }

        public double getWON_PER_EURO()
        {
            return EURO_PER_WON;
        }

        public double getWON_PER_YEN()
        {
            return YEN_PER_WON;
        }

        public double getWON_PER_YUAN()
        {
            return YUAN_PER_WON;
        }
    }
}
