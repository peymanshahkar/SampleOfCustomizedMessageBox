namespace MessageBoxSh
{
    partial class CMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMesages = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnYes = new BehComponents.ButtonX();
            this.btnCancel = new BehComponents.ButtonX();
            this.btnNo = new BehComponents.ButtonX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LblMesages);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 121);
            this.panel1.TabIndex = 0;
            // 
            // LblMesages
            // 
            this.LblMesages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMesages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMesages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblMesages.Location = new System.Drawing.Point(0, 0);
            this.LblMesages.Name = "LblMesages";
            this.LblMesages.Size = new System.Drawing.Size(631, 117);
            this.LblMesages.TabIndex = 1;
            this.LblMesages.Text = "ErrorMessage";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 40);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.11787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.88213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Controls.Add(this.btnNo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnYes, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnYes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnYes.HolidayForeColor = System.Drawing.Color.Red;
            this.btnYes.Image = global::MessageBoxSh.Properties.Resources.Ok_icon28;
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnYes.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnYes.IsBolded = false;
            this.btnYes.IsHoliday = false;
            this.btnYes.IsTrailing = false;
            this.btnYes.Location = new System.Drawing.Point(356, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.PushedAlways = false;
            this.btnYes.SecondBorderColor = System.Drawing.Color.Red;
            this.btnYes.SecondBorderDistanceToEdge = 3F;
            this.btnYes.SecondBorderWidth = 3F;
            this.btnYes.ShowFirstBorder = true;
            this.btnYes.ShowSecondBorder = false;
            this.btnYes.Size = new System.Drawing.Size(102, 34);
            this.btnYes.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "بله";
            this.btnYes.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.HolidayForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = global::MessageBoxSh.Properties.Resources.Alarm_Error_icon28;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnCancel.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnCancel.IsBolded = false;
            this.btnCancel.IsHoliday = false;
            this.btnCancel.IsTrailing = false;
            this.btnCancel.Location = new System.Drawing.Point(169, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PushedAlways = false;
            this.btnCancel.SecondBorderColor = System.Drawing.Color.Red;
            this.btnCancel.SecondBorderDistanceToEdge = 3F;
            this.btnCancel.SecondBorderWidth = 3F;
            this.btnCancel.ShowFirstBorder = true;
            this.btnCancel.ShowSecondBorder = false;
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNo
            // 
            this.btnNo.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNo.HolidayForeColor = System.Drawing.Color.Red;
            this.btnNo.Image = global::MessageBoxSh.Properties.Resources.Actions_edit_delete_icon28;
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnNo.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnNo.IsBolded = false;
            this.btnNo.IsHoliday = false;
            this.btnNo.IsTrailing = false;
            this.btnNo.Location = new System.Drawing.Point(266, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.PushedAlways = false;
            this.btnNo.SecondBorderColor = System.Drawing.Color.Red;
            this.btnNo.SecondBorderDistanceToEdge = 3F;
            this.btnNo.SecondBorderWidth = 3F;
            this.btnNo.ShowFirstBorder = true;
            this.btnNo.ShowSecondBorder = false;
            this.btnNo.Size = new System.Drawing.Size(84, 34);
            this.btnNo.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "خیر";
            this.btnNo.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // CMessageBox
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(634, 166);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMessageBox";
            this.Load += new System.EventHandler(this.CMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblMesages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BehComponents.ButtonX btnNo;
        private BehComponents.ButtonX btnYes;
        private BehComponents.ButtonX btnCancel;
    }
}