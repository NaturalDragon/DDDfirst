using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core
{

    public interface IEntity : IEntity<Guid>
    {

    }

   public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { set; get; }
    }
}
