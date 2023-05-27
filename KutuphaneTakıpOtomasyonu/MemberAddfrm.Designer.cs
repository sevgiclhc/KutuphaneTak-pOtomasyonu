namespace KutuphaneTakıpOtomasyonu
{
    partial class MemberAddfrm
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
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumberofBookRead = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(162, 75);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(184, 22);
            this.txtTc.TabIndex = 0;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameSurname.Location = new System.Drawing.Point(162, 103);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(184, 22);
            this.txtNameSurname.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAge.Location = new System.Drawing.Point(162, 131);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(184, 22);
            this.txtAge.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(162, 189);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(184, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Location = new System.Drawing.Point(162, 217);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(184, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(162, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNumberofBookRead
            // 
            this.txtNumberofBookRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumberofBookRead.Location = new System.Drawing.Point(162, 273);
            this.txtNumberofBookRead.Name = "txtNumberofBookRead";
            this.txtNumberofBookRead.Size = new System.Drawing.Size(184, 22);
            this.txtNumberofBookRead.TabIndex = 6;
            this.txtNumberofBookRead.Text = "0";
            this.txtNumberofBookRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Woman",
            "Male"});
            this.comboGender.Location = new System.Drawing.Point(162, 159);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(184, 24);
            this.comboGender.TabIndex = 8;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(116, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(93, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(109, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of Book Read";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 27);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MemberAddfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(435, 394);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.txtNumberofBookRead);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.txtTc);
            this.Name = "MemberAddfrm";
            this.Text = "Member Add Page";
            this.Load += new System.EventHandler(this.MemberAddfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumberofBookRead;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}