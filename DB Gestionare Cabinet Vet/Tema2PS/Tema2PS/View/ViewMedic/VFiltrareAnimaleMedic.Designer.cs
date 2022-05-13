
namespace Tema2PS.View.ViewMedic
{
    partial class VFiltrareAnimaleMedic
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
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.txtTratamentF = new System.Windows.Forms.ComboBox();
            this.txtDiagnosticF = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCauta2 = new System.Windows.Forms.Button();
            this.btnCauta1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(1837, 44);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(151, 45);
            this.btnInapoi.TabIndex = 55;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(24, 188);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(1964, 324);
            this.dgv1.TabIndex = 56;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(25, 621);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 82;
            this.dgv2.RowTemplate.Height = 33;
            this.dgv2.Size = new System.Drawing.Size(1963, 324);
            this.dgv2.TabIndex = 57;
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
            this.txtTratamentF.Location = new System.Drawing.Point(264, 554);
            this.txtTratamentF.Name = "txtTratamentF";
            this.txtTratamentF.Size = new System.Drawing.Size(264, 33);
            this.txtTratamentF.TabIndex = 82;
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
            this.txtDiagnosticF.Location = new System.Drawing.Point(264, 111);
            this.txtDiagnosticF.Name = "txtDiagnosticF";
            this.txtDiagnosticF.Size = new System.Drawing.Size(264, 33);
            this.txtDiagnosticF.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 42);
            this.label8.TabIndex = 78;
            this.label8.Text = "Diagnostic:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(36, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 42);
            this.label7.TabIndex = 77;
            this.label7.Text = "Tratament:";
            // 
            // btnCauta2
            // 
            this.btnCauta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCauta2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta2.Location = new System.Drawing.Point(613, 534);
            this.btnCauta2.Name = "btnCauta2";
            this.btnCauta2.Size = new System.Drawing.Size(227, 61);
            this.btnCauta2.TabIndex = 83;
            this.btnCauta2.Text = "Cauta";
            this.btnCauta2.UseVisualStyleBackColor = false;
            this.btnCauta2.Click += new System.EventHandler(this.btnCauta2_Click);
            // 
            // btnCauta1
            // 
            this.btnCauta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCauta1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta1.Location = new System.Drawing.Point(613, 95);
            this.btnCauta1.Name = "btnCauta1";
            this.btnCauta1.Size = new System.Drawing.Size(227, 59);
            this.btnCauta1.TabIndex = 84;
            this.btnCauta1.Text = "Cauta";
            this.btnCauta1.UseVisualStyleBackColor = false;
            this.btnCauta1.Click += new System.EventHandler(this.button2_Click);
            // 
            // VFiltrareAnimaleMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2003, 967);
            this.Controls.Add(this.btnCauta1);
            this.Controls.Add(this.btnCauta2);
            this.Controls.Add(this.txtTratamentF);
            this.Controls.Add(this.txtDiagnosticF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnInapoi);
            this.Name = "VFiltrareAnimaleMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VFiltrareAnimaleMedic";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ComboBox txtTratamentF;
        private System.Windows.Forms.ComboBox txtDiagnosticF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCauta2;
        private System.Windows.Forms.Button btnCauta1;
    }
}