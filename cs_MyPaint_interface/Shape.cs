using System.Drawing;

namespace cs_MyPaint_interface
{
    abstract class Shape
    {
        public Point Location { get; set; } = new Point(0, 0);
        public string Name { get; set; }
        public string Tag { get; set; }

        // 기본 그리기 기능
        //public abstract void Draw(Graphics g);

        // 고급 기능들
        public abstract void Clip(/* */);
        public abstract void Resize(/**/);

        //....


    }
}
