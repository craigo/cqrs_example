using System;
using NServiceBus;

namespace cqrs_example
{
    public class CurrentBus 
    {
        private static IBus Bus { get; set; }

        public static void AssociatedCurrentBus(IBus bus)
        {
            Bus = bus;
        }

        public static IBus GetCurrent()
        {
            if(null == Bus)
                throw new ApplicationException("Bus has not been initialized.");

            return Bus;
        }
    }
}