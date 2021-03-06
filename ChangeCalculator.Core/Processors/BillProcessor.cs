﻿using ChangeCalculator.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {

    public class BillProcessor : AbstractProcessor {
        
        public override IEnumerable<int> GetAvailableUnits() {
            return new List<int>() {200, 500, 1000, 2000, 5000, 10000};
        }

        public override string GetName() {
            return "Bill";
        }
    }
}
