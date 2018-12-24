using LZN.Core.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Application.PersonApp
{
  public  class PersonGeneratorEvent: IEvent
    {
        public string PersonId { get; set; }
    }
}
