﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGen.StateMachine
{
    public class UnspecifiedStateException : Exception
    {
        public UnspecifiedStateException()
            :base("State not set.")
        {
        }
    }
}
