﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Caller : Instrument
    {
        public void CallerInstrumentType(Instrument instrument)
        {
            string inst;
            inst = instrument.Type;
            Console.WriteLine("{0}", inst);
        }

    }
}
