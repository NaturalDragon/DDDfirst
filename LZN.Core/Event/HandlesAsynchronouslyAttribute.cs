using System;

namespace LZN.Core.Event
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HandlesAsynchronouslyAttribute : Attribute
    {
    }
}