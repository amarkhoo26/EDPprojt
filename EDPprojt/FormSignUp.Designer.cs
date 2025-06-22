namespace EDPprojt
{
    partial class FormSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.pNumber = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.NoBox = new System.Windows.Forms.TextBox();
            this.cfrmBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(422, 119);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(82, 16);
            this.fName.TabIndex = 1;
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(422, 157);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(81, 16);
            this.lName.TabIndex = 2;
            this.lName.Text = "Last Name";
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.Location = new System.Drawing.Point(421, 201);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(78, 16);
            this.uName.TabIndex = 3;
            this.uName.Text = "Username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(453, 283);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 16);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.label5_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(424, 240);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(75, 16);
            this.pass.TabIndex = 5;
            this.pass.Text = "Password";
            // 
            // pNumber
            // 
            this.pNumber.AutoSize = true;
            this.pNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumber.Location = new System.Drawing.Point(395, 325);
            this.pNumber.Name = "pNumber";
            this.pNumber.Size = new System.Drawing.Size(109, 16);
            this.pNumber.TabIndex = 6;
            this.pNumber.Text = "Phone Number";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(525, 113);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(266, 22);
            this.fNameBox.TabIndex = 7;
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(525, 151);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(266, 22);
            this.lNameBox.TabIndex = 8;
            this.lNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uNameBox
            // 
            this.uNameBox.Location = new System.Drawing.Point(525, 195);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(266, 22);
            this.uNameBox.TabIndex = 9;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(525, 240);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(266, 22);
            this.passBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(525, 283);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(266, 22);
            this.emailBox.TabIndex = 11;
            // 
            // NoBox
            // 
            this.NoBox.Location = new System.Drawing.Point(525, 322);
            this.NoBox.Name = "NoBox";
            this.NoBox.Size = new System.Drawing.Size(266, 22);
            this.NoBox.TabIndex = 12;
            // 
            // cfrmBtn
            // 
            this.cfrmBtn.Location = new System.Drawing.Point(956, 414);
            this.cfrmBtn.Name = "cfrmBtn";
            this.cfrmBtn.Size = new System.Drawing.Size(147, 33);
            this.cfrmBtn.TabIndex = 13;
            this.cfrmBtn.Text = "Confirm";
            this.cfrmBtn.UseVisualStyleBackColor = true;
            this.cfrmBtn.Click += new System.EventHandler(this.cfrmBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDPprojt.Properties.Resources.ChatGPT_Image_Jun_22__2025__11_24_49_PM;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cfrmBtn);
            this.Controls.Add(this.NoBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.uNameBox);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.pNumber);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label1);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label pNumber;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox NoBox;
        private System.Windows.Forms.Button cfrmBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}