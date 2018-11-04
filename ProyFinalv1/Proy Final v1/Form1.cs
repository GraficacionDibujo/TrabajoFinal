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
using System.Drawing.Drawing2D;

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
        //LAPIZ
        Pen LapizRojo = new Pen(Color.Red, 5);
        Pen LapizAzul = new Pen(Color.Blue, 5);
        SolidBrush BrochaCafe = new SolidBrush(Color.Brown);
        SolidBrush BrochaAzul = new SolidBrush(Color.Blue);
        SolidBrush BrochaNegra = new SolidBrush(Color.Black);
        SolidBrush BrochaVerde = new SolidBrush(Color.Green);
        Graphics Dibujo; //Objeto Graphics
        private void Cuadro_Paint(object sender, PaintEventArgs e)
        {
            //Isauro
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

            Dibujo.DrawPolygon(LapizAzul, RectanguloII);
            Dibujo.FillPolygon(BrochaCafe, RectanguloII);


            PointF[] RectanguloII2 = new PointF[5];
            Point[] Arreglo1 =
            {
                new Point(),new Point(), new Point(),new Point(), new Point()
            };
            Dibujo.DrawPolygon(LapizAzul, Arreglo1);
            Dibujo.FillPolygon(BrochaCafe, Arreglo1);

            Point A1 = new Point(94, 305);
            Point B1 = new Point(269, 250);
            Point C1 = new Point(265, 284);
            Point D1 = new Point(204, 312);

            RectanguloII2[0] = A1;
            RectanguloII2[1] = B1;
            RectanguloII2[2] = C1;
            RectanguloII2[3] = D1;
            RectanguloII2[4] = A1;

            Dibujo.DrawPolygon(LapizAzul, RectanguloII2);
            Dibujo.FillPolygon(BrochaCafe, RectanguloII2);

            //--Primer rectangulo, lado izquierdo, cerca del timon ----- Isauro
            List<Point> PrimerRectantulo = new List<Point>();
            PrimerRectantulo.Add(new Point(0, 231));
            PrimerRectantulo.Add(new Point(270, 165));
            PrimerRectantulo.Add(new Point(285, 178));
            PrimerRectantulo.Add(new Point(272, 249));
            PrimerRectantulo.Add(new Point(0, 337));
            PrimerRectantulo.Add(new Point(0, 231));
            Dibujo.DrawPolygon(LapizAzul, PrimerRectantulo.ToArray());
            Dibujo.FillPolygon(BrochaCafe, PrimerRectantulo.ToArray());

            //--Segundo rectangulo, lado izquierdo inferior
            List<Point> SegundoRectangulo = new List<Point>();
            SegundoRectangulo.Add(new Point(1, 338));
            SegundoRectangulo.Add(new Point(93, 309));
            SegundoRectangulo.Add(new Point(99, 718));
            SegundoRectangulo.Add(new Point(1, 719));
            SegundoRectangulo.Add(new Point(1,338));
            Dibujo.DrawPolygon(LapizAzul, SegundoRectangulo.ToArray());
            Dibujo.FillPolygon(BrochaCafe, SegundoRectangulo.ToArray());

            //--Primera forma (cuadrado), cerca del timon,lado izquierdo, lado superior      
            GraphicsPath Path = new GraphicsPath(); 
            Path.StartFigure();
            Path.AddLine(206, 314, 266, 286);
            Path.AddLine(266, 286, 263, 377);
            List<Point> Curva1 = new List<Point>();
            Curva1.Add(new Point(252,382));
            Curva1.Add(new Point(232,390));
            Curva1.Add(new Point(221, 396));
            Curva1.Add(new Point(216, 399));
            Curva1.Add(new Point(209, 406));
            Path.AddCurve(Curva1.ToArray(), 3);
            Path.CloseFigure();
            Dibujo.DrawPath(LapizRojo, Path);
            Dibujo.FillPath(BrochaCafe, Path);

            // --Segunda forma (Rectangulo con curva),lado izquierdo,cerca del timon, lado inferior
            GraphicsPath SegundaForma = new GraphicsPath();
            SegundaForma.StartFigure();
            List<Point> Curva2 = new List<Point>();//Primera curva
            Curva2.Add(new Point(210, 443));
            Curva2.Add(new Point(218, 450));
            Curva2.Add(new Point(227, 453));
            Curva2.Add(new Point(227, 453));
            Curva2.Add(new Point(237, 452));
            Curva2.Add(new Point(247, 450));
            SegundaForma.AddCurve(Curva2.ToArray(),1);
            SegundaForma.AddLine(247, 450, 265, 443);//Primera linea
            List<Point> Curva3 = new List<Point>();//Segunda Curva
            Curva3.Add(new Point(266, 455));
            Curva3.Add(new Point(270, 487));
            Curva3.Add(new Point(284, 543));
            Curva3.Add(new Point(298, 579));
            Curva3.Add(new Point(311, 603));
            Curva3.Add(new Point(318, 615));
            SegundaForma.AddCurve(Curva3.ToArray(),1);
            List<Point> Curva4 = new List<Point>();//Tercera Curva
            Curva4.Add(new Point(314, 627));
            Curva4.Add(new Point(306, 652));
            Curva4.Add(new Point(306, 677));
            Curva4.Add(new Point(310, 693));
            SegundaForma.AddCurve(Curva4.ToArray(),1);
            SegundaForma.AddLine(310, 693, 276, 717);//Segunda Linea
            SegundaForma.AddLine(276, 717, 216, 717);//Tercera linea
            SegundaForma.CloseFigure();
            Dibujo.DrawPath(LapizRojo, SegundaForma);
            Dibujo.FillPath(BrochaVerde, SegundaForma);

            //--Primera parte del rectangulo, lado derecho, Entre el timon y cara de mickey mouse, parte superior
            GraphicsPath TerceraForma = new GraphicsPath();
            TerceraForma.AddLine(499, 136, 710, 136);//Primera linea
            TerceraForma.AddLine(710, 136, 722, 144);//Segunda linea
            List<Point> Curva5 = new List<Point>();//Primera curva
            Curva5.Add(new Point(712, 151));
            Curva5.Add(new Point(689, 163));
            Curva5.Add(new Point(671, 180));
            Curva5.Add(new Point(676, 175));
            Curva5.Add(new Point(665, 191));
            TerceraForma.AddCurve(Curva5.ToArray(), 0);
            TerceraForma.AddLine(661, 194, 633, 194);//Tercera linea
            List<Point> Curva6 = new List<Point>();//Segunda Curva
            Curva6.Add(new Point(623, 179));
            Curva6.Add(new Point(600, 161));
            Curva6.Add(new Point(578, 176));
            Curva6.Add(new Point(580, 189));
            Curva6.Add(new Point(584, 195));
            TerceraForma.AddCurve(Curva6.ToArray(), 1);
            TerceraForma.AddLine(584, 195, 514, 196);//Cuarta linea
            TerceraForma.CloseFigure();
            Dibujo.DrawPath(LapizAzul, TerceraForma);
            //--Segunda parte del rectangulo, lado derecho,cerca de la cara de mickey, parte superior
            GraphicsPath CuartaForma = new GraphicsPath();
            CuartaForma.AddLine(896, 135, 1279, 139);//Primera linea
            CuartaForma.AddLine(1279, 139, 1279, 205);//Segunda linea
            CuartaForma.AddLine(1279, 205, 1219, 202);//Tercera linea
            CuartaForma.AddLine(1219, 202, 1156, 199);//Cuarta linea
            CuartaForma.AddLine(1156, 199, 1103, 199);//Quinta linea
            CuartaForma.AddLine(1103, 199, 983, 200);//Sexta linea
            List<Point> Curva7 = new List<Point>();//Primera curva
            Curva7.Add(new Point(978, 186));
            Curva7.Add(new Point(972, 176));
            Curva7.Add(new Point(954, 160));
            Curva7.Add(new Point(935, 151));
            Curva7.Add(new Point(906, 148));
            Curva7.Add(new Point(889, 152));
            Curva7.Add(new Point(880, 154));
            CuartaForma.AddCurve(Curva7.ToArray(),1);
            CuartaForma.CloseFigure();
            Dibujo.DrawPath(LapizRojo, CuartaForma);


            //--Primera forma poligonal con curvas, cerca del salvavidas
            GraphicsPath QuintaForma = new GraphicsPath();
            QuintaForma.AddLine(982, 202, 1157, 201);//Primera linea
            List<Point> Curva8 = new List<Point>();//Primera curva
            Curva8.Add(new Point(1116, 208));
            Curva8.Add(new Point(1071, 238));
            Curva8.Add(new Point(1046, 264));
            Curva8.Add(new Point(1026, 309));
            Curva8.Add(new Point(1025, 324));
            QuintaForma.AddCurve(Curva8.ToArray(), 1);
            List<Point> Curva9 = new List<Point>();//Segunda curva
            Curva9.Add(new Point(1019, 329));
            Curva9.Add(new Point(1018, 336));
            Curva9.Add(new Point(1023,348));
            QuintaForma.AddCurve(Curva9.ToArray());
            List<Point> Curva10 = new List<Point>();//Tercera curva
            Curva10.Add(new Point(1030, 376));
            Curva10.Add(new Point(1063, 423));
            Curva10.Add(new Point(1087, 442));
            Curva10.Add(new Point(1106, 452));
            Curva10.Add(new Point(1114, 456));
            QuintaForma.AddCurve(Curva10.ToArray(), 1);
            List<Point> Curva11 = new List<Point>();//Cuarta curva
            Curva11.Add(new Point(1170, 474));
            Curva11.Add(new Point(1179, 476));
            Curva11.Add(new Point(1185, 473));
            QuintaForma.AddCurve(Curva11.ToArray(), 1);
            List<Point> Curva12 = new List<Point>();//Quinta curva
            Curva12.Add(new Point(1205, 472));
            Curva12.Add(new Point(1228, 465));
            Curva12.Add(new Point(1246, 458));
            Curva12.Add(new Point(1264, 445));
            Curva12.Add(new Point(1278, 432));
            QuintaForma.AddCurve(Curva12.ToArray(), 1);
            QuintaForma.AddLine(1278, 432, 1279, 514);//Segunda linea
            QuintaForma.AddLine(1279, 514, 917, 507);//Tercera linea
            List<Point> Curva13 = new List<Point>();//Sexta curva
            Curva13.Add(new Point(920, 487));
            Curva13.Add(new Point(922,474));
            Curva13.Add(new Point(921,467));
            QuintaForma.AddCurve(Curva13.ToArray(), 1);
            List<Point> Curva14 = new List<Point>();//Septima curva
            Curva14.Add(new Point(926, 449));
            Curva14.Add(new Point(930, 426));
            Curva14.Add(new Point(926, 396));
            Curva14.Add(new Point(904, 359));
            Curva14.Add(new Point(859, 339));
            QuintaForma.AddCurve(Curva14.ToArray(), 1);
            QuintaForma.AddLine(859, 339, 836, 332);//Cuarta linea
            List<Point> Curva15 = new List<Point>();//Octava curva
            Curva15.Add(new Point(860, 309));
            Curva15.Add(new Point(867, 300));
            Curva15.Add(new Point(877, 285));
            Curva15.Add(new Point(884, 266));
            Curva15.Add(new Point(887, 252));
            QuintaForma.AddCurve(Curva15.ToArray(), 1);
            List<Point> Curva16 = new List<Point>();//Novena curva
            Curva16.Add(new Point(909, 262));
            Curva16.Add(new Point(917, 263));
            Curva16.Add(new Point(934, 262));
            Curva16.Add(new Point(946, 259));
            Curva16.Add(new Point(962, 249));
            Curva16.Add(new Point(980, 232));
            Curva16.Add(new Point(984, 218));
            //Curva16.Add(new Point(983, 202));
            QuintaForma.AddCurve(Curva16.ToArray(), 1);
            QuintaForma.CloseFigure();
            Dibujo.DrawPath(LapizAzul, QuintaForma);


            //Timon Agarradera1
            List<Point> Curvas8 = new List<Point>();
            Curvas8.Add(new Point(287, 181));
            Curvas8.Add(new Point(240, 105));
            Curvas8.Add(new Point(273, 76));
            Curvas8.Add(new Point(318, 156));
            Dibujo.FillClosedCurve(BrochaNegra, Curvas8.ToArray());
            Dibujo.DrawClosedCurve(LapizAzul, Curvas8.ToArray());

      

            //Timon Agarradera2
            List<Point> Curvas9 = new List<Point>();//Primera curva
            Curvas9.Add(new Point(212, 406));
            Curvas9.Add(new Point(223, 448));
            Curvas9.Add(new Point(299, 415));
            Curvas9.Add(new Point(286, 375));
            Dibujo.DrawClosedCurve(LapizAzul, Curvas9.ToArray());


            //Timon Agarradera3
            List<Point> Curvas10 = new List<Point>();//Primera curva
            Curvas10.Add(new Point(327, 605));
            Curvas10.Add(new Point(308, 664));
            Curvas10.Add(new Point(307, 673));
            Curvas10.Add(new Point(320, 696));
            Curvas10.Add(new Point(352, 684));
            Curvas10.Add(new Point(363, 609));
            Dibujo.DrawClosedCurve(LapizAzul, Curvas10.ToArray());



            GraphicsPath PaloTimon = new GraphicsPath();
            PaloTimon.AddLine(new Point(406, 289), new Point(427, 143));
            List<Point> Curvas11 = new List<Point>();
            Curvas11.Add(new Point(427, 143));
            Curvas11.Add(new Point(442, 142));
            Curvas11.Add(new Point(462, 152));
            PaloTimon.AddCurve(Curvas11.ToArray(),1);
            PaloTimon.AddLine(new Point(462, 152), new Point(434, 291));
            PaloTimon.CloseFigure();
            Dibujo.DrawPath(LapizRojo, PaloTimon);



            GraphicsPath Timon = new GraphicsPath();

            List<Point> Curvas12 = new List<Point>();

            Curvas12.Add(new Point(267, 375));
            Curvas12.Add(new Point(269, 279));
            Curvas12.Add(new Point(285, 182));

            Timon.AddCurve(Curvas12.ToArray(), 1);
            List<Point> Curvas13 = new List<Point>();

            Curvas13.Add(new Point(285, 182));
            Curvas13.Add(new Point(304, 180));
            Curvas13.Add(new Point(312, 174));

            Timon.AddCurve(Curvas13.ToArray(), 1);
            List<Point> Curvas14 = new List<Point>();
            Curvas14.Add(new Point(312, 174));
            Curvas14.Add(new Point(317, 164));

            Curvas14.Add(new Point(319, 153));
            Timon.AddCurve(Curvas14.ToArray(), 1);
            List<Point> Curvas15 = new List<Point>();
            Curvas15.Add(new Point(319, 153));
            Curvas15.Add(new Point(305, 121));

            Timon.AddCurve(Curvas15.ToArray(), 1);
            List<Point> Curvas16 = new List<Point>();
            Curvas16.Add(new Point(305, 121));
            Curvas16.Add(new Point(325, 85));

            Curvas16.Add(new Point(353, 63));

            Timon.AddCurve(Curvas16.ToArray(), 1);


            List<Point> Curvas17 = new List<Point>();
            Curvas17.Add(new Point(353, 63));
            Curvas17.Add(new Point(386, 56));
            Timon.AddCurve(Curvas17.ToArray(), 1);

            List<Point> Curvas18 = new List<Point>();
            Curvas18.Add(new Point(386, 56));
            Curvas18.Add(new Point(413, 54));

            Curvas18.Add(new Point(440, 59));

          //  Curvas18.Add(new Point(476, 91));

            Timon.AddCurve(Curvas18.ToArray(), 1);


            List<Point> Curvas19 = new List<Point>();
            Curvas19.Add(new Point(440, 59));
            Curvas19.Add(new Point(473, 90));

            Curvas19.Add(new Point(495, 132));
            Curvas19.Add(new Point(510, 194));


            Timon.AddCurve(Curvas19.ToArray(), 1);

            List<Point> Curvas20 = new List<Point>();
            Curvas20.Add(new Point(510, 194));
            Curvas20.Add(new Point(520, 268));

            Curvas20.Add(new Point(522, 355));


            Timon.AddCurve(Curvas20.ToArray(), 1);

            List<Point> Curvas21 = new List<Point>();
            Curvas21.Add(new Point(522, 355));
            Curvas21.Add(new Point(519, 430));

            Curvas21.Add(new Point(512, 503));


            Timon.AddCurve(Curvas21.ToArray(), 1);



            List<Point> Curvas22 = new List<Point>();
            Curvas22.Add(new Point(512, 503));
            Curvas22.Add(new Point(493, 564));

            Curvas22.Add(new Point(480, 590));


            Timon.AddCurve(Curvas22.ToArray(), 1);

            List<Point> Curvas23 = new List<Point>();
            Curvas23.Add(new Point(480, 590));
            Curvas23.Add(new Point(454, 620));
           Curvas23.Add(new Point(415, 636));
            Curvas23.Add(new Point(366, 635));


            Timon.AddCurve(Curvas23.ToArray(), 1);


            List<Point> Curvas24 = new List<Point>();
            Curvas24.Add(new Point(366, 635));
            Curvas24.Add(new Point(364, 609));
            Curvas24.Add(new Point(350, 596));


            Timon.AddCurve(Curvas24.ToArray(), 1);


            List<Point> Curvas25 = new List<Point>();
            Curvas25.Add(new Point(350, 596));
            Curvas25.Add(new Point(334, 597));
            Curvas25.Add(new Point(321, 611));


            Timon.AddCurve(Curvas25.ToArray(), 1);


            List<Point> Curvas26 = new List<Point>();
            Curvas26.Add(new Point(321, 611));
            Curvas26.Add(new Point(285, 531));
            Curvas26.Add(new Point(268, 435));


            Timon.AddCurve(Curvas26.ToArray(), 1);
            Timon.AddLine(new Point(268, 435), new Point(294,421));
            List<Point> Curvas27 = new List<Point>();
            Curvas27.Add(new Point(294, 421));
            Curvas27.Add(new Point(303, 395));
            Curvas27.Add(new Point(285, 373));

            Timon.AddCurve(Curvas27.ToArray(), 1);
            Timon.AddLine(new Point(285, 373), new Point(267, 375));


            Dibujo.DrawPath(LapizRojo, Timon);








        }

    }
}


