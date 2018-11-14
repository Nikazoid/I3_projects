namespace Zad2
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
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.List3 = new System.Windows.Forms.ListBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.ItemHeight = 16;
            this.List1.Location = new System.Drawing.Point(554, 36);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(154, 452);
            this.List1.TabIndex = 0;
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.ItemHeight = 16;
            this.List2.Location = new System.Drawing.Point(735, 36);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(178, 388);
            this.List2.TabIndex = 1;
            // 
            // List3
            // 
            this.List3.FormattingEnabled = true;
            this.List3.ItemHeight = 16;
            this.List3.Location = new System.Drawing.Point(955, 36);
            this.List3.Name = "List3";
            this.List3.Size = new System.Drawing.Size(170, 388);
            this.List3.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(100, 470);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(267, 470);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(12, 27);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(506, 397);
            this.Text1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Unique";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

