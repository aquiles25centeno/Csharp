namespace oraclecsharp
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_Linea = new System.Windows.Forms.Label();
            this.labelmaquina = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.Boxtrack = new System.Windows.Forms.TextBox();
            this.panel1_resultados = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_selfsn = new System.Windows.Forms.TextBox();
            this.txt_Feeder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_track = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tablero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_linea = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.Combo_tablero = new System.Windows.Forms.ComboBox();
            this.Combo_linea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1_resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONSULTA -  ERROR NO KP/ NO FEEDER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Linea
            // 
            this.label_Linea.AutoSize = true;
            this.label_Linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Linea.Location = new System.Drawing.Point(19, 56);
            this.label_Linea.Name = "label_Linea";
            this.label_Linea.Size = new System.Drawing.Size(59, 18);
            this.label_Linea.TabIndex = 10;
            this.label_Linea.Text = "LINEA:";
            // 
            // labelmaquina
            // 
            this.labelmaquina.AutoSize = true;
            this.labelmaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmaquina.Location = new System.Drawing.Point(20, 91);
            this.labelmaquina.Name = "labelmaquina";
            this.labelmaquina.Size = new System.Drawing.Size(98, 18);
            this.labelmaquina.TabIndex = 12;
            this.labelmaquina.Text = "#TABLERO:";
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrack.Location = new System.Drawing.Point(185, 91);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(89, 18);
            this.labelTrack.TabIndex = 14;
            this.labelTrack.Text = "#FEEDER:";
            // 
            // Boxtrack
            // 
            this.Boxtrack.AcceptsReturn = true;
            this.Boxtrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Boxtrack.Location = new System.Drawing.Point(279, 91);
            this.Boxtrack.Name = "Boxtrack";
            this.Boxtrack.Size = new System.Drawing.Size(40, 20);
            this.Boxtrack.TabIndex = 15;
            this.Boxtrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1_resultados
            // 
            this.panel1_resultados.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1_resultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1_resultados.Controls.Add(this.label6);
            this.panel1_resultados.Controls.Add(this.label5);
            this.panel1_resultados.Controls.Add(this.txt_selfsn);
            this.panel1_resultados.Controls.Add(this.txt_Feeder);
            this.panel1_resultados.Controls.Add(this.label4);
            this.panel1_resultados.Controls.Add(this.txt_track);
            this.panel1_resultados.Controls.Add(this.label3);
            this.panel1_resultados.Controls.Add(this.txt_tablero);
            this.panel1_resultados.Controls.Add(this.label1);
            this.panel1_resultados.Controls.Add(this.txt_linea);
            this.panel1_resultados.Location = new System.Drawing.Point(13, 139);
            this.panel1_resultados.Name = "panel1_resultados";
            this.panel1_resultados.Size = new System.Drawing.Size(581, 204);
            this.panel1_resultados.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "NUMERO DE PARTE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "*FEEDER ANTERIOR:";
            // 
            // txt_selfsn
            // 
            this.txt_selfsn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_selfsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_selfsn.Enabled = false;
            this.txt_selfsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selfsn.ForeColor = System.Drawing.Color.Red;
            this.txt_selfsn.Location = new System.Drawing.Point(171, 147);
            this.txt_selfsn.Name = "txt_selfsn";
            this.txt_selfsn.ReadOnly = true;
            this.txt_selfsn.Size = new System.Drawing.Size(390, 27);
            this.txt_selfsn.TabIndex = 13;
            this.txt_selfsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Feeder
            // 
            this.txt_Feeder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Feeder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Feeder.Enabled = false;
            this.txt_Feeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Feeder.ForeColor = System.Drawing.Color.Red;
            this.txt_Feeder.Location = new System.Drawing.Point(171, 111);
            this.txt_Feeder.Name = "txt_Feeder";
            this.txt_Feeder.ReadOnly = true;
            this.txt_Feeder.Size = new System.Drawing.Size(120, 27);
            this.txt_Feeder.TabIndex = 13;
            this.txt_Feeder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "FEEDER:";
            // 
            // txt_track
            // 
            this.txt_track.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_track.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_track.Enabled = false;
            this.txt_track.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_track.ForeColor = System.Drawing.Color.Red;
            this.txt_track.Location = new System.Drawing.Point(93, 80);
            this.txt_track.Name = "txt_track";
            this.txt_track.ReadOnly = true;
            this.txt_track.Size = new System.Drawing.Size(52, 26);
            this.txt_track.TabIndex = 13;
            this.txt_track.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "TABLERO:";
            // 
            // txt_tablero
            // 
            this.txt_tablero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tablero.Enabled = false;
            this.txt_tablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tablero.ForeColor = System.Drawing.Color.Red;
            this.txt_tablero.Location = new System.Drawing.Point(93, 48);
            this.txt_tablero.Name = "txt_tablero";
            this.txt_tablero.ReadOnly = true;
            this.txt_tablero.Size = new System.Drawing.Size(52, 26);
            this.txt_tablero.TabIndex = 13;
            this.txt_tablero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "LINEA:";
            // 
            // txt_linea
            // 
            this.txt_linea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_linea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_linea.Enabled = false;
            this.txt_linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linea.ForeColor = System.Drawing.Color.Red;
            this.txt_linea.Location = new System.Drawing.Point(93, 17);
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.ReadOnly = true;
            this.txt_linea.Size = new System.Drawing.Size(52, 26);
            this.txt_linea.TabIndex = 13;
            this.txt_linea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Query
            // 
            this.btn_Query.Image = ((System.Drawing.Image)(resources.GetObject("btn_Query.Image")));
            this.btn_Query.Location = new System.Drawing.Point(350, 82);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(115, 44);
            this.btn_Query.TabIndex = 18;
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Combo_tablero
            // 
            this.Combo_tablero.FormattingEnabled = true;
            this.Combo_tablero.Location = new System.Drawing.Point(118, 91);
            this.Combo_tablero.Name = "Combo_tablero";
            this.Combo_tablero.Size = new System.Drawing.Size(43, 21);
            this.Combo_tablero.TabIndex = 19;
            // 
            // Combo_linea
            // 
            this.Combo_linea.FormattingEnabled = true;
            this.Combo_linea.Items.AddRange(new object[] {
            "TOP_S01",
            "BOT_ST01"});
            this.Combo_linea.Location = new System.Drawing.Point(88, 55);
            this.Combo_linea.Name = "Combo_linea";
            this.Combo_linea.Size = new System.Drawing.Size(104, 21);
            this.Combo_linea.TabIndex = 20;
            this.Combo_linea.Text = "            ELIJA";
            this.Combo_linea.SelectedIndexChanged += new System.EventHandler(this.Combo_linea_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(606, 359);
            this.Controls.Add(this.Combo_linea);
            this.Controls.Add(this.Combo_tablero);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.panel1_resultados);
            this.Controls.Add(this.Boxtrack);
            this.Controls.Add(this.labelTrack);
            this.Controls.Add(this.labelmaquina);
            this.Controls.Add(this.label_Linea);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFIS_QUERY_SMT";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1_resultados.ResumeLayout(false);
            this.panel1_resultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Linea;
        private System.Windows.Forms.Label labelmaquina;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.TextBox Boxtrack;
        private System.Windows.Forms.Panel panel1_resultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_linea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_selfsn;
        private System.Windows.Forms.TextBox txt_Feeder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_track;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tablero;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.ComboBox Combo_tablero;
        private System.Windows.Forms.ComboBox Combo_linea;
    }
}

