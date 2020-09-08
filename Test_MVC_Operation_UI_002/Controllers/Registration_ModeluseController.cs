using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Data;
using Test_MVC_Operation_UI_002.Models;
using Test_MVC_Operation_UI_002.App_Start;
using System.IO;
using System.Collections;
using RestSharp;
using System.Net;
using System.Security.AccessControl;
using System.Text;

namespace Test_MVC_Operation_UI_002.Controllers
{
    public class Registration_ModeluseController : Controller
    {
        // GET: Registration_Modeluse
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult saveUser()
        {
            InformaionModel igsm = new InformaionModel();
            List<SelectListItem> item_city = new List<SelectListItem>() {
                        new SelectListItem() { Text = "Select", Value = "", Selected = true },
                        new SelectListItem() { Text = "KOLKATA", Value = "KOLKATA" },
                        new SelectListItem() { Text = "DURGAPUR", Value = "DURGAPUR" },
                        new SelectListItem() { Text = "SILIGURI", Value = "SILIGURI" },
               };
            igsm.CityList = item_city;
            return View(igsm);
        }
        [HttpPost]
        public string Registration_Data_Save(InformaionModel ob)
        {
            if (Request.IsAjaxRequest())
            {
                string response = string.Empty;
                Registration_management rmm = new Registration_management();
                string url = Constant.POST_INFORMATION;
                List<object> postdata = new List<object>();
                SortedList<string, object> _postArrData = new SortedList<string, object>();
                _postArrData.Add("NAME",ob.NAME.Trim());
                _postArrData.Add("ADDRESS", ob.ADDRESS.Trim());
                _postArrData.Add("EMAIL_ID", ob.EMAIL_ID.Trim());
                _postArrData.Add("PHONE_NO", ob.PHONE_NO.Trim());
                _postArrData.Add("CITY", ob.CITY.Trim());
                _postArrData.Add("GENDER", ob.GENDER);
                postdata.Add(_postArrData);
                var _postContent = System.Web.Helpers.Json.Encode(postdata);
                response = rmm.student_basic_details(url,_postContent);
             
                return response;
            }
            else
            {
                return Constant.UNAUTH_ACCESS;
            }
        }
        [HttpGet]
        public string GET_Data_Show()
        {
            string response = string.Empty;
            Registration_management rmm = new Registration_management();
            response = rmm.Get_Table_Show();
            return response;
        }
        public string GET_Data_Search(string email_id) 
        {

            string response = string.Empty;
            Registration_management rmm = new Registration_management();
            List<object> postdata = new List<object>();
            SortedList<string, object> _postArrData = new SortedList<string, object>();
            _postArrData.Add("EMAIL_ID", email_id);
            postdata.Add(_postArrData);
            var _postContent = System.Web.Helpers.Json.Encode(postdata);
            response = rmm.Get_Table_Show_search(_postContent);
            return response;
        }

    }
}