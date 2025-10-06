namespace Lab3_WinForms_Processor
{
    partial class fProcessor
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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.groupBoxGraphics = new System.Windows.Forms.GroupBox();
            this.chbIntegratedGraphics = new System.Windows.Forms.CheckBox();
            this.tbCache = new System.Windows.Forms.TextBox();
            this.lblCache = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbCores = new System.Windows.Forms.TextBox();
            this.lblCores = new System.Windows.Forms.Label();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.tbGeneration = new System.Windows.Forms.TextBox();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxGraphics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.groupBoxGraphics);
            this.groupBoxGeneral.Controls.Add(this.tbCache);
            this.groupBoxGeneral.Controls.Add(this.lblCache);
            this.groupBoxGeneral.Controls.Add(this.tbYear);
            this.groupBoxGeneral.Controls.Add(this.lblYear);
            this.groupBoxGeneral.Controls.Add(this.tbCores);
            this.groupBoxGeneral.Controls.Add(this.lblCores);
            this.groupBoxGeneral.Controls.Add(this.tbFrequency);
            this.groupBoxGeneral.Controls.Add(this.lblFrequency);
            this.groupBoxGeneral.Controls.Add(this.tbGeneration);
            this.groupBoxGeneral.Controls.Add(this.lblGeneration);
            this.groupBoxGeneral.Controls.Add(this.tbModel);
            this.groupBoxGeneral.Controls.Add(this.lblModel);
            this.groupBoxGeneral.Controls.Add(this.tbBrand);
            this.groupBoxGeneral.Controls.Add(this.lblBrand);
            this.groupBoxGeneral.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(455, 426);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Основна інформація";
            // 
            // groupBoxGraphics
            // 
            this.groupBoxGraphics.Controls.Add(this.chbIntegratedGraphics);
            this.groupBoxGraphics.Location = new System.Drawing.Point(17, 320);
            this.groupBoxGraphics.Name = "groupBoxGraphics";
            this.groupBoxGraphics.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGraphics.TabIndex = 14;
            this.groupBoxGraphics.TabStop = false;
            this.groupBoxGraphics.Text = "Графіка";
            // 
            // chbIntegratedGraphics
            // 
            this.chbIntegratedGraphics.AutoSize = true;
            this.chbIntegratedGraphics.Location = new System.Drawing.Point(12, 33);
            this.chbIntegratedGraphics.Name = "chbIntegratedGraphics";
            this.chbIntegratedGraphics.Size = new System.Drawing.Size(185, 20);
            this.chbIntegratedGraphics.TabIndex = 0;
            this.chbIntegratedGraphics.Text = "Має вбудовану графіку";
            this.chbIntegratedGraphics.UseVisualStyleBackColor = true;
            // 
            // tbCache
            // 
            this.tbCache.Location = new System.Drawing.Point(144, 271);
            this.tbCache.Name = "tbCache";
            this.tbCache.Size = new System.Drawing.Size(100, 22);
            this.tbCache.TabIndex = 13;
            // 
            // lblCache
            // 
            this.lblCache.AutoSize = true;
            this.lblCache.Location = new System.Drawing.Point(26, 274);
            this.lblCache.Name = "lblCache";
            this.lblCache.Size = new System.Drawing.Size(63, 16);
            this.lblCache.TabIndex = 12;
            this.lblCache.Text = "Кеш (МБ)";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(144, 228);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 22);
            this.tbYear.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(29, 228);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(83, 16);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Рік випуску";
            // 
            // tbCores
            // 
            this.tbCores.Location = new System.Drawing.Point(144, 186);
            this.tbCores.Name = "tbCores";
            this.tbCores.Size = new System.Drawing.Size(100, 22);
            this.tbCores.TabIndex = 9;
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(25, 186);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(98, 16);
            this.lblCores.TabIndex = 8;
            this.lblCores.Text = "Кількість ядер";
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(144, 149);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(100, 22);
            this.tbFrequency.TabIndex = 7;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(29, 149);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(94, 16);
            this.lblFrequency.TabIndex = 6;
            this.lblFrequency.Text = "Частота (ГГц)";
            // 
            // tbGeneration
            // 
            this.tbGeneration.Location = new System.Drawing.Point(144, 105);
            this.tbGeneration.Name = "tbGeneration";
            this.tbGeneration.Size = new System.Drawing.Size(100, 22);
            this.tbGeneration.TabIndex = 5;
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Location = new System.Drawing.Point(26, 105);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(74, 16);
            this.lblGeneration.TabIndex = 4;
            this.lblGeneration.Text = "Покоління";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(144, 69);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 22);
            this.tbModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(26, 69);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Модель";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(144, 30);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 22);
            this.tbBrand.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(26, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 16);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Бренд";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(532, 73);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(532, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fProcessor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBoxGeneral);
            this.MaximizeBox = false;
            this.Name = "fProcessor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про процесор";
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxGraphics.ResumeLayout(false);
            this.groupBoxGraphics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.TextBox tbGeneration;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.TextBox tbCores;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lblCache;
        private System.Windows.Forms.TextBox tbCache;
        private System.Windows.Forms.GroupBox groupBoxGraphics;
        private System.Windows.Forms.CheckBox chbIntegratedGraphics;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}