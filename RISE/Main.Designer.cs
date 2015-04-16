namespace RISE
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.log_textbox = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.serial_port_select = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_selectedport = new System.Windows.Forms.Label();
            this.tickets_low = new System.Windows.Forms.CheckBox();
            this.tickets_medium = new System.Windows.Forms.CheckBox();
            this.tickets_high = new System.Windows.Forms.CheckBox();
            this.tickets_critical = new System.Windows.Forms.CheckBox();
            this.endpoint = new System.Windows.Forms.TextBox();
            this.label_endpoint = new System.Windows.Forms.Label();
            this.labelWhich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_textbox
            // 
            this.log_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_textbox.Location = new System.Drawing.Point(12, 111);
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log_textbox.Size = new System.Drawing.Size(435, 142);
            this.log_textbox.TabIndex = 0;
            this.log_textbox.Text = "";
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button.Location = new System.Drawing.Point(372, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 21);
            this.button.TabIndex = 1;
            this.button.Text = "Enable";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // serial_port_select
            // 
            this.serial_port_select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serial_port_select.FormattingEnabled = true;
            this.serial_port_select.Location = new System.Drawing.Point(102, 12);
            this.serial_port_select.Name = "serial_port_select";
            this.serial_port_select.Size = new System.Drawing.Size(264, 21);
            this.serial_port_select.TabIndex = 2;
            this.serial_port_select.SelectedIndexChanged += new System.EventHandler(this.serial_port_select_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_selectedport
            // 
            this.label_selectedport.AutoSize = true;
            this.label_selectedport.Location = new System.Drawing.Point(25, 16);
            this.label_selectedport.Name = "label_selectedport";
            this.label_selectedport.Size = new System.Drawing.Size(71, 13);
            this.label_selectedport.TabIndex = 3;
            this.label_selectedport.Text = "Selected Port";
            // 
            // tickets_low
            // 
            this.tickets_low.AutoSize = true;
            this.tickets_low.Location = new System.Drawing.Point(102, 65);
            this.tickets_low.Name = "tickets_low";
            this.tickets_low.Size = new System.Drawing.Size(84, 17);
            this.tickets_low.TabIndex = 4;
            this.tickets_low.Text = "Low Tickets";
            this.tickets_low.UseVisualStyleBackColor = true;
            // 
            // tickets_medium
            // 
            this.tickets_medium.AutoSize = true;
            this.tickets_medium.Location = new System.Drawing.Point(227, 66);
            this.tickets_medium.Name = "tickets_medium";
            this.tickets_medium.Size = new System.Drawing.Size(101, 17);
            this.tickets_medium.TabIndex = 5;
            this.tickets_medium.Text = "Medium Tickets";
            this.tickets_medium.UseVisualStyleBackColor = true;
            // 
            // tickets_high
            // 
            this.tickets_high.AutoSize = true;
            this.tickets_high.Checked = true;
            this.tickets_high.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tickets_high.Location = new System.Drawing.Point(102, 88);
            this.tickets_high.Name = "tickets_high";
            this.tickets_high.Size = new System.Drawing.Size(86, 17);
            this.tickets_high.TabIndex = 6;
            this.tickets_high.Text = "High Tickets";
            this.tickets_high.UseVisualStyleBackColor = true;
            // 
            // tickets_critical
            // 
            this.tickets_critical.AutoSize = true;
            this.tickets_critical.Checked = true;
            this.tickets_critical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tickets_critical.Location = new System.Drawing.Point(227, 88);
            this.tickets_critical.Name = "tickets_critical";
            this.tickets_critical.Size = new System.Drawing.Size(95, 17);
            this.tickets_critical.TabIndex = 7;
            this.tickets_critical.Text = "Critical Tickets";
            this.tickets_critical.UseVisualStyleBackColor = true;
            // 
            // endpoint
            // 
            this.endpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endpoint.Location = new System.Drawing.Point(102, 39);
            this.endpoint.Name = "endpoint";
            this.endpoint.Size = new System.Drawing.Size(345, 20);
            this.endpoint.TabIndex = 8;
            // 
            // label_endpoint
            // 
            this.label_endpoint.AutoSize = true;
            this.label_endpoint.Location = new System.Drawing.Point(18, 42);
            this.label_endpoint.Name = "label_endpoint";
            this.label_endpoint.Size = new System.Drawing.Size(78, 13);
            this.label_endpoint.TabIndex = 9;
            this.label_endpoint.Text = "End Point URL";
            // 
            // labelWhich
            // 
            this.labelWhich.AutoSize = true;
            this.labelWhich.Location = new System.Drawing.Point(14, 66);
            this.labelWhich.Name = "labelWhich";
            this.labelWhich.Size = new System.Drawing.Size(82, 13);
            this.labelWhich.TabIndex = 10;
            this.labelWhich.Text = "Which Tickets?";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 265);
            this.Controls.Add(this.labelWhich);
            this.Controls.Add(this.label_endpoint);
            this.Controls.Add(this.endpoint);
            this.Controls.Add(this.tickets_critical);
            this.Controls.Add(this.tickets_high);
            this.Controls.Add(this.tickets_medium);
            this.Controls.Add(this.tickets_low);
            this.Controls.Add(this.label_selectedport);
            this.Controls.Add(this.serial_port_select);
            this.Controls.Add(this.button);
            this.Controls.Add(this.log_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "RISE - Team C";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox log_textbox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox serial_port_select;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_selectedport;
        private System.Windows.Forms.CheckBox tickets_low;
        private System.Windows.Forms.CheckBox tickets_medium;
        private System.Windows.Forms.CheckBox tickets_high;
        private System.Windows.Forms.CheckBox tickets_critical;
        private System.Windows.Forms.TextBox endpoint;
        private System.Windows.Forms.Label label_endpoint;
        private System.Windows.Forms.Label labelWhich;
    }
}

