﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.ResponseModels
{
    public class CheckEmail
    {
        [JsonProperty("IsExist")]
        public bool IsExist { get; set; }
    }
}
