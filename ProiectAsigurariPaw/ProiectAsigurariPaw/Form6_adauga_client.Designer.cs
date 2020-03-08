namespace ProiectAsigurariPaw
{
    partial class Form6_adauga_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_adauga_client));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbNumePF = new System.Windows.Forms.TextBox();
            this.label1PF = new System.Windows.Forms.Label();
            this.label2PF = new System.Windows.Forms.Label();
            this.label3PF = new System.Windows.Forms.Label();
            this.tbPrenumePF = new System.Windows.Forms.TextBox();
            this.tbCNPPF = new System.Windows.Forms.TextBox();
            this.tbAdresaPF = new System.Windows.Forms.TextBox();
            this.tbNrTelPF = new System.Windows.Forms.TextBox();
            this.tbEmailPF = new System.Windows.Forms.TextBox();
            this.label4PF = new System.Windows.Forms.Label();
            this.label5PF = new System.Windows.Forms.Label();
            this.label6PF = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6PJ = new System.Windows.Forms.Label();
            this.label5PJ = new System.Windows.Forms.Label();
            this.label4PJ = new System.Windows.Forms.Label();
            this.tbAdresaPJ = new System.Windows.Forms.TextBox();
            this.tbRepPJ = new System.Windows.Forms.TextBox();
            this.tbNumeFirmaPJ = new System.Windows.Forms.TextBox();
            this.tbNrRegComPJ = new System.Windows.Forms.TextBox();
            this.label3PJ = new System.Windows.Forms.Label();
            this.label2PJ = new System.Windows.Forms.Label();
            this.label1PJ = new System.Windows.Forms.Label();
            this.tbCUIPJ = new System.Windows.Forms.TextBox();
            this.label8PJ = new System.Windows.Forms.Label();
            this.label7PJ = new System.Windows.Forms.Label();
            this.tbEmailPJ = new System.Windows.Forms.TextBox();
            this.tbNrTelPJ = new System.Windows.Forms.TextBox();
            this.cbFormaJurPJ = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "Persoana fizica",
            "Persoana juridica"});
            this.listBox1.Location = new System.Drawing.Point(112, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 62);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbNumePF
            // 
            this.tbNumePF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumePF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumePF.Location = new System.Drawing.Point(544, 62);
            this.tbNumePF.Name = "tbNumePF";
            this.tbNumePF.Size = new System.Drawing.Size(155, 30);
            this.tbNumePF.TabIndex = 1;
            this.tbNumePF.Visible = false;
            this.tbNumePF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumePF_KeyPress);
            // 
            // label1PF
            // 
            this.label1PF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1PF.AutoSize = true;
            this.label1PF.BackColor = System.Drawing.Color.Transparent;
            this.label1PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1PF.Location = new System.Drawing.Point(423, 67);
            this.label1PF.Name = "label1PF";
            this.label1PF.Size = new System.Drawing.Size(70, 25);
            this.label1PF.TabIndex = 2;
            this.label1PF.Text = "Nume:";
            this.label1PF.Visible = false;
            // 
            // label2PF
            // 
            this.label2PF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2PF.AutoSize = true;
            this.label2PF.BackColor = System.Drawing.Color.Transparent;
            this.label2PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2PF.Location = new System.Drawing.Point(404, 112);
            this.label2PF.Name = "label2PF";
            this.label2PF.Size = new System.Drawing.Size(97, 25);
            this.label2PF.TabIndex = 3;
            this.label2PF.Text = "Prenume:";
            this.label2PF.Visible = false;
            // 
            // label3PF
            // 
            this.label3PF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3PF.AutoSize = true;
            this.label3PF.BackColor = System.Drawing.Color.Transparent;
            this.label3PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3PF.Location = new System.Drawing.Point(432, 160);
            this.label3PF.Name = "label3PF";
            this.label3PF.Size = new System.Drawing.Size(60, 25);
            this.label3PF.TabIndex = 4;
            this.label3PF.Text = "CNP:";
            this.label3PF.Visible = false;
            // 
            // tbPrenumePF
            // 
            this.tbPrenumePF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrenumePF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenumePF.Location = new System.Drawing.Point(544, 107);
            this.tbPrenumePF.Name = "tbPrenumePF";
            this.tbPrenumePF.Size = new System.Drawing.Size(155, 30);
            this.tbPrenumePF.TabIndex = 5;
            this.tbPrenumePF.Visible = false;
            this.tbPrenumePF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumePF_KeyPress);
            // 
            // tbCNPPF
            // 
            this.tbCNPPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCNPPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCNPPF.Location = new System.Drawing.Point(544, 155);
            this.tbCNPPF.MaxLength = 13;
            this.tbCNPPF.Name = "tbCNPPF";
            this.tbCNPPF.Size = new System.Drawing.Size(155, 30);
            this.tbCNPPF.TabIndex = 6;
            this.tbCNPPF.Visible = false;
            this.tbCNPPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPPF_KeyPress);
            // 
            // tbAdresaPF
            // 
            this.tbAdresaPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAdresaPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresaPF.Location = new System.Drawing.Point(544, 204);
            this.tbAdresaPF.Name = "tbAdresaPF";
            this.tbAdresaPF.Size = new System.Drawing.Size(155, 30);
            this.tbAdresaPF.TabIndex = 7;
            this.tbAdresaPF.Visible = false;
            // 
            // tbNrTelPF
            // 
            this.tbNrTelPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNrTelPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrTelPF.Location = new System.Drawing.Point(544, 251);
            this.tbNrTelPF.MaxLength = 10;
            this.tbNrTelPF.Name = "tbNrTelPF";
            this.tbNrTelPF.Size = new System.Drawing.Size(155, 30);
            this.tbNrTelPF.TabIndex = 8;
            this.tbNrTelPF.Visible = false;
            this.tbNrTelPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPPF_KeyPress);
            // 
            // tbEmailPF
            // 
            this.tbEmailPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmailPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailPF.Location = new System.Drawing.Point(544, 293);
            this.tbEmailPF.Name = "tbEmailPF";
            this.tbEmailPF.Size = new System.Drawing.Size(155, 30);
            this.tbEmailPF.TabIndex = 9;
            this.tbEmailPF.Visible = false;
            // 
            // label4PF
            // 
            this.label4PF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4PF.AutoSize = true;
            this.label4PF.BackColor = System.Drawing.Color.Transparent;
            this.label4PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4PF.Location = new System.Drawing.Point(415, 209);
            this.label4PF.Name = "label4PF";
            this.label4PF.Size = new System.Drawing.Size(81, 25);
            this.label4PF.TabIndex = 10;
            this.label4PF.Text = "Adresa:";
            this.label4PF.Visible = false;
            // 
            // label5PF
            // 
            this.label5PF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5PF.AutoSize = true;
            this.label5PF.BackColor = System.Drawing.Color.Transparent;
            this.label5PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5PF.Location = new System.Drawing.Point(422, 256);
            this.label5PF.Name = "label5PF";
            this.label5PF.Size = new System.Drawing.Size(68, 25);
            this.label5PF.TabIndex = 11;
            this.label5PF.Text = "Nr. tel:";
            this.label5PF.Visible = false;
            // 
            // label6PF
            // 
            this.label6PF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6PF.AutoSize = true;
            this.label6PF.BackColor = System.Drawing.Color.Transparent;
            this.label6PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6PF.Location = new System.Drawing.Point(426, 298);
            this.label6PF.Name = "label6PF";
            this.label6PF.Size = new System.Drawing.Size(66, 25);
            this.label6PF.TabIndex = 12;
            this.label6PF.Text = "Email:";
            this.label6PF.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adauga client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selecteaza tip client:";
            // 
            // label6PJ
            // 
            this.label6PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6PJ.AutoSize = true;
            this.label6PJ.BackColor = System.Drawing.Color.Transparent;
            this.label6PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6PJ.Location = new System.Drawing.Point(788, 261);
            this.label6PJ.Name = "label6PJ";
            this.label6PJ.Size = new System.Drawing.Size(81, 25);
            this.label6PJ.TabIndex = 26;
            this.label6PJ.Text = "Adresa:";
            this.label6PJ.Visible = false;
            // 
            // label5PJ
            // 
            this.label5PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5PJ.AutoSize = true;
            this.label5PJ.BackColor = System.Drawing.Color.Transparent;
            this.label5PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5PJ.Location = new System.Drawing.Point(744, 221);
            this.label5PJ.Name = "label5PJ";
            this.label5PJ.Size = new System.Drawing.Size(134, 25);
            this.label5PJ.TabIndex = 25;
            this.label5PJ.Text = "Reprezentant:";
            this.label5PJ.Visible = false;
            // 
            // label4PJ
            // 
            this.label4PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4PJ.AutoSize = true;
            this.label4PJ.BackColor = System.Drawing.Color.Transparent;
            this.label4PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4PJ.Location = new System.Drawing.Point(741, 179);
            this.label4PJ.Name = "label4PJ";
            this.label4PJ.Size = new System.Drawing.Size(140, 25);
            this.label4PJ.TabIndex = 24;
            this.label4PJ.Text = "Forma juridica:";
            this.label4PJ.Visible = false;
            // 
            // tbAdresaPJ
            // 
            this.tbAdresaPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAdresaPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresaPJ.Location = new System.Drawing.Point(885, 260);
            this.tbAdresaPJ.Name = "tbAdresaPJ";
            this.tbAdresaPJ.Size = new System.Drawing.Size(163, 30);
            this.tbAdresaPJ.TabIndex = 23;
            this.tbAdresaPJ.Visible = false;
            // 
            // tbRepPJ
            // 
            this.tbRepPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRepPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepPJ.Location = new System.Drawing.Point(885, 218);
            this.tbRepPJ.Name = "tbRepPJ";
            this.tbRepPJ.Size = new System.Drawing.Size(163, 30);
            this.tbRepPJ.TabIndex = 22;
            this.tbRepPJ.Visible = false;
            this.tbRepPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumePF_KeyPress);
            // 
            // tbNumeFirmaPJ
            // 
            this.tbNumeFirmaPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumeFirmaPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeFirmaPJ.Location = new System.Drawing.Point(885, 125);
            this.tbNumeFirmaPJ.Name = "tbNumeFirmaPJ";
            this.tbNumeFirmaPJ.Size = new System.Drawing.Size(163, 30);
            this.tbNumeFirmaPJ.TabIndex = 20;
            this.tbNumeFirmaPJ.Visible = false;
            this.tbNumeFirmaPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumePF_KeyPress);
            // 
            // tbNrRegComPJ
            // 
            this.tbNrRegComPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNrRegComPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrRegComPJ.Location = new System.Drawing.Point(885, 80);
            this.tbNrRegComPJ.Name = "tbNrRegComPJ";
            this.tbNrRegComPJ.Size = new System.Drawing.Size(163, 30);
            this.tbNrRegComPJ.TabIndex = 19;
            this.tbNrRegComPJ.Visible = false;
            this.tbNrRegComPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPPF_KeyPress);
            // 
            // label3PJ
            // 
            this.label3PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3PJ.AutoSize = true;
            this.label3PJ.BackColor = System.Drawing.Color.Transparent;
            this.label3PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3PJ.Location = new System.Drawing.Point(750, 128);
            this.label3PJ.Name = "label3PJ";
            this.label3PJ.Size = new System.Drawing.Size(117, 25);
            this.label3PJ.TabIndex = 18;
            this.label3PJ.Text = "Nume firma:";
            this.label3PJ.Visible = false;
            // 
            // label2PJ
            // 
            this.label2PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2PJ.AutoSize = true;
            this.label2PJ.BackColor = System.Drawing.Color.Transparent;
            this.label2PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2PJ.Location = new System.Drawing.Point(760, 77);
            this.label2PJ.Name = "label2PJ";
            this.label2PJ.Size = new System.Drawing.Size(113, 25);
            this.label2PJ.TabIndex = 17;
            this.label2PJ.Text = "Nr.reg.com:";
            this.label2PJ.Visible = false;
            // 
            // label1PJ
            // 
            this.label1PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1PJ.AutoSize = true;
            this.label1PJ.BackColor = System.Drawing.Color.Transparent;
            this.label1PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1PJ.Location = new System.Drawing.Point(760, 37);
            this.label1PJ.Name = "label1PJ";
            this.label1PJ.Size = new System.Drawing.Size(52, 25);
            this.label1PJ.TabIndex = 16;
            this.label1PJ.Text = "CUI:";
            this.label1PJ.Visible = false;
            // 
            // tbCUIPJ
            // 
            this.tbCUIPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCUIPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCUIPJ.Location = new System.Drawing.Point(885, 37);
            this.tbCUIPJ.Name = "tbCUIPJ";
            this.tbCUIPJ.Size = new System.Drawing.Size(163, 30);
            this.tbCUIPJ.TabIndex = 15;
            this.tbCUIPJ.Visible = false;
            this.tbCUIPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPPF_KeyPress);
            // 
            // label8PJ
            // 
            this.label8PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8PJ.AutoSize = true;
            this.label8PJ.BackColor = System.Drawing.Color.Transparent;
            this.label8PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8PJ.Location = new System.Drawing.Point(788, 342);
            this.label8PJ.Name = "label8PJ";
            this.label8PJ.Size = new System.Drawing.Size(66, 25);
            this.label8PJ.TabIndex = 30;
            this.label8PJ.Text = "Email:";
            this.label8PJ.Visible = false;
            // 
            // label7PJ
            // 
            this.label7PJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7PJ.AutoSize = true;
            this.label7PJ.BackColor = System.Drawing.Color.Transparent;
            this.label7PJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7PJ.Location = new System.Drawing.Point(744, 302);
            this.label7PJ.Name = "label7PJ";
            this.label7PJ.Size = new System.Drawing.Size(101, 25);
            this.label7PJ.TabIndex = 29;
            this.label7PJ.Text = "Nr.telefon:";
            this.label7PJ.Visible = false;
            // 
            // tbEmailPJ
            // 
            this.tbEmailPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmailPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailPJ.Location = new System.Drawing.Point(885, 341);
            this.tbEmailPJ.Name = "tbEmailPJ";
            this.tbEmailPJ.Size = new System.Drawing.Size(163, 30);
            this.tbEmailPJ.TabIndex = 28;
            this.tbEmailPJ.Visible = false;
            // 
            // tbNrTelPJ
            // 
            this.tbNrTelPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNrTelPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrTelPJ.Location = new System.Drawing.Point(885, 299);
            this.tbNrTelPJ.MaxLength = 10;
            this.tbNrTelPJ.Name = "tbNrTelPJ";
            this.tbNrTelPJ.Size = new System.Drawing.Size(163, 30);
            this.tbNrTelPJ.TabIndex = 27;
            this.tbNrTelPJ.Visible = false;
            this.tbNrTelPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPPF_KeyPress);
            // 
            // cbFormaJurPJ
            // 
            this.cbFormaJurPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFormaJurPJ.FormattingEnabled = true;
            this.cbFormaJurPJ.Location = new System.Drawing.Point(885, 175);
            this.cbFormaJurPJ.Name = "cbFormaJurPJ";
            this.cbFormaJurPJ.Size = new System.Drawing.Size(163, 24);
            this.cbFormaJurPJ.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form6_adauga_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 480);
            this.Controls.Add(this.cbFormaJurPJ);
            this.Controls.Add(this.label8PJ);
            this.Controls.Add(this.label7PJ);
            this.Controls.Add(this.tbEmailPJ);
            this.Controls.Add(this.tbNrTelPJ);
            this.Controls.Add(this.label6PJ);
            this.Controls.Add(this.label5PJ);
            this.Controls.Add(this.label4PJ);
            this.Controls.Add(this.tbAdresaPJ);
            this.Controls.Add(this.tbRepPJ);
            this.Controls.Add(this.tbNumeFirmaPJ);
            this.Controls.Add(this.tbNrRegComPJ);
            this.Controls.Add(this.label3PJ);
            this.Controls.Add(this.label2PJ);
            this.Controls.Add(this.label1PJ);
            this.Controls.Add(this.tbCUIPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6PF);
            this.Controls.Add(this.label5PF);
            this.Controls.Add(this.label4PF);
            this.Controls.Add(this.tbEmailPF);
            this.Controls.Add(this.tbNrTelPF);
            this.Controls.Add(this.tbAdresaPF);
            this.Controls.Add(this.tbCNPPF);
            this.Controls.Add(this.tbPrenumePF);
            this.Controls.Add(this.label3PF);
            this.Controls.Add(this.label2PF);
            this.Controls.Add(this.label1PF);
            this.Controls.Add(this.tbNumePF);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6_adauga_client";
            this.Text = "Adauga client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_adauga_client_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbNumePF;
        private System.Windows.Forms.Label label1PF;
        private System.Windows.Forms.Label label2PF;
        private System.Windows.Forms.Label label3PF;
        private System.Windows.Forms.TextBox tbPrenumePF;
        private System.Windows.Forms.TextBox tbCNPPF;
        private System.Windows.Forms.TextBox tbAdresaPF;
        private System.Windows.Forms.TextBox tbNrTelPF;
        private System.Windows.Forms.TextBox tbEmailPF;
        private System.Windows.Forms.Label label4PF;
        private System.Windows.Forms.Label label5PF;
        private System.Windows.Forms.Label label6PF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6PJ;
        private System.Windows.Forms.Label label5PJ;
        private System.Windows.Forms.Label label4PJ;
        private System.Windows.Forms.TextBox tbAdresaPJ;
        private System.Windows.Forms.TextBox tbRepPJ;
        private System.Windows.Forms.TextBox tbNumeFirmaPJ;
        private System.Windows.Forms.TextBox tbNrRegComPJ;
        private System.Windows.Forms.Label label3PJ;
        private System.Windows.Forms.Label label2PJ;
        private System.Windows.Forms.Label label1PJ;
        private System.Windows.Forms.TextBox tbCUIPJ;
        private System.Windows.Forms.Label label8PJ;
        private System.Windows.Forms.Label label7PJ;
        private System.Windows.Forms.TextBox tbEmailPJ;
        private System.Windows.Forms.TextBox tbNrTelPJ;
        private System.Windows.Forms.ComboBox cbFormaJurPJ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}