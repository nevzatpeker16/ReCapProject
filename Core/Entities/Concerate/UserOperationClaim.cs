﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concerate
{
    public class UserOperationClaim:IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }
    }
}