﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLearnForSelf
{
    public class Mobile
    {
        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Data { get; set; }
        public string Name { get; set; }


        public Mobile( string nationaVal , string phonenumberval , string dataVal , string nameVal  )
        {
            NationalCode = nationaVal;
            PhoneNumber = phonenumberval;
            Data = dataVal;
            Name = nameVal;
        }
    }
}
