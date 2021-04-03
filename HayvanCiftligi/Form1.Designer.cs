namespace HayvanCiftligi
{
    partial class AnaMenuForm
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
            this.AnaTablo = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // AnaTablo
            // 
            this.AnaTablo.BackColor = System.Drawing.SystemColors.Info;
            this.AnaTablo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.AnaTablo.ColumnCount = 2;
            this.AnaTablo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnaTablo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnaTablo.Location = new System.Drawing.Point(-1, -2);
            this.AnaTablo.Name = "AnaTablo";
            this.AnaTablo.RowCount = 2;
            this.AnaTablo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnaTablo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnaTablo.Size = new System.Drawing.Size(865, 448);
            this.AnaTablo.TabIndex = 0;
            this.AnaTablo.Paint += new System.Windows.Forms.PaintEventHandler(this.AnaTablo_Paint);
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 443);
            this.Controls.Add(this.AnaTablo);
            this.Name = "AnaMenuForm";
            this.Text = "AnaMenuForm";
            this.Load += new System.EventHandler(this.AnaMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AnaTablo;
    }
}

