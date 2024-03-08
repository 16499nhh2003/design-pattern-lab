namespace demo2 {
    public abstract class TamGiac {
        public Point A { get; set; }
        public Point B { get; set; }
        public Color Color { get; set; } = Color.Black;
        public void Draw(Graphics g) {
            var p1 = TinhDiem1();
            var p2 = TinhDiem2();
            var p3 = TinhDiem3();
            g.DrawLine(new Pen(Color), p1, p2);
            g.DrawLine(new Pen(Color), p1, p3);
            g.DrawLine(new Pen(Color), p2, p3);
        }
        public bool Inside(Point p) {
            var p1 = TinhDiem1();
            var p2 = TinhDiem2();
            var p3 = TinhDiem3();

            var v1 = new Point(p2.X - p1.X, p2.Y - p1.Y);
            var v2 = new Point(p3.X - p2.X, p3.Y - p2.Y);
            var v3 = new Point(p1.X - p3.X, p1.Y - p3.Y);

            var vp1 = new Point(p1.X - p.X, p1.Y - p.Y);
            var vp2 = new Point(p2.X - p.X, p2.Y - p.Y);
            var vp3 = new Point(p3.X - p.X, p3.Y - p.Y);

            var c1 = (v1.X * vp1.Y - v1.Y * vp1.X) >= 0;
            var c2 = (v2.X * vp2.Y - v2.Y * vp2.X) >= 0;
            var c3 = (v3.X * vp3.Y - v3.Y * vp3.X) >= 0;

            return c1 == c2 && c2 == c3;
        }

        public abstract Point TinhDiem1();
        public abstract Point TinhDiem2();
        public abstract Point TinhDiem3();
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

    public enum TamGiacType {
        VT, VP , CAN , DEU
    }
    public class TamGiacSimpleFactory {
        public TamGiac CreateTamGiac(TamGiacType type) {
            if (type == TamGiacType.VT) {
                return new TamGiacVT();
            }
            if (type == TamGiacType.VP) {
                return new TamGiacVP();
            }
            if (type == TamGiacType.CAN) {
                return new TamGiacCan();    
            }
            if (type == TamGiacType.DEU) {
                return new TamGiacDeu();
            }
            return null;
        }
    }
}
