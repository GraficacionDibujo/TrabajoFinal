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
        Pen LapizRojo = new Pen(Color.Black, 5);
        Pen LapizAzul = new Pen(Color.Blue, 5);
        SolidBrush BrochaCafe = new SolidBrush(Color.White);
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

            Dibujo.DrawPath(LapizAzul, QuintaForma);


           






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
           Dibujo.FillPath(BrochaCafe, Timon);

            Dibujo.DrawPath(LapizRojo, Timon);
   


            // Hecho por --Davalos
            GraphicsPath LineaInteriorTimon = new GraphicsPath();
            List<Point> Curvas30 = new List<Point>();
            Curvas30.Add(new Point(421, 634));
            Curvas30.Add(new Point(400, 628));
            Curvas30.Add(new Point(376, 610));
            LineaInteriorTimon.AddCurve(Curvas30.ToArray(), 1);
            List<Point> Curvas31 = new List<Point>();
            Curvas31.Add(new Point(376, 610));
            Curvas31.Add(new Point(352,574));
            Curvas31.Add(new Point(334, 518));
            LineaInteriorTimon.AddCurve(Curvas31.ToArray(), 1);
            List<Point> Curvas32 = new List<Point>();
            Curvas32.Add(new Point(334, 518));
            Curvas32.Add(new Point(322, 460));
            Curvas32.Add(new Point(315, 400));
            LineaInteriorTimon.AddCurve(Curvas32.ToArray(), 1);
            List<Point> Curvas33 = new List<Point>();
            Curvas33.Add(new Point(315, 400));
            Curvas33.Add(new Point(312, 339));
            Curvas33.Add(new Point(315, 287));
            LineaInteriorTimon.AddCurve(Curvas33.ToArray(), 1);
            List<Point> Curvas34 = new List<Point>();
            Curvas34.Add(new Point(315, 287));
            Curvas34.Add(new Point(328, 202));
            Curvas34.Add(new Point(335, 175));
            LineaInteriorTimon.AddCurve(Curvas34.ToArray(), 1);
            List<Point> Curvas35 = new List<Point>();
            Curvas35.Add(new Point(335, 175));
            Curvas35.Add(new Point(349, 131));
            Curvas35.Add(new Point(364, 100));
            LineaInteriorTimon.AddCurve(Curvas35.ToArray(), 1);
            List<Point> Curvas36 = new List<Point>();
            Curvas36.Add(new Point(364, 100));
            Curvas36.Add(new Point(385, 74));
            Curvas36.Add(new Point(413, 54));
            LineaInteriorTimon.AddCurve(Curvas36.ToArray(), 1);
            Dibujo.DrawPath(LapizRojo, LineaInteriorTimon);


      

            // Hecho por --Davalos
            GraphicsPath CirculoInteriorTimon = new GraphicsPath();
            List<Point> Curvas37 = new List<Point>();
            Curvas37.Add(new Point(428, 571));
            Curvas37.Add(new Point(395, 550));
            Curvas37.Add(new Point(369, 494));
            CirculoInteriorTimon.AddCurve(Curvas37.ToArray(), 1);
            List<Point> Curvas38 = new List<Point>();
            Curvas38.Add(new Point(369, 494));
            Curvas38.Add(new Point(357, 437));
            Curvas38.Add(new Point(354, 390));
            CirculoInteriorTimon.AddCurve(Curvas38.ToArray(), 1);
            List<Point> Curvas39 = new List<Point>();
            Curvas39.Add(new Point(354, 390));
            Curvas39.Add(new Point(356, 330));
            Curvas39.Add(new Point(358, 281));
            CirculoInteriorTimon.AddCurve(Curvas39.ToArray(), 1);
            List<Point> Curvas40 = new List<Point>();
            Curvas40.Add(new Point(358, 281));
            Curvas40.Add(new Point(363, 248));
            Curvas40.Add(new Point(380, 187));
            CirculoInteriorTimon.AddCurve(Curvas40.ToArray(), 1);
            List<Point> Curvas41 = new List<Point>();
            Curvas41.Add(new Point(380, 187));
            Curvas41.Add(new Point(391, 160));
            Curvas41.Add(new Point(408, 132));
            CirculoInteriorTimon.AddCurve(Curvas41.ToArray(), 1);
            List<Point> Curvas42 = new List<Point>();
            Curvas42.Add(new Point(408, 132));
            Curvas42.Add(new Point(428, 124));
            Curvas42.Add(new Point(449, 132));
            CirculoInteriorTimon.AddCurve(Curvas42.ToArray(), 1);
            List<Point> Curvas43 = new List<Point>();
            Curvas43.Add(new Point(449, 132));
            Curvas43.Add(new Point(472, 168));
            Curvas43.Add(new Point(485, 219));
            CirculoInteriorTimon.AddCurve(Curvas43.ToArray(), 1);
            List<Point> Curvas44 = new List<Point>();
            Curvas44.Add(new Point(485, 219));
            Curvas44.Add(new Point(489, 255));
            Curvas44.Add(new Point(497, 305));
            CirculoInteriorTimon.AddCurve(Curvas44.ToArray(), 1);
            List<Point> Curvas45 = new List<Point>();
            Curvas45.Add(new Point(497, 305));
            Curvas45.Add(new Point(498, 356));
            Curvas45.Add(new Point(498, 409));
            CirculoInteriorTimon.AddCurve(Curvas45.ToArray(), 1);
            List<Point> Curvas46 = new List<Point>();
            Curvas46.Add(new Point(498, 409));
            Curvas46.Add(new Point(493, 449));
            Curvas46.Add(new Point(482, 505));
            CirculoInteriorTimon.AddCurve(Curvas46.ToArray(), 1);
            List<Point> Curvas47 = new List<Point>();
            Curvas47.Add(new Point(482, 505));
            Curvas47.Add(new Point(461, 548));
            Curvas47.Add(new Point(428, 571));
            CirculoInteriorTimon.AddCurve(Curvas47.ToArray(), 1);
            Dibujo.FillPath(BrochaNegra, CirculoInteriorTimon);
            Dibujo.DrawPath(LapizRojo, CirculoInteriorTimon);

            // Hecho por --Davalos Palo timon2
            GraphicsPath PaloTimon2 = new GraphicsPath();
            PaloTimon2.AddLine(367, 228, 405, 297);
            List<Point> Curvas28 = new List<Point>();
            Curvas28.Add(new Point(402, 315));
            Curvas28.Add(new Point(386, 313));
            Curvas28.Add(new Point(373, 314));
            PaloTimon2.AddCurve(Curvas28.ToArray(), 1);
            PaloTimon2.AddLine(373, 314, 360, 284);
            List<Point> Curvas29 = new List<Point>();
            Curvas29.Add(new Point(360, 284));
            Curvas29.Add(new Point(361, 260));
            Curvas29.Add(new Point(367, 227));
            PaloTimon2.AddCurve(Curvas29.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, PaloTimon2);
            Dibujo.DrawPath(LapizRojo, PaloTimon2);



            GraphicsPath FiguraDentroTImon = new GraphicsPath();
            List<Point> Curvas48 = new List<Point>();
            Curvas48.Add(new Point(425, 155));
            Curvas48.Add(new Point(413, 145));
            Curvas48.Add(new Point(404, 136));

            FiguraDentroTImon.AddCurve(Curvas48.ToArray());
            List<Point> Curvas94 = new List<Point>();
            Curvas94.Add(new Point(404, 136));
            Curvas94.Add(new Point(418, 126));
            Curvas94.Add(new Point(434, 124));
            FiguraDentroTImon.AddCurve(Curvas94.ToArray());
            List<Point> Curvas95 = new List<Point>();
            Curvas95.Add(new Point(434, 124));
            Curvas95.Add(new Point(450, 134));
            Curvas95.Add(new Point(461, 152));
            FiguraDentroTImon.AddCurve(Curvas95.ToArray());
            List<Point> Curvas96 = new List<Point>();
            Curvas96.Add(new Point(461, 152));
            Curvas96.Add(new Point(440, 140));
            Curvas96.Add(new Point(425, 142));
            FiguraDentroTImon.AddLine(425, 142, 425, 152);
            FiguraDentroTImon.AddCurve(Curvas96.ToArray());
            Dibujo.FillPath(BrochaCafe, FiguraDentroTImon);
            Dibujo.DrawPath(LapizRojo, FiguraDentroTImon);



            //AgarredeTimon4
            GraphicsPath AgarreTimon4 = new GraphicsPath();
            List<Point> Curvas50 = new List<Point>();
            Curvas50.Add(new Point(511, 505));
            Curvas50.Add(new Point(504, 536));
            Curvas50.Add(new Point(494, 563));
            AgarreTimon4.AddCurve(Curvas50.ToArray(), 1);
            List<Point> Curvas49 = new List<Point>();
            Curvas49.Add(new Point(494, 563));
            Curvas49.Add(new Point(512, 582));
            Curvas49.Add(new Point(532, 581));
            AgarreTimon4.AddCurve(Curvas49.ToArray(), 1);
            List<Point> Curvas51 = new List<Point>();
            Curvas51.Add(new Point(532, 581));
            Curvas51.Add(new Point(542, 564));
            Curvas51.Add(new Point(539, 547));
            AgarreTimon4.AddCurve(Curvas51.ToArray(), 1);
            AgarreTimon4.AddLine(539, 547, 511, 505);
            Dibujo.FillPath(BrochaCafe, AgarreTimon4);
            Dibujo.DrawPath(LapizRojo, AgarreTimon4);



            //AgarredeTimon4
            GraphicsPath AgarreTimon5 = new GraphicsPath();
            List<Point> Curvas52 = new List<Point>();
            Curvas52.Add(new Point(477, 95));
            Curvas52.Add(new Point(459, 74));
            Curvas52.Add(new Point(437, 59));
            AgarreTimon5.AddCurve(Curvas52.ToArray(), 1);
            AgarreTimon5.AddLine(437, 59, 446, 31);
            List<Point> Curvas54 = new List<Point>();
            Curvas54.Add(new Point(446, 31));
            Curvas54.Add(new Point(455, 12));
            Curvas54.Add(new Point(472, 4));
            AgarreTimon5.AddCurve(Curvas54.ToArray(), 1);
            List<Point> Curvas55 = new List<Point>();
            Curvas55.Add(new Point(472, 4));
            Curvas55.Add(new Point(491, 20));
            Curvas55.Add(new Point(490, 54));
            AgarreTimon5.AddCurve(Curvas55.ToArray(), 1);
            AgarreTimon5.AddLine(490, 54, 477, 92);
            Dibujo.FillPath(BrochaCafe, AgarreTimon5);
            Dibujo.DrawPath(LapizRojo, AgarreTimon5);


            //Circulo cerca de la mano de mickey
            GraphicsPath Circulomano = new GraphicsPath();
            List<Point> Curvas56 = new List<Point>();
            Curvas56.Add(new Point(419, 319));
            Curvas56.Add(new Point(425, 304));
            Curvas56.Add(new Point(436, 292));
            Circulomano.AddCurve(Curvas56.ToArray(), 1);
            List<Point> Curvas57 = new List<Point>();
            Curvas57.Add(new Point(436, 292));
            Curvas57.Add(new Point(451, 297));
            Curvas57.Add(new Point(460, 318));
            Circulomano.AddCurve(Curvas57.ToArray(), 1);
            List<Point> Curvas58 = new List<Point>();
            Curvas58.Add(new Point(460, 318));
            Curvas58.Add(new Point(463,333));
            Curvas58.Add(new Point(464,356));
            Circulomano.AddCurve(Curvas58.ToArray(), 1);
            Circulomano.AddLine(464, 356, 453, 357);
            List<Point> Curvas59 = new List<Point>();
            Curvas59.Add(new Point(453, 357));
            Curvas59.Add(new Point(451,339));
            Curvas59.Add(new Point(443,327));
            Circulomano.AddCurve(Curvas59.ToArray(), 1);
            List<Point> Curvas60 = new List<Point>();
            Curvas60.Add(new Point(443, 327));
            Curvas60.Add(new Point(433, 330));
            Circulomano.AddCurve(Curvas60.ToArray(), 1);
            List<Point> Curvas61 = new List<Point>();
            Curvas61.Add(new Point(433, 330));
            Curvas61.Add(new Point(427, 323));
            Curvas61.Add(new Point(419, 319));
            Circulomano.AddCurve(Curvas61.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, Circulomano);
            Dibujo.DrawPath(LapizRojo, Circulomano);

            //Palo timon
            GraphicsPath PaloTimon3 = new GraphicsPath();
            List<Point> Curvas62 = new List<Point>();
            Curvas62.Add(new Point(379, 419));
            Curvas62.Add(new Point(394, 419));
            Curvas62.Add(new Point(412, 413));
            PaloTimon3.AddCurve(Curvas62.ToArray(), 1);
            PaloTimon3.AddLine(412, 413, 387, 538);
            List<Point> Curvas63 = new List<Point>();
            Curvas63.Add(new Point(387, 538));
            Curvas63.Add(new Point(372, 503));
            Curvas63.Add(new Point(365, 476));
            PaloTimon3.AddCurve(Curvas63.ToArray(), 1);
            PaloTimon3.AddLine(365, 476, 379, 417);
            Dibujo.FillPath(BrochaCafe, PaloTimon3);
            Dibujo.DrawPath(LapizRojo, PaloTimon3);



            //Palo timon
            GraphicsPath PaloTimon4 = new GraphicsPath();
            List<Point> Curvas64 = new List<Point>();
            Curvas64.Add(new Point(418, 411));
            Curvas64.Add(new Point(434, 410));
            Curvas64.Add(new Point(451, 405));
            PaloTimon4.AddCurve(Curvas64.ToArray(), 1);
            List<Point> Curvas65 = new List<Point>();
            Curvas65.Add(new Point(451, 405));
            Curvas65.Add(new Point(471,435));
            Curvas65.Add(new Point(487,474));
            PaloTimon4.AddCurve(Curvas65.ToArray(), 1);
            List<Point> Curvas66 = new List<Point>();
            Curvas66.Add(new Point(487, 474));
            Curvas66.Add(new Point(477, 490));
            Curvas66.Add(new Point(455, 488));
            PaloTimon4.AddCurve(Curvas66.ToArray(), 1);
            PaloTimon4.AddLine(455, 488, 418, 411);
            Dibujo.FillPath(BrochaCafe, PaloTimon4);
            Dibujo.DrawPath(LapizRojo, PaloTimon4);


            //Palo timon
            GraphicsPath PaloTimon5 = new GraphicsPath();
            List<Point> Curvas67 = new List<Point>();
            Curvas67.Add(new Point(457, 301));
            Curvas67.Add(new Point(469, 292));
            Curvas67.Add(new Point(482, 290));
            PaloTimon5.AddCurve(Curvas67.ToArray(), 1);
            List<Point> Curvas68 = new List<Point>();
            Curvas68.Add(new Point(482, 290));
            Curvas68.Add(new Point(489, 297));
            Curvas68.Add(new Point(493, 318));
           PaloTimon5.AddCurve(Curvas68.ToArray(), 1);
            List<Point> Curvas69 = new List<Point>();
            Curvas69.Add(new Point(493, 318));
            Curvas69.Add(new Point(489, 326));
            Curvas69.Add(new Point(479, 330));
           PaloTimon5.AddCurve(Curvas69.ToArray(), 1);
            PaloTimon5.AddLine(479, 330, 464, 337);
            List<Point> Curvas70 = new List<Point>();
            Curvas70.Add(new Point(464, 337));
            Curvas70.Add(new Point(459, 315));
            Curvas70.Add(new Point(454, 298));
            PaloTimon5.AddCurve(Curvas70.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, PaloTimon5);
            Dibujo.DrawPath(LapizRojo, PaloTimon5);


            //Linea de cerca de la mano de mickey
            GraphicsPath LineaMano = new GraphicsPath();
            List<Point> Curvas71 = new List<Point>();
            Curvas71.Add(new Point(430, 402));
            Curvas71.Add(new Point(439, 405));
            Curvas71.Add(new Point(450, 402));
            LineaMano.AddCurve(Curvas71.ToArray(), 1);
            List<Point> Curvas72 = new List<Point>();
            Curvas72.Add(new Point(450, 402));
            Curvas72.Add(new Point(455, 394));
            Curvas72.Add(new Point(459, 386));
            LineaMano.AddCurve(Curvas72.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, LineaMano);
            Dibujo.DrawPath(LapizRojo, LineaMano);


            //Linea de abajo centro de mickey
            GraphicsPath LineaTimon = new GraphicsPath();
            List<Point> Curvas73 = new List<Point>();
            Curvas73.Add(new Point(408, 561));
            Curvas73.Add(new Point(424, 548));
            Curvas73.Add(new Point(440, 526));
            LineaTimon.AddCurve(Curvas73.ToArray(), 1);
            List<Point> Curvas74 = new List<Point>();
            Curvas74.Add(new Point(440, 526));
            Curvas74.Add(new Point(449, 504));
            Curvas74.Add(new Point(453, 484));
            LineaTimon.AddCurve(Curvas74.ToArray(), 1);
            List<Point> Curvas90 = new List<Point>();
            Curvas90.Add(new Point(453, 484));
            Curvas90.Add(new Point(470, 489));
            Curvas90.Add(new Point(486, 484));
            LineaTimon.AddCurve(Curvas90.ToArray(), 1);
            List<Point> Curvas91 = new List<Point>();
            Curvas91.Add(new Point(486, 484));
            Curvas91.Add(new Point(477, 517));
            Curvas91.Add(new Point(464, 545));
            LineaTimon.AddCurve(Curvas91.ToArray(), 1);
            List<Point> Curvas92 = new List<Point>();
            Curvas92.Add(new Point(464, 545));
            Curvas92.Add(new Point(439, 564));
            Curvas92.Add(new Point(408, 561));

            LineaTimon.AddCurve(Curvas92.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, LineaTimon);
            Dibujo.DrawPath(LapizRojo, LineaTimon);

            //Linea de abajo centro de mickey
            GraphicsPath LineaTimon2 = new GraphicsPath();
            List<Point> Curvas75 = new List<Point>();
            Curvas75.Add(new Point(461, 415));
            Curvas75.Add(new Point(464, 398));
            Curvas75.Add(new Point(464, 382));
            LineaTimon2.AddCurve(Curvas75.ToArray(), 1);
            LineaTimon2.AddLine(464, 382, 498, 374);
            List<Point> Curvas103 = new List<Point>();
            Curvas103.Add(new Point(498, 374));
            Curvas103.Add(new Point(496, 417));
            Curvas103.Add(new Point(489, 470));
            LineaTimon2.AddCurve(Curvas103.ToArray(), 1);
            List<Point> Curvas104 = new List<Point>();
            Curvas104.Add(new Point(489, 470));
            Curvas104.Add(new Point(472, 436));
            Curvas104.Add(new Point(459, 412));
            LineaTimon2.AddCurve(Curvas104.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, LineaTimon2);

            Dibujo.DrawPath(LapizRojo, LineaTimon2);

            GraphicsPath LineaTimon3 = new GraphicsPath();
            List<Point> Curvas76 = new List<Point>();
            Curvas76.Add(new Point(456, 296));
            Curvas76.Add(new Point(453, 264));
            Curvas76.Add(new Point(446, 230));
            LineaTimon3.AddCurve(Curvas76.ToArray(), 1);
            LineaTimon3.AddLine(446, 230, 463, 153);

            List<Point> Curvas98 = new List<Point>();
            Curvas98.Add(new Point(463, 153));
            Curvas98.Add(new Point(480, 196));
            Curvas98.Add(new Point(489, 244));
            LineaTimon3.AddCurve(Curvas98.ToArray(), 1);
            List<Point> Curvas99 = new List<Point>();
            Curvas99.Add(new Point(489, 244));
            Curvas99.Add(new Point(491, 266));
            Curvas99.Add(new Point(497, 309));
            LineaTimon3.AddCurve(Curvas99.ToArray(), 1);
            LineaTimon3.AddLine(497, 309, 492, 312);
            List<Point> Curvas100 = new List<Point>();
            Curvas100.Add(new Point(492, 312));
            Curvas100.Add(new Point(490, 299));
            Curvas100.Add(new Point(484, 291));
            LineaTimon3.AddCurve(Curvas100.ToArray(), 1);
            List<Point> Curvas101 = new List<Point>();
            Curvas101.Add(new Point(484, 291));
            Curvas101.Add(new Point(472, 290));
            Curvas101.Add(new Point(456, 296));
            
            LineaTimon3.AddCurve(Curvas101.ToArray(), 1);
            Dibujo.FillPath(BrochaCafe, LineaTimon3);
            Dibujo.DrawPath(LapizRojo, LineaTimon3);


            //Timon Agarradera1
            List<Point> Curvas8 = new List<Point>();
            Curvas8.Add(new Point(287, 181));
            Curvas8.Add(new Point(240, 105));
            Curvas8.Add(new Point(273, 76));
            Curvas8.Add(new Point(318, 156));
            Dibujo.FillClosedCurve(BrochaCafe, Curvas8.ToArray());
            Dibujo.DrawClosedCurve(LapizRojo, Curvas8.ToArray());



            //Timon Agarradera2
            List<Point> Curvas9 = new List<Point>();//Primera curva
            Curvas9.Add(new Point(212, 406));
            Curvas9.Add(new Point(223, 448));
            Curvas9.Add(new Point(299, 415));
            Curvas9.Add(new Point(286, 375));
            Dibujo.FillClosedCurve(BrochaCafe, Curvas9.ToArray());
            Dibujo.DrawClosedCurve(LapizRojo, Curvas9.ToArray());


            //Timon Agarradera3
            List<Point> Curvas10 = new List<Point>();//Primera curva
            Curvas10.Add(new Point(327, 605));
            Curvas10.Add(new Point(308, 664));
            Curvas10.Add(new Point(307, 673));
            Curvas10.Add(new Point(320, 696));
            Curvas10.Add(new Point(352, 684));
            Curvas10.Add(new Point(363, 609));
            Dibujo.FillClosedCurve(BrochaCafe, Curvas10.ToArray());
            Dibujo.DrawClosedCurve(LapizRojo, Curvas10.ToArray());


            GraphicsPath PaloTimon = new GraphicsPath();
            PaloTimon.AddLine(new Point(406, 289), new Point(427, 143));
            List<Point> Curvas11 = new List<Point>();
            Curvas11.Add(new Point(427, 143));
            Curvas11.Add(new Point(442, 142));
            Curvas11.Add(new Point(462, 152));
            PaloTimon.AddCurve(Curvas11.ToArray(), 1);
            PaloTimon.AddLine(new Point(462, 152), new Point(434, 291));
            PaloTimon.CloseFigure();
            Dibujo.FillPath(BrochaCafe, PaloTimon);
            Dibujo.DrawPath(LapizRojo, PaloTimon);


            GraphicsPath Lineatimon4 = new GraphicsPath();
            Lineatimon4.AddLine(new Point(403, 313), new Point(404, 288));
            Lineatimon4.AddLine(new Point(404, 288), new Point(431, 291));
            Lineatimon4.AddLine(new Point(431, 291), new Point(418, 317));
            Lineatimon4.AddLine(new Point(418, 317), new Point(403, 313));
            Dibujo.FillPath(BrochaCafe, Lineatimon4);

            Dibujo.DrawPath(LapizRojo, Lineatimon4);

            GraphicsPath Lineatimon5 = new GraphicsPath();
            Lineatimon5.AddLine(new Point(466, 356), new Point(466, 336));
            Lineatimon5.AddLine(new Point(466, 336), new Point(495, 324));
            Lineatimon5.AddLine(new Point(495, 324), new Point(496, 355));
            Lineatimon5.AddLine(new Point(496, 355), new Point(466, 356));
            Dibujo.FillPath(BrochaCafe, Lineatimon5);

            Dibujo.DrawPath(LapizRojo, Lineatimon5);

            Dibujo.DrawLine(LapizRojo,437, 408, 420, 404);


        }

    }
}


