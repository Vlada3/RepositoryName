﻿namespace MulticastClient
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
            this.richTextBoxClient = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxClient
            // 
            this.richTextBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxClient.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxClient.Name = "richTextBoxClient";
            this.richTextBoxClient.Size = new System.Drawing.Size(392, 477);
            this.richTextBoxClient.TabIndex = 1;
            this.richTextBoxClient.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 477);
            this.Controls.Add(this.richTextBoxClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxClient;
    }
}

