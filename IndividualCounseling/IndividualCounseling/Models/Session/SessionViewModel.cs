using IndividualCounseling.Models.Foreignkey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCounseling.Models.Session
{
    public class SessionViewModel
    {
        [ScaffoldColumn(false)]
        public int sessionID
        {
            get;
            set;
        }

        [DisplayName("تاريخ الجلسة:")]
        [DataType(DataType.Date)]
        public DateTime sessionDate { get; set; }

        [DisplayName("نتائج:")]
        [AllowHtml]
        public string sessionResult { get; set; }
        [DisplayName("توصيات:")]
        [AllowHtml]
        public string sessionRecommendations { get; set; }

        public int? CaseID { get; set; }

    }
}