using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Figurenzeichner
{
  partial class FRM_main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.tbx_dreieck_winkel = new TextBox();
      this.button1 = new Button();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.tbx_dreieck_p3y = new TextBox();
      this.tbx_dreieck_p3x = new TextBox();
      this.tbx_dreieck_p2y = new TextBox();
      this.tbx_dreieck_p2x = new TextBox();
      this.tbx_dreieck_p1y = new TextBox();
      this.tbx_dreieck_p1x = new TextBox();
      this.btn_zeichneDreieck = new Button();
      this.btn_wisch = new Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbx_dreieck_winkel);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.tbx_dreieck_p3y);
      this.groupBox1.Controls.Add(this.tbx_dreieck_p3x);
      this.groupBox1.Controls.Add(this.tbx_dreieck_p2y);
      this.groupBox1.Controls.Add(this.tbx_dreieck_p2x);
      this.groupBox1.Controls.Add(this.tbx_dreieck_p1y);
      this.groupBox1.Controls.Add(this.tbx_dreieck_p1x);
      this.groupBox1.Controls.Add(this.btn_zeichneDreieck);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(295, 145);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dreieck";
      // 
      // tbx_dreieck_winkel
      // 
      this.tbx_dreieck_winkel.Location = new Point(214, 77);
      this.tbx_dreieck_winkel.Name = "tbx_dreieck_winkel";
      this.tbx_dreieck_winkel.Size = new Size(55, 20);
      this.tbx_dreieck_winkel.TabIndex = 27;
      this.tbx_dreieck_winkel.Text = "10";
      // 
      // button1
      // 
      this.button1.Location = new Point(214, 100);
      this.button1.Name = "button1";
      this.button1.Size = new Size(55, 23);
      this.button1.TabIndex = 26;
      this.button1.Text = "Drehen";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.btn_dreheDreieck);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new Point(11, 77);
      this.label5.Name = "label5";
      this.label5.Size = new Size(14, 13);
      this.label5.TabIndex = 25;
      this.label5.Text = "Y";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new Point(11, 51);
      this.label4.Name = "label4";
      this.label4.Size = new Size(14, 13);
      this.label4.TabIndex = 24;
      this.label4.Text = "X";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new Point(169, 32);
      this.label3.Name = "label3";
      this.label3.Size = new Size(23, 13);
      this.label3.TabIndex = 23;
      this.label3.Text = "P 3";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new Point(108, 32);
      this.label2.Name = "label2";
      this.label2.Size = new Size(23, 13);
      this.label2.TabIndex = 22;
      this.label2.Text = "P 2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new Point(48, 32);
      this.label1.Name = "label1";
      this.label1.Size = new Size(23, 13);
      this.label1.TabIndex = 21;
      this.label1.Text = "P 1";
      // 
      // tbx_dreieck_p3y
      // 
      this.tbx_dreieck_p3y.Location = new Point(153, 74);
      this.tbx_dreieck_p3y.Name = "tbx_dreieck_p3y";
      this.tbx_dreieck_p3y.Size = new Size(55, 20);
      this.tbx_dreieck_p3y.TabIndex = 20;
      this.tbx_dreieck_p3y.Text = "300";
      // 
      // tbx_dreieck_p3x
      // 
      this.tbx_dreieck_p3x.Location = new Point(153, 48);
      this.tbx_dreieck_p3x.Name = "tbx_dreieck_p3x";
      this.tbx_dreieck_p3x.Size = new Size(55, 20);
      this.tbx_dreieck_p3x.TabIndex = 19;
      this.tbx_dreieck_p3x.Text = "0";
      // 
      // tbx_dreieck_p2y
      // 
      this.tbx_dreieck_p2y.Location = new Point(92, 74);
      this.tbx_dreieck_p2y.Name = "tbx_dreieck_p2y";
      this.tbx_dreieck_p2y.Size = new Size(55, 20);
      this.tbx_dreieck_p2y.TabIndex = 18;
      this.tbx_dreieck_p2y.Text = "0";
      // 
      // tbx_dreieck_p2x
      // 
      this.tbx_dreieck_p2x.Location = new Point(92, 48);
      this.tbx_dreieck_p2x.Name = "tbx_dreieck_p2x";
      this.tbx_dreieck_p2x.Size = new Size(55, 20);
      this.tbx_dreieck_p2x.TabIndex = 17;
      this.tbx_dreieck_p2x.Text = "+200";
      // 
      // tbx_dreieck_p1y
      // 
      this.tbx_dreieck_p1y.Location = new Point(31, 74);
      this.tbx_dreieck_p1y.Name = "tbx_dreieck_p1y";
      this.tbx_dreieck_p1y.Size = new Size(55, 20);
      this.tbx_dreieck_p1y.TabIndex = 16;
      this.tbx_dreieck_p1y.Text = "0";
      // 
      // tbx_dreieck_p1x
      // 
      this.tbx_dreieck_p1x.Location = new Point(31, 48);
      this.tbx_dreieck_p1x.Name = "tbx_dreieck_p1x";
      this.tbx_dreieck_p1x.Size = new Size(55, 20);
      this.tbx_dreieck_p1x.TabIndex = 15;
      this.tbx_dreieck_p1x.Text = "-200";
      // 
      // btn_zeichneDreieck
      // 
      this.btn_zeichneDreieck.Location = new Point(31, 100);
      this.btn_zeichneDreieck.Name = "btn_zeichneDreieck";
      this.btn_zeichneDreieck.Size = new Size(177, 23);
      this.btn_zeichneDreieck.TabIndex = 14;
      this.btn_zeichneDreieck.Text = "Zeichnen";
      this.btn_zeichneDreieck.UseVisualStyleBackColor = true;
      this.btn_zeichneDreieck.Click += new EventHandler(this.btn_zeichneDreieck_Click);
      // 
      // btn_wisch
      // 
      this.btn_wisch.Location = new Point(313, 22);
      this.btn_wisch.Name = "btn_wisch";
      this.btn_wisch.Size = new Size(97, 23);
      this.btn_wisch.TabIndex = 15;
      this.btn_wisch.Text = "WischiWaschi";
      this.btn_wisch.UseVisualStyleBackColor = true;
      this.btn_wisch.Click += new EventHandler(this.btn_wisch_Click);
      // 
      // FRM_main
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(984, 864);
      this.Controls.Add(this.btn_wisch);
      this.Controls.Add(this.groupBox1);
      this.Name = "FRM_main";
      this.Text = "Figuren Zeichner 0.1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private GroupBox groupBox1;
    private TextBox tbx_dreieck_winkel;
    private Button button1;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox tbx_dreieck_p3y;
    private TextBox tbx_dreieck_p3x;
    private TextBox tbx_dreieck_p2y;
    private TextBox tbx_dreieck_p2x;
    private TextBox tbx_dreieck_p1y;
    private TextBox tbx_dreieck_p1x;
    private Button btn_zeichneDreieck;
    private Button btn_wisch;


  }
}

