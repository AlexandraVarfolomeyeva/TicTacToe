﻿namespace TicTacToe
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
            this.BeginAgainBtn = new System.Windows.Forms.Button();
            this.onePlayer = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CrossCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BeginAgainBtn
            // 
            this.BeginAgainBtn.Location = new System.Drawing.Point(608, 8);
            this.BeginAgainBtn.Name = "BeginAgainBtn";
            this.BeginAgainBtn.Size = new System.Drawing.Size(184, 32);
            this.BeginAgainBtn.TabIndex = 0;
            this.BeginAgainBtn.Text = "Начать сначала";
            this.BeginAgainBtn.UseVisualStyleBackColor = true;
            this.BeginAgainBtn.Click += new System.EventHandler(this.BeginAgainBtn_Click);
            // 
            // onePlayer
            // 
            this.onePlayer.AutoSize = true;
            this.onePlayer.Checked = true;
            this.onePlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onePlayer.Location = new System.Drawing.Point(24, 16);
            this.onePlayer.Name = "onePlayer";
            this.onePlayer.Size = new System.Drawing.Size(105, 21);
            this.onePlayer.TabIndex = 1;
            this.onePlayer.Text = "Один игрок";
            this.onePlayer.UseVisualStyleBackColor = true;
            this.onePlayer.CheckedChanged += new System.EventHandler(this.onePlayer_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 216);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // CrossCB
            // 
            this.CrossCB.AutoSize = true;
            this.CrossCB.Checked = true;
            this.CrossCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CrossCB.Location = new System.Drawing.Point(24, 40);
            this.CrossCB.Name = "CrossCB";
            this.CrossCB.Size = new System.Drawing.Size(148, 21);
            this.CrossCB.TabIndex = 3;
            this.CrossCB.Text = "Играть крестиком";
            this.CrossCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrossCB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.onePlayer);
            this.Controls.Add(this.BeginAgainBtn);
            this.Name = "Form1";
            this.Text = "Крестики-нолики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeginAgainBtn;
        private System.Windows.Forms.CheckBox onePlayer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox CrossCB;
    }
}

