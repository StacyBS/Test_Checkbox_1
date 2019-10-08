using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Checkbox_test.Models
{
    public class Source
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Checked {get;set;}
        public List<SelectListItem> dropDownList { get; set; }
    }
}