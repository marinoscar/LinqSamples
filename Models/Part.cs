using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Part
    {
        public int Id { get; set; }
        public int PartTypeId { get; set; }
        public string Code { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format(@"
Id.........: {0}
PartTypeId.: {1}
Code.......: {2}
IssuedDate.: {3}
Description: {4}
", Id, PartTypeId, Code, IssuedDate.ToString("yyyy-mm-dd"), Description);
        }
    }
}
