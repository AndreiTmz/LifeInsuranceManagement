namespace ProiectAsigurariPaw
{
    partial class Form7_adauga_asigurare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7_adauga_asigurare));
            this.tbSumaAsig = new System.Windows.Forms.TextBox();
            this.tbPrima = new System.Windows.Forms.TextBox();
            this.tbComision = new System.Windows.Forms.TextBox();
            this.dtpDataIncheiere = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbBunuriAsig = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label7Bunuri = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRiscuriAcoperite = new System.Windows.Forms.TextBox();
            this.tbExceptii = new System.Windows.Forms.TextBox();
            this.label7Viata = new System.Windows.Forms.Label();
            this.label9Viata = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nmrValabilitate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrValabilitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSumaAsig
            // 
            this.tbSumaAsig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSumaAsig.Location = new System.Drawing.Point(293, 51);
            this.tbSumaAsig.Name = "tbSumaAsig";
            this.tbSumaAsig.Size = new System.Drawing.Size(202, 22);
            this.tbSumaAsig.TabIndex = 0;
            this.tbSumaAsig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumaAsig_KeyPress);
            // 
            // tbPrima
            // 
            this.tbPrima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrima.Location = new System.Drawing.Point(293, 241);
            this.tbPrima.Name = "tbPrima";
            this.tbPrima.Size = new System.Drawing.Size(202, 22);
            this.tbPrima.TabIndex = 2;
            this.tbPrima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumaAsig_KeyPress);
            // 
            // tbComision
            // 
            this.tbComision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbComision.Location = new System.Drawing.Point(293, 282);
            this.tbComision.MaxLength = 2;
            this.tbComision.Name = "tbComision";
            this.tbComision.Size = new System.Drawing.Size(202, 22);
            this.tbComision.TabIndex = 3;
            this.tbComision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumaAsig_KeyPress);
            // 
            // dtpDataIncheiere
            // 
            this.dtpDataIncheiere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataIncheiere.CustomFormat = "dd/MM/yyyy";
            this.dtpDataIncheiere.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataIncheiere.Location = new System.Drawing.Point(293, 89);
            this.dtpDataIncheiere.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpDataIncheiere.Name = "dtpDataIncheiere";
            this.dtpDataIncheiere.Size = new System.Drawing.Size(202, 22);
            this.dtpDataIncheiere.TabIndex = 4;
            this.dtpDataIncheiere.ValueChanged += new System.EventHandler(this.dtpDataIncheiere_ValueChanged);
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataInceput.CustomFormat = "dd/MM/yyyy";
            this.dtpDataInceput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInceput.Location = new System.Drawing.Point(293, 139);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(202, 22);
            this.dtpDataInceput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(157, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma asigurata:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(164, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data incheiere:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(176, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data inceput:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(182, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valabilitate";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(220, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prima:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(153, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Procent comision:";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(601, 124);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bunuri";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(601, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 21);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Viata";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tbBunuriAsig
            // 
            this.tbBunuriAsig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBunuriAsig.Location = new System.Drawing.Point(293, 391);
            this.tbBunuriAsig.Name = "tbBunuriAsig";
            this.tbBunuriAsig.Size = new System.Drawing.Size(202, 22);
            this.tbBunuriAsig.TabIndex = 14;
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInfo.Location = new System.Drawing.Point(293, 331);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(202, 22);
            this.tbInfo.TabIndex = 15;
            // 
            // label7Bunuri
            // 
            this.label7Bunuri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7Bunuri.AutoSize = true;
            this.label7Bunuri.BackColor = System.Drawing.Color.Transparent;
            this.label7Bunuri.Location = new System.Drawing.Point(157, 396);
            this.label7Bunuri.Name = "label7Bunuri";
            this.label7Bunuri.Size = new System.Drawing.Size(116, 17);
            this.label7Bunuri.TabIndex = 16;
            this.label7Bunuri.Text = "Bunuri asigurate:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(199, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Informatii:";
            // 
            // tbRiscuriAcoperite
            // 
            this.tbRiscuriAcoperite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRiscuriAcoperite.Location = new System.Drawing.Point(293, 374);
            this.tbRiscuriAcoperite.Name = "tbRiscuriAcoperite";
            this.tbRiscuriAcoperite.Size = new System.Drawing.Size(202, 22);
            this.tbRiscuriAcoperite.TabIndex = 18;
            this.tbRiscuriAcoperite.Visible = false;
            // 
            // tbExceptii
            // 
            this.tbExceptii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbExceptii.Location = new System.Drawing.Point(293, 419);
            this.tbExceptii.Name = "tbExceptii";
            this.tbExceptii.Size = new System.Drawing.Size(202, 22);
            this.tbExceptii.TabIndex = 19;
            this.tbExceptii.Visible = false;
            // 
            // label7Viata
            // 
            this.label7Viata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7Viata.AutoSize = true;
            this.label7Viata.BackColor = System.Drawing.Color.Transparent;
            this.label7Viata.Location = new System.Drawing.Point(164, 379);
            this.label7Viata.Name = "label7Viata";
            this.label7Viata.Size = new System.Drawing.Size(118, 17);
            this.label7Viata.TabIndex = 20;
            this.label7Viata.Text = "Riscuri acoperite:";
            this.label7Viata.Visible = false;
            // 
            // label9Viata
            // 
            this.label9Viata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9Viata.AutoSize = true;
            this.label9Viata.BackColor = System.Drawing.Color.Transparent;
            this.label9Viata.Location = new System.Drawing.Point(222, 424);
            this.label9Viata.Name = "label9Viata";
            this.label9Viata.Size = new System.Drawing.Size(56, 17);
            this.label9Viata.TabIndex = 21;
            this.label9Viata.Text = "Exceptii";
            this.label9Viata.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(568, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Adauga asigurare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmrValabilitate
            // 
            this.nmrValabilitate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmrValabilitate.Location = new System.Drawing.Point(293, 189);
            this.nmrValabilitate.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmrValabilitate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrValabilitate.Name = "nmrValabilitate";
            this.nmrValabilitate.Size = new System.Drawing.Size(120, 22);
            this.nmrValabilitate.TabIndex = 23;
            this.nmrValabilitate.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "luni";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form7_adauga_asigurare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrValabilitate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9Viata);
            this.Controls.Add(this.label7Viata);
            this.Controls.Add(this.tbExceptii);
            this.Controls.Add(this.tbRiscuriAcoperite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7Bunuri);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbBunuriAsig);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataInceput);
            this.Controls.Add(this.dtpDataIncheiere);
            this.Controls.Add(this.tbComision);
            this.Controls.Add(this.tbPrima);
            this.Controls.Add(this.tbSumaAsig);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7_adauga_asigurare";
            this.Text = "Adauga asigurare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_adauga_asigurare_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nmrValabilitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSumaAsig;
        private System.Windows.Forms.TextBox tbPrima;
        private System.Windows.Forms.TextBox tbComision;
        private System.Windows.Forms.DateTimePicker dtpDataIncheiere;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbBunuriAsig;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label7Bunuri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRiscuriAcoperite;
        private System.Windows.Forms.TextBox tbExceptii;
        private System.Windows.Forms.Label label7Viata;
        private System.Windows.Forms.Label label9Viata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmrValabilitate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}