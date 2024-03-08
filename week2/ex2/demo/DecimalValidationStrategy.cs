using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo {
    internal class DecimalValidationStrategy : IValidationStrategy {
        public bool IsValid(string data) {
            return decimal.TryParse(data, out _);
        }
    }
}
