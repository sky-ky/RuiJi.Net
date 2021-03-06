﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RuiJi.Core
{
    public class Request
    {
        public string Cookie { get; set; }

        public NameValueCollection Data { get; set; }

        public bool IsRaw { get; set; }

        public string Charset { get; set; }

        public string Method { get; set; }

        public WebHeaderCollection Headers { get; set; }

        public Uri Uri { get; set; }

        public int Timeout { get; set; }

        public string Elect { get; set; }

        public string PostParam { get; set; }

        public Request()
        {
            Method = "GET";
            Headers = new WebHeaderCollection();
        }

        public Request(string url) : this()
        {
            this.Uri = new Uri(url);
        }

        public static Request Create(string url)
        {
            return new Request(url);
        }
    }
}
