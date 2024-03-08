namespace demo2 {
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            tamGiacTraiToolStripMenuItem = new ToolStripMenuItem();
            tamGiacPhaiToolStripMenuItem = new ToolStripMenuItem();
            tamGiacCanToolStripMenuItem = new ToolStripMenuItem();
            tamGiacDeuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { tamGiacTraiToolStripMenuItem, tamGiacPhaiToolStripMenuItem, tamGiacCanToolStripMenuItem, tamGiacDeuToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // tamGiacTraiToolStripMenuItem
            // 
            tamGiacTraiToolStripMenuItem.Name = "tamGiacTraiToolStripMenuItem";
            tamGiacTraiToolStripMenuItem.Size = new Size(111, 24);
            tamGiacTraiToolStripMenuItem.Text = " tam giac trai";
            tamGiacTraiToolStripMenuItem.Click += tamGiacTraiToolStripMenuItem_Click;
            // 
            // tamGiacPhaiToolStripMenuItem
            // 
            tamGiacPhaiToolStripMenuItem.Name = "tamGiacPhaiToolStripMenuItem";
            tamGiacPhaiToolStripMenuItem.Size = new Size(114, 24);
            tamGiacPhaiToolStripMenuItem.Text = "tam giac phai";
            tamGiacPhaiToolStripMenuItem.Click += tamGiacPhaiToolStripMenuItem_Click;
            // 
            // tamGiacCanToolStripMenuItem
            // 
            tamGiacCanToolStripMenuItem.Name = "tamGiacCanToolStripMenuItem";
            tamGiacCanToolStripMenuItem.Size = new Size(108, 24);
            tamGiacCanToolStripMenuItem.Text = "tam giac can";
            tamGiacCanToolStripMenuItem.Click += tamGiacCanToolStripMenuItem_Click;
            // 
            // tamGiacDeuToolStripMenuItem
            // 
            tamGiacDeuToolStripMenuItem.Name = "tamGiacDeuToolStripMenuItem";
            tamGiacDeuToolStripMenuItem.Size = new Size(110, 24);
            tamGiacDeuToolStripMenuItem.Text = "tam giac deu";
            tamGiacDeuToolStripMenuItem.Click += tamGiacDeuToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem tamGiacTraiToolStripMenuItem;
        private ToolStripMenuItem tamGiacPhaiToolStripMenuItem;
        private ToolStripMenuItem tamGiacCanToolStripMenuItem;
        private ToolStripMenuItem tamGiacDeuToolStripMenuItem;
    }
}