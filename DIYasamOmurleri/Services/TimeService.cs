namespace DIYasamOmurleri.Services
{
    public class TimeService
    {
        private DateTime _olusturmaZamani = DateTime.Now;

        public DateTime GetTime()
        {
            return _olusturmaZamani;
        }
    }
}
