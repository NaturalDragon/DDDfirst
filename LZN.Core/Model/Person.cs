using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core.Model
{
    public class Person : IEntity<Guid>
    {
        public Guid Id { set; get; }


        public string Name { set; get; }
    }
}
