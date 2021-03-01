using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concerate
{
    public class OperationClaim:IEntity
    {
        public int ClaimID { get; set; }
        public string ClaimName { get; set; }
    }
}
