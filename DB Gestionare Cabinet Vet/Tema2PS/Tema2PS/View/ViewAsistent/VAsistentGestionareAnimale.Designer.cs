
namespace Tema2PS.View.ViewAsistent
{
    partial class VAsistentGestionareAnimale
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
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnCautareAnimal = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnCreare = new System.Windows.Forms.Button();
            this.txtCIPAnimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCautareAnimal = new System.Windows.Forms.TextBox();
            this.dgvAnimale2 = new System.Windows.Forms.DataGridView();
            this.dgvAnimale = new System.Windows.Forms.DataGridView();
            this.txtSpecieAnimal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimale)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVizualizare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVizualizare.Location = new System.Drawing.Point(28, 647);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(561, 92);
            this.btnVizualizare.TabIndex = 36;
            this.btnVizualizare.Text = "Vizualizare";
            this.btnVizualizare.UseVisualStyleBackColor = false;
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnActualizare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizare.Location = new System.Drawing.Point(28, 382);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(561, 96);
            this.btnActualizare.TabIndex = 35;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            // 
            // btnCautareAnimal
            // 
            this.btnCautareAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCautareAnimal.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCautareAnimal.Location = new System.Drawing.Point(944, 399);
            this.btnCautareAnimal.Name = "btnCautareAnimal";
            this.btnCautareAnimal.Size = new System.Drawing.Size(246, 96);
            this.btnCautareAnimal.TabIndex = 34;
            this.btnCautareAnimal.Text = "Cautare";
            this.btnCautareAnimal.UseVisualStyleBackColor = false;
            this.btnCautareAnimal.Click += new System.EventHandler(this.btnCitire_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStergere.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergere.Location = new System.Drawing.Point(28, 515);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(561, 96);
            this.btnStergere.TabIndex = 33;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnCreare
            // 
            this.btnCreare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreare.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreare.Location = new System.Drawing.Point(28, 253);
            this.btnCreare.Name = "btnCreare";
            this.btnCreare.Size = new System.Drawing.Size(561, 96);
            this.btnCreare.TabIndex = 32;
            this.btnCreare.Text = "Creare";
            this.btnCreare.UseVisualStyleBackColor = false;
            // 
            // txtCIPAnimal
            // 
            this.txtCIPAnimal.Location = new System.Drawing.Point(259, 84);
            this.txtCIPAnimal.Name = "txtCIPAnimal";
            this.txtCIPAnimal.Size = new System.Drawing.Size(330, 31);
            this.txtCIPAnimal.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "Specie: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "CIP:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1039, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 26;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCautareAnimal
            // 
            this.txtCautareAnimal.Location = new System.Drawing.Point(629, 437);
            this.txtCautareAnimal.Name = "txtCautareAnimal";
            this.txtCautareAnimal.Size = new System.Drawing.Size(277, 31);
            this.txtCautareAnimal.TabIndex = 37;
            // 
            // dgvAnimale2
            // 
            this.dgvAnimale2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimale2.Location = new System.Drawing.Point(629, 515);
            this.dgvAnimale2.Name = "dgvAnimale2";
            this.dgvAnimale2.RowHeadersWidth = 82;
            this.dgvAnimale2.RowTemplate.Height = 33;
            this.dgvAnimale2.Size = new System.Drawing.Size(561, 224);
            this.dgvAnimale2.TabIndex = 38;
            // 
            // dgvAnimale
            // 
            this.dgvAnimale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimale.Location = new System.Drawing.Point(629, 78);
            this.dgvAnimale.Name = "dgvAnimale";
            this.dgvAnimale.RowHeadersWidth = 82;
            this.dgvAnimale.RowTemplate.Height = 33;
            this.dgvAnimale.Size = new System.Drawing.Size(561, 290);
            this.dgvAnimale.TabIndex = 39;
            this.dgvAnimale.DoubleClick += new System.EventHandler(this.dgvAnimale_DoubleClick);
            // 
            // txtSpecieAnimal
            // 
            this.txtSpecieAnimal.FormattingEnabled = true;
            this.txtSpecieAnimal.Items.AddRange(new object[] {
            "felina",
            "canin",
            "rozatoare",
            "pasare",
            "peste",
            "reptila",
            "paianjen"});
            this.txtSpecieAnimal.Location = new System.Drawing.Point(259, 159);
            this.txtSpecieAnimal.Name = "txtSpecieAnimal";
            this.txtSpecieAnimal.Size = new System.Drawing.Size(330, 33);
            this.txtSpecieAnimal.TabIndex = 40;
            // 
            // VAsistentGestionareAnimale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1212, 780);
            this.Controls.Add(this.txtSpecieAnimal);
            this.Controls.Add(this.dgvAnimale);
            this.Controls.Add(this.dgvAnimale2);
            this.Controls.Add(this.txtCautareAnimal);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnCautareAnimal);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnCreare);
            this.Controls.Add(this.txtCIPAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "VAsistentGestionareAnimale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAsistentGestionareAnimale";
            this.Load += new System.EventHandler(this.VAsistentGestionareAnimale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVizualizare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnCautareAnimal;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnCreare;
        private System.Windows.Forms.TextBox txtCIPAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCautareAnimal;
        private System.Windows.Forms.DataGridView dgvAnimale2;
        private System.Windows.Forms.DataGridView dgvAnimale;
        private System.Windows.Forms.ComboBox txtSpecieAnimal;
    }
}