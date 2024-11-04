namespace ProjetoTcc2
{
    partial class AdicionarFamilia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtdatanasc = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtuf = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpFilhos = new System.Windows.Forms.GroupBox();
            this.filhocombox = new System.Windows.Forms.ComboBox();
            this.btncrianca = new System.Windows.Forms.Button();
            this.rdtem = new System.Windows.Forms.RadioButton();
            this.txtestcivil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnomeresponsavel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmarmita = new System.Windows.Forms.ComboBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gpFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADICIONAR FAMILIA";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(946, 272);
            this.txtrg.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtrg.Mask = "00,000,000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(94, 26);
            this.txtrg.TabIndex = 53;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(155, 425);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txttelefone.Mask = "(99) 0 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(142, 26);
            this.txttelefone.TabIndex = 52;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(106, 276);
            this.txtcep.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(97, 26);
            this.txtcep.TabIndex = 51;
            // 
            // txtdatanasc
            // 
            this.txtdatanasc.Location = new System.Drawing.Point(968, 200);
            this.txtdatanasc.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtdatanasc.Mask = "00/00/0000";
            this.txtdatanasc.Name = "txtdatanasc";
            this.txtdatanasc.Size = new System.Drawing.Size(117, 26);
            this.txtdatanasc.TabIndex = 50;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(436, 275);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(131, 26);
            this.txtcpf.TabIndex = 49;
            // 
            // txtuf
            // 
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Items.AddRange(new object[] {
            "AC  ",
            "AL  ",
            "AP  ",
            "AM  ",
            "BA  ",
            "CE  ",
            "DF  ",
            "ES  ",
            "GO  ",
            "MA  ",
            "MT  ",
            "MS  ",
            "MG  ",
            "PA  ",
            "PB  ",
            "PR  ",
            "PE  ",
            "PI  ",
            "RJ  ",
            "RN  ",
            "RS  ",
            "RO  ",
            "RR  ",
            "SC  ",
            "SP  ",
            "SE  ",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(288, 275);
            this.txtuf.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(41, 28);
            this.txtuf.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(53, 283);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "CEP";
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(661, 347);
            this.txtcomp.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(241, 26);
            this.txtcomp.TabIndex = 46;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(455, 425);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(254, 26);
            this.txtemail.TabIndex = 45;
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(155, 348);
            this.txtrua.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(345, 26);
            this.txtrua.TabIndex = 44;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(661, 200);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(169, 26);
            this.txtcidade.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 428);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "TELEFONE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(524, 350);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "COMPLEMENTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(577, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "CIDADE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(384, 428);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "EMAIL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(51, 350);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "ENDEREÇO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(245, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(900, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(856, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "DATA/NASC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(384, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 494);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "TEM FILHOS?";
            // 
            // gpFilhos
            // 
            this.gpFilhos.Controls.Add(this.filhocombox);
            this.gpFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFilhos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpFilhos.Location = new System.Drawing.Point(81, 542);
            this.gpFilhos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gpFilhos.Name = "gpFilhos";
            this.gpFilhos.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gpFilhos.Size = new System.Drawing.Size(97, 77);
            this.gpFilhos.TabIndex = 62;
            this.gpFilhos.TabStop = false;
            this.gpFilhos.Text = "Filhos";
            this.gpFilhos.Visible = false;
            this.gpFilhos.Enter += new System.EventHandler(this.gpFilhos_Enter);
            // 
            // filhocombox
            // 
            this.filhocombox.FormattingEnabled = true;
            this.filhocombox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.filhocombox.Location = new System.Drawing.Point(31, 31);
            this.filhocombox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.filhocombox.Name = "filhocombox";
            this.filhocombox.Size = new System.Drawing.Size(41, 28);
            this.filhocombox.TabIndex = 64;
            // 
            // btncrianca
            // 
            this.btncrianca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(34)))));
            this.btncrianca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrianca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncrianca.Location = new System.Drawing.Point(246, 572);
            this.btncrianca.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btncrianca.Name = "btncrianca";
            this.btncrianca.Size = new System.Drawing.Size(166, 47);
            this.btncrianca.TabIndex = 63;
            this.btncrianca.Text = "Adicionar criança";
            this.btncrianca.UseVisualStyleBackColor = false;
            this.btncrianca.Click += new System.EventHandler(this.btncrianca_Click);
            // 
            // rdtem
            // 
            this.rdtem.AutoSize = true;
            this.rdtem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdtem.Location = new System.Drawing.Point(220, 494);
            this.rdtem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rdtem.Name = "rdtem";
            this.rdtem.Size = new System.Drawing.Size(56, 24);
            this.rdtem.TabIndex = 2;
            this.rdtem.TabStop = true;
            this.rdtem.Text = "SIM";
            this.rdtem.UseVisualStyleBackColor = true;
            this.rdtem.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtestcivil
            // 
            this.txtestcivil.FormattingEnabled = true;
            this.txtestcivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Prefiro não dizer"});
            this.txtestcivil.Location = new System.Drawing.Point(735, 270);
            this.txtestcivil.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtestcivil.Name = "txtestcivil";
            this.txtestcivil.Size = new System.Drawing.Size(141, 28);
            this.txtestcivil.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(594, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "ESTADO CIVIL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(528, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 47);
            this.button1.TabIndex = 66;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnomeresponsavel
            // 
            this.txtnomeresponsavel.Location = new System.Drawing.Point(276, 203);
            this.txtnomeresponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.txtnomeresponsavel.Name = "txtnomeresponsavel";
            this.txtnomeresponsavel.Size = new System.Drawing.Size(266, 26);
            this.txtnomeresponsavel.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(53, 206);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 20);
            this.label14.TabIndex = 67;
            this.label14.Text = "NOME DO RESPONSÁVEL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(750, 428);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 20);
            this.label15.TabIndex = 69;
            this.label15.Text = "MARMITAS RECEBIDAS";
            // 
            // txtmarmita
            // 
            this.txtmarmita.FormattingEnabled = true;
            this.txtmarmita.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtmarmita.Location = new System.Drawing.Point(960, 425);
            this.txtmarmita.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtmarmita.Name = "txtmarmita";
            this.txtmarmita.Size = new System.Drawing.Size(41, 28);
            this.txtmarmita.TabIndex = 70;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(1020, 348);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(55, 26);
            this.txtnumero.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(920, 350);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 72;
            this.label16.Text = "NÚMERO";
            // 
            // AdicionarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1138, 650);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtmarmita);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtnomeresponsavel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtestcivil);
            this.Controls.Add(this.rdtem);
            this.Controls.Add(this.btncrianca);
            this.Controls.Add(this.gpFilhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtdatanasc);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "AdicionarFamilia";
            this.Text = "AdicionarFamilia";
            this.Load += new System.EventHandler(this.AdicionarFamilia_Load);
            this.gpFilhos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtdatanasc;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.ComboBox txtuf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpFilhos;
        private System.Windows.Forms.Button btncrianca;
        private System.Windows.Forms.RadioButton rdtem;
        private System.Windows.Forms.ComboBox filhocombox;
        private System.Windows.Forms.ComboBox txtestcivil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnomeresponsavel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtmarmita;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label16;
    }
}