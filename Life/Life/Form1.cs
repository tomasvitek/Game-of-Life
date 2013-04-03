using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;

namespace Life
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;

        bool kreslit = false;

        int x;
        int y;

        int sizePanelX;
        int sizePanelY;

        int sizeX;
        int sizeY;

        bool upozorneno = false;
        bool mamZastavit = true;

        int[,] pole;
        int[,] poleMinule;

        int[,] sousedePoli;

        bool[] preziva = new bool[9];
        bool[] vznika = new bool[9];

        int pocetGeneraci = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        //should paint when mouse button is pressed down
        private void drawingPanelForm_MouseDown(object sender, MouseEventArgs e)
        {
            //indicate that user is dragging the mouse
            if (kreslit) shouldPaint = true;
        }
        //stop painting when mouse button is released
        private void drawingPanelForm_MouseUp(object sender, MouseEventArgs e)
        {
            //indicate that user released the mouse button
            shouldPaint = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (kreslit) kresli();
        }

        private void sousede()
        {
            int[,] soused = new int[8, 2];
            soused[0, 0] = -1;
            soused[0, 1] = 1;

            soused[1, 0] = 0;
            soused[1, 1] = 1;

            soused[2, 0] = 1;
            soused[2, 1] = 1;

            soused[3, 0] = -1;
            soused[3, 1] = 0;

            soused[4, 0] = 1;
            soused[4, 1] = 0;

            soused[5, 0] = -1;
            soused[5, 1] = -1;

            soused[6, 0] = 0;
            soused[6, 1] = -1;

            soused[7, 0] = 1;
            soused[7, 1] = -1;

            for (int xx = 0; xx < x; xx++)
                for (int yy = 0; yy < y; yy++)
                {
                    int pocet = 0;

                    for (int i = 0; i < 8; i++)
                        if (((xx + soused[i, 0]) >= 0) && ((yy + soused[i, 1]) >= 0) && ((xx + soused[i, 0]) < x) && ((yy + soused[i, 1]) < y)) if (pole[(xx + soused[i, 0]), (yy + soused[i, 1])] != 0) pocet++;

                    sousedePoli[xx, yy] = pocet;
                }
        }

        private void kresli()
        {
            Graphics graphics = this.panel1.CreateGraphics();

            for (int i = 0; i <= (sizeX + 1) * x; i = i + sizeX + 1)
            {
                // Create the starting point.
                Point startPoint = new Point(i, 0);

                // Use the addition operator to get the end point.
                Point endPoint = new Point(i, (sizeY + 1) * y);

                graphics.DrawLine(SystemPens.Highlight, startPoint, endPoint);
               
            }

            for (int i = 0; i <= (sizeY + 1) * y; i = i + sizeY + 1)
            {
                // Create the starting point.
                Point startPoint = new Point(0, i);

                // Use the addition operator to get the end point.
                Point endPoint = new Point((sizeX + 1)*x, i);

                graphics.DrawLine(SystemPens.Highlight, startPoint, endPoint);

            }

            for (int i = 0; i < x; i++)
                for (int ii = 0; ii < y; ii++)
                {
                    if (pole[i, ii] != 0)
                    {
                        Color barva;

                        int r, g, b;

                        r = 255;

                        g = 255 - 10 * pole[i, ii];
    
                        if (g < 0) g = 0;
                        b = 0;
                        barva = Color.FromArgb(r, g, b);

                        graphics.FillRectangle(new SolidBrush(barva), i * (sizeX + 1) + 1, ii * (sizeY + 1) + 1, sizeX, sizeY);
                    }
                    else graphics.FillRectangle(new SolidBrush(Color.LightGray), i * (sizeX + 1) + 1, ii * (sizeY + 1) + 1, sizeX, sizeY);
                }

            graphics.Dispose();
        }

        private void panel1_Click(object sender, MouseEventArgs e)
        {
            if (shouldPaint)//check if mouse button is being pressed
            {
                //draw where the mouse pointer is present
                Graphics graphics = this.panel1.CreateGraphics();
                //graphics.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 10, 10);
                graphics.Dispose();

                float eX = e.X;
                float eY = e.Y;

                int iX, iY;

                if (eX < sizeX)
                    eX = sizeX;
                if (eY < sizeY)
                    eY = sizeY;

                if (eX < (sizePanelX) && eY < (sizePanelY))
                {

                    eX = eX / (sizeX + 1);
                    eY = eY / (sizeY + 1);

                    iX = (int)Math.Ceiling(eX) - 1;
                    iY = (int)Math.Ceiling(eY) - 1;

                    if (pole[iX, iY] != 0) pole[iX, iY] = 0;
                    else pole[iX, iY] = 1;

                    startStop.Visible = true;
                    rychlost.Visible = true;
                    dalsi.Visible = true;
                    zastavit.Visible = true;

                    groupBox4.Visible = true;

                    groupBox5.Visible = true;

                    upozorneno = false;

                    kresli();
                }
            }            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //panel1_Click(sender, e);
        }

        private void tlacitkoVytvor_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(sirka.Text);
                y = Convert.ToInt32(vyska.Text);

                if (x > 100 || y > 100)
                {
                    MessageBox.Show("Chyba! Povolené jsou rozmìry maximálnì 100x100!");
                }
                else
                {
                    sizePanelX = 600;
                    sizePanelY = 400;

                    sizeX = sizePanelX / x - 1;
                    sizeY = sizePanelY / y - 1;

                    sizePanelX = (sizeX + 1) * x + 1;
                    sizePanelY = (sizeY + 1) * y + 1;

                    pole = new int[x, y];
                    sousedePoli = new int[x, y];
                    poleMinule = new int[x, y];

                    kreslit = true;
                    vymazTlacitko.Visible = true;
                    ulozitTlacitko.Visible = true;
                    vyber.Visible = true;
                    nazev.Visible = true;
                    generaci.Visible = true;

                    zastavit.Visible = true;

                    upozorneno = false;

                    casovac.Enabled = false;
                    startStop.Text = "Start";
                    startStop.Visible = false;
                    rychlost.Visible = false;
                    dalsi.Visible = false;

                    groupBox3.Visible = true;
                    groupBox4.Visible = false;
                    groupBox5.Visible = true;

                    statusStrip1.Visible = true;

                    pocetGeneraci = 0;
                    generaci.Text = "Poèet generací: " + pocetGeneraci.ToString();

                    for (int i = 0; i < x; i++)
                        for (int ii = 0; ii < y; ii++)
                            pole[i, ii] = 0;

                    this.Size = new Size(700, 739);
                    groupBox1.Size = new Size(204, 132);

                    kresli();
                }
            }
            catch
            {
                MessageBox.Show("Chyba! Byl zadán špatný vstup!");
            }
        }

        private void vymazTlacitko_Click(object sender, EventArgs e)
        {
            casovac.Enabled = false;
            startStop.Text = "Start";
            startStop.Visible = false;
            rychlost.Visible = false;
            dalsi.Visible = false;

            upozorneno = false;

            vyber.Enabled = true;
            groupBox3.Visible = true;
            zastavit.Visible = false;
            groupBox4.Visible = false;
            
            for (int i = 0; i < x; i++)
                for (int ii = 0; ii < y; ii++)
                    pole[i, ii] = 0;

            pocetGeneraci = 0;
            generaci.Text = "Poèet generací: " + pocetGeneraci.ToString();

            kresli();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 209);
            groupBox1.Size = new Size(204, 66);

            preziva[2] = true;
            preziva[3] = true;
            vznika[3] = true;

            statusStrip1.Visible = false;
        }
        
        private void dalsi_Click(object sender, EventArgs e)
        {
            int[,] pole2 = (int[,])pole.Clone();   

            sousede();
            for (int i = 0; i < x; i++)
                for (int ii = 0; ii < y; ii++)
                {
                    if (pole[i, ii] != 0)
                    {
                        if (preziva[sousedePoli[i, ii]])
                        {
                            if (pole[i, ii] < 500) pole2[i, ii] = pole[i, ii] + 1;
                        }
                        else pole2[i, ii] = 0;
                    }
                    else
                    {
                        if (vznika[sousedePoli[i, ii]]) pole2[i, ii] = 1;
                        else pole2[i, ii] = 0;
                    }
                }

            bool stejne = true;

            if (!upozorneno)
            {                
                for (int i = 0; i < x; i++)
                {
                    for (int ii = 0; ii < y; ii++)
                    {
                        if ((pole[i, ii] != 0 && pole2[i, ii] == 0) || (pole[i, ii] == 0 && pole2[i, ii] != 0))
                        {
                            stejne = false;
                            break;
                        }
                    }
                    if (!stejne) break;
                }

                if (stejne)
                {
                    upozorneno = true;
                    if (mamZastavit)
                    {
                        casovac.Enabled = false;
                        startStop.Text = "Start";
                        startStop.Visible = false;
                        rychlost.Visible = false;
                        dalsi.Visible = false;
                        zastavit.Visible = false;
                        vyber.Enabled = true;
                        groupBox3.Visible = true;
                        zastavit.Visible = false;
                        groupBox4.Visible = false;
                    }
                    MessageBox.Show("Došlo k zacyklení (jednoduchému)!");
                }
            }

            if (pocetGeneraci > 0 && !upozorneno)
            {
                stejne = true;
                for (int i = 0; i < x; i++)
                {
                    for (int ii = 0; ii < y; ii++)
                    {
                        if ((poleMinule[i, ii] != 0 && pole2[i, ii] == 0) || (poleMinule[i, ii] == 0 && pole2[i, ii] != 0))
                        {
                            stejne = false;
                            break;
                        }
                    }
                    if (!stejne) break;
                }

                if (stejne)
                {
                    upozorneno = true;                    
                    if (mamZastavit)
                    {
                        casovac.Enabled = false;
                        startStop.Text = "Start";
                        startStop.Visible = false;
                        rychlost.Visible = false;
                        dalsi.Visible = false;
                        zastavit.Visible = false;
                        vyber.Enabled = true;
                        groupBox3.Visible = true;
                        zastavit.Visible = false;
                        groupBox4.Visible = false;
                    }
                    MessageBox.Show("Došlo k zacyklení (dvojtému)!");
                }
            }
            poleMinule = (int[,])pole.Clone();   
            pole = (int[,])pole2.Clone();   
            kresli();

            pocetGeneraci++;
            generaci.Text = "Poèet generací: " + pocetGeneraci.ToString();
        }

        private void startStop_Click(object sender, EventArgs e)
        {
            if (!casovac.Enabled)
            {
                casovac.Enabled = true;
                startStop.Text = "Stop";
                vyber.Enabled = false;
                groupBox3.Visible = false;

                groupBox5.Visible = true;

            }
            else
            {
                casovac.Enabled = false;
                startStop.Text = "Start";
                vyber.Enabled = true;
                groupBox3.Visible = true;
            }
        }

        private void rychlost_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rychlost.SelectedIndex)
            {
                case 0:
                    casovac.Interval = 100;
                    break;
                case 1:
                    casovac.Interval = 500;
                    break;
                case 2:
                    casovac.Interval = 1000;
                    break;
                case 3:
                    casovac.Interval = 2000;
                    break;
                case 4:
                    casovac.Interval = 3000;
                    break;
                case 5:
                    casovac.Interval = 5000;
                    break;
                case 6:
                    casovac.Interval = 10000;
                    break;
                default:
                    casovac.Interval = 1000;
                    break;
            }

        }

        private void nacistTlacitko_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "textové soubory (*.txt)|*.txt";
            open.Multiselect = false;

            try {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(open.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    string radek;
                    int pocetRadku = 0;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        if (pocetRadku == 0) x = radek.Length;
                        pocetRadku++;
                    }
                    sr.Close();
                    file.Close();
                    y = pocetRadku;

                    if (x > 100 || y > 100)
                    {
                        MessageBox.Show("Chyba! Povolené jsou rozmìry maximálnì 100x100!");
                        
                    }
                    else
                    {
                        sizePanelX = 600;
                        sizePanelY = 400;

                        sizeX = sizePanelX / x - 1;
                        sizeY = sizePanelY / y - 1;

                        sizePanelX = (sizeX + 1) * x + 1;
                        sizePanelY = (sizeY + 1) * y + 1;

                        pole = new int[x, y];
                        sousedePoli = new int[x, y];
                        poleMinule = new int[x, y];

                        kreslit = true;
                        vymazTlacitko.Visible = true;
                        ulozitTlacitko.Visible = true;
                        vyber.Visible = true;
                        nazev.Visible = true;
                        generaci.Visible = true;

                        zastavit.Visible = true;

                        casovac.Enabled = false;
                        startStop.Text = "Start";
                        startStop.Visible = true;
                        rychlost.Visible = true;
                        dalsi.Visible = true;
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;

                        statusStrip1.Visible = true;

                        upozorneno = false;

                        pocetGeneraci = 0;
                        generaci.Text = "Poèet generací: " + pocetGeneraci.ToString();

                        this.Size = new Size(700, 739);
                        groupBox1.Size = new Size(204, 132);

                        file = new FileStream(open.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                        sr = new StreamReader(file);
                        radek = null;
                        int poradi = 0;
                        while ((radek = sr.ReadLine()) != null)
                        {
                            for (int i = 0; i < x; i++) {
                                if (radek[i] == 'x' || radek[i] == 'X') pole[i, poradi] = 1;
                                else pole[i, poradi] = 0;
                            }
                            poradi++;
                        }
                        sr.Close();
                        file.Close();

                        kresli();
                    }
                }
            }
            catch
            {
               MessageBox.Show("Chyba! Došlo k chybì pøi ètení souboru!");
            }            
        }

        private void zastavit_CheckedChanged(object sender, EventArgs e)
        {
            if (!mamZastavit)
            {
                mamZastavit = true;
                upozorneno = false;
            }
            else
            {
                mamZastavit = false;
            }
        }

        private void ulozitTlacitko_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "textové soubory (*.txt)|*.txt";

            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(file);

                    casovac.Enabled = false;
                    startStop.Text = "Start"; 

                    for (int i = 0; i < y; i++)
                    {
                        for (int ii = 0; ii < (x - 1); ii++)
                            if (pole[ii, i] != 0) sw.Write("X");
                            else sw.Write("O");
                        if (i == (y - 1))
                            if (pole[x - 1, i] != 0) sw.Write("X");
                            else sw.Write("O");
                        else
                            if (pole[x - 1, i] != 0) sw.WriteLine("X");
                            else sw.WriteLine("O");
                    }
                    sw.Close();
                    file.Close();

                    MessageBox.Show("Uloženo!");
                }
            }
            catch
            {
                MessageBox.Show("Chyba! Došlo k chybì pøi ukládání do souboru!");
            }   
        }

        private void vyber_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = 60;
            y = 40;
            
            sizePanelX = 600;
            sizePanelY = 400;

            sizeX = sizePanelX / x - 1;
            sizeY = sizePanelY / y - 1;

            sizePanelX = (sizeX + 1) * x + 1;
            sizePanelY = (sizeY + 1) * y + 1;

            pole = new int[x, y];
            sousedePoli = new int[x, y];
            poleMinule = new int[x, y];

            kreslit = true;
            vymazTlacitko.Visible = true;
            ulozitTlacitko.Visible = true;
            vyber.Visible = true;
            nazev.Visible = true;
            generaci.Visible = true;

            zastavit.Visible = true;

            upozorneno = false;

            casovac.Enabled = false;
            startStop.Text = "Start";
            startStop.Visible = true;
            rychlost.Visible = true;
            dalsi.Visible = true;

            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;

            statusStrip1.Visible = true;

            pocetGeneraci = 0;
            generaci.Text = "Poèet generací: " + pocetGeneraci.ToString();

            for (int i = 0; i < x; i++)
                for (int ii = 0; ii < y; ii++)
                    pole[i, ii] = 0;

            this.Size = new Size(700, 739);
            groupBox1.Size = new Size(204, 132);         

            switch (vyber.SelectedIndex)
            {
                case 0:
                    // Kluzák
                    pole[27, 18] = 1;
                    pole[28, 18] = 1;
                    pole[29, 18] = 1;
                    pole[29, 17] = 1;
                    pole[28, 16] = 1;
                    break;
                case 1:
                    // Malý prùzkumník
                    pole[27, 18] = 1;
                    pole[28, 18] = 1;
                    pole[29, 18] = 1;
                    pole[28, 17] = 1;
                    pole[27, 19] = 1;
                    pole[29, 19] = 1;
                    pole[28, 20] = 1; 
                    break;
                case 2:
                    // Prùzkumník
                    pole[27, 17] = 1;
                    pole[27, 18] = 1;
                    pole[27, 19] = 1;
                    pole[27, 20] = 1;
                    pole[27, 21] = 1;

                    pole[31, 17] = 1;
                    pole[31, 18] = 1;
                    pole[31, 19] = 1;
                    pole[31, 20] = 1;
                    pole[31, 21] = 1;

                    pole[29, 17] = 1;
                    pole[29, 21] = 1;

                    break;
                case 3:
                    // Èára s 10 poli
                    pole[25, 19] = 1;
                    pole[26, 19] = 1;
                    pole[27, 19] = 1;
                    pole[28, 19] = 1;
                    pole[29, 19] = 1;
                    pole[30, 19] = 1;
                    pole[31, 19] = 1;
                    pole[32, 19] = 1;
                    pole[33, 19] = 1;
                    pole[34, 19] = 1;

                    break;
                case 4:
                    // Lehká vermírná loï
                    pole[28, 17] = 1;
                    pole[29, 17] = 1;
                    pole[30, 17] = 1;
                    pole[31, 17] = 1;
                    pole[31, 18] = 1;
                    pole[31, 19] = 1;
                    pole[30, 20] = 1;
                    pole[27, 20] = 1;
                    pole[27, 18] = 1;
                    break;
                case 5:
                    // Kejklíø
                    pole[27, 17] = 1;
                    pole[28, 17] = 1;
                    pole[30, 17] = 1;
                    pole[31, 17] = 1;
                    pole[27, 18] = 1;
                    pole[28, 18] = 1;
                    pole[30, 18] = 1;
                    pole[31, 18] = 1;
                    pole[28, 19] = 1;
                    pole[30, 19] = 1;
                    pole[28, 20] = 1;
                    pole[30, 20] = 1;
                    pole[26, 20] = 1;
                    pole[32, 20] = 1;
                    pole[28, 21] = 1;
                    pole[30, 21] = 1;
                    pole[26, 21] = 1;
                    pole[32, 21] = 1;
                    pole[26, 22] = 1;
                    pole[32, 22] = 1;
                    pole[27, 22] = 1;
                    pole[31, 22] = 1;
                    break;
                case 6:
                    // Vystøelovaè kluzákù
                    pole[7, 11] = 1;
                    pole[8, 11] = 1;
                    pole[7, 12] = 1;
                    pole[8, 12] = 1;

                    pole[16, 11] = 1;
                    pole[17, 11] = 1;
                    pole[15, 12] = 1;
                    pole[17, 12] = 1;
                    pole[15, 13] = 1;
                    pole[16, 13] = 1;

                    pole[30, 9] = 1;
                    pole[31, 9] = 1;
                    pole[29, 10] = 1;
                    pole[31, 10] = 1;
                    pole[29, 11] = 1;
                    pole[30, 11] = 1;

                    pole[41, 9] = 1;
                    pole[42, 9] = 1;
                    pole[41, 10] = 1;
                    pole[42, 10] = 1;

                    pole[23, 13] = 1;
                    pole[24, 13] = 1;
                    pole[23, 14] = 1;
                    pole[25, 14] = 1;
                    pole[23, 15] = 1;

                    pole[42, 16] = 1;
                    pole[43, 16] = 1;
                    pole[42, 17] = 1;
                    pole[44, 17] = 1;
                    pole[42, 18] = 1;

                    pole[31, 21] = 1;
                    pole[32, 21] = 1;
                    pole[33, 21] = 1;
                    pole[31, 22] = 1;
                    pole[32, 23] = 1;
                    break;
                default:
                    casovac.Interval = 1000;
                    break;
            }

            kresli();
        }

        private void um1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;

            if (ch.Text == "1") if (ch.Checked == true) preziva[1] = true;
                else preziva[1] = false;
            if (ch.Text == "2") if (ch.Checked == true) preziva[2] = true;
                else preziva[2] = false;
            if (ch.Text == "3") if (ch.Checked == true) preziva[3] = true;
                else preziva[3] = false;
            if (ch.Text == "4") if (ch.Checked == true) preziva[4] = true;
                else preziva[4] = false;
            if (ch.Text == "5") if (ch.Checked == true) preziva[5] = true;
                else preziva[5] = false;
            if (ch.Text == "6") if (ch.Checked == true) preziva[6] = true;
                else preziva[6] = false;
            if (ch.Text == "7") if (ch.Checked == true) preziva[7] = true;
                else preziva[7] = false;
            if (ch.Text == "8") if (ch.Checked == true) preziva[8] = true;
                else preziva[8] = false;
        }

        private void ziv8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;

            if (ch.Text == "1") if (ch.Checked == true) vznika[1] = true;
                else vznika[1] = false;
            if (ch.Text == "2") if (ch.Checked == true) vznika[2] = true;
                else vznika[2] = false;
            if (ch.Text == "3") if (ch.Checked == true) vznika[3] = true;
                else vznika[3] = false;
            if (ch.Text == "4") if (ch.Checked == true) vznika[4] = true;
                else vznika[4] = false;
            if (ch.Text == "5") if (ch.Checked == true) vznika[5] = true;
                else vznika[5] = false;
            if (ch.Text == "6") if (ch.Checked == true) vznika[6] = true;
                else vznika[6] = false;
            if (ch.Text == "7") if (ch.Checked == true) vznika[7] = true;
                else vznika[7] = false;
            if (ch.Text == "8") if (ch.Checked == true) vznika[8] = true;
                else vznika[8] = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            um1.Checked = false;
            um2.Checked = true;
            um3.Checked = true;
            um4.Checked = false;
            um5.Checked = false;
            um6.Checked = false;
            um7.Checked = false;
            um8.Checked = false;

            ziv1.Checked = false;
            ziv2.Checked = false;
            ziv3.Checked = true;
            ziv4.Checked = false;
            ziv5.Checked = false;
            ziv6.Checked = false;
            ziv7.Checked = false;
            ziv8.Checked = false;

            preziva[1] = false;
            preziva[4] = false;
            preziva[5] = false;
            preziva[6] = false;
            preziva[7] = false;
            preziva[8] = false;
            preziva[2] = true;
            preziva[3] = true;

            vznika[1] = false;
            vznika[2] = false;
            vznika[4] = false;
            vznika[5] = false;
            vznika[6] = false;
            vznika[7] = false;
            vznika[8] = false;
            vznika[3] = true;
        }
   }
}