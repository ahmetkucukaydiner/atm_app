namespace atm_app.Business
{
    internal interface ILogger
    {
        public void WriteFile(string message);
        public void ReadFile();
    }
}
