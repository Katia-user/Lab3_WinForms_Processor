namespace Lab3_WinForms_Processor
{
    partial class fMain
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
            this.tbProcessorsInfo = new System.Windows.Forms.TextBox();
            this.btnAddProcessor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProcessorsInfo
            // 
            this.tbProcessorsInfo.Location = new System.Drawing.Point(12, 12);
            this.tbProcessorsInfo.Multiline = true;
            this.tbProcessorsInfo.Name = "tbProcessorsInfo";
            this.tbProcessorsInfo.ReadOnly = true;
            this.tbProcessorsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProcessorsInfo.Size = new System.Drawing.Size(439, 416);
            this.tbProcessorsInfo.TabIndex = 0;
            // 
            // btnAddProcessor
            // 
            this.btnAddProcessor.Location = new System.Drawing.Point(504, 74);
            this.btnAddProcessor.Name = "btnAddProcessor";
            this.btnAddProcessor.Size = new System.Drawing.Size(155, 50);
            this.btnAddProcessor.TabIndex = 1;
            this.btnAddProcessor.Text = "Додати процесор";
            this.btnAddProcessor.UseVisualStyleBackColor = true;
            this.btnAddProcessor.Click += new System.EventHandler(this.btnAddProcessor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(522, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddProcessor);
            this.Controls.Add(this.tbProcessorsInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProcessorsInfo;
        private System.Windows.Forms.Button btnAddProcessor;
        private System.Windows.Forms.Button btnClose;
    }
}

