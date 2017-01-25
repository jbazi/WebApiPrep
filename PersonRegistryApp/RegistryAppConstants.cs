﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonRegistryApp
{
    public class RegistryAppConstants
    {
        public const string ExpenseTrackerAPI = "https://localhost:44344/";
        //public const string ExpenseTrackerClient = "http://localhost:27470/";
        //public const string ExpenseTrackerMobile = "ms-app://s-1-15-2-467734538-4209884262-1311024127-1211083007-3894294004-443087774-3929518054/";

        // public const string IdSrvIssuerUri = "https://expensetrackeridsrv3/embedded";

        public const string IdSrv = "https://localhost:44344/identity";
        public const string IdSrvToken = IdSrv + "/connect/token";
        public const string IdSrvAuthorize = IdSrv + "/connect/authorize";
        public const string IdSrvUserInfo = IdSrv + "/connect/userinfo";
    }
}