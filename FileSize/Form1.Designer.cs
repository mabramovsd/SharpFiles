namespace FileSize
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OneLineButton = new System.Windows.Forms.Button();
            this.MultiLineButton = new System.Windows.Forms.Button();
            this.PictureSizeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MultiLineTextBox = new System.Windows.Forms.TextBox();
            this.OneLineTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CopyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OneLineButton
            // 
            this.OneLineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneLineButton.Location = new System.Drawing.Point(5, 5);
            this.OneLineButton.Margin = new System.Windows.Forms.Padding(5);
            this.OneLineButton.Name = "OneLineButton";
            this.OneLineButton.Size = new System.Drawing.Size(217, 50);
            this.OneLineButton.TabIndex = 0;
            this.OneLineButton.Text = "Построчно";
            this.OneLineButton.UseVisualStyleBackColor = true;
            this.OneLineButton.Click += new System.EventHandler(this.OneLineButton_Click);
            // 
            // MultiLineButton
            // 
            this.MultiLineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiLineButton.Location = new System.Drawing.Point(232, 5);
            this.MultiLineButton.Margin = new System.Windows.Forms.Padding(5);
            this.MultiLineButton.Name = "MultiLineButton";
            this.MultiLineButton.Size = new System.Drawing.Size(217, 50);
            this.MultiLineButton.TabIndex = 1;
            this.MultiLineButton.Text = "Кучкой";
            this.MultiLineButton.UseVisualStyleBackColor = true;
            this.MultiLineButton.Click += new System.EventHandler(this.MultiLineButton_Click);
            // 
            // PictureSizeButton
            // 
            this.PictureSizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureSizeButton.Location = new System.Drawing.Point(686, 5);
            this.PictureSizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.PictureSizeButton.Name = "PictureSizeButton";
            this.PictureSizeButton.Size = new System.Drawing.Size(218, 50);
            this.PictureSizeButton.TabIndex = 2;
            this.PictureSizeButton.Text = "Размер картинок";
            this.PictureSizeButton.UseVisualStyleBackColor = true;
            this.PictureSizeButton.Click += new System.EventHandler(this.PictureSizeButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.OneLineButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureSizeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MultiLineButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MultiLineTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.OneLineTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CopyButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 241);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MultiLineTextBox
            // 
            this.MultiLineTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiLineTextBox.Location = new System.Drawing.Point(230, 63);
            this.MultiLineTextBox.Multiline = true;
            this.MultiLineTextBox.Name = "MultiLineTextBox";
            this.MultiLineTextBox.Size = new System.Drawing.Size(221, 175);
            this.MultiLineTextBox.TabIndex = 3;
            // 
            // OneLineTextBox
            // 
            this.OneLineTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneLineTextBox.Location = new System.Drawing.Point(3, 63);
            this.OneLineTextBox.Multiline = true;
            this.OneLineTextBox.Name = "OneLineTextBox";
            this.OneLineTextBox.Size = new System.Drawing.Size(221, 175);
            this.OneLineTextBox.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(684, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(222, 175);
            this.progressBar1.TabIndex = 5;
            // 
            // CopyButton
            // 
            this.CopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyButton.Location = new System.Drawing.Point(457, 3);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(221, 54);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "Копировать";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Файлы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OneLineButton;
        private System.Windows.Forms.Button MultiLineButton;
        private System.Windows.Forms.Button PictureSizeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox MultiLineTextBox;
        private System.Windows.Forms.TextBox OneLineTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CopyButton;
    }
}

