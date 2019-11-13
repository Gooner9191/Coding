﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class ReportingUnit
    {
        public event EventHandler UnitStatusChanged;

        public ReportingUnit()
        {

        }
     

        

        protected void OnStatusChanged(EventArgs e)
        {
            EventHandler handler = UnitStatusChanged;
            handler?.Invoke(this, e);
        }
    }
}
