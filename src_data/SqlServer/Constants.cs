using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer
{
    public struct Constants
    {
        public struct StoredProcedures
        {
            public struct Core
            {
                public const string GET_ALL_STATES = "[brs_core].[get_states]";
            }
        }

        public struct FieldNames
        {
            public const string STATE_CODE = "state_code";
            public const string STATE_NAME = "state_name";
        }
    }
}
