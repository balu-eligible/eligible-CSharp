﻿using EligibleService.Common;
using RestSharp;
using RestSharp.Deserializers;
using System.Collections;
using System.Runtime.InteropServices;

namespace EligibleService.Core
{

    public class BaseCore : FormatInputWithRequestOptions
    {
        protected IRequestExecute executeObj;
        protected IRestResponse response { get; set; }
        protected Hashtable param { get; set; }

        public BaseCore()
        {
            executeObj = new RequestExecute();
        }
    }
}
