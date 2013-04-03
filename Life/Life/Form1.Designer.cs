namespace Life
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.popisVytvor = new System.Windows.Forms.Label();
            this.sirka = new System.Windows.Forms.TextBox();
            this.xVytvor = new System.Windows.Forms.Label();
            this.vyska = new System.Windows.Forms.TextBox();
            this.tlacitkoVytvor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vymazTlacitko = new System.Windows.Forms.Button();
            this.nacistTlacitko = new System.Windows.Forms.Button();
            this.vyber = new System.Windows.Forms.ComboBox();
            this.nazev = new System.Windows.Forms.Label();
            this.generaci = new System.Windows.Forms.Label();
            this.startStop = new System.Windows.Forms.Button();
            this.dalsi = new System.Windows.Forms.Button();
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.rychlost = new System.Windows.Forms.ComboBox();
            this.ulozitTlacitko = new System.Windows.Forms.Button();
            this.zastavit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ziv8 = new System.Windows.Forms.CheckBox();
            this.um8 = new System.Windows.Forms.CheckBox();
            this.ziv4 = new System.Windows.Forms.CheckBox();
            this.ziv3 = new System.Windows.Forms.CheckBox();
            this.um4 = new System.Windows.Forms.CheckBox();
            this.ziv7 = new System.Windows.Forms.CheckBox();
            this.um3 = new System.Windows.Forms.CheckBox();
            this.ziv6 = new System.Windows.Forms.CheckBox();
            this.um7 = new System.Windows.Forms.CheckBox();
            this.ziv2 = new System.Windows.Forms.CheckBox();
            this.um6 = new System.Windows.Forms.CheckBox();
            this.ziv5 = new System.Windows.Forms.CheckBox();
            this.um2 = new System.Windows.Forms.CheckBox();
            this.ziv1 = new System.Windows.Forms.CheckBox();
            this.um5 = new System.Windows.Forms.CheckBox();
            this.um1 = new System.Windows.Forms.CheckBox();
            this.vznikne = new System.Windows.Forms.Label();
            this.prezije = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisVytvor
            // 
            this.popisVytvor.AutoSize = true;
            this.popisVytvor.Location = new System.Drawing.Point(21, 28);
            this.popisVytvor.Name = "popisVytvor";
            this.popisVytvor.Size = new System.Drawing.Size(145, 13);
            this.popisVytvor.TabIndex = 0;
            this.popisVytvor.Text = "Vytvoøit novou hrací plochu: ";
            // 
            // sirka
            // 
            this.sirka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sirka.Location = new System.Drawing.Point(172, 23);
            this.sirka.MaxLength = 3;
            this.sirka.Name = "sirka";
            this.sirka.Size = new System.Drawing.Size(51, 22);
            this.sirka.TabIndex = 1;
            // 
            // xVytvor
            // 
            this.xVytvor.AutoSize = true;
            this.xVytvor.Location = new System.Drawing.Point(229, 28);
            this.xVytvor.Name = "xVytvor";
            this.xVytvor.Size = new System.Drawing.Size(14, 13);
            this.xVytvor.TabIndex = 0;
            this.xVytvor.Text = "X";
            // 
            // vyska
            // 
            this.vyska.Location = new System.Drawing.Point(248, 25);
            this.vyska.MaxLength = 3;
            this.vyska.Name = "vyska";
            this.vyska.Size = new System.Drawing.Size(51, 20);
            this.vyska.TabIndex = 2;
            // 
            // tlacitkoVytvor
            // 
            this.tlacitkoVytvor.Location = new System.Drawing.Point(315, 25);
            this.tlacitkoVytvor.Name = "tlacitkoVytvor";
            this.tlacitkoVytvor.Size = new System.Drawing.Size(69, 21);
            this.tlacitkoVytvor.TabIndex = 3;
            this.tlacitkoVytvor.Text = "OK";
            this.tlacitkoVytvor.UseVisualStyleBackColor = true;
            this.tlacitkoVytvor.Click += new System.EventHandler(this.tlacitkoVytvor_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(51, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 401);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanelForm_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanelForm_MouseUp);
            // 
            // vymazTlacitko
            // 
            this.vymazTlacitko.Location = new System.Drawing.Point(18, 94);
            this.vymazTlacitko.Name = "vymazTlacitko";
            this.vymazTlacitko.Size = new System.Drawing.Size(164, 21);
            this.vymazTlacitko.TabIndex = 4;
            this.vymazTlacitko.Text = "vymaž celou plochu";
            this.vymazTlacitko.UseVisualStyleBackColor = true;
            this.vymazTlacitko.Visible = false;
            this.vymazTlacitko.Click += new System.EventHandler(this.vymazTlacitko_Click);
            // 
            // nacistTlacitko
            // 
            this.nacistTlacitko.Location = new System.Drawing.Point(18, 30);
            this.nacistTlacitko.Name = "nacistTlacitko";
            this.nacistTlacitko.Size = new System.Drawing.Size(164, 21);
            this.nacistTlacitko.TabIndex = 4;
            this.nacistTlacitko.Text = "naèíst ze souboru";
            this.nacistTlacitko.UseVisualStyleBackColor = true;
            this.nacistTlacitko.Click += new System.EventHandler(this.nacistTlacitko_Click);
            // 
            // vyber
            // 
            this.vyber.FormattingEnabled = true;
            this.vyber.Items.AddRange(new object[] {
            "Kluzák",
            "Malý prùzkumník",
            "Prùzkumník",
            "Èára s 10 poli",
            "Lehká vermírná loï",
            "Kejklíø",
            "Vystøelovaè kluzákù"});
            this.vyber.Location = new System.Drawing.Point(25, 19);
            this.vyber.Name = "vyber";
            this.vyber.Size = new System.Drawing.Size(164, 21);
            this.vyber.TabIndex = 5;
            this.vyber.Text = "vyberte:";
            this.vyber.SelectedIndexChanged += new System.EventHandler(this.vyber_SelectedIndexChanged);
            // 
            // nazev
            // 
            this.nazev.AutoSize = true;
            this.nazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazev.Location = new System.Drawing.Point(57, 245);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(220, 18);
            this.nazev.TabIndex = 6;
            this.nazev.Text = "Hra \"Life\" | © Tomáš Vítek, 2008";
            this.nazev.Visible = false;
            // 
            // generaci
            // 
            this.generaci.AutoSize = true;
            this.generaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generaci.Location = new System.Drawing.Point(498, 245);
            this.generaci.Name = "generaci";
            this.generaci.Size = new System.Drawing.Size(123, 18);
            this.generaci.TabIndex = 6;
            this.generaci.Text = "Poèet generací: 0";
            this.generaci.Visible = false;
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(27, 63);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(82, 21);
            this.startStop.TabIndex = 4;
            this.startStop.Text = "start";
            this.startStop.UseVisualStyleBackColor = true;
            this.startStop.Visible = false;
            this.startStop.Click += new System.EventHandler(this.startStop_Click);
            // 
            // dalsi
            // 
            this.dalsi.Location = new System.Drawing.Point(27, 28);
            this.dalsi.Name = "dalsi";
            this.dalsi.Size = new System.Drawing.Size(116, 21);
            this.dalsi.TabIndex = 4;
            this.dalsi.Text = "další generace";
            this.dalsi.UseVisualStyleBackColor = true;
            this.dalsi.Visible = false;
            this.dalsi.Click += new System.EventHandler(this.dalsi_Click);
            // 
            // casovac
            // 
            this.casovac.Interval = 1000;
            this.casovac.Tick += new System.EventHandler(this.dalsi_Click);
            // 
            // rychlost
            // 
            this.rychlost.FormattingEnabled = true;
            this.rychlost.Items.AddRange(new object[] {
            "0,1 sek.",
            "0,5 sek.",
            "   1 sek.",
            "   2 sek.",
            "   3 sek.",
            "   5 sek.",
            " 10 sek."});
            this.rychlost.Location = new System.Drawing.Point(123, 63);
            this.rychlost.Name = "rychlost";
            this.rychlost.Size = new System.Drawing.Size(56, 21);
            this.rychlost.TabIndex = 5;
            this.rychlost.Text = "1 sek.";
            this.rychlost.Visible = false;
            this.rychlost.SelectedIndexChanged += new System.EventHandler(this.rychlost_SelectedIndexChanged);
            // 
            // ulozitTlacitko
            // 
            this.ulozitTlacitko.Location = new System.Drawing.Point(18, 64);
            this.ulozitTlacitko.Name = "ulozitTlacitko";
            this.ulozitTlacitko.Size = new System.Drawing.Size(164, 21);
            this.ulozitTlacitko.TabIndex = 4;
            this.ulozitTlacitko.Text = "uložit stav bunìk do souboru";
            this.ulozitTlacitko.UseVisualStyleBackColor = true;
            this.ulozitTlacitko.Visible = false;
            this.ulozitTlacitko.Click += new System.EventHandler(this.ulozitTlacitko_Click);
            // 
            // zastavit
            // 
            this.zastavit.AutoSize = true;
            this.zastavit.Checked = true;
            this.zastavit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zastavit.Location = new System.Drawing.Point(29, 95);
            this.zastavit.Name = "zastavit";
            this.zastavit.Size = new System.Drawing.Size(126, 17);
            this.zastavit.TabIndex = 7;
            this.zastavit.Text = "pøi zacyklení zastavit";
            this.zastavit.UseVisualStyleBackColor = true;
            this.zastavit.Visible = false;
            this.zastavit.CheckedChanged += new System.EventHandler(this.zastavit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nacistTlacitko);
            this.groupBox1.Controls.Add(this.ulozitTlacitko);
            this.groupBox1.Controls.Add(this.vymazTlacitko);
            this.groupBox1.Location = new System.Drawing.Point(36, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import a export plochy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.popisVytvor);
            this.groupBox2.Controls.Add(this.sirka);
            this.groupBox2.Controls.Add(this.vyska);
            this.groupBox2.Controls.Add(this.xVytvor);
            this.groupBox2.Controls.Add(this.tlacitkoVytvor);
            this.groupBox2.Location = new System.Drawing.Point(36, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vytvoøit novou plochu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vyber);
            this.groupBox3.Location = new System.Drawing.Point(448, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 56);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pøednastevené  kolonie";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dalsi);
            this.groupBox4.Controls.Add(this.startStop);
            this.groupBox4.Controls.Add(this.rychlost);
            this.groupBox4.Controls.Add(this.zastavit);
            this.groupBox4.Location = new System.Drawing.Point(258, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 130);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Další generace";
            this.groupBox4.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.ziv8);
            this.groupBox5.Controls.Add(this.um8);
            this.groupBox5.Controls.Add(this.ziv4);
            this.groupBox5.Controls.Add(this.ziv3);
            this.groupBox5.Controls.Add(this.um4);
            this.groupBox5.Controls.Add(this.ziv7);
            this.groupBox5.Controls.Add(this.um3);
            this.groupBox5.Controls.Add(this.ziv6);
            this.groupBox5.Controls.Add(this.um7);
            this.groupBox5.Controls.Add(this.ziv2);
            this.groupBox5.Controls.Add(this.um6);
            this.groupBox5.Controls.Add(this.ziv5);
            this.groupBox5.Controls.Add(this.um2);
            this.groupBox5.Controls.Add(this.ziv1);
            this.groupBox5.Controls.Add(this.um5);
            this.groupBox5.Controls.Add(this.um1);
            this.groupBox5.Controls.Add(this.vznikne);
            this.groupBox5.Controls.Add(this.prezije);
            this.groupBox5.Location = new System.Drawing.Point(481, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 130);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pravidla";
            this.groupBox5.Visible = false;
            // 
            // ziv8
            // 
            this.ziv8.AutoSize = true;
            this.ziv8.Location = new System.Drawing.Point(109, 103);
            this.ziv8.Name = "ziv8";
            this.ziv8.Size = new System.Drawing.Size(32, 17);
            this.ziv8.TabIndex = 1;
            this.ziv8.Text = "8";
            this.ziv8.UseVisualStyleBackColor = true;
            this.ziv8.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um8
            // 
            this.um8.AutoSize = true;
            this.um8.Location = new System.Drawing.Point(109, 49);
            this.um8.Name = "um8";
            this.um8.Size = new System.Drawing.Size(32, 17);
            this.um8.TabIndex = 1;
            this.um8.Text = "8";
            this.um8.UseVisualStyleBackColor = true;
            this.um8.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // ziv4
            // 
            this.ziv4.AutoSize = true;
            this.ziv4.Location = new System.Drawing.Point(109, 86);
            this.ziv4.Name = "ziv4";
            this.ziv4.Size = new System.Drawing.Size(32, 17);
            this.ziv4.TabIndex = 1;
            this.ziv4.Text = "4";
            this.ziv4.UseVisualStyleBackColor = true;
            this.ziv4.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // ziv3
            // 
            this.ziv3.AutoSize = true;
            this.ziv3.Checked = true;
            this.ziv3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ziv3.Location = new System.Drawing.Point(78, 86);
            this.ziv3.Name = "ziv3";
            this.ziv3.Size = new System.Drawing.Size(32, 17);
            this.ziv3.TabIndex = 1;
            this.ziv3.Text = "3";
            this.ziv3.UseVisualStyleBackColor = true;
            this.ziv3.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um4
            // 
            this.um4.AutoSize = true;
            this.um4.Location = new System.Drawing.Point(109, 32);
            this.um4.Name = "um4";
            this.um4.Size = new System.Drawing.Size(32, 17);
            this.um4.TabIndex = 1;
            this.um4.Text = "4";
            this.um4.UseVisualStyleBackColor = true;
            this.um4.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // ziv7
            // 
            this.ziv7.AutoSize = true;
            this.ziv7.Location = new System.Drawing.Point(78, 103);
            this.ziv7.Name = "ziv7";
            this.ziv7.Size = new System.Drawing.Size(32, 17);
            this.ziv7.TabIndex = 1;
            this.ziv7.Text = "7";
            this.ziv7.UseVisualStyleBackColor = true;
            this.ziv7.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um3
            // 
            this.um3.AutoSize = true;
            this.um3.Checked = true;
            this.um3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.um3.Location = new System.Drawing.Point(78, 32);
            this.um3.Name = "um3";
            this.um3.Size = new System.Drawing.Size(32, 17);
            this.um3.TabIndex = 1;
            this.um3.Text = "3";
            this.um3.UseVisualStyleBackColor = true;
            this.um3.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // ziv6
            // 
            this.ziv6.AutoSize = true;
            this.ziv6.Location = new System.Drawing.Point(48, 104);
            this.ziv6.Name = "ziv6";
            this.ziv6.Size = new System.Drawing.Size(32, 17);
            this.ziv6.TabIndex = 1;
            this.ziv6.Text = "6";
            this.ziv6.UseVisualStyleBackColor = true;
            this.ziv6.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um7
            // 
            this.um7.AutoSize = true;
            this.um7.Location = new System.Drawing.Point(78, 49);
            this.um7.Name = "um7";
            this.um7.Size = new System.Drawing.Size(32, 17);
            this.um7.TabIndex = 1;
            this.um7.Text = "7";
            this.um7.UseVisualStyleBackColor = true;
            this.um7.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // ziv2
            // 
            this.ziv2.AutoSize = true;
            this.ziv2.Location = new System.Drawing.Point(48, 86);
            this.ziv2.Name = "ziv2";
            this.ziv2.Size = new System.Drawing.Size(32, 17);
            this.ziv2.TabIndex = 1;
            this.ziv2.Text = "2";
            this.ziv2.UseVisualStyleBackColor = true;
            this.ziv2.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um6
            // 
            this.um6.AutoSize = true;
            this.um6.Location = new System.Drawing.Point(48, 50);
            this.um6.Name = "um6";
            this.um6.Size = new System.Drawing.Size(32, 17);
            this.um6.TabIndex = 1;
            this.um6.Text = "6";
            this.um6.UseVisualStyleBackColor = true;
            this.um6.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // ziv5
            // 
            this.ziv5.AutoSize = true;
            this.ziv5.Location = new System.Drawing.Point(17, 103);
            this.ziv5.Name = "ziv5";
            this.ziv5.Size = new System.Drawing.Size(32, 17);
            this.ziv5.TabIndex = 1;
            this.ziv5.Text = "5";
            this.ziv5.UseVisualStyleBackColor = true;
            this.ziv5.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um2
            // 
            this.um2.AutoSize = true;
            this.um2.Checked = true;
            this.um2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.um2.Location = new System.Drawing.Point(48, 32);
            this.um2.Name = "um2";
            this.um2.Size = new System.Drawing.Size(32, 17);
            this.um2.TabIndex = 1;
            this.um2.Text = "2";
            this.um2.UseVisualStyleBackColor = true;
            this.um2.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // ziv1
            // 
            this.ziv1.AutoSize = true;
            this.ziv1.Location = new System.Drawing.Point(17, 86);
            this.ziv1.Name = "ziv1";
            this.ziv1.Size = new System.Drawing.Size(32, 17);
            this.ziv1.TabIndex = 1;
            this.ziv1.Text = "1";
            this.ziv1.UseVisualStyleBackColor = true;
            this.ziv1.CheckedChanged += new System.EventHandler(this.ziv8_CheckedChanged);
            // 
            // um5
            // 
            this.um5.AutoSize = true;
            this.um5.Location = new System.Drawing.Point(17, 49);
            this.um5.Name = "um5";
            this.um5.Size = new System.Drawing.Size(32, 17);
            this.um5.TabIndex = 1;
            this.um5.Text = "5";
            this.um5.UseVisualStyleBackColor = true;
            this.um5.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // um1
            // 
            this.um1.AutoSize = true;
            this.um1.Location = new System.Drawing.Point(17, 32);
            this.um1.Name = "um1";
            this.um1.Size = new System.Drawing.Size(32, 17);
            this.um1.TabIndex = 1;
            this.um1.Text = "1";
            this.um1.UseVisualStyleBackColor = true;
            this.um1.CheckedChanged += new System.EventHandler(this.um1_CheckedChanged);
            // 
            // vznikne
            // 
            this.vznikne.AutoSize = true;
            this.vznikne.Location = new System.Drawing.Point(14, 71);
            this.vznikne.Name = "vznikne";
            this.vznikne.Size = new System.Drawing.Size(96, 13);
            this.vznikne.TabIndex = 0;
            this.vznikne.Text = "Buòka vznikne pøi:";
            // 
            // prezije
            // 
            this.prezije.AutoSize = true;
            this.prezije.Location = new System.Drawing.Point(14, 16);
            this.prezije.Name = "prezije";
            this.prezije.Size = new System.Drawing.Size(90, 13);
            this.prezije.TabIndex = 0;
            this.prezije.Text = "Buòka pøežije pøi:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 682);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(263, 17);
            this.toolStripStatusLabel1.Text = "Poznámka: èím tmavší èervená, tím starší buòka.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 704);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generaci);
            this.Controls.Add(this.nazev);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hra \"Life\" | © Tomáš Vítek, 2008";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisVytvor;
        private System.Windows.Forms.TextBox sirka;
        private System.Windows.Forms.Label xVytvor;
        private System.Windows.Forms.TextBox vyska;
        private System.Windows.Forms.Button tlacitkoVytvor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vymazTlacitko;
        private System.Windows.Forms.Button nacistTlacitko;
        private System.Windows.Forms.ComboBox vyber;
        private System.Windows.Forms.Label nazev;
        private System.Windows.Forms.Label generaci;
        private System.Windows.Forms.Button startStop;
        private System.Windows.Forms.Button dalsi;
        private System.Windows.Forms.Timer casovac;
        private System.Windows.Forms.ComboBox rychlost;
        private System.Windows.Forms.Button ulozitTlacitko;
        private System.Windows.Forms.CheckBox zastavit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox um1;
        private System.Windows.Forms.Label vznikne;
        private System.Windows.Forms.Label prezije;
        private System.Windows.Forms.CheckBox ziv8;
        private System.Windows.Forms.CheckBox um8;
        private System.Windows.Forms.CheckBox ziv4;
        private System.Windows.Forms.CheckBox ziv3;
        private System.Windows.Forms.CheckBox um4;
        private System.Windows.Forms.CheckBox ziv7;
        private System.Windows.Forms.CheckBox um3;
        private System.Windows.Forms.CheckBox ziv6;
        private System.Windows.Forms.CheckBox um7;
        private System.Windows.Forms.CheckBox ziv2;
        private System.Windows.Forms.CheckBox um6;
        private System.Windows.Forms.CheckBox ziv5;
        private System.Windows.Forms.CheckBox um2;
        private System.Windows.Forms.CheckBox ziv1;
        private System.Windows.Forms.CheckBox um5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
    }
}

