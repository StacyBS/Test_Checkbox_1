using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Checkbox_test.Models;

namespace Checkbox_test.ViewModel
{
    public class SourceDataView
    {
        public List<SelectListItem> droplistItem { get; set; }
        public List<TestData_chk_droplist> testData_Chk_Droplist { get; set; }
        public bool Checked { get; set; }
    }
}