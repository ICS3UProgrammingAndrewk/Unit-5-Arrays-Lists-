namespace ListsAndrewK
{
    partial class frmlists
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
            this.lblMark = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lstMark = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.BtnCalculator = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(28, 30);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(203, 16);
            this.lblMark.TabIndex = 0;
            this.lblMark.Text = "Enter a mark  between 0 and 100:";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(248, 26);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 1;
            // 
            // lstMark
            // 
            this.lstMark.FormattingEnabled = true;
            this.lstMark.Location = new System.Drawing.Point(51, 118);
            this.lstMark.Name = "lstMark";
            this.lstMark.Size = new System.Drawing.Size(249, 251);
            this.lstMark.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(248, 70);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 32);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // BtnCalculator
            // 
            this.BtnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculator.Location = new System.Drawing.Point(92, 387);
            this.BtnCalculator.Name = "BtnCalculator";
            this.BtnCalculator.Size = new System.Drawing.Size(191, 51);
            this.BtnCalculator.TabIndex = 4;
            this.BtnCalculator.Text = "Calculate Average";
            this.BtnCalculator.UseVisualStyleBackColor = false;
            this.BtnCalculator.Click += new System.EventHandler(this.BtnCalculator_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(48, 459);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(113, 16);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "The average is -1";
            // 
            // frmlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 499);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.BtnCalculator);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lstMark);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblMark);
            this.Name = "frmlists";
            this.Text = "Lists By Andrew K.";
            this.Load += new System.EventHandler(this.frmlists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.ListBox lstMark;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button BtnCalculator;
        private System.Windows.Forms.Label lblAverage;
    }
}

