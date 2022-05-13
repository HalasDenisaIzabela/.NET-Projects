
namespace Tema2PS.View.ViewMedic
{
    partial class VGestionareFiseMedicaleMedic
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
            this.dgvFiseF = new System.Windows.Forms.DataGridView();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.txtTratamentF = new System.Windows.Forms.ComboBox();
            this.txtDiagnosticF = new System.Windows.Forms.ComboBox();
            this.txtSimptomF = new System.Windows.Forms.ComboBox();
            this.txtOraF = new System.Windows.Forms.ComboBox();
            this.txtZiuaF = new System.Windows.Forms.ComboBox();
            this.txtNrCrtF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpecieA = new System.Windows.Forms.TextBox();
            this.txtCipA = new System.Windows.Forms.TextBox();
            this.btnSDT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiseF)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiseF
            // 
            this.dgvFiseF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiseF.Location = new System.Drawing.Point(45, 214);
            this.dgvFiseF.Name = "dgvFiseF";
            this.dgvFiseF.RowHeadersWidth = 82;
            this.dgvFiseF.RowTemplate.Height = 33;
            this.dgvFiseF.Size = new System.Drawing.Size(2033, 324);
            this.dgvFiseF.TabIndex = 53;
            this.dgvFiseF.DoubleClick += new System.EventHandler(this.dgvFiseF_DoubleClick);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(1906, 27);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(151, 45);
            this.btnInapoi.TabIndex = 54;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
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
            this.txtTratamentF.Location = new System.Drawing.Point(1409, 150);
            this.txtTratamentF.Name = "txtTratamentF";
            this.txtTratamentF.Size = new System.Drawing.Size(264, 33);
            this.txtTratamentF.TabIndex = 76;
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
            this.txtDiagnosticF.Location = new System.Drawing.Point(821, 148);
            this.txtDiagnosticF.Name = "txtDiagnosticF";
            this.txtDiagnosticF.Size = new System.Drawing.Size(264, 33);
            this.txtDiagnosticF.TabIndex = 75;
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
            this.txtSimptomF.Location = new System.Drawing.Point(266, 139);
            this.txtSimptomF.Name = "txtSimptomF";
            this.txtSimptomF.Size = new System.Drawing.Size(264, 33);
            this.txtSimptomF.TabIndex = 74;
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
            this.txtOraF.Location = new System.Drawing.Point(1972, 634);
            this.txtOraF.Name = "txtOraF";
            this.txtOraF.Size = new System.Drawing.Size(101, 33);
            this.txtOraF.TabIndex = 73;
            this.txtOraF.Visible = false;
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
            this.txtZiuaF.Location = new System.Drawing.Point(1972, 565);
            this.txtZiuaF.Name = "txtZiuaF";
            this.txtZiuaF.Size = new System.Drawing.Size(101, 33);
            this.txtZiuaF.TabIndex = 72;
            this.txtZiuaF.Visible = false;
            // 
            // txtNrCrtF
            // 
            this.txtNrCrtF.Location = new System.Drawing.Point(1678, 638);
            this.txtNrCrtF.Name = "txtNrCrtF";
            this.txtNrCrtF.Size = new System.Drawing.Size(116, 31);
            this.txtNrCrtF.TabIndex = 71;
            this.txtNrCrtF.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(38, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 42);
            this.label9.TabIndex = 70;
            this.label9.Text = "Simptom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(593, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 42);
            this.label8.TabIndex = 69;
            this.label8.Text = "Diagnostic:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1181, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 42);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tratament:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1489, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 42);
            this.label6.TabIndex = 67;
            this.label6.Text = "Nr Crt:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1835, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 42);
            this.label5.TabIndex = 66;
            this.label5.Text = "Ora:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1835, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 42);
            this.label4.TabIndex = 65;
            this.label4.Text = "Ziua:";
            this.label4.Visible = false;
            // 
            // txtIdM
            // 
            this.txtIdM.Location = new System.Drawing.Point(1678, 563);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(116, 31);
            this.txtIdM.TabIndex = 64;
            this.txtIdM.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1489, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 42);
            this.label3.TabIndex = 63;
            this.label3.Text = "ID Medic:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1096, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 42);
            this.label2.TabIndex = 62;
            this.label2.Text = "Specie Animal:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1096, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 61;
            this.label1.Text = "CIP Animal:";
            this.label1.Visible = false;
            // 
            // txtSpecieA
            // 
            this.txtSpecieA.Location = new System.Drawing.Point(1371, 636);
            this.txtSpecieA.Name = "txtSpecieA";
            this.txtSpecieA.Size = new System.Drawing.Size(101, 31);
            this.txtSpecieA.TabIndex = 60;
            this.txtSpecieA.Visible = false;
            // 
            // txtCipA
            // 
            this.txtCipA.Location = new System.Drawing.Point(1371, 552);
            this.txtCipA.Name = "txtCipA";
            this.txtCipA.Size = new System.Drawing.Size(101, 31);
            this.txtCipA.TabIndex = 59;
            this.txtCipA.Visible = false;
            // 
            // btnSDT
            // 
            this.btnSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSDT.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSDT.Location = new System.Drawing.Point(45, 556);
            this.btnSDT.Name = "btnSDT";
            this.btnSDT.Size = new System.Drawing.Size(1009, 111);
            this.btnSDT.TabIndex = 77;
            this.btnSDT.Text = "Adaugare simptom, diagnostic, tratament";
            this.btnSDT.UseVisualStyleBackColor = false;
            this.btnSDT.Click += new System.EventHandler(this.btnSDT_Click);
            // 
            // VGestionareFiseMedicaleMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2090, 694);
            this.Controls.Add(this.btnSDT);
            this.Controls.Add(this.txtTratamentF);
            this.Controls.Add(this.txtDiagnosticF);
            this.Controls.Add(this.txtSimptomF);
            this.Controls.Add(this.txtOraF);
            this.Controls.Add(this.txtZiuaF);
            this.Controls.Add(this.txtNrCrtF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpecieA);
            this.Controls.Add(this.txtCipA);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.dgvFiseF);
            this.Name = "VGestionareFiseMedicaleMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VGestionareFiseMedicaleMedic";
            this.Load += new System.EventHandler(this.VGestionareFiseMedicaleMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiseF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiseF;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.ComboBox txtTratamentF;
        private System.Windows.Forms.ComboBox txtDiagnosticF;
        private System.Windows.Forms.ComboBox txtSimptomF;
        private System.Windows.Forms.ComboBox txtOraF;
        private System.Windows.Forms.ComboBox txtZiuaF;
        private System.Windows.Forms.TextBox txtNrCrtF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpecieA;
        private System.Windows.Forms.TextBox txtCipA;
        private System.Windows.Forms.Button btnSDT;
    }
}