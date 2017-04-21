using System.IO;

namespace Net.Chdk.Model.Card
{
    public static class CardInfoExtensions
    {
        public static string GetRootPath(this CardInfo cardInfo)
        {
            return $"{cardInfo.DriveLetter}\\";
        }

        public static string GetMetadataPath(this CardInfo cardInfo)
        {
            var rootPath = GetRootPath(cardInfo);
            return Path.Combine(rootPath, "METADATA");
        }

        public static string GetDcimPath(this CardInfo cardInfo)
        {
            var rootPath = GetRootPath(cardInfo);
            return Path.Combine(rootPath, "DCIM");
        }

        public static string GetDiskbootPath(this CardInfo cardInfo)
        {
            var rootPath = GetRootPath(cardInfo);
            return Path.Combine(rootPath, "DISKBOOT.BIN");
        }
    }
}
