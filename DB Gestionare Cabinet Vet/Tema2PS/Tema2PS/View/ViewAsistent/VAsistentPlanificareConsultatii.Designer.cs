
namespace Tema2PS.View.ViewAsistent
{
    partial class VAsistentPlanificareConsultatii
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
            this.dgvAnimaleF = new System.Windows.Forms.DataGridView();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.txtCipA = new System.Windows.Forms.TextBox();
            this.txtSpecieA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMediciF = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.txtRolM = new System.Windows.Forms.TextBox();
            this.txtEmailM = new System.Windows.Forms.TextBox();
            this.txtParolaM = new System.Windows.Forms.TextBox();
            this.txtOraStopM = new System.Windows.Forms.TextBox();
            this.txtOraStartM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNrCrtF = new System.Windows.Forms.TextBox();
            this.dgvFiseF = new System.Windows.Forms.DataGridView();
            this.btnAdaugareFisa = new System.Windows.Forms.Button();
            this.txtZiuaF = new System.Windows.Forms.ComboBox();
            this.txtOraF = new System.Windows.Forms.ComboBox();
            this.txtSimptomF = new System.Windows.Forms.ComboBox();
            this.txtDiagnosticF = new System.Windows.Forms.ComboBox();
            this.txtTratamentF = new System.Windows.Forms.ComboBox();
            this.txtIdMF = new System.Windows.Forms.TextBox();
            this.txtSpecieAF = new System.Windows.Forms.TextBox();
            this.txtCipAF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaleF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediciF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiseF)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimaleF
            // 
            this.dgvAnimaleF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaleF.Location = new System.Drawing.Point(44, 203);
            this.dgvAnimaleF.Name = "dgvAnimaleF";
            this.dgvAnimaleF.RowHeadersWidth = 82;
            this.dgvAnimaleF.RowTemplate.Height = 33;
            this.dgvAnimaleF.Size = new System.Drawing.Size(598, 318);
            this.dgvAnimaleF.TabIndex = 0;
            this.dgvAnimaleF.DoubleClick += new System.EventHandler(this.dgvAnimaleF_DoubleClick);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(1926, 12);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(151, 45);
            this.btnInapoi.TabIndex = 27;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // txtCipA
            // 
            this.txtCipA.Location = new System.Drawing.Point(322, 73);
            this.txtCipA.Name = "txtCipA";
            this.txtCipA.Size = new System.Drawing.Size(315, 31);
            this.txtCipA.TabIndex = 28;
            // 
            // txtSpecieA
            // 
            this.txtSpecieA.Location = new System.Drawing.Point(322, 157);
            this.txtSpecieA.Name = "txtSpecieA";
            this.txtSpecieA.Size = new System.Drawing.Size(315, 31);
            this.txtSpecieA.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "CIP Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 42);
            this.label2.TabIndex = 31;
            this.label2.Text = "Specie Animal:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvMediciF
            // 
            this.dgvMediciF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediciF.Location = new System.Drawing.Point(692, 203);
            this.dgvMediciF.Name = "dgvMediciF";
            this.dgvMediciF.RowHeadersWidth = 82;
            this.dgvMediciF.RowTemplate.Height = 33;
            this.dgvMediciF.Size = new System.Drawing.Size(1385, 318);
            this.dgvMediciF.TabIndex = 32;
            this.dgvMediciF.DoubleClick += new System.EventHandler(this.dgvMediciF_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(702, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 42);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID Medic:";
            // 
            // txtIdM
            // 
            this.txtIdM.Location = new System.Drawing.Point(901, 84);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(116, 31);
            this.txtIdM.TabIndex = 34;
            // 
            // txtRolM
            // 
            this.txtRolM.Location = new System.Drawing.Point(1035, 84);
            this.txtRolM.Name = "txtRolM";
            this.txtRolM.Size = new System.Drawing.Size(78, 31);
            this.txtRolM.TabIndex = 35;
            this.txtRolM.Visible = false;
            // 
            // txtEmailM
            // 
            this.txtEmailM.Location = new System.Drawing.Point(1129, 84);
            this.txtEmailM.Name = "txtEmailM";
            this.txtEmailM.Size = new System.Drawing.Size(81, 31);
            this.txtEmailM.TabIndex = 36;
            this.txtEmailM.Visible = false;
            // 
            // txtParolaM
            // 
            this.txtParolaM.Location = new System.Drawing.Point(1231, 84);
            this.txtParolaM.Name = "txtParolaM";
            this.txtParolaM.Size = new System.Drawing.Size(77, 31);
            this.txtParolaM.TabIndex = 37;
            this.txtParolaM.Visible = false;
            // 
            // txtOraStopM
            // 
            this.txtOraStopM.Location = new System.Drawing.Point(1416, 84);
            this.txtOraStopM.Name = "txtOraStopM";
            this.txtOraStopM.Size = new System.Drawing.Size(74, 31);
            this.txtOraStopM.TabIndex = 38;
            this.txtOraStopM.Visible = false;
            // 
            // txtOraStartM
            // 
            this.txtOraStartM.Location = new System.Drawing.Point(1324, 84);
            this.txtOraStartM.Name = "txtOraStartM";
            this.txtOraStartM.Size = new System.Drawing.Size(77, 31);
            this.txtOraStartM.TabIndex = 39;
            this.txtOraStartM.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(54, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 42);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ziua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(54, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 42);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1068, 997);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 42);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nr Crt:";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1585, 1055);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 42);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tratament:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1585, 1003);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 42);
            this.label8.TabIndex = 44;
            this.label8.Text = "Diagnostic:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1068, 1055);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 42);
            this.label9.TabIndex = 45;
            this.label9.Text = "Simptom:";
            this.label9.Visible = false;
            // 
            // txtNrCrtF
            // 
            this.txtNrCrtF.Location = new System.Drawing.Point(1296, 1008);
            this.txtNrCrtF.Name = "txtNrCrtF";
            this.txtNrCrtF.Size = new System.Drawing.Size(264, 31);
            this.txtNrCrtF.TabIndex = 46;
            this.txtNrCrtF.Visible = false;
            this.txtNrCrtF.TextChanged += new System.EventHandler(this.txtNrCrtF_TextChanged);
            // 
            // dgvFiseF
            // 
            this.dgvFiseF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiseF.Location = new System.Drawing.Point(44, 655);
            this.dgvFiseF.Name = "dgvFiseF";
            this.dgvFiseF.RowHeadersWidth = 82;
            this.dgvFiseF.RowTemplate.Height = 33;
            this.dgvFiseF.Size = new System.Drawing.Size(2033, 324);
            this.dgvFiseF.TabIndex = 52;
            // 
            // btnAdaugareFisa
            // 
            this.btnAdaugareFisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdaugareFisa.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugareFisa.Location = new System.Drawing.Point(44, 993);
            this.btnAdaugareFisa.Name = "btnAdaugareFisa";
            this.btnAdaugareFisa.Size = new System.Drawing.Size(485, 122);
            this.btnAdaugareFisa.TabIndex = 53;
            this.btnAdaugareFisa.Text = "Adaugare Fisa";
            this.btnAdaugareFisa.UseVisualStyleBackColor = false;
            this.btnAdaugareFisa.Click += new System.EventHandler(this.btnAdaugareFisa_Click);
            // 
            // txtZiuaF
            // 
            this.txtZiuaF.FormattingEnabled = true;
            this.txtZiuaF.Items.AddRange(new object[] {
            "Luni",
            "Marti",
            "Miercuri",
            "Joi",
            "Vineri",
            "Sambata",
            "Duminica"});
            this.txtZiuaF.Location = new System.Drawing.Point(282, 557);
            this.txtZiuaF.Name = "txtZiuaF";
            this.txtZiuaF.Size = new System.Drawing.Size(264, 33);
            this.txtZiuaF.TabIndex = 54;
            this.txtZiuaF.SelectedIndexChanged += new System.EventHandler(this.txtZiuaF_SelectedIndexChanged);
            // 
            // txtOraF
            // 
            this.txtOraF.FormattingEnabled = true;
            this.txtOraF.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.txtOraF.Location = new System.Drawing.Point(282, 610);
            this.txtOraF.Name = "txtOraF";
            this.txtOraF.Size = new System.Drawing.Size(264, 33);
            this.txtOraF.TabIndex = 55;
            this.txtOraF.SelectedIndexChanged += new System.EventHandler(this.txtOraF_SelectedIndexChanged);
            // 
            // txtSimptomF
            // 
            this.txtSimptomF.FormattingEnabled = true;
            this.txtSimptomF.Items.AddRange(new object[] {
            "Febra",
            "Tuse",
            "Somnolenta",
            "Greata",
            "Inflamare",
            "Rana",
            "RespiratieIngreunata"});
            this.txtSimptomF.Location = new System.Drawing.Point(1296, 1055);
            this.txtSimptomF.Name = "txtSimptomF";
            this.txtSimptomF.Size = new System.Drawing.Size(264, 33);
            this.txtSimptomF.TabIndex = 56;
            this.txtSimptomF.Visible = false;
            this.txtSimptomF.SelectedIndexChanged += new System.EventHandler(this.txtSimptomF_SelectedIndexChanged);
            // 
            // txtDiagnosticF
            // 
            this.txtDiagnosticF.FormattingEnabled = true;
            this.txtDiagnosticF.Items.AddRange(new object[] {
            "Raceala",
            "Gripa",
            "PIF",
            "Pesta",
            "Tuberculoza",
            "Bluetongue",
            "Trichineloza"});
            this.txtDiagnosticF.Location = new System.Drawing.Point(1813, 1012);
            this.txtDiagnosticF.Name = "txtDiagnosticF";
            this.txtDiagnosticF.Size = new System.Drawing.Size(264, 33);
            this.txtDiagnosticF.TabIndex = 57;
            this.txtDiagnosticF.Visible = false;
            this.txtDiagnosticF.SelectedIndexChanged += new System.EventHandler(this.txtDiagnosticF_SelectedIndexChanged);
            // 
            // txtTratamentF
            // 
            this.txtTratamentF.FormattingEnabled = true;
            this.txtTratamentF.Items.AddRange(new object[] {
            "Pastile",
            "Sirop",
            "Infuzii",
            "Injectii",
            "Operatie"});
            this.txtTratamentF.Location = new System.Drawing.Point(1813, 1066);
            this.txtTratamentF.Name = "txtTratamentF";
            this.txtTratamentF.Size = new System.Drawing.Size(264, 33);
            this.txtTratamentF.TabIndex = 58;
            this.txtTratamentF.Visible = false;
            this.txtTratamentF.SelectedIndexChanged += new System.EventHandler(this.txtTratamentF_SelectedIndexChanged);
            // 
            // txtIdMF
            // 
            this.txtIdMF.Location = new System.Drawing.Point(949, 1057);
            this.txtIdMF.Name = "txtIdMF";
            this.txtIdMF.Size = new System.Drawing.Size(100, 31);
            this.txtIdMF.TabIndex = 59;
            this.txtIdMF.Visible = false;
            // 
            // txtSpecieAF
            // 
            this.txtSpecieAF.Location = new System.Drawing.Point(843, 1057);
            this.txtSpecieAF.Name = "txtSpecieAF";
            this.txtSpecieAF.Size = new System.Drawing.Size(100, 31);
            this.txtSpecieAF.TabIndex = 60;
            this.txtSpecieAF.Visible = false;
            // 
            // txtCipAF
            // 
            this.txtCipAF.Location = new System.Drawing.Point(610, 1057);
            this.txtCipAF.Name = "txtCipAF";
            this.txtCipAF.Size = new System.Drawing.Size(100, 31);
            this.txtCipAF.TabIndex = 61;
            this.txtCipAF.Visible = false;
            // 
            // VAsistentPlanificareConsultatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2089, 1155);
            this.Controls.Add(this.txtCipAF);
            this.Controls.Add(this.txtSpecieAF);
            this.Controls.Add(this.txtIdMF);
            this.Controls.Add(this.txtTratamentF);
            this.Controls.Add(this.txtDiagnosticF);
            this.Controls.Add(this.txtSimptomF);
            this.Controls.Add(this.txtOraF);
            this.Controls.Add(this.txtZiuaF);
            this.Controls.Add(this.btnAdaugareFisa);
            this.Controls.Add(this.dgvFiseF);
            this.Controls.Add(this.txtNrCrtF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOraStartM);
            this.Controls.Add(this.txtOraStopM);
            this.Controls.Add(this.txtParolaM);
            this.Controls.Add(this.txtEmailM);
            this.Controls.Add(this.txtRolM);
            this.Controls.Add(this.txtIdM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMediciF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpecieA);
            this.Controls.Add(this.txtCipA);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.dgvAnimaleF);
            this.Name = "VAsistentPlanificareConsultatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAsistentPlanificareConsultatii";
            this.Load += new System.EventHandler(this.VAsistentPlanificareConsultatii_Load);
            this.Click += new System.EventHandler(this.VAsistentPlanificareConsultatii_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaleF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediciF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiseF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimaleF;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.TextBox txtCipA;
        private System.Windows.Forms.TextBox txtSpecieA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMediciF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.TextBox txtRolM;
        private System.Windows.Forms.TextBox txtEmailM;
        private System.Windows.Forms.TextBox txtParolaM;
        private System.Windows.Forms.TextBox txtOraStopM;
        private System.Windows.Forms.TextBox txtOraStartM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNrCrtF;
        private System.Windows.Forms.DataGridView dgvFiseF;
        private System.Windows.Forms.Button btnAdaugareFisa;
        private System.Windows.Forms.ComboBox txtZiuaF;
        private System.Windows.Forms.ComboBox txtOraF;
        private System.Windows.Forms.ComboBox txtSimptomF;
        private System.Windows.Forms.ComboBox txtDiagnosticF;
        private System.Windows.Forms.ComboBox txtTratamentF;
        private System.Windows.Forms.TextBox txtIdMF;
        private System.Windows.Forms.TextBox txtSpecieAF;
        private System.Windows.Forms.TextBox txtCipAF;
    }
}