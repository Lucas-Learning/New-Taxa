namespace New_Taxa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.name_Location = new System.Windows.Forms.TextBox();
            this.destination_Location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_Location
            // 
            this.name_Location.Location = new System.Drawing.Point(12, 49);
            this.name_Location.Name = "name_Location";
            this.name_Location.Size = new System.Drawing.Size(100, 26);
            this.name_Location.TabIndex = 1;
            // 
            // destination_Location
            // 
            this.destination_Location.Location = new System.Drawing.Point(118, 49);
            this.destination_Location.Name = "destination_Location";
            this.destination_Location.Size = new System.Drawing.Size(100, 26);
            this.destination_Location.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Get Distance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lokation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.destination_Location);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_Location);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_Location;
        private System.Windows.Forms.TextBox destination_Location;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
