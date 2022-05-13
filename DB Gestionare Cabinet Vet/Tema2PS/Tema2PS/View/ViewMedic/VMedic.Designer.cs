
namespace Tema2PS.View.ViewMedic
{
    partial class VMedic
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnGestProgram = new System.Windows.Forms.Button();
            this.btnFiltrareAnimale = new System.Windows.Forms.Button();
            this.btnGestFise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(890, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGestProgram
            // 
            this.btnGestProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestProgram.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGestProgram.Location = new System.Drawing.Point(37, 432);
            this.btnGestProgram.Name = "btnGestProgram";
            this.btnGestProgram.Size = new System.Drawing.Size(779, 113);
            this.btnGestProgram.TabIndex = 6;
            this.btnGestProgram.Text = "Gestionare Program";
            this.btnGestProgram.UseVisualStyleBackColor = false;
            this.btnGestProgram.Click += new System.EventHandler(this.btnGestProgram_Click);
            // 
            // btnFiltrareAnimale
            // 
            this.btnFiltrareAnimale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrareAnimale.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltrareAnimale.Location = new System.Drawing.Point(37, 260);
            this.btnFiltrareAnimale.Name = "btnFiltrareAnimale";
            this.btnFiltrareAnimale.Size = new System.Drawing.Size(779, 110);
            this.btnFiltrareAnimale.TabIndex = 5;
            this.btnFiltrareAnimale.Text = "Filtrare Animale";
            this.btnFiltrareAnimale.UseVisualStyleBackColor = false;
            this.btnFiltrareAnimale.Click += new System.EventHandler(this.btnFiltrareAnimale_Click);
            // 
            // btnGestFise
            // 
            this.btnGestFise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestFise.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGestFise.Location = new System.Drawing.Point(37, 95);
            this.btnGestFise.Name = "btnGestFise";
            this.btnGestFise.Size = new System.Drawing.Size(779, 110);
            this.btnGestFise.TabIndex = 4;
            this.btnGestFise.Text = "Gestionare Fise Medicale";
            this.btnGestFise.UseVisualStyleBackColor = false;
            this.btnGestFise.Click += new System.EventHandler(this.btnGestFise_Click);
            // 
            // VMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1102, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGestProgram);
            this.Controls.Add(this.btnFiltrareAnimale);
            this.Controls.Add(this.btnGestFise);
            this.Name = "VMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VMedic";
            this.Load += new System.EventHandler(this.VMedic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGestProgram;
        private System.Windows.Forms.Button btnFiltrareAnimale;
        private System.Windows.Forms.Button btnGestFise;
    }
}