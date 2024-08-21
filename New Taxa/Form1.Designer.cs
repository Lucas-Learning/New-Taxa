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
            this.map_type = new System.Windows.Forms.ComboBox();
            this.name_Location = new System.Windows.Forms.TextBox();
            this.destination_Location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map_type
            // 
            this.map_type.FormattingEnabled = true;
            this.map_type.Items.AddRange(new object[] {
            "m",
            "k",
            "h",
            "p",
            "e"});
            this.map_type.Location = new System.Drawing.Point(13, 13);
            this.map_type.Name = "map_type";
            this.map_type.Size = new System.Drawing.Size(121, 28);
            this.map_type.TabIndex = 0;
            this.map_type.SelectedIndexChanged += new System.EventHandler(this.map_type_SelectedIndexChanged_1);
            // 
            // name_Location
            // 
            this.name_Location.Location = new System.Drawing.Point(141, 13);
            this.name_Location.Name = "name_Location";
            this.name_Location.Size = new System.Drawing.Size(100, 26);
            this.name_Location.TabIndex = 1;
            // 
            // destination_Location
            // 
            this.destination_Location.Location = new System.Drawing.Point(248, 13);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.destination_Location);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_Location);
            this.Controls.Add(this.map_type);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox map_type;
        private System.Windows.Forms.TextBox name_Location;
        private System.Windows.Forms.TextBox destination_Location;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
