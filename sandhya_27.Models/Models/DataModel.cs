using sandhya_27.Models.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Models.Models
{
    public class DataModel
    {
        public Questions questions { get; set; }
        public List<Answer> Options { get; set; }   
    }
}
