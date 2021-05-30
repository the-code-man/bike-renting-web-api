using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Model
{
    public class ModelBaseWithAudit : ModelBase
    {
        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
