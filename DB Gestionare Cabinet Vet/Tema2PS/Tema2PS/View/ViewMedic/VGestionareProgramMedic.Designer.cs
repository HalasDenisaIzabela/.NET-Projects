
namespace Tema2PS.View.ViewMedic
{
    partial class VGestionareProgramMedic
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
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOraStart = new System.Windows.Forms.ComboBox();
            this.txtOraStop = new System.Windows.Forms.ComboBox();
            this.btnAdaugareProgram = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.txtIdMed = new System.Windows.Forms.TextBox();
            this.txtRolMed = new System.Windows.Forms.TextBox();
            this.txtEmailMed = new System.Windows.Forms.TextBox();
            this.txtParolaMed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedici
            // 
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Location = new System.Drawing.Point(605, 228);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.RowHeadersWidth = 82;
            this.dgvMedici.RowTemplate.Height = 33;
            this.dgvMedici.Size = new System.Drawing.Size(1367, 456);
            this.dgvMedici.TabIndex = 0;
            this.dgvMedici.DoubleClick += new System.EventHandler(this.dgvMedici_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ora terminare program: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ora incepere program: ";
            // 
            // txtOraStart
            // 
            this.txtOraStart.FormattingEnabled = true;
            this.txtOraStart.Items.AddRange(new object[] {
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
            this.txtOraStart.Location = new System.Drawing.Point(414, 228);
            this.txtOraStart.Name = "txtOraStart";
            this.txtOraStart.Size = new System.Drawing.Size(170, 33);
            this.txtOraStart.TabIndex = 7;
            this.txtOraStart.SelectedIndexChanged += new System.EventHandler(this.txtOraStart_SelectedIndexChanged);
            // 
            // txtOraStop
            // 
            this.txtOraStop.FormattingEnabled = true;
            this.txtOraStop.Items.AddRange(new object[] {
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
            this.txtOraStop.Location = new System.Drawing.Point(414, 332);
            this.txtOraStop.Name = "txtOraStop";
            this.txtOraStop.Size = new System.Drawing.Size(170, 33);
            this.txtOraStop.TabIndex = 8;
            // 
            // btnAdaugareProgram
            // 
            this.btnAdaugareProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdaugareProgram.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugareProgram.Location = new System.Drawing.Point(19, 558);
            this.btnAdaugareProgram.Name = "btnAdaugareProgram";
            this.btnAdaugareProgram.Size = new System.Drawing.Size(565, 126);
            this.btnAdaugareProgram.TabIndex = 9;
            this.btnAdaugareProgram.Text = "Actualizare program";
            this.btnAdaugareProgram.UseVisualStyleBackColor = false;
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(1801, 8);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(171, 53);
            this.btnInapoi.TabIndex = 10;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // txtIdMed
            // 
            this.txtIdMed.Location = new System.Drawing.Point(19, 426);
            this.txtIdMed.Name = "txtIdMed";
            this.txtIdMed.Size = new System.Drawing.Size(100, 31);
            this.txtIdMed.TabIndex = 11;
            this.txtIdMed.Visible = false;
            // 
            // txtRolMed
            // 
            this.txtRolMed.Location = new System.Drawing.Point(151, 426);
            this.txtRolMed.Name = "txtRolMed";
            this.txtRolMed.Size = new System.Drawing.Size(100, 31);
            this.txtRolMed.TabIndex = 12;
            this.txtRolMed.Visible = false;
            // 
            // txtEmailMed
            // 
            this.txtEmailMed.Location = new System.Drawing.Point(301, 426);
            this.txtEmailMed.Name = "txtEmailMed";
            this.txtEmailMed.Size = new System.Drawing.Size(100, 31);
            this.txtEmailMed.TabIndex = 13;
            this.txtEmailMed.Visible = false;
            // 
            // txtParolaMed
            // 
            this.txtParolaMed.Location = new System.Drawing.Point(457, 426);
            this.txtParolaMed.Name = "txtParolaMed";
            this.txtParolaMed.Size = new System.Drawing.Size(94, 31);
            this.txtParolaMed.TabIndex = 14;
            this.txtParolaMed.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(196, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1654, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selectati medicul dorit (dublu click) si modificati orele de lucru. Program valab" +
    "il de Luni pana Duminica";
            // 
            // VGestionareProgramMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1984, 694);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParolaMed);
            this.Controls.Add(this.txtEmailMed);
            this.Controls.Add(this.txtRolMed);
            this.Controls.Add(this.txtIdMed);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnAdaugareProgram);
            this.Controls.Add(this.txtOraStop);
            this.Controls.Add(this.txtOraStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedici);
            this.Name = "VGestionareProgramMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VGestionareProgramMedic";
            this.Load += new System.EventHandler(this.VGestionareProgramMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtOraStart;
        private System.Windows.Forms.ComboBox txtOraStop;
        private System.Windows.Forms.Button btnAdaugareProgram;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.TextBox txtIdMed;
        private System.Windows.Forms.TextBox txtRolMed;
        private System.Windows.Forms.TextBox txtEmailMed;
        private System.Windows.Forms.TextBox txtParolaMed;
        private System.Windows.Forms.Label label2;
    }
}