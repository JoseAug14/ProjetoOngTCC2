namespace ProjetoTcc2
{
    partial class Telahome
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
            this.dataGridViewActivities = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtcrianca = new System.Windows.Forms.Label();
            this.lbldoacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewActivities
            // 
            this.dataGridViewActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivities.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewActivities.Name = "dataGridViewActivities";
            this.dataGridViewActivities.Size = new System.Drawing.Size(1119, 412);
            this.dataGridViewActivities.TabIndex = 0;
            this.dataGridViewActivities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivities_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewActivities, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtcrianca
            // 
            this.txtcrianca.AutoSize = true;
            this.txtcrianca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrianca.Location = new System.Drawing.Point(314, 106);
            this.txtcrianca.Name = "txtcrianca";
            this.txtcrianca.Size = new System.Drawing.Size(81, 22);
            this.txtcrianca.TabIndex = 2;
            this.txtcrianca.Text = "Crianca";
            this.txtcrianca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldoacao
            // 
            this.lbldoacao.Location = new System.Drawing.Point(317, 165);
            this.lbldoacao.Name = "lbldoacao";
            this.lbldoacao.Size = new System.Drawing.Size(168, 20);
            this.lbldoacao.TabIndex = 3;
            // 
            // Telahome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1138, 650);
            this.Controls.Add(this.lbldoacao);
            this.Controls.Add(this.txtcrianca);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Telahome";
            this.Text = "Telahome";
            this.Load += new System.EventHandler(this.Telahome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActivities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txtcrianca;
        private System.Windows.Forms.TextBox lbldoacao;
    }
}