using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Model
{
    public class Accelerator
    {
        [Key]
        public int accId { get; set; }


        public string accName { get; set; }


        public string accDescr { get; set; }


        public string accUrl { get; set; }


        public string accImg { get; set; }


    }

}
