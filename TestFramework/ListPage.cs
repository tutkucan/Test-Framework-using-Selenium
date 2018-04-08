using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class ListPage
    {
        public static class Page
        {
            public static string  Url = "https://www.shurgard.be/available-units?searchLocation=ghent&type=new";
            public static string PageTitle = "Reserveer gratis je opslagruimte";
            public static void GoTo()
            {
                Browser.GoTo(Url);
            }

            public static bool GoPage()
            {
                Browser.GoToPage();
                return Browser.IsPage(PageTitle);
            }
        }
    }
}
