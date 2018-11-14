namespace ExerciseOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_scanTime = new System.Windows.Forms.Label();
            this.lbl_sortTime = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.lv_raw = new System.Windows.Forms.ListView();
            this.lv_sort = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_scanTime
            // 
            this.lbl_scanTime.AutoSize = true;
            this.lbl_scanTime.Location = new System.Drawing.Point(611, 484);
            this.lbl_scanTime.Name = "lbl_scanTime";
            this.lbl_scanTime.Size = new System.Drawing.Size(53, 13);
            this.lbl_scanTime.TabIndex = 1;
            this.lbl_scanTime.Text = "Raw data";
            // 
            // lbl_sortTime
            // 
            this.lbl_sortTime.AutoSize = true;
            this.lbl_sortTime.Location = new System.Drawing.Point(786, 483);
            this.lbl_sortTime.Name = "lbl_sortTime";
            this.lbl_sortTime.Size = new System.Drawing.Size(64, 13);
            this.lbl_sortTime.TabIndex = 2;
            this.lbl_sortTime.Text = "Sorted Data";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(571, 509);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(139, 23);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "Scanner";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(716, 509);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(139, 23);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // lv_raw
            // 
            this.lv_raw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_raw.Location = new System.Drawing.Point(571, 9);
            this.lv_raw.Name = "lv_raw";
            this.lv_raw.Size = new System.Drawing.Size(121, 471);
            this.lv_raw.TabIndex = 5;
            this.lv_raw.UseCompatibleStateImageBehavior = false;
            this.lv_raw.View = System.Windows.Forms.View.Details;
            // 
            // lv_sort
            // 
            this.lv_sort.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lv_sort.Location = new System.Drawing.Point(734, 9);
            this.lv_sort.Name = "lv_sort";
            this.lv_sort.Size = new System.Drawing.Size(121, 471);
            this.lv_sort.TabIndex = 6;
            this.lv_sort.UseCompatibleStateImageBehavior = false;
            this.lv_sort.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort time: ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(139, 467);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(16, 24);
            this.time.TabIndex = 8;
            this.time.Text = "-";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(23, 9);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(479, 429);
            this.tb_data.TabIndex = 9;
            this.tb_data.Text = resources.GetString("tb_data.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 625);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_sort);
            this.Controls.Add(this.lv_raw);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.lbl_sortTime);
            this.Controls.Add(this.lbl_scanTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_scanTime;
        private System.Windows.Forms.Label lbl_sortTime;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.ListView lv_raw;
        private System.Windows.Forms.ListView lv_sort;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox tb_data;
    }
}

