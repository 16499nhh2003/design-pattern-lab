using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo {
    internal class IntegerValidationStrategy : IValidationStrategy {
        public bool IsValid(string data) {
            return int.TryParse(data , out _);
        }
    }
}
