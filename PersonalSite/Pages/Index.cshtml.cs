using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalSite.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            string remoteUri = "http://www.contoso.com/library/homepage/images/";
            string fileName = "ms-banner.gif", myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(myStringWebResource, fileName);
        }
        public void OnPost()
        {

        }
    }
}
