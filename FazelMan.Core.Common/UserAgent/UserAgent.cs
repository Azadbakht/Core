﻿using FazelMan.Core.Common.Enums;
using FazelMan.Core.Common.Extentions;

namespace FazelMan.Core.Common.UserAgent
{
    public static class UserAgent
    {
        public static ClientTypeEnum GetUserAgentClientType(string userAgent)
        {
            userAgent = userAgent.ToLower();

            if (userAgent.Contains("android"))
                userAgent = "android";

            else if (userAgent.Contains("ipad") || userAgent.Contains("iphone") || userAgent.Contains("ios"))
                userAgent = "ios";

            else
                userAgent = "web";

            return userAgent.GetEnum<ClientTypeEnum>();
        }
    }
}
