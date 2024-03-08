using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

namespace demo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            MyTextBox myTextBox = new MyTextBox(new DecimalValidationStrategy());

            if (!myTextBox.Validation(txtDecimal.Text.Trim().ToString())) {
                MessageBox.Show("Error Decimal");
                return;
            }

            myTextBox.SetStrategy(new IntegerValidationStrategy());
            if (!myTextBox.Validation(txtInteger.Text.Trim().ToString())) {
                MessageBox.Show("Error Integer");
                return;
            }

            myTextBox = new MyTextBox(new NumericStringValidationStrategy());
            if (!myTextBox.Validation(txtString.Text.Trim().ToString())) {
                MessageBox.Show("Error String");
                return;
            }

            myTextBox = new MyTextBox(new EmailValidationStrategy());
            if (!myTextBox.Validation(txtEmail.Text.Trim().ToString())) {
                MessageBox.Show("Error Email");
                return;
            }

            myTextBox = new MyTextBox(new DateValidationStrategy());
            if (!myTextBox.Validation(txtDate.Text.Trim().ToString())) {
                MessageBox.Show("Error Date");
                return;
            }

            MessageBox.Show("Successfully");
        }
    }
}