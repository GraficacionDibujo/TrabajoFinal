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
        Color Cafe = Color.FromArgb(80, 39, 39);
        Color Cafe1 = Color.FromArgb(137,69,69);
        Color FondoPiso = Color.FromArgb(230,164,88);
        Color FondoPared = Color.FromArgb(122,71,42);
        Color Azul1 = Color.FromArgb(89,255,255);
        Color BancasBarco = Color.FromArgb(82,137,131);
        Pen LapizRojo = new Pen(Color.Red, 2);
        Pen LapizAzul = new Pen(Color.Blue, 2);
        Pen LapizNegro = new Pen(Color.Black, 4);
        Pen LapizNaranja = new Pen(Color.Orange, 2);
        Pen LapizBlanco = new Pen(Color.White, 0);
        SolidBrush BrochaRoja = new SolidBrush(Color.Red);
        SolidBrush BrochaAzul = new SolidBrush(Color.Blue);
        SolidBrush BrochaNegra = new SolidBrush(Color.Black);
        SolidBrush BrochaVerde = new SolidBrush(Color.Green);
        SolidBrush BrochaNaranja = new SolidBrush(Color.Orange);

        SolidBrush BrochaBlanca = new SolidBrush(Color.White);
        Graphics Dibujo; //Objeto Graphics
        private void Cuadro_Paint(object sender, PaintEventArgs e)
        {
            Pen LapizBanca = new Pen(BancasBarco, 1);
            SolidBrush BrochaCafe = new SolidBrush(Cafe);
            SolidBrush BrochaCafe1 = new SolidBrush(Cafe1);
            SolidBrush BrochaAzul1 = new SolidBrush(Azul1);
            SolidBrush BrochaFondoPiso = new SolidBrush(FondoPiso);
            SolidBrush BrochaFondoPared = new SolidBrush(FondoPared);
            SolidBrush BrochaBanca = new SolidBrush(BancasBarco);
            Dibujo = e.Graphics; //Para poder dibujar

            FondoFinal();
            PrimerosDibujos();

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

            DibujarLadoIzquierdo();
            DibujarFondoPared();
            //DibujarFondoPiso();
            DetallesPiso();
            DibujarMesa();

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

            DibujarSalvavidas();
            DibujarCuerdas();

        }

        public void DetallesPiso()
        {
            //Detalles Del Piso
            Dibujo.DrawLine(LapizNegro, 1036, 504, 1066, 601);
            Dibujo.DrawLine(LapizNegro, 1174, 513, 1279, 681);
            Dibujo.DrawLine(LapizNegro, 815, 525, 787, 625);
            Dibujo.DrawLine(LapizNegro, 670, 509, 608, 619);
            Dibujo.DrawLine(LapizNegro, 558, 507, 534, 533);
            Dibujo.DrawLine(LapizNegro, 429, 647, 358, 718);

        }

        public void DibujarSalvavidas()
        {

            SolidBrush BrochaCafe = new SolidBrush(Cafe);
            SolidBrush BrochaCafe1 = new SolidBrush(Cafe1);
            SolidBrush BrochaAzul1 = new SolidBrush(Azul1);
            //Salvavidas----------------------------
            Point PC3 = new Point(1174, 199 + 15);
            Point PC4 = new Point(1187, 471);
            int diametro2 = PC4.Y - PC3.Y;
            Dibujo.DrawEllipse(LapizRojo, new Rectangle(1025, 202, diametro2 + 40, diametro2 + 10));
            Dibujo.FillEllipse(BrochaRoja, new Rectangle(1025, 202, diametro2 + 40, diametro2 + 10));


            //Circulo interior del timon
            Point Pc1 = new Point(1173, 300);
            Point Pc2 = new Point(1177, 376);
            int Diametro1 = Pc2.Y - Pc1.Y;
            Dibujo.DrawEllipse(LapizNaranja, new Rectangle(1131, 300, Diametro1 + 13, Diametro1));
            Dibujo.FillEllipse(BrochaCafe, new Rectangle(1131, 300, Diametro1 + 13, Diametro1));
        }

        public void DibujarFondoPared()
        {
            SolidBrush BrochaFondoPared = new SolidBrush(FondoPared);
            GraphicsPath PrimerFondo = new GraphicsPath();
            PrimerFondo.AddLine(1279, 141, 499, 138);
            List<Point> CurvaFizq = new List<Point>();
            CurvaFizq.Add(new Point(504, 154));
            CurvaFizq.Add(new Point(510, 181));
            CurvaFizq.Add(new Point(514, 198));
            CurvaFizq.Add(new Point(519, 233));
            CurvaFizq.Add(new Point(526, 326));
            CurvaFizq.Add(new Point(526, 345));
            CurvaFizq.Add(new Point(524, 394));
            CurvaFizq.Add(new Point(522, 450));
            CurvaFizq.Add(new Point(519, 478));
            CurvaFizq.Add(new Point(518, 494));
            CurvaFizq.Add(new Point(515, 500));
            CurvaFizq.Add(new Point(519, 508));
            PrimerFondo.AddCurve(CurvaFizq.ToArray(), 1);
            PrimerFondo.AddLine(519, 508, 1279, 508);
            PrimerFondo.CloseFigure();
            Dibujo.FillPath(BrochaFondoPared, PrimerFondo);
        }

        public void DibujarFondoPiso()
        {
            Pen LapizBanca = new Pen(BancasBarco, 1);
            SolidBrush BrochaFondoPiso = new SolidBrush(FondoPiso);

            //Segundo Fondo, El piso
            GraphicsPath SegundoFondo = new GraphicsPath();
            SegundoFondo.AddLine(1279, 504, 516, 504);
            List<Point> CurvafSegundo = new List<Point>();//Primera curva
            CurvafSegundo.Add(new Point(515, 513));
            CurvafSegundo.Add(new Point(518, 522));
            CurvafSegundo.Add(new Point(539, 558));
            CurvafSegundo.Add(new Point(533, 578));
            CurvafSegundo.Add(new Point(499, 565));
            SegundoFondo.AddCurve(CurvafSegundo.ToArray(), 1);
            List<Point> CurvafSegundo2 = new List<Point>();
            CurvafSegundo2.Add(new Point(487, 587));
            CurvafSegundo2.Add(new Point(470, 611));
            CurvafSegundo2.Add(new Point(436, 637));
            CurvafSegundo2.Add(new Point(384, 641));
            CurvafSegundo2.Add(new Point(367, 638));
            SegundoFondo.AddCurve(CurvafSegundo2.ToArray(), 1);
            List<Point> CurvafSegundo3 = new List<Point>();
            CurvafSegundo3.Add(new Point(364, 652));
            CurvafSegundo3.Add(new Point(354, 686));
            CurvafSegundo3.Add(new Point(323, 701));
            CurvafSegundo3.Add(new Point(310, 695));
            SegundoFondo.AddCurve(CurvafSegundo3.ToArray(), 1);
            SegundoFondo.AddLine(310, 695, 280, 718);
            SegundoFondo.AddLine(280, 718, 1279, 719);
            SegundoFondo.CloseFigure();
            Dibujo.FillPath(BrochaFondoPiso, SegundoFondo);
            Dibujo.DrawPath(LapizBanca, SegundoFondo);   
        }

        public void PrimerosDibujos()
        {
            SolidBrush BrochaCafe = new SolidBrush(Cafe);
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
        }


        public void DibujarLadoIzquierdo()
        {
            SolidBrush BrochaCafe = new SolidBrush(Cafe);
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
            SegundoRectangulo.Add(new Point(1, 338));
            Dibujo.DrawPolygon(LapizAzul, SegundoRectangulo.ToArray());
            Dibujo.FillPolygon(BrochaCafe, SegundoRectangulo.ToArray());

            //--Primera forma (cuadrado), cerca del timon,lado izquierdo, lado superior      
            GraphicsPath Path = new GraphicsPath();
            Path.StartFigure();
            Path.AddLine(206, 314, 266, 286);
            Path.AddLine(266, 286, 263, 377);
            List<Point> Curva1 = new List<Point>();
            Curva1.Add(new Point(252, 382));
            Curva1.Add(new Point(232, 390));
            Curva1.Add(new Point(221, 396));
            Curva1.Add(new Point(216, 399));
            Curva1.Add(new Point(209, 406));
            Path.AddCurve(Curva1.ToArray(), 1);
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
            SegundaForma.AddCurve(Curva2.ToArray(), 1);
            SegundaForma.AddLine(247, 450, 265, 443);//Primera linea
            List<Point> Curva3 = new List<Point>();//Segunda Curva
            Curva3.Add(new Point(266, 455));
            Curva3.Add(new Point(270, 487));
            Curva3.Add(new Point(284, 543));
            Curva3.Add(new Point(298, 579));
            Curva3.Add(new Point(311, 603));
            Curva3.Add(new Point(318, 615));
            SegundaForma.AddCurve(Curva3.ToArray(), 1);
            List<Point> Curva4 = new List<Point>();//Tercera Curva
            Curva4.Add(new Point(314, 627));
            Curva4.Add(new Point(306, 652));
            Curva4.Add(new Point(306, 677));
            Curva4.Add(new Point(310, 693));
            SegundaForma.AddCurve(Curva4.ToArray(), 1);
            SegundaForma.AddLine(310, 693, 276, 717);//Segunda Linea
            SegundaForma.AddLine(276, 717, 216, 717);//Tercera linea
            SegundaForma.CloseFigure();
            Dibujo.DrawPath(LapizRojo, SegundaForma);
            Dibujo.FillPath(BrochaVerde, SegundaForma);
        
        }

        public void DibujarMesa()
        {
            SolidBrush BrochaBanca = new SolidBrush(BancasBarco);
            Pen LapizBanca = new Pen(BancasBarco, 1);
            //--Primera parte del rectangulo, lado derecho, Entre el timon y cara de mickey mouse, parte superior
            GraphicsPath TerceraForma = new GraphicsPath();
            TerceraForma.AddLine(498, 132, 705, 132);//Primera linea
            TerceraForma.AddLine(710, 136, 720, 146);//Segunda linea
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
            TerceraForma.AddLine(584, 195, 514, 195);//Cuarta linea
            TerceraForma.CloseFigure();
            Dibujo.DrawPath(LapizBanca, TerceraForma);
            Dibujo.FillPath(BrochaBanca, TerceraForma);

            //--Segunda parte del rectangulo, lado derecho,cerca de la cara de mickey, parte superior
            GraphicsPath CuartaForma = new GraphicsPath();
            CuartaForma.AddLine(896, 132, 1279, 132);//Primera linea
            CuartaForma.AddLine(1279, 139, 1279, 205);//Segunda linea
            CuartaForma.AddLine(1279, 200, 1219, 200);//Tercera linea
            //  CuartaForma.AddLine(1219, 202, 1156, 199);//Cuarta linea
            //  CuartaForma.AddLine(1156, 199, 1103, 199);//Quinta linea
            CuartaForma.AddLine(1103, 200, 983, 200);//Sexta linea
            List<Point> Curva7 = new List<Point>();//Primera curva
            Curva7.Add(new Point(978, 186));
            Curva7.Add(new Point(972, 176));
            Curva7.Add(new Point(954, 160));
            Curva7.Add(new Point(935, 151));
            Curva7.Add(new Point(906, 148));
            Curva7.Add(new Point(889, 152));
            Curva7.Add(new Point(880, 154));
            CuartaForma.AddCurve(Curva7.ToArray(), 1);
            CuartaForma.CloseFigure();
            Dibujo.DrawPath(LapizBanca, CuartaForma);
            Dibujo.FillPath(BrochaBanca, CuartaForma);
        }


        public void DibujarCuerdas()
        {
            //Primera cuerda
            GraphicsPath PrimeraCuerda = new GraphicsPath();
            List<Point> Curvacuerda1 = new List<Point>();//Curva superior
            Curvacuerda1.Add(new Point(1022, 326));
            Curvacuerda1.Add(new Point(1052, 343));
            Curvacuerda1.Add(new Point(1064, 348));
            Curvacuerda1.Add(new Point(1081, 349));
            Curvacuerda1.Add(new Point(1096, 348));
            //Curvacuerda1.Add(new Point(1111, 347));
            Curvacuerda1.Add(new Point(1130, 339));

            //Primer lado de la primera cuerda (Derecha)
            //Curvacuerda1.Add(new Point(1132, 342));
            //Curvacuerda1.Add(new Point(1129, 350));
            //Curva Inferior1
            Curvacuerda1.Add(new Point(1120, 354));
            // Curvacuerda1.Add(new Point(1104,359));
            // Curvacuerda1.Add(new Point(1073,360));
            Curvacuerda1.Add(new Point(1052, 357));
            //  Curvacuerda1.Add(new Point(1032, 348));
            //Curvacuerda1.Add(new Point(1019,339));
            //Segundo lado de la primera cuerda (Izquierda)
            // Curvacuerda1.Add(new Point(1018, 338));
            // Curvacuerda1.Add(new Point(1020, 328));
            //PrimeraCuerda.AddCurve(Curvacuerda1.ToArray(), 1);
            PrimeraCuerda.AddClosedCurve(Curvacuerda1.ToArray(), 1);
            // PrimeraCuerda.CloseFigure();
            Dibujo.DrawPath(LapizNegro, PrimeraCuerda);
            Dibujo.FillPath(BrochaBlanca, PrimeraCuerda);

            //Segunda cuerda
            GraphicsPath Segundacuerda = new GraphicsPath();
            List<Point> Curvacuerda2 = new List<Point>();
            Curvacuerda2.Add(new Point(1169, 470));//Primera curva(lado izquierdo)
            Curvacuerda2.Add(new Point(1178, 458));
            Curvacuerda2.Add(new Point(1183, 442));
            Curvacuerda2.Add(new Point(1184, 426));
            Curvacuerda2.Add(new Point(1182, 407));
            Curvacuerda2.Add(new Point(1178, 386));
            Curvacuerda2.Add(new Point(1177, 380));
            //Primer lado (lado superior)
            Curvacuerda2.Add(new Point(1178, 374));
            // Curvacuerda2.Add(new Point(1182, 375));
            Curvacuerda2.Add(new Point(1187, 376));
            // Curvacuerda2.Add(new Point(1189, 378));
            //Segunda curva de la cuerda (lado derecho)
            //Curvacuerda2.Add(new Point(1191,389));
            Curvacuerda2.Add(new Point(1194, 399));
            Curvacuerda2.Add(new Point(1194, 428));
            //Curvacuerda1.Add(new Point(1195, 412));
            Curvacuerda2.Add(new Point(1191, 448));
            Curvacuerda2.Add(new Point(1185, 465));
            Curvacuerda2.Add(new Point(1180, 471));
            Curvacuerda2.Add(new Point(1176, 474));
            //Segundo lado (Lado inferior)
            Curvacuerda2.Add(new Point(1171, 473));
            Curvacuerda2.Add(new Point(1170, 472));
            Segundacuerda.AddClosedCurve(Curvacuerda2.ToArray(), 1);
            Segundacuerda.CloseFigure();
            Dibujo.DrawPath(LapizNegro, Segundacuerda);
            Dibujo.FillPath(BrochaBlanca, Segundacuerda);

            //Tercera cuerda
            GraphicsPath TerceraCuerda = new GraphicsPath();
            List<Point> Curvacuerda3 = new List<Point>();//Primera curva (lado superior
            Curvacuerda3.Add(new Point(1278, 349));
            Curvacuerda3.Add(new Point(1253, 348));
            Curvacuerda3.Add(new Point(1230, 344));
            //Lado izquierdo
            Curvacuerda3.Add(new Point(1215, 332));
            Curvacuerda3.Add(new Point(1221, 330));
            Curvacuerda3.Add(new Point(1225, 332));
            //Segunda curva (lado inferior)
            Curvacuerda3.Add(new Point(1227, 332));
            Curvacuerda3.Add(new Point(1239, 336));
            Curvacuerda3.Add(new Point(1251, 339));
            Curvacuerda3.Add(new Point(1278, 340));
            TerceraCuerda.AddCurve(Curvacuerda3.ToArray(), 1);
            TerceraCuerda.CloseFigure();
            Dibujo.DrawPath(LapizNegro, TerceraCuerda);
            Dibujo.FillPath(BrochaBlanca, TerceraCuerda);

            //Cuarta Cuerda
            GraphicsPath Cuartacuerda = new GraphicsPath();
            List<Point> Curvacuerda4 = new List<Point>();
            Curvacuerda4.Add(new Point(1157, 203));//Primera curva (lado izquierdo)
            Curvacuerda4.Add(new Point(1160, 232));
            Curvacuerda4.Add(new Point(1163, 256));
            Curvacuerda4.Add(new Point(1164, 276));
            Curvacuerda4.Add(new Point(1160, 296));
            //Lado inferior
            Curvacuerda4.Add(new Point(1163, 301));
            Curvacuerda4.Add(new Point(1167, 303));
            Curvacuerda4.Add(new Point(1172, 301));
            //Segunda curva(lado derecho)
            Curvacuerda4.Add(new Point(1176, 291));
            Curvacuerda4.Add(new Point(1179, 264));
            Curvacuerda4.Add(new Point(1178, 241));
            Curvacuerda4.Add(new Point(1176, 213));
            Curvacuerda4.Add(new Point(1172, 199));
            //Lado superior
            Curvacuerda4.Add(new Point(1165, 196));
            Curvacuerda4.Add(new Point(1160, 196));
            Cuartacuerda.AddCurve(Curvacuerda4.ToArray(), 1);
            Cuartacuerda.CloseFigure();
            Dibujo.DrawPath(LapizNegro, Cuartacuerda);
            Dibujo.FillPath(BrochaBlanca, Cuartacuerda);
        }

        public void FondoFinal()
        {
            List<Point> FondoF = new List<Point>();
            FondoF.Add(new Point(0, 0));
            FondoF.Add(new Point(1279, 0));
            FondoF.Add(new Point(1279, 241));
            FondoF.Add(new Point(0, 241));
            FondoF.Add(new Point(0,0));
            Dibujo.FillPolygon(BrochaBlanca, FondoF.ToArray());
        }
    }
}


