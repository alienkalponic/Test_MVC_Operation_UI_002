using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Test_MVC_Operation_UI_002.App_Start
{
    public class Constant
    {
        internal static string API_BASEURL = ConfigurationManager.AppSettings["URL"];
        internal static string UNAUTH_ACCESS = "Unauthorized Access";
        internal static string POST_INFORMATION = API_BASEURL + "api/Test_MVC_Operation_001/SaveUser";
        internal static string GET_FULL_DATA_SHOW = API_BASEURL + "api/Test_MVC_Operation_001/AllSearch";
        internal static string GET_PERSON_SEARCH = API_BASEURL + "api/Test_MVC_Operation_001/Mail_Search";
    }
}