using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo {
    class DateValidationStrategy : IValidationStrategy {
        public bool IsValid(string data) {
            return DateTime.TryParse(data, out _);
        }
    }
}
    