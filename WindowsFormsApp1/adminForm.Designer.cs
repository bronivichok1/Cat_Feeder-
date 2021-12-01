
namespace WindowsFormsApp1
{
    partial class adminForm
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
            this.Create_user = new System.Windows.Forms.Button();
            this.add_feeder = new System.Windows.Forms.Button();
            this.check_the_status = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.get_info = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_user
            // 
            this.Create_user.Location = new System.Drawing.Point(292, 62);
            this.Create_user.Name = "Create_user";
            this.Create_user.Size = new System.Drawing.Size(153, 23);
            this.Create_user.TabIndex = 1;
            this.Create_user.Text = "Create user";
            this.Create_user.UseVisualStyleBackColor = true;
            this.Create_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_feeder
            // 
            this.add_feeder.Location = new System.Drawing.Point(292, 118);
            this.add_feeder.Name = "add_feeder";
            this.add_feeder.Size = new System.Drawing.Size(153, 23);
            this.add_feeder.TabIndex = 2;
            this.add_feeder.Text = "add feeder";
            this.add_feeder.UseVisualStyleBackColor = true;
            this.add_feeder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // check_the_status
            // 
            this.check_the_status.Location = new System.Drawing.Point(292, 176);
            this.check_the_status.Name = "check_the_status";
            this.check_the_status.Size = new System.Drawing.Size(153, 23);
            this.check_the_status.TabIndex = 3;
            this.check_the_status.Text = "check the status";
            this.check_the_status.UseVisualStyleBackColor = true;
            this.check_the_status.Click += new System.EventHandler(this.check_the_status_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // get_info
            // 
            this.get_info.Location = new System.Drawing.Point(292, 234);
            this.get_info.Name = "get_info";
            this.get_info.Size = new System.Drawing.Size(153, 26);
            this.get_info.TabIndex = 4;
            this.get_info.Text = "get info";
            this.get_info.UseVisualStyleBackColor = true;
            this.get_info.Click += new System.EventHandler(this.get_info_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.get_info);
            this.Controls.Add(this.check_the_status);
            this.Controls.Add(this.add_feeder);
            this.Controls.Add(this.Create_user);
            this.Name = "adminForm";
            this.Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Create_user;
        private System.Windows.Forms.Button add_feeder;
        private System.Windows.Forms.Button check_the_status;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button get_info;
        private System.Windows.Forms.Button button1;
    }
}