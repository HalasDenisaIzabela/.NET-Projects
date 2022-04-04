
namespace CabinetVeterinarPS.View
{
    partial class VizualizareMedic
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
            this.btnGestFise = new System.Windows.Forms.Button();
            this.btnFiltrareAnimale = new System.Windows.Forms.Button();
            this.btnGestProgram = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestFise
            // 
            this.btnGestFise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestFise.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGestFise.Location = new System.Drawing.Point(276, 96);
            this.btnGestFise.Name = "btnGestFise";
            this.btnGestFise.Size = new System.Drawing.Size(779, 110);
            this.btnGestFise.TabIndex = 0;
            this.btnGestFise.Text = "Gestionare Fise Medicale";
            this.btnGestFise.UseVisualStyleBackColor = false;
            this.btnGestFise.Click += new System.EventHandler(this.btnGestFise_Click);
            // 
            // btnFiltrareAnimale
            // 
            this.btnFiltrareAnimale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrareAnimale.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltrareAnimale.Location = new System.Drawing.Point(276, 261);
            this.btnFiltrareAnimale.Name = "btnFiltrareAnimale";
            this.btnFiltrareAnimale.Size = new System.Drawing.Size(779, 110);
            this.btnFiltrareAnimale.TabIndex = 1;
            this.btnFiltrareAnimale.Text = "Filtrare Animale";
            this.btnFiltrareAnimale.UseVisualStyleBackColor = false;
            this.btnFiltrareAnimale.Click += new System.EventHandler(this.btnFiltrareAnimale_Click);
            // 
            // btnGestProgram
            // 
            this.btnGestProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestProgram.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGestProgram.Location = new System.Drawing.Point(276, 433);
            this.btnGestProgram.Name = "btnGestProgram";
            this.btnGestProgram.Size = new System.Drawing.Size(779, 113);
            this.btnGestProgram.TabIndex = 2;
            this.btnGestProgram.Text = "Gestionare Program";
            this.btnGestProgram.UseVisualStyleBackColor = false;
            this.btnGestProgram.Click += new System.EventHandler(this.btnGestProgram_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1129, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VizualizareMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1333, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGestProgram);
            this.Controls.Add(this.btnFiltrareAnimale);
            this.Controls.Add(this.btnGestFise);
            this.Name = "VizualizareMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestFise;
        private System.Windows.Forms.Button btnFiltrareAnimale;
        private System.Windows.Forms.Button btnGestProgram;
        private System.Windows.Forms.Button button1;
    }
}