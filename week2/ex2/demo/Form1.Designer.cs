namespace demo {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtEmail = new TextBox();
            btnSave = new Button();
            lbEmail = new Label();
            label1 = new Label();
            txtDecimal = new TextBox();
            txtInteger = new TextBox();
            txtString = new TextBox();
            txtDate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(255, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 20);
            txtEmail.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(273, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(88, 235);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 65);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Số thực";
            // 
            // txtDecimal
            // 
            txtDecimal.BorderStyle = BorderStyle.None;
            txtDecimal.Location = new Point(255, 65);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(125, 20);
            txtDecimal.TabIndex = 4;
            // 
            // txtInteger
            // 
            txtInteger.BorderStyle = BorderStyle.None;
            txtInteger.Location = new Point(255, 123);
            txtInteger.Name = "txtInteger";
            txtInteger.Size = new Size(125, 20);
            txtInteger.TabIndex = 5;
            // 
            // txtString
            // 
            txtString.BorderStyle = BorderStyle.None;
            txtString.Location = new Point(255, 185);
            txtString.Name = "txtString";
            txtString.Size = new Size(125, 20);
            txtString.TabIndex = 6;
            // 
            // txtDate
            // 
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Location = new Point(255, 276);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 20);
            txtDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 123);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Số nguyên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 185);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 9;
            label3.Text = "Chuỗi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 276);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày/Tháng/Năm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(txtString);
            Controls.Add(txtInteger);
            Controls.Add(txtDecimal);
            Controls.Add(label1);
            Controls.Add(lbEmail);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnSave;
        private Label lbEmail;
        private Label label1;
        private TextBox txtDecimal;
        private TextBox txtInteger;
        private TextBox txtString;
        private TextBox txtDate;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}