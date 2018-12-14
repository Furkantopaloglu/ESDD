using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esdd.Enties
{
    [Table("Activity")]
    public class Activity:MyEntityBase
    {
        public string Title { get; set; }
        public string Text { get; set; }
        

    }
}
