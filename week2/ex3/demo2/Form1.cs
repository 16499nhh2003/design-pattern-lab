namespace demo2 {
    public partial class Form1 : Form {
        TamGiacType type = TamGiacType.VT;
        bool drawing = false;
        List<TamGiac> tamGiacs = new List<TamGiac>();
        public Form1() {
            InitializeComponent();
        }

        private void tamGiacTraiToolStripMenuItem_Click(object sender, EventArgs e) {
            type = TamGiacType.VT;
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            foreach (var tg in tamGiacs) {
                tg.Draw(e.Graphics);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            drawing = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            foreach(var tg1 in tamGiacs) {
                if (tg1.Inside(e.Location)) {
                    tg1.Color = Color.Red;
                    Invalidate();
                    return;
                }
            }
            var tg = new TamGiacSimpleFactory().CreateTamGiac(type);
            tg.A = tg.B = e.Location;
            drawing = true;
            tamGiacs.Add(tg);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (!drawing) { return; }
            var currentTriangle = tamGiacs[tamGiacs.Count - 1];
            var A = currentTriangle.A;
            var B = e.Location;

            if (B.X < A.X) {
                currentTriangle.A = new Point(B.X, A.Y);
                currentTriangle.B = new Point(A.X, B.Y);
            } else {
                currentTriangle.B = B;
            }

            Invalidate();
        }

        private void tamGiacPhaiToolStripMenuItem_Click(object sender, EventArgs e) {
            type = TamGiacType.VP;
        }

        private void tamGiacCanToolStripMenuItem_Click(object sender, EventArgs e) {
            type = TamGiacType.CAN;
        }

        private void tamGiacDeuToolStripMenuItem_Click(object sender, EventArgs e) {
            type = TamGiacType.DEU;
        }
    }
}