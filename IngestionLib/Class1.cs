using System.Net;
using static System.Net.WebRequestMethods;

namespace IngestionLib
{
    public class Class1
    {
       

        private static void Import2DB()
        {
            string url = "https://myth.fra1.digitaloceanspaces.com/misc/528%20%281%29.json";
            string file = "528%20%281%29.json";

            using (var client = new WebClient())
            {
                client.DownloadFile(url, file);
            }

        }

    }
}