using System.Drawing.Drawing2D;

namespace demo2 {
    public abstract class IShape {
        public Point A { get; set; }
        public Point B { get; set; }
        public Color Color { get; set; } = Color.Black;
        public abstract void Draw(Graphics g);
        public abstract bool Inside(Point point);
    }
    public abstract class TamGiac : IShape {
        public override void Draw(Graphics g) {
            var p1 = TinhDiem1();
            var p2 = TinhDiem2();
            var p3 = TinhDiem3();
            g.DrawLine(new Pen(Color), p1, p2);
            g.DrawLine(new Pen(Color), p1, p3);
            g.DrawLine(new Pen(Color), p2, p3);
        }
        public override bool Inside(Point p) {
            var p1 = TinhDiem1();
            var p2 = TinhDiem2();
            var p3 = TinhDiem3();
            var path = new GraphicsPath(); 
            path.AddPolygon(new Point[] { p1, p2 , p3 });
            var region = new Region(path);
            return region.IsVisible(p);
        }

        public abstract Point TinhDiem1();
        public abstract Point TinhDiem2();
        public abstract Point TinhDiem3();
    }
    
    public class  Circle : IShape {
        public override void Draw(Graphics g) {
            var canh = Math.Min(Math.Abs(A.X - B.X) , Math.Abs(A.Y - B.Y));
            g.FillEllipse(new HatchBrush(HatchStyle.Cross, Color.Red), new Rectangle(A, new Size(canh, canh)));
            var pen = new Pen(Color);
            pen.DashStyle = DashStyle.DashDotDot;
            pen.Width = 5; 
            g.DrawEllipse(pen, new Rectangle(A, new Size(canh, canh)));
        }
        public override bool Inside(Point p) {
            return false;
        }
    }
    public class TamGiacVT : TamGiac {
        public override Point TinhDiem1() {
            return A;
        }

        public override Point TinhDiem2() {
            return B;
        }

        public override Point TinhDiem3() {
            return new Point(A.X, B.Y);
        }
    }
    public class TamGiacVP : TamGiac {
        public override Point TinhDiem1() {
            return A;
        }

        public override Point TinhDiem2() {
            return B;
        }

        public override Point TinhDiem3() {
            return new Point(B.X, A.Y);
        }
    }

    public class TamGiacCan : TamGiac {
        public override Point TinhDiem1() {
            int diem1X = (A.X + B.X) / 2;
            int diem1Y = (A.Y + B.Y) / 2;
            return new Point(diem1X, diem1Y);
        }

        public override Point TinhDiem2() {
            return new Point(B.X, A.Y);
        }

        public override Point TinhDiem3() {
            int diem1X = (A.X + B.X) / 2;
            int diem1Y = (A.Y + B.Y) / 2;

            double khoangCach = Math.Sqrt(Math.Pow(A.X - diem1X, 2) + Math.Pow(A.Y - diem1Y, 2));

            int diem3X = diem1X;
            int diem3Y = (int)(diem1Y + khoangCach);

            return new Point(diem3X, diem3Y);
        }
    }

    public class TamGiacDeu: TamGiac {
        public override Point TinhDiem1() {
            int diem1X = (A.X + B.X) / 2;
            int diem1Y = (A.Y + B.Y) / 2;
            return new Point(diem1X, diem1Y);
        }

        public override Point TinhDiem2() {
            return B;
        }

        public override Point TinhDiem3() {
            return new Point(B.X, A.Y);
        }
    }
    

    public enum ShapeType {
        VT, VP , CAN , DEU , HT
    }
    public class TamGiacSimpleFactory {
        public IShape CreateTamGiac(ShapeType type) {
            if (type == ShapeType.VT) {
                return new TamGiacVT();
            }
            if (type == ShapeType.VP) {
                return new TamGiacVP();
            }
            if (type == ShapeType.CAN) {
                return new TamGiacCan();    
            }
            if (type == ShapeType.DEU) {
                return new TamGiacDeu();
            }
            if(type == ShapeType.HT) {
                return new Circle();
            }
            return null;
        }
    }
}
