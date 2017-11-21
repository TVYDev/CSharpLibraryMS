namespace LibraryManagementSystem
{
    partial class frmRegisterLibrarian
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recRoundPic = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLibrarian = new System.Windows.Forms.PictureBox();
            this.lblRequiredName = new System.Windows.Forms.Button();
            this.lblRequiredPhone = new System.Windows.Forms.Button();
            this.lblRequiredAddress = new System.Windows.Forms.Button();
            this.pnIdGenerated = new System.Windows.Forms.Panel();
            this.btnCreateQrCode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.picLibrarian)).BeginInit();
            this.pnIdGenerated.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 21;
            this.rectangleShape1.Location = new System.Drawing.Point(6, 6);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(683, 42);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recRoundPic,
            this.lineShape1,
            this.lineShape2,
            this.lineShape3,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1135, 670);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // recRoundPic
            // 
            this.recRoundPic.CornerRadius = 92;
            this.recRoundPic.Location = new System.Drawing.Point(48, 119);
            this.recRoundPic.Name = "recRoundPic";
            this.recRoundPic.Size = new System.Drawing.Size(185, 185);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 505;
            this.lineShape1.X2 = 1093;
            this.lineShape1.Y1 = 286;
            this.lineShape1.Y2 = 286;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 509;
            this.lineShape2.X2 = 1091;
            this.lineShape2.Y1 = 150;
            this.lineShape2.Y2 = 150;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 507;
            this.lineShape3.X2 = 806;
            this.lineShape3.Y1 = 218;
            this.lineShape3.Y2 = 218;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Register new librarian";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::LibraryManagementSystem.Properties.Resources.Add_new;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(409, 13);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(76, 29);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::LibraryManagementSystem.Properties.Resources.Reset_Filled;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(585, 13);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LibraryManagementSystem.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(497, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(92, 234);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 31);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(509, 260);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.MaxLength = 10;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(577, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Image = global::LibraryManagementSystem.Properties.Resources.Isbn_number;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(325, 255);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(174, 34);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(509, 192);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(298, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::LibraryManagementSystem.Properties.Resources.Authors;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(325, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 34);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(509, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(577, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::LibraryManagementSystem.Properties.Resources.Titles;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(325, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLibrarian
            // 
            this.picLibrarian.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.Cover;
            this.picLibrarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLibrarian.Location = new System.Drawing.Point(92, 145);
            this.picLibrarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLibrarian.Name = "picLibrarian";
            this.picLibrarian.Size = new System.Drawing.Size(100, 100);
            this.picLibrarian.TabIndex = 27;
            this.picLibrarian.TabStop = false;
            this.picLibrarian.Click += new System.EventHandler(this.picLibrarian_Click);
            // 
            // lblRequiredName
            // 
            this.lblRequiredName.FlatAppearance.BorderSize = 0;
            this.lblRequiredName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRequiredName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRequiredName.Location = new System.Drawing.Point(239, 123);
            this.lblRequiredName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRequiredName.Name = "lblRequiredName";
            this.lblRequiredName.Size = new System.Drawing.Size(97, 36);
            this.lblRequiredName.TabIndex = 34;
            this.lblRequiredName.Text = "*Required*";
            this.lblRequiredName.UseVisualStyleBackColor = true;
            // 
            // lblRequiredPhone
            // 
            this.lblRequiredPhone.FlatAppearance.BorderSize = 0;
            this.lblRequiredPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRequiredPhone.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredPhone.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRequiredPhone.Location = new System.Drawing.Point(239, 191);
            this.lblRequiredPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRequiredPhone.Name = "lblRequiredPhone";
            this.lblRequiredPhone.Size = new System.Drawing.Size(97, 36);
            this.lblRequiredPhone.TabIndex = 35;
            this.lblRequiredPhone.Text = "*Required*";
            this.lblRequiredPhone.UseVisualStyleBackColor = true;
            // 
            // lblRequiredAddress
            // 
            this.lblRequiredAddress.FlatAppearance.BorderSize = 0;
            this.lblRequiredAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRequiredAddress.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredAddress.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRequiredAddress.Location = new System.Drawing.Point(239, 258);
            this.lblRequiredAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRequiredAddress.Name = "lblRequiredAddress";
            this.lblRequiredAddress.Size = new System.Drawing.Size(97, 36);
            this.lblRequiredAddress.TabIndex = 36;
            this.lblRequiredAddress.Text = "*Required*";
            this.lblRequiredAddress.UseVisualStyleBackColor = true;
            // 
            // pnIdGenerated
            // 
            this.pnIdGenerated.Controls.Add(this.btnCreateQrCode);
            this.pnIdGenerated.Controls.Add(this.label7);
            this.pnIdGenerated.Controls.Add(this.shapeContainer2);
            this.pnIdGenerated.Location = new System.Drawing.Point(78, 586);
            this.pnIdGenerated.Name = "pnIdGenerated";
            this.pnIdGenerated.Size = new System.Drawing.Size(959, 72);
            this.pnIdGenerated.TabIndex = 37;
            // 
            // btnCreateQrCode
            // 
            this.btnCreateQrCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(56)))), ((int)(((byte)(15)))));
            this.btnCreateQrCode.FlatAppearance.BorderSize = 0;
            this.btnCreateQrCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQrCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQrCode.ForeColor = System.Drawing.Color.White;
            this.btnCreateQrCode.Image = global::LibraryManagementSystem.Properties.Resources.QR_code;
            this.btnCreateQrCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQrCode.Location = new System.Drawing.Point(759, 22);
            this.btnCreateQrCode.Name = "btnCreateQrCode";
            this.btnCreateQrCode.Size = new System.Drawing.Size(158, 29);
            this.btnCreateQrCode.TabIndex = 9;
            this.btnCreateQrCode.Text = "Create ID card";
            this.btnCreateQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateQrCode.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(56)))), ((int)(((byte)(15)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::LibraryManagementSystem.Properties.Resources.Done;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(55, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID generated for newly registered librarian is done.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(959, 72);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(56)))), ((int)(((byte)(15)))));
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(56)))), ((int)(((byte)(15)))));
            this.rectangleShape2.CornerRadius = 19;
            this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(56)))), ((int)(((byte)(15)))));
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(15, 17);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(927, 38);
            // 
            // frmRegisterLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1135, 670);
            this.Controls.Add(this.pnIdGenerated);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequiredName);
            this.Controls.Add(this.lblRequiredPhone);
            this.Controls.Add(this.lblRequiredAddress);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLibrarian);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegisterLibrarian";
            this.Text = "frmRegisterLibrarian";
            this.Load += new System.EventHandler(this.frmRegisterLibrarian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLibrarian)).EndInit();
            this.pnIdGenerated.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLibrarian;
        private System.Windows.Forms.Button lblRequiredName;
        private System.Windows.Forms.Button lblRequiredPhone;
        private System.Windows.Forms.Button lblRequiredAddress;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recRoundPic;
        private System.Windows.Forms.Panel pnIdGenerated;
        private System.Windows.Forms.Button btnCreateQrCode;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
    }
}