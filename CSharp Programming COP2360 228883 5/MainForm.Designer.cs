namespace CSharp_Programming_COP2360_228883_5
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLabel = new System.Windows.Forms.Label();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainLabel.AutoSize = true;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(211, 9);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(178, 25);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Show Examples";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DropDown
            // 
            this.DropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.DropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDown.DropDownHeight = 110;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(221)))), ((int)(((byte)(83)))));
            this.DropDown.FormattingEnabled = true;
            this.DropDown.IntegralHeight = false;
            this.DropDown.ItemHeight = 20;
            this.DropDown.Items.AddRange(new object[] {
            "Book",
            "Magazine",
            "Online"});
            this.DropDown.Location = new System.Drawing.Point(216, 49);
            this.DropDown.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.DropDown.MaxDropDownItems = 3;
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(173, 28);
            this.DropDown.TabIndex = 1;
            this.DropDown.SelectedValueChanged += new System.EventHandler(this.DropDown_SelectedValueChanged);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(34, 109);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(25, 100, 0, 0);
            this.DataLabel.MaximumSize = new System.Drawing.Size(500, 275);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(157, 42);
            this.DataLabel.TabIndex = 2;
            this.DataLabel.Text = "Title: Data Grids\r\nAuthor: Julia Little";
            this.DataLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(221)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.MainLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Reading Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.Label DataLabel;
    }
}

