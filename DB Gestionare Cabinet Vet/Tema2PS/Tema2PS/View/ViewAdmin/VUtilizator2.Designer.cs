
namespace Tema2PS.View
{
    partial class VUtilizator2
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnCreare = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.txtRol = new System.Windows.Forms.ComboBox();
            this.dgvUtilizatori2 = new System.Windows.Forms.DataGridView();
            this.txtCautare = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(179, 311);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(432, 31);
            this.txtId.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 42);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1496, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 59);
            this.button1.TabIndex = 27;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVizualizare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVizualizare.Location = new System.Drawing.Point(25, 781);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(586, 123);
            this.btnVizualizare.TabIndex = 26;
            this.btnVizualizare.Text = "Vizualizare";
            this.btnVizualizare.UseVisualStyleBackColor = false;
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActualizare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizare.Location = new System.Drawing.Point(27, 504);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(584, 103);
            this.btnActualizare.TabIndex = 25;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click_1);
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCautare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCautare.Location = new System.Drawing.Point(1448, 440);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(260, 99);
            this.btnCautare.TabIndex = 24;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStergere.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergere.Location = new System.Drawing.Point(27, 643);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(584, 103);
            this.btnStergere.TabIndex = 23;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnCreare
            // 
            this.btnCreare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreare.Location = new System.Drawing.Point(25, 381);
            this.btnCreare.Name = "btnCreare";
            this.btnCreare.Size = new System.Drawing.Size(586, 99);
            this.btnCreare.TabIndex = 22;
            this.btnCreare.Text = "Creare";
            this.btnCreare.UseVisualStyleBackColor = false;
            this.btnCreare.Click += new System.EventHandler(this.btnCreare_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(179, 249);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(432, 31);
            this.txtParola.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(179, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 31);
            this.txtEmail.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "Parola: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rol:";
            // 
            // dgvUtilizatori
            // 
            this.dgvUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatori.Location = new System.Drawing.Point(687, 106);
            this.dgvUtilizatori.Name = "dgvUtilizatori";
            this.dgvUtilizatori.RowHeadersWidth = 82;
            this.dgvUtilizatori.RowTemplate.Height = 33;
            this.dgvUtilizatori.Size = new System.Drawing.Size(1021, 306);
            this.dgvUtilizatori.TabIndex = 30;
            this.dgvUtilizatori.DoubleClick += new System.EventHandler(this.dgvUtilizatori_DoubleClick);
            // 
            // txtRol
            // 
            this.txtRol.FormattingEnabled = true;
            this.txtRol.Items.AddRange(new object[] {
            "admin",
            "asistent",
            "dr"});
            this.txtRol.Location = new System.Drawing.Point(179, 106);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(432, 33);
            this.txtRol.TabIndex = 34;
            // 
            // dgvUtilizatori2
            // 
            this.dgvUtilizatori2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatori2.Location = new System.Drawing.Point(687, 561);
            this.dgvUtilizatori2.Name = "dgvUtilizatori2";
            this.dgvUtilizatori2.RowHeadersWidth = 82;
            this.dgvUtilizatori2.RowTemplate.Height = 33;
            this.dgvUtilizatori2.Size = new System.Drawing.Size(1021, 343);
            this.dgvUtilizatori2.TabIndex = 35;
            // 
            // txtCautare
            // 
            this.txtCautare.FormattingEnabled = true;
            this.txtCautare.Items.AddRange(new object[] {
            "admin",
            "asistent",
            "dr"});
            this.txtCautare.Location = new System.Drawing.Point(687, 479);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(724, 33);
            this.txtCautare.TabIndex = 36;
            // 
            // VUtilizator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1734, 923);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.dgvUtilizatori2);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.dgvUtilizatori);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnCreare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VUtilizator2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VUtilizator2";
            this.Load += new System.EventHandler(this.VUtilizator2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVizualizare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnCreare;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.ComboBox txtRol;
        private System.Windows.Forms.DataGridView dgvUtilizatori2;
        private System.Windows.Forms.ComboBox txtCautare;
    }
}