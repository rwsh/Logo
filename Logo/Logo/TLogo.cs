using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Logo
{
    class TLogo
    {
        Canvas g;

        double X, Y;

        public TLogo(Canvas g)
        {
            this.g = g;
            X = g.Width / 2;
            Y = g.Height / 2;

            Draw();
        }

        Ellipse O;

        double R = 10;

        void Draw()
        {
            if (O == null)
            {
                O = new Ellipse();
                O.Height = R;
                O.Width = R;
                O.Fill = Brushes.Red;
                g.Children.Add(O);
            }

            if (X < 0)
            {
                X = 0;
            }

            if (X > g.Width)
            {
                X = g.Width;
            }

            if (Y < 0)
            {
                Y = 0;
            }

            if (Y > g.Height)
            {
                Y = g.Height;
            }


            O.Margin = new Thickness(X - R / 2, Y - R / 2, 0, 0);
        }

        public void Up(double dy)
        {
            Y -= dy;

            Draw();
        }

        public void Right(double dx)
        {
            X += dx;

            Draw();
        }

        public void Jump()
        {
            Random rnd = new Random();

            X = rnd.NextDouble() * g.Width;
            Y = rnd.NextDouble() * g.Height;

            Draw();
        }

        public void ToHome()
        {
            X = g.Width / 2;
            Y = g.Height / 2;

            Draw();
        }
    }
}
