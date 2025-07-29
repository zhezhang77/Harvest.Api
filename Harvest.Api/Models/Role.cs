using System;
using System.Collections.Generic;
using System.Text;

namespace Harvest.Api
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public long[] UserIds { get; set; }
    }

    public class RolesResponse : PagedList
    {
        public Role[] Roles { get; set; }
    }
}
