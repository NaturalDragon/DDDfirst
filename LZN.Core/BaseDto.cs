﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core
{
  public  class BaseDto
    {
        public string Id { set; get; }

        public int IsDelete { set; get; }

        public DateTime CreateDate { set; get; }
    }
}
