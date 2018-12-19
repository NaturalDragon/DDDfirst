using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core.Model
{
    public class Person : IEntity<string>
    {
        public  string Id { set; get; }


        public string Name { set; get; }

        public DateTime CreateDate { set; get; }
    }
}
