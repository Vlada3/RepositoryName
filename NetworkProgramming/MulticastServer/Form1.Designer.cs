﻿namespace MulticastServer
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
            this.richTextBoxServer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxServer
            // 
            this.richTextBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxServer.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxServer.Name = "richTextBoxServer";
            this.richTextBoxServer.Size = new System.Drawing.Size(410, 449);
            this.richTextBoxServer.TabIndex = 0;
            this.richTextBoxServer.Text = "";
            this.richTextBoxServer.TextChanged += new System.EventHandler(this.richTextBoxServer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 449);
            this.Controls.Add(this.richTextBoxServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxServer;
    }
}

