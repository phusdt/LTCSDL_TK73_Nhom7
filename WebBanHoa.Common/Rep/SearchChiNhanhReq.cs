﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace WebBanHoa.Common.Rep
{
    public class SearchChiNhanhReq
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public string Keyword { get; set; }
    }
}
