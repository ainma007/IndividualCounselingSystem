using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndividualCounseling.Models.Project
{
    public class projectViewModle
    {
        [ScaffoldColumn(false)]
        public int ProjectID
        {
            get;
            set;
        }

        [Required]

        [DisplayName("اسم المشروع:")]
        public string ProjectName
        {
            get;
            set;
        }


        [Required]

        [DisplayName("تاريخ البداية:")]
        [DataType(DataType.Date)]
        public DateTime StartDate
        {
            get;
            set;
        }

        [Required]

        [DisplayName("تاريخ النهاية:")]
        [DataType(DataType.Date)]
        public DateTime EndDate
        {
            get;
            set;
        }



        [DisplayName("وصف  المشروع:")]
        public string Description
        {
            get;
            set;
        }



        [DisplayName("الحالة:")]
        public bool Status
        {
            get;
            set;
        }

    }
}