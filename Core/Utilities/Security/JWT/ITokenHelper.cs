﻿using Core.Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
   public  interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
