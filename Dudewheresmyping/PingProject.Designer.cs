namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.tmPing = new System.Windows.Forms.Timer(this.components);
            this.cbEnablePing = new System.Windows.Forms.CheckBox();
            this.lstIPAddress = new System.Windows.Forms.ListView();
            this.IPAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIPAddress = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmPing
            // 
            this.tmPing.Interval = 1000;
            this.tmPing.Tick += new System.EventHandler(this.tmPing_Tick);
            // 
            // cbEnablePing
            // 
            this.cbEnablePing.AutoSize = true;
            this.cbEnablePing.Location = new System.Drawing.Point(12, 14);
            this.cbEnablePing.Name = "cbEnablePing";
            this.cbEnablePing.Size = new System.Drawing.Size(83, 17);
            this.cbEnablePing.TabIndex = 4;
            this.cbEnablePing.Text = "Enable Ping";
            this.cbEnablePing.UseVisualStyleBackColor = true;
            this.cbEnablePing.CheckedChanged += new System.EventHandler(this.cbEnablePing_CheckedChanged);
            // 
            // lstIPAddress
            // 
            this.lstIPAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPAddr,
            this.Status});
            this.lstIPAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIPAddress.GridLines = true;
            this.lstIPAddress.HideSelection = false;
            this.lstIPAddress.Location = new System.Drawing.Point(0, 59);
            this.lstIPAddress.Name = "lstIPAddress";
            this.lstIPAddress.Size = new System.Drawing.Size(871, 372);
            this.lstIPAddress.TabIndex = 5;
            this.lstIPAddress.UseCompatibleStateImageBehavior = false;
            this.lstIPAddress.View = System.Windows.Forms.View.Details;
            // 
            // IPAddr
            // 
            this.IPAddr.Text = "IP Address";
            this.IPAddr.Width = 157;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 736;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIPAddress);
            this.panel1.Controls.Add(this.cbEnablePing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 59);
            this.panel1.TabIndex = 6;
            // 
            // btnIPAddress
            // 
            this.btnIPAddress.Location = new System.Drawing.Point(101, 14);
            this.btnIPAddress.Name = "btnIPAddress";
            this.btnIPAddress.Size = new System.Drawing.Size(140, 23);
            this.btnIPAddress.TabIndex = 5;
            this.btnIPAddress.Text = "Add IP Address...";
            this.btnIPAddress.UseVisualStyleBackColor = true;
            this.btnIPAddress.Click += new System.EventHandler(this.btnIPAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 431);
            this.Controls.Add(this.lstIPAddress);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dude, Wheres my Ping?!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmPing;
        private System.Windows.Forms.CheckBox cbEnablePing;
        private System.Windows.Forms.ListView lstIPAddress;
        private System.Windows.Forms.ColumnHeader IPAddr;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIPAddress;
    }
}

