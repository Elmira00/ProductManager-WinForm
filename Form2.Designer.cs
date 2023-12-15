namespace ProductManager_WinForm
{
    partial class Form2
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
            this.productListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // productListbox
            // 
            this.productListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(159)))), ((int)(((byte)(254)))));
            this.productListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.productListbox.FormattingEnabled = true;
            this.productListbox.HorizontalScrollbar = true;
            this.productListbox.ItemHeight = 31;
            this.productListbox.Location = new System.Drawing.Point(49, 35);
            this.productListbox.Name = "productListbox";
            this.productListbox.ScrollAlwaysVisible = true;
            this.productListbox.Size = new System.Drawing.Size(522, 376);
            this.productListbox.TabIndex = 0;
            this.productListbox.SelectedIndexChanged += new System.EventHandler(this.productListbox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(630, 454);
            this.Controls.Add(this.productListbox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productListbox;
    }
}