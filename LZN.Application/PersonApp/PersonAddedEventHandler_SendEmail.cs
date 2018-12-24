using LZN.Core.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Application.PersonApp
{
    public class PersonAddedEventHandler_SendEmail : IEventHandler<PersonGeneratorEvent>
    {
        public void Handle(PersonGeneratorEvent evt)
        {
            Console.WriteLine(evt.PersonId);
        }
    }
}
