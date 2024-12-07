using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally.Models
{
    class ViewSchedule :Schedule
    {
        
        public string slot { get; set; }
        public int status {  get; set; }
        public int dayOfWeek { get; set;}
        public int scheID { get; set; }
    }
}
