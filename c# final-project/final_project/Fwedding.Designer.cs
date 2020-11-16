namespace final_project
{
    partial class Fwedding
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbchatan = new System.Windows.Forms.TextBox();
            this.tbkalla = new System.Windows.Forms.TextBox();
            this.tbgift = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(295, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "חתן";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(295, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "כלה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(295, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "מתנה";
            // 
            // tbchatan
            // 
            this.tbchatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbchatan.Location = new System.Drawing.Point(128, 368);
            this.tbchatan.Name = "tbchatan";
            this.tbchatan.Size = new System.Drawing.Size(148, 26);
            this.tbchatan.TabIndex = 18;
            this.tbchatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbkalla
            // 
            this.tbkalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbkalla.Location = new System.Drawing.Point(128, 416);
            this.tbkalla.Name = "tbkalla";
            this.tbkalla.Size = new System.Drawing.Size(148, 26);
            this.tbkalla.TabIndex = 19;
            this.tbkalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbgift
            // 
            this.tbgift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbgift.Location = new System.Drawing.Point(128, 463);
            this.tbgift.Name = "tbgift";
            this.tbgift.Size = new System.Drawing.Size(148, 26);
            this.tbgift.TabIndex = 20;
            this.tbgift.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fwedding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.tbgift);
            this.Controls.Add(this.tbkalla);
            this.Controls.Add(this.tbchatan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Fwedding";
            this.Text = "Fwedding";
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbchatan, 0);
            this.Controls.SetChildIndex(this.tbkalla, 0);
            this.Controls.SetChildIndex(this.tbgift, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbchatan;
        private System.Windows.Forms.TextBox tbkalla;
        private System.Windows.Forms.TextBox tbgift;
    }
}