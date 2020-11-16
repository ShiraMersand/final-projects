namespace final_project
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddEvent = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.weddingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthdayPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayofmonth
            // 
            this.dayofmonth.BackColor = System.Drawing.Color.Transparent;
            this.dayofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dayofmonth.ForeColor = System.Drawing.Color.White;
            this.dayofmonth.Location = new System.Drawing.Point(-5, 0);
            this.dayofmonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(193, 38);
            this.dayofmonth.TabIndex = 0;
            this.dayofmonth.Text = "dayofmonth";
            this.dayofmonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 38);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 68);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddEvent
            // 
            this.AddEvent.ActiveLinkColor = System.Drawing.Color.Black;
            this.AddEvent.AutoSize = true;
            this.AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddEvent.LinkColor = System.Drawing.Color.White;
            this.AddEvent.Location = new System.Drawing.Point(25, 110);
            this.AddEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(129, 29);
            this.AddEvent.TabIndex = 2;
            this.AddEvent.TabStop = true;
            this.AddEvent.Text = "הוסף אירוע";
            this.AddEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weddingToolStripMenuItem,
            this.birthdayPartyToolStripMenuItem,
            this.tripToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 82);
            // 
            // weddingToolStripMenuItem
            // 
            this.weddingToolStripMenuItem.Image = global::final_project.Properties.Resources.טבעת__25_;
            this.weddingToolStripMenuItem.Name = "weddingToolStripMenuItem";
            this.weddingToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.weddingToolStripMenuItem.Text = "חתונה";
            this.weddingToolStripMenuItem.Click += new System.EventHandler(this.weddingToolStripMenuItem_Click);
            // 
            // birthdayPartyToolStripMenuItem
            // 
            this.birthdayPartyToolStripMenuItem.Image = global::final_project.Properties.Resources.בלון;
            this.birthdayPartyToolStripMenuItem.Name = "birthdayPartyToolStripMenuItem";
            this.birthdayPartyToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.birthdayPartyToolStripMenuItem.Text = "יום הולדת";
            this.birthdayPartyToolStripMenuItem.Click += new System.EventHandler(this.birthdayPartyToolStripMenuItem_Click);
            // 
            // tripToolStripMenuItem
            // 
            this.tripToolStripMenuItem.Image = global::final_project.Properties.Resources.tropical_beach__Converted_;
            this.tripToolStripMenuItem.Name = "tripToolStripMenuItem";
            this.tripToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.tripToolStripMenuItem.Text = "טיול";
            this.tripToolStripMenuItem.Click += new System.EventHandler(this.tripToolStripMenuItem_Click);
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dayofmonth);
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(170, 139);
            this.Click += new System.EventHandler(this.clicK);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel AddEvent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem weddingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthdayPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripToolStripMenuItem;
    }
}
