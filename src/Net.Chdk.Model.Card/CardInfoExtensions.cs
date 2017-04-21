namespace Net.Chdk.Model.Card
{
    public static class CardInfoExtensions
    {
        public static string GetRootPath(this CardInfo cardInfo)
        {
            return $"{cardInfo.DriveLetter}\\";
        }
    }
}
