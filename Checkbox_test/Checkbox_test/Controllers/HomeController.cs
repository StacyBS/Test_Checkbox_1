using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Checkbox_test.Models;
using Checkbox_test.ViewModel;
using Checkbox_test.Service;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace Checkbox_test.Controllers
{
    public class HomeController : Controller
    {
        MVCUseEntities db = new MVCUseEntities();
        SourceData sourceDataService = new SourceData();
            
        public ActionResult ShowData()
        {
            
            var Alldata = sourceDataService.GetAllData();
            var DropItem = sourceDataService.GetDropItem();
            
            SourceDataView dataView = new SourceDataView()
            {
                testData_Chk_Droplist = Alldata,
                droplistItem = DropItem
            };
            
            return View(dataView);
        }
        
        [HttpPost]
        public ActionResult ShowData([Bind(Include = "Id,TypeItem")]List<TestData_chk_droplist> vv)
        {
            //vv變數有成功接收到勾選項目之 Id & 下拉選單之value

            StringBuilder sb = new StringBuilder();
            //SqlConnection conn = new SqlConnection("server=localhost;database=MVCUse;UID=SQLAdmin;PWD=1234;");
            //conn.Open();
            if (vv.Count()>0)
            {
                foreach(var item in vv)
                {   
                    /*
                    //ado.net 解法(可以成功 Update 資料)
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Update TestData_chk_droplist set TypeItem = @type where Id=@id";
                        cmd.Connection = conn;

                        cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = item.TypeItem;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = item.Id;
                        cmd.ExecuteNonQuery();
                        sb.Append(item.Id).Append(" is Updated\n").ToString();
                    }
                    */
                    
                    //EF 解法 (也可以成功 Update 資料)
                    //測試:
                    var test1 = db.TestData_chk_droplist.Find(item.Id); //null
                    var UpdData = db.TestData_chk_droplist.Where(p => p.Id == item.Id).FirstOrDefault(); //null
                    UpdData.TypeItem = item.TypeItem;
                    db.SaveChanges();
                    //只是 我的困惑是為什麼 test1、UpdData都是null????
                }
            }
            //conn.Close();
            
           // ViewData["UpdResult1"] = sb.ToString();

            var Alldata = sourceDataService.GetAllData();            
            var DropItem = sourceDataService.GetDropItem();
            
            SourceDataView dataView = new SourceDataView()
            {
                testData_Chk_Droplist = Alldata,
                droplistItem = DropItem
            };
            
            return View(dataView);
        }
        
    }
}