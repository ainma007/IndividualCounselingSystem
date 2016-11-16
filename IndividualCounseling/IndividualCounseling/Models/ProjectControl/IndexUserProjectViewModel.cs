using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndividualCounseling.Models.ProjectControl
{
    public class IndexUserProjectViewModel
    {

        public int ID { get; set; }

        public int? ProID { get; set; }
        public int? UserID { get; set; }

        [DisplayName(" اسم المشروع:")]
        public string ProjectName { get; set; }
        [DisplayName("تاريخ البداية:")]
        public DateTime startdate { get; set; }

        [DisplayName("تاريخ الانتهاء:")]
        public DateTime endDate { get; set; }
        [DisplayName("وصف  المشروع:")]
        public string Description { get; set; }

        public bool Status { get; set; }


    }
}