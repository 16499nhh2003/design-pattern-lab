using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo {
     class MyTextBox : TextBox {
        private IValidationStrategy _strategy;

        public MyTextBox(IValidationStrategy strategy) {
            _strategy = strategy;   
        }

        public void SetStrategy(IValidationStrategy strategy) {
            _strategy = strategy;
        }

        public bool Validation(string data) {
            return _strategy.IsValid(data); 
        }
    }
}
