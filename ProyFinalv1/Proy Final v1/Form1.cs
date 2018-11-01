using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proy_Final_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Console.WriteLine("X: " + x.ToString() + " Y: " + y.ToString());
        }
        //Codigo Del Dibujo
        Pen LapizA = new Pen(Color.Red, 2);
        SolidBrush BrochaA = new SolidBrush(Color.Brown);
        SolidBrush BroshaB = new SolidBrush(Color.Blue);
        Graphics Dibujo; //Objeto Graphics

        private void Cuadro_Paint(object sender, PaintEventArgs e)
        {
            Dibujo = e.Graphics; //Para poder dibujar
            //Lado Izquierdo, Esquina Inferior, Primer rectangulo, lado uno
            Point A = new Point(99, 718);
            Point B = new Point(94, 305);
            //Dibujo.DrawLine(LapizA, p1, p2);
            Point E = new Point(94, 305);
            Point F = new Point(204, 312);
            //Dibujo.DrawLine(LapizA, A, B);
            Point C = new Point(204, 312);//Lado Izquierdo, Esquina Inferior, Primer rectangulo, lado dos
            Point D = new Point(209, 493);//Mitad de la linea
            Point G = new Point(216, 715);
         

            PointF[] RectanguloII = new PointF[8];
            RectanguloII[0] = A;
            RectanguloII[1] = B;

            RectanguloII[2] = E;
            RectanguloII[3] = F;

            RectanguloII[4] = C;
            RectanguloII[5] = D;
            RectanguloII[6] = G;
            RectanguloII[7] = A;





            Dibujo.DrawPolygon(LapizA, RectanguloII);
            Dibujo.FillPolygon(BrochaA, RectanguloII);


            PointF[] RectanguloII2 = new PointF[5];
            Point[] Arreglo1 =
            {
                new Point(),new Point(), new Point(),new Point(), new Point()
            };
            Dibujo.DrawPolygon(LapizA, Arreglo1);
            Dibujo.FillPolygon(BrochaA, Arreglo1);

            Point A1 = new Point(94, 305);
            Point B1 = new Point(269, 250);
            Point C1 = new Point(265, 284);
            Point D1 = new Point(204, 312);

            RectanguloII2[0] = A1;
            RectanguloII2[1] = B1;
            RectanguloII2[2] = C1;
            RectanguloII2[3] = D1;
            RectanguloII2[4] = A1;



            //Dibujo.DrawLine(LapizA, A1, B1);
            //Dibujo.DrawLine(LapizA, B1, C1);
            //Dibujo.DrawLine(LapizA, C1, D1);

            Dibujo.DrawPolygon(LapizA, RectanguloII2);
            Dibujo.FillPolygon(BroshaB, RectanguloII2);






        }

    }
}


