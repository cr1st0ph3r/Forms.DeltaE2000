namespace Forms.DeltaE2000
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnColor1 = new System.Windows.Forms.Panel();
            this.pnColor2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnColor1
            // 
            this.pnColor1.Location = new System.Drawing.Point(12, 12);
            this.pnColor1.Name = "pnColor1";
            this.pnColor1.Size = new System.Drawing.Size(160, 160);
            this.pnColor1.TabIndex = 0;
            // 
            // pnColor2
            // 
            this.pnColor2.Location = new System.Drawing.Point(178, 12);
            this.pnColor2.Name = "pnColor2";
            this.pnColor2.Size = new System.Drawing.Size(160, 160);
            this.pnColor2.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 178);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(326, 23);
            this.txtResult.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 208);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.pnColor2);
            this.Controls.Add(this.pnColor1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnColor1;
        private Panel pnColor2;
        private TextBox txtResult;
    }
}