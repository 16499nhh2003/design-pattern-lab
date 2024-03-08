using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo {
    interface IValidationStrategy {
        bool IsValid(String data);    
    }
}
