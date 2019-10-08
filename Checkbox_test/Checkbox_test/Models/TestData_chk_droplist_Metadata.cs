using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Checkbox_test.Models
{
    [MetadataType(typeof(TestData_chk_droplist_Metadata))]
    public partial class TestData_chk_droplist
    { 
        private class TestData_chk_droplist_Metadata
        {
            [DisplayName("Id")]
            public int Id { get; set; }
            [DisplayName("Name")]
            public string Names { get; set; }
            [DisplayName("Content")]
            public string Content { get; set; }
            [DisplayName("Type")]
            public string TypeItem { get; set; }
        }
    }
}