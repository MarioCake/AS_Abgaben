using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figurenzeichner
{
  public partial class FRM_main : Form
  {
    private Graphics meineGrafik;
    private Dreieck einDreieck;

    //Konstruktor
    public FRM_main()
    {
      InitializeComponent();
      meineGrafik = CreateGraphics(); //Zeichen-Objekt erstellen
    }

    //Eine Figur zeichnen
    private void ZeichneFigur(Figur eineFigur)
    {      
      //Malsachen erzeugen
      var meinStift = new Pen(Color.Red, 3);
      var meinPinsel = new SolidBrush(Color.Red);

      meineGrafik.ResetTransform(); //Verschiebung des Koordinatensystems zuruecksetzen
      meineGrafik.TranslateTransform(Width / 2, Height / 2); //Ursprung des Koord.systems in Clientmitte verschieben

      zeichneKoordinatensystem();

      meineGrafik.DrawPolygon(meinStift, eineFigur.ArrayKoordinaten.ToPointArray()); //Figur zeichnen
      meineGrafik.FillEllipse(meinPinsel, (int)Math.Round(eineFigur.Mittelpunkt.X), (int)Math.Round(eineFigur.Mittelpunkt.Y), 5, 5); //Mittelpunkt zeichnen
    }

    //Ein Dreieck zeichnen
    private void btn_zeichneDreieck_Click(object sender, EventArgs e)
    {
      var arrayKoordinaten = new Vector2d[3];

      var x = Convert.ToDouble(tbx_dreieck_p1x.Text);
      var y = Convert.ToDouble(tbx_dreieck_p1y.Text);
      arrayKoordinaten[0] = new Vector2d(x, y);

      x = Convert.ToDouble(tbx_dreieck_p2x.Text);
      y = Convert.ToDouble(tbx_dreieck_p2y.Text);

      arrayKoordinaten[1] = new Vector2d(x, y);

      x = Convert.ToDouble(tbx_dreieck_p3x.Text);
      y = Convert.ToDouble(tbx_dreieck_p3y.Text);
      arrayKoordinaten[2] = new Vector2d(x, y);

      einDreieck = new Dreieck(arrayKoordinaten); //Dreieck erzeugen...
      ZeichneFigur(einDreieck); //...und zeichnen
    }

    //Dreieck drehen
    private void btn_dreheDreieck(object sender, EventArgs e)
    {
      einDreieck.DreheFigur(Convert.ToInt32(tbx_dreieck_winkel.Text));
      ZeichneFigur(einDreieck);
    }

    //Wischi-Waschi machen
    private void btn_wisch_Click(object sender, EventArgs e)
    {
      meineGrafik.Clear(BackColor);
    }

    //Koordinatensystem zeichen
    private void zeichneKoordinatensystem()
    {
      Point pStart, pEnde;
      var meinStift = new Pen(Color.Black, 1);

      //y-Achse
      pStart = new Point(0, -ClientSize.Height / 2);
      pEnde = new Point(0,ClientSize.Height / 2);

      meineGrafik.DrawLine(meinStift, pStart, pEnde);

      //x-Achse
      pStart = new Point(-ClientSize.Width / 2, 0);
      pEnde = new Point(ClientSize.Width / 2, 0);

      meineGrafik.DrawLine(meinStift, pStart, pEnde);
    }
  }
}

