﻿using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMLNancyMock
{
    class NancyREST: NancyModule
    {
        public NancyREST()
        {
            Get["/"] = parameters => {
                return "Hello";
            };
         }
    }
}