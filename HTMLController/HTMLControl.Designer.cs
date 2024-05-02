namespace HTMLController
{
    partial class HTMLControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.open = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.read = new System.Windows.Forms.Button();
            this.saveas = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.Location = new System.Drawing.Point(484, 12);
            this.open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(76, 23);
            this.open.TabIndex = 1;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 12);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 272);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(484, 42);
            this.read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(76, 23);
            this.read.TabIndex = 3;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // saveas
            // 
            this.saveas.Location = new System.Drawing.Point(483, 102);
            this.saveas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveas.Name = "saveas";
            this.saveas.Size = new System.Drawing.Size(76, 23);
            this.saveas.TabIndex = 4;
            this.saveas.Text = "save as";
            this.saveas.UseVisualStyleBackColor = true;
            this.saveas.Click += new System.EventHandler(this.saveas_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(484, 72);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // HTMLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.save);
            this.Controls.Add(this.saveas);
            this.Controls.Add(this.read);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.open);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HTMLControl";
            this.Size = new System.Drawing.Size(564, 302);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveas;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
    }
}
