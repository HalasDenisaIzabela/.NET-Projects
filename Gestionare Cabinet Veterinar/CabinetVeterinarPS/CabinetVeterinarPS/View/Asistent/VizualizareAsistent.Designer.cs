
namespace CabinetVeterinarPS.View
{
    partial class VizualizareAsistent
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
            this.btnGestAnimale = new System.Windows.Forms.Button();
            this.btnFiltAnimale = new System.Windows.Forms.Button();
            this.btnSalvareAnimale = new System.Windows.Forms.Button();
            this.btnPlanifConsult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestAnimale
            // 
            this.btnGestAnimale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestAnimale.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGestAnimale.Location = new System.Drawing.Point(276, 129);
            this.btnGestAnimale.Name = "btnGestAnimale";
            this.btnGestAnimale.Size = new System.Drawing.Size(838, 123);
            this.btnGestAnimale.TabIndex = 0;
            this.btnGestAnimale.Text = "Gestionare Animale";
            this.btnGestAnimale.UseVisualStyleBackColor = false;
            this.btnGestAnimale.Click += new System.EventHandler(this.btnGestAnimale_Click);
            // 
            // btnFiltAnimale
            // 
            this.btnFiltAnimale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltAnimale.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltAnimale.Location = new System.Drawing.Point(276, 297);
            this.btnFiltAnimale.Name = "btnFiltAnimale";
            this.btnFiltAnimale.Size = new System.Drawing.Size(838, 126);
            this.btnFiltAnimale.TabIndex = 1;
            this.btnFiltAnimale.Text = "Filtrare Animale";
            this.btnFiltAnimale.UseVisualStyleBackColor = false;
            this.btnFiltAnimale.Click += new System.EventHandler(this.btnFiltAnimale_Click);
            // 
            // btnSalvareAnimale
            // 
            this.btnSalvareAnimale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalvareAnimale.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvareAnimale.Location = new System.Drawing.Point(276, 628);
            this.btnSalvareAnimale.Name = "btnSalvareAnimale";
            this.btnSalvareAnimale.Size = new System.Drawing.Size(838, 130);
            this.btnSalvareAnimale.TabIndex = 2;
            this.btnSalvareAnimale.Text = "Salvare Liste Animale";
            this.btnSalvareAnimale.UseVisualStyleBackColor = false;
            this.btnSalvareAnimale.Click += new System.EventHandler(this.btnSalvareAnimale_Click);
            // 
            // btnPlanifConsult
            // 
            this.btnPlanifConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlanifConsult.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlanifConsult.Location = new System.Drawing.Point(276, 466);
            this.btnPlanifConsult.Name = "btnPlanifConsult";
            this.btnPlanifConsult.Size = new System.Drawing.Size(838, 124);
            this.btnPlanifConsult.TabIndex = 3;
            this.btnPlanifConsult.Text = "Planificare Consultatii";
            this.btnPlanifConsult.UseVisualStyleBackColor = false;
            this.btnPlanifConsult.Click += new System.EventHandler(this.btnPlanifConsult_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1146, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VizualizareAsistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1362, 888);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlanifConsult);
            this.Controls.Add(this.btnSalvareAnimale);
            this.Controls.Add(this.btnFiltAnimale);
            this.Controls.Add(this.btnGestAnimale);
            this.Name = "VizualizareAsistent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareAsistent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestAnimale;
        private System.Windows.Forms.Button btnFiltAnimale;
        private System.Windows.Forms.Button btnSalvareAnimale;
        private System.Windows.Forms.Button btnPlanifConsult;
        private System.Windows.Forms.Button button1;
    }
}