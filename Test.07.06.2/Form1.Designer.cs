namespace Test._07._06._2
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.TerminateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(92, 203);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(170, 37);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.TabStop = false;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(347, 203);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(428, 36);
            this.progressBar.Step = 100;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLbl.Location = new System.Drawing.Point(461, 133);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(172, 43);
            this.ProgressLbl.TabIndex = 2;
            this.ProgressLbl.Text = "0%";
            this.ProgressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TerminateBtn
            // 
            this.TerminateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.TerminateBtn.Location = new System.Drawing.Point(304, 332);
            this.TerminateBtn.Name = "TerminateBtn";
            this.TerminateBtn.Size = new System.Drawing.Size(231, 47);
            this.TerminateBtn.TabIndex = 3;
            this.TerminateBtn.Text = "Terminate";
            this.TerminateBtn.UseVisualStyleBackColor = true;
            this.TerminateBtn.Click += new System.EventHandler(this.TerminateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TerminateBtn);
            this.Controls.Add(this.ProgressLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ProgressLbl;
        private System.Windows.Forms.Button TerminateBtn;
    }
}

