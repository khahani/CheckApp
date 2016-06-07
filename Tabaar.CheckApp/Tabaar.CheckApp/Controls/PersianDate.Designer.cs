namespace Tabaar.CheckApp.Controls
{
    partial class PersianDate
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
            this.Year = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(0, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(48, 22);
            this.Year.TabIndex = 0;
            // 
            // Month
            // 
            this.Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Month.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(60, 0);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(35, 22);
            this.Month.TabIndex = 2;
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(109, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(35, 22);
            this.Day.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(98, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersianDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Year);
            this.Name = "PersianDate";
            this.Size = new System.Drawing.Size(151, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}
