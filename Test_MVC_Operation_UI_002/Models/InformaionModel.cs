using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Test_MVC_Operation_UI_002.App_Start;
using RestSharp;
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using RestSharp.Deserializers;

using System.Linq;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_MVC_Operation_UI_002.Models
{
    public class InformaionModel
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string EMAIL_ID { get; set; }
        public string PHONE_NO { get; set; }
        public string CITY { get; set; }
        public string GENDER { get; set; }
        public List<SelectListItem> CityList = new List<SelectListItem>();
    }
    public class Registration_management
    {
        public string student_basic_details(string url, string jsondata)
        {
            var client1 = new RestSharp.RestClient(url);
            var request1 = new RestRequest(Method.POST);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            request1.RequestFormat = DataFormat.Json;
            request1.AddHeader("Content-Type", "application/json");
            request1.AddParameter("application/json", jsondata, ParameterType.RequestBody);
            IRestResponse response = client1.Execute(request1);
            string responsedata = response.Content.ToString();
            return responsedata;
        }
        public string Get_Table_Show()
        {
            var client1 = new RestSharp.RestClient(Constant.GET_FULL_DATA_SHOW);
            var request1 = new RestRequest(Method.GET);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            request1.RequestFormat = DataFormat.Json;
            request1.AddHeader("Content-Type", "application/json");
            request1.AddParameter("application/json", ParameterType.RequestBody);
            request1.AddHeader("Content-Type", "application/json");
            IRestResponse response = client1.Execute(request1);
            string responsedata = response.Content.ToString();
            return responsedata;
        }
        public string Get_Table_Show_search(string _postContent)
        {
            var client1 = new RestSharp.RestClient(Constant.GET_PERSON_SEARCH);
            var request1 = new RestRequest(Method.GET);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            request1.RequestFormat = DataFormat.Json;
            request1.AddHeader("Content-Type", "application/json");
            request1.AddParameter("application/json", _postContent, ParameterType.HttpHeader);
            request1.AddHeader("Content-Type", "application/json");
            IRestResponse response = client1.Execute(request1);
            string responsedata = response.Content.ToString();
            return responsedata;
        }
    }
}