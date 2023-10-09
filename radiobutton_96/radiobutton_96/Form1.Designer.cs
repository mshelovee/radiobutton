namespace radiobutton_96
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
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.rbSari = new System.Windows.Forms.RadioButton();
            this.rbYesil = new System.Windows.Forms.RadioButton();
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.btnRenk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMavi.Location = new System.Drawing.Point(12, 35);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(54, 20);
            this.rbMavi.TabIndex = 0;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "Mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            // 
            // rbSari
            // 
            this.rbSari.AutoSize = true;
            this.rbSari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSari.Location = new System.Drawing.Point(12, 78);
            this.rbSari.Name = "rbSari";
            this.rbSari.Size = new System.Drawing.Size(49, 20);
            this.rbSari.TabIndex = 1;
            this.rbSari.TabStop = true;
            this.rbSari.Text = "Sarı";
            this.rbSari.UseVisualStyleBackColor = true;
            // 
            // rbYesil
            // 
            this.rbYesil.AutoSize = true;
            this.rbYesil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYesil.Location = new System.Drawing.Point(12, 178);
            this.rbYesil.Name = "rbYesil";
            this.rbYesil.Size = new System.Drawing.Size(55, 20);
            this.rbYesil.TabIndex = 3;
            this.rbYesil.TabStop = true;
            this.rbYesil.Text = "Yeşil";
            this.rbYesil.UseVisualStyleBackColor = true;
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKirmizi.Location = new System.Drawing.Point(12, 125);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(63, 20);
            this.rbKirmizi.TabIndex = 2;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "Kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            // 
            // btnRenk
            // 
            this.btnRenk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenk.Location = new System.Drawing.Point(36, 252);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(195, 45);
            this.btnRenk.TabIndex = 4;
            this.btnRenk.Text = "Değiştir";
            this.btnRenk.UseVisualStyleBackColor = false;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 328);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.rbYesil);
            this.Controls.Add(this.rbKirmizi);
            this.Controls.Add(this.rbSari);
            this.Controls.Add(this.rbMavi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.RadioButton rbSari;
        private System.Windows.Forms.RadioButton rbYesil;
        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.Button btnRenk;
    }
}

