namespace ProductManager_WinForm
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
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.priceTxtb = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.descriptionTxtb = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.showListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtb
            // 
            this.nameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.nameTxtb.Location = new System.Drawing.Point(291, 35);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(259, 38);
            this.nameTxtb.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.nameLbl.Location = new System.Drawing.Point(49, 35);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLbl.Size = new System.Drawing.Size(97, 33);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // priceTxtb
            // 
            this.priceTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.priceTxtb.Location = new System.Drawing.Point(291, 222);
            this.priceTxtb.Name = "priceTxtb";
            this.priceTxtb.Size = new System.Drawing.Size(259, 38);
            this.priceTxtb.TabIndex = 0;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.priceLbl.Location = new System.Drawing.Point(49, 229);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLbl.Size = new System.Drawing.Size(87, 33);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Price";
            // 
            // descriptionTxtb
            // 
            this.descriptionTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.descriptionTxtb.Location = new System.Drawing.Point(291, 125);
            this.descriptionTxtb.Name = "descriptionTxtb";
            this.descriptionTxtb.Size = new System.Drawing.Size(259, 38);
            this.descriptionTxtb.TabIndex = 0;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.descriptionLbl.Location = new System.Drawing.Point(49, 132);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionLbl.Size = new System.Drawing.Size(173, 33);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "Description";
            // 
            // addbtn
            // 
            this.addbtn.AutoSize = true;
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.addbtn.Location = new System.Drawing.Point(55, 349);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(121, 43);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSize = true;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.updateBtn.Location = new System.Drawing.Point(220, 349);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(124, 43);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // showListBtn
            // 
            this.showListBtn.AutoSize = true;
            this.showListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.showListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.showListBtn.Location = new System.Drawing.Point(390, 349);
            this.showListBtn.Name = "showListBtn";
            this.showListBtn.Size = new System.Drawing.Size(160, 43);
            this.showListBtn.TabIndex = 2;
            this.showListBtn.Text = "Show List";
            this.showListBtn.UseVisualStyleBackColor = false;
            this.showListBtn.Click += new System.EventHandler(this.showListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(630, 454);
            this.Controls.Add(this.showListBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.descriptionTxtb);
            this.Controls.Add(this.priceTxtb);
            this.Controls.Add(this.nameTxtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox priceTxtb;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox descriptionTxtb;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button showListBtn;
    }
}

