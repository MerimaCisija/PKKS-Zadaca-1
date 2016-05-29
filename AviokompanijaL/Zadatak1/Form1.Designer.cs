namespace AviokompanijaL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.brisanjeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rezervacijaBtn = new System.Windows.Forms.Button();
            this.komentarTxt = new System.Windows.Forms.RichTextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.jmbgTxt = new System.Windows.Forms.TextBox();
            this.prezimeTxt = new System.Windows.Forms.TextBox();
            this.imeTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cijenaBtn = new System.Windows.Forms.Button();
            this.klasaBar = new System.Windows.Forms.TrackBar();
            this.cijenaTxt = new System.Windows.Forms.TextBox();
            this.takseTxt = new System.Windows.Forms.TextBox();
            this.prtljagTxt = new System.Windows.Forms.TextBox();
            this.distancaTxt = new System.Windows.Forms.TextBox();
            this.odredisteCB = new System.Windows.Forms.ComboBox();
            this.polazisteCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prtljag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posiljaoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klasaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(780, 25);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(183, 239);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // brisanjeBtn
            // 
            this.brisanjeBtn.Location = new System.Drawing.Point(21, 399);
            this.brisanjeBtn.Name = "brisanjeBtn";
            this.brisanjeBtn.Size = new System.Drawing.Size(942, 35);
            this.brisanjeBtn.TabIndex = 12;
            this.brisanjeBtn.Text = "Izbriši uneseni let";
            this.brisanjeBtn.UseVisualStyleBackColor = true;
            this.brisanjeBtn.Click += new System.EventHandler(this.brisanjeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rezervacijaBtn);
            this.groupBox2.Controls.Add(this.komentarTxt);
            this.groupBox2.Controls.Add(this.telefonTxt);
            this.groupBox2.Controls.Add(this.jmbgTxt);
            this.groupBox2.Controls.Add(this.prezimeTxt);
            this.groupBox2.Controls.Add(this.imeTxt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(417, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(348, 248);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lični podaci";
            // 
            // rezervacijaBtn
            // 
            this.rezervacijaBtn.Location = new System.Drawing.Point(22, 193);
            this.rezervacijaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rezervacijaBtn.Name = "rezervacijaBtn";
            this.rezervacijaBtn.Size = new System.Drawing.Size(296, 37);
            this.rezervacijaBtn.TabIndex = 19;
            this.rezervacijaBtn.Text = "Rezerviši let";
            this.rezervacijaBtn.UseVisualStyleBackColor = true;
            this.rezervacijaBtn.Click += new System.EventHandler(this.rezervacijaBtn_Click);
            // 
            // komentarTxt
            // 
            this.komentarTxt.Location = new System.Drawing.Point(104, 138);
            this.komentarTxt.Margin = new System.Windows.Forms.Padding(2);
            this.komentarTxt.Name = "komentarTxt";
            this.komentarTxt.Size = new System.Drawing.Size(214, 50);
            this.komentarTxt.TabIndex = 18;
            this.komentarTxt.Text = "";
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(104, 109);
            this.telefonTxt.Margin = new System.Windows.Forms.Padding(2);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(214, 20);
            this.telefonTxt.TabIndex = 17;
            this.telefonTxt.Validated += new System.EventHandler(this.telefonTxt_Validated);
            // 
            // jmbgTxt
            // 
            this.jmbgTxt.Location = new System.Drawing.Point(104, 84);
            this.jmbgTxt.Margin = new System.Windows.Forms.Padding(2);
            this.jmbgTxt.Name = "jmbgTxt";
            this.jmbgTxt.Size = new System.Drawing.Size(214, 20);
            this.jmbgTxt.TabIndex = 16;
            this.jmbgTxt.Validated += new System.EventHandler(this.jmbgTxt_Validated);
            // 
            // prezimeTxt
            // 
            this.prezimeTxt.Location = new System.Drawing.Point(104, 55);
            this.prezimeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.prezimeTxt.Name = "prezimeTxt";
            this.prezimeTxt.Size = new System.Drawing.Size(214, 20);
            this.prezimeTxt.TabIndex = 15;
            this.prezimeTxt.Validated += new System.EventHandler(this.prezimeTxt_Validated);
            // 
            // imeTxt
            // 
            this.imeTxt.Location = new System.Drawing.Point(104, 27);
            this.imeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.imeTxt.Name = "imeTxt";
            this.imeTxt.Size = new System.Drawing.Size(214, 20);
            this.imeTxt.TabIndex = 14;
            this.imeTxt.Validated += new System.EventHandler(this.imeTxt_Validated);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 138);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Komentar:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 113);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Telefon:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "JMBG:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 59);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Prezime:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ime:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cijenaBtn);
            this.groupBox1.Controls.Add(this.klasaBar);
            this.groupBox1.Controls.Add(this.cijenaTxt);
            this.groupBox1.Controls.Add(this.takseTxt);
            this.groupBox1.Controls.Add(this.prtljagTxt);
            this.groupBox1.Controls.Add(this.distancaTxt);
            this.groupBox1.Controls.Add(this.odredisteCB);
            this.groupBox1.Controls.Add(this.polazisteCB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(392, 248);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o letu";
            // 
            // cijenaBtn
            // 
            this.cijenaBtn.Location = new System.Drawing.Point(17, 193);
            this.cijenaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cijenaBtn.Name = "cijenaBtn";
            this.cijenaBtn.Size = new System.Drawing.Size(301, 37);
            this.cijenaBtn.TabIndex = 18;
            this.cijenaBtn.Text = "Izračunaj cijenu leta";
            this.cijenaBtn.UseVisualStyleBackColor = true;
            this.cijenaBtn.Click += new System.EventHandler(this.cijenaBtn_Click);
            // 
            // klasaBar
            // 
            this.klasaBar.Location = new System.Drawing.Point(17, 157);
            this.klasaBar.Margin = new System.Windows.Forms.Padding(2);
            this.klasaBar.Name = "klasaBar";
            this.klasaBar.Size = new System.Drawing.Size(158, 45);
            this.klasaBar.TabIndex = 17;
            // 
            // cijenaTxt
            // 
            this.cijenaTxt.Location = new System.Drawing.Point(181, 169);
            this.cijenaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.cijenaTxt.Name = "cijenaTxt";
            this.cijenaTxt.Size = new System.Drawing.Size(137, 20);
            this.cijenaTxt.TabIndex = 16;
            // 
            // takseTxt
            // 
            this.takseTxt.Location = new System.Drawing.Point(104, 105);
            this.takseTxt.Margin = new System.Windows.Forms.Padding(2);
            this.takseTxt.Name = "takseTxt";
            this.takseTxt.Size = new System.Drawing.Size(214, 20);
            this.takseTxt.TabIndex = 15;
            this.takseTxt.Validated += new System.EventHandler(this.takseTxt_Validated);
            // 
            // prtljagTxt
            // 
            this.prtljagTxt.Location = new System.Drawing.Point(104, 81);
            this.prtljagTxt.Margin = new System.Windows.Forms.Padding(2);
            this.prtljagTxt.Name = "prtljagTxt";
            this.prtljagTxt.Size = new System.Drawing.Size(214, 20);
            this.prtljagTxt.TabIndex = 14;
            this.prtljagTxt.Validated += new System.EventHandler(this.prtljagTxt_Validated);
            // 
            // distancaTxt
            // 
            this.distancaTxt.Location = new System.Drawing.Point(104, 55);
            this.distancaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.distancaTxt.Name = "distancaTxt";
            this.distancaTxt.ReadOnly = true;
            this.distancaTxt.Size = new System.Drawing.Size(214, 20);
            this.distancaTxt.TabIndex = 13;
            this.distancaTxt.TextChanged += new System.EventHandler(this.distancaTxt_TextChanged);
            this.distancaTxt.Validated += new System.EventHandler(this.distancaTxt_Validated);
            // 
            // odredisteCB
            // 
            this.odredisteCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odredisteCB.FormattingEnabled = true;
            this.odredisteCB.Items.AddRange(new object[] {
            "Sarajevo",
            "Istanbul",
            "Pariz"});
            this.odredisteCB.Location = new System.Drawing.Point(190, 24);
            this.odredisteCB.Margin = new System.Windows.Forms.Padding(2);
            this.odredisteCB.Name = "odredisteCB";
            this.odredisteCB.Size = new System.Drawing.Size(92, 21);
            this.odredisteCB.TabIndex = 12;
            this.odredisteCB.SelectedIndexChanged += new System.EventHandler(this.odredisteCB_SelectedIndexChanged);
            // 
            // polazisteCB
            // 
            this.polazisteCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.polazisteCB.FormattingEnabled = true;
            this.polazisteCB.Items.AddRange(new object[] {
            "Sarajevo",
            "Istanbul",
            "Pariz"});
            this.polazisteCB.Location = new System.Drawing.Point(56, 24);
            this.polazisteCB.Margin = new System.Windows.Forms.Padding(2);
            this.polazisteCB.Name = "polazisteCB";
            this.polazisteCB.Size = new System.Drawing.Size(92, 21);
            this.polazisteCB.TabIndex = 11;
            this.polazisteCB.SelectedIndexChanged += new System.EventHandler(this.polazisteCB_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "kom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cijena leta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Klasa sjedišta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Takse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prtljag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distanca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Distance,
            this.Prtljag,
            this.Takse,
            this.Klasa,
            this.Posiljaoc,
            this.JMBG,
            this.Kontakt,
            this.Komentar});
            this.dataGridView1.Location = new System.Drawing.Point(21, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 123);
            this.dataGridView1.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            // 
            // Prtljag
            // 
            this.Prtljag.HeaderText = "Prtljag";
            this.Prtljag.Name = "Prtljag";
            this.Prtljag.ReadOnly = true;
            // 
            // Takse
            // 
            this.Takse.HeaderText = "Takse";
            this.Takse.Name = "Takse";
            this.Takse.ReadOnly = true;
            // 
            // Klasa
            // 
            this.Klasa.HeaderText = "Klasa";
            this.Klasa.Name = "Klasa";
            this.Klasa.ReadOnly = true;
            // 
            // Posiljaoc
            // 
            this.Posiljaoc.HeaderText = "Posiljaoc";
            this.Posiljaoc.Name = "Posiljaoc";
            this.Posiljaoc.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // Kontakt
            // 
            this.Kontakt.HeaderText = "Kontakt";
            this.Kontakt.Name = "Kontakt";
            this.Kontakt.ReadOnly = true;
            // 
            // Komentar
            // 
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.brisanjeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lufthansa - Rezervacija leta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klasaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button brisanjeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rezervacijaBtn;
        private System.Windows.Forms.RichTextBox komentarTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox jmbgTxt;
        private System.Windows.Forms.TextBox prezimeTxt;
        private System.Windows.Forms.TextBox imeTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cijenaBtn;
        private System.Windows.Forms.TrackBar klasaBar;
        private System.Windows.Forms.TextBox cijenaTxt;
        private System.Windows.Forms.TextBox takseTxt;
        private System.Windows.Forms.TextBox prtljagTxt;
        private System.Windows.Forms.TextBox distancaTxt;
        private System.Windows.Forms.ComboBox odredisteCB;
        private System.Windows.Forms.ComboBox polazisteCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prtljag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posiljaoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
    }
}

