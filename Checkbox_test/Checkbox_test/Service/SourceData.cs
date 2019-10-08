using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Checkbox_test.Models;

namespace Checkbox_test.Service
{
    public class SourceData
    {
        MVCUseEntities db = new MVCUseEntities();
        public List<TestData_chk_droplist> GetAllData()
        {
            var data = db.TestData_chk_droplist;
            List<TestData_chk_droplist> alldata=new List<TestData_chk_droplist>();
            foreach (var item in data)
            {
                alldata.Add(new TestData_chk_droplist { Id = item.Id, Names = item.Names,
                    Content = item.Content, TypeItem = item.TypeItem });
            }
            return alldata;
        }

        public List<SelectListItem> GetDropItem()
        {
            var DropItem = (from s in db.droplistItem select s).ToList();
            List<SelectListItem> ss=new List<SelectListItem>();
            foreach(var item in DropItem)
            {
                ss.Add(new SelectListItem { Text = item.TypePath, Value = item.TypeItem });
            }
            return ss;
        }
    }
}