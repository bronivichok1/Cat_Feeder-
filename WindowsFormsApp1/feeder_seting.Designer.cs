﻿
namespace WindowsFormsApp1
{
    partial class feeder_seting
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "create a label";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "create Schedule";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "manual control";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(307, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Choosing the type of feed";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Condition monitoring";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(307, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 65);
            this.button6.TabIndex = 5;
            this.button6.Text = "Selecting a ready-made schedule";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(307, 358);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "Choosing the type of feeder";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // feeder_seting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "feeder_seting";
            this.Text = "feeder_seting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}