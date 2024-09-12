namespace StudentRegistrationApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.LN = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MN = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.GEN = new System.Windows.Forms.Label();
            this.GENMALE = new System.Windows.Forms.RadioButton();
            this.GENFEMALE = new System.Windows.Forms.RadioButton();
            this.DATE = new System.Windows.Forms.Label();
            this.DAY = new System.Windows.Forms.ComboBox();
            this.MONTH = new System.Windows.Forms.ComboBox();
            this.YEAR = new System.Windows.Forms.ComboBox();
            this.REGISTER = new System.Windows.Forms.Button();
            this.ProgramCB = new System.Windows.Forms.ComboBox();
            this.prog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LN
            // 
            this.LN.AutoSize = true;
            this.LN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.Location = new System.Drawing.Point(47, 70);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(84, 19);
            this.LN.TabIndex = 1;
            this.LN.Text = "Lastname";
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.Location = new System.Drawing.Point(47, 148);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(87, 19);
            this.FN.TabIndex = 2;
            this.FN.Text = "Firstname ";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(51, 93);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(310, 27);
            this.LastName.TabIndex = 3;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(51, 171);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(310, 27);
            this.FirstName.TabIndex = 4;
            // 
            // MN
            // 
            this.MN.AutoSize = true;
            this.MN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MN.Location = new System.Drawing.Point(47, 223);
            this.MN.Name = "MN";
            this.MN.Size = new System.Drawing.Size(114, 19);
            this.MN.TabIndex = 5;
            this.MN.Text = "Middlename ";
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.Location = new System.Drawing.Point(51, 246);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(310, 27);
            this.MiddleName.TabIndex = 6;
            // 
            // GEN
            // 
            this.GEN.AutoSize = true;
            this.GEN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEN.Location = new System.Drawing.Point(47, 293);
            this.GEN.Name = "GEN";
            this.GEN.Size = new System.Drawing.Size(79, 19);
            this.GEN.TabIndex = 7;
            this.GEN.Text = "Gender *";
            // 
            // GENMALE
            // 
            this.GENMALE.AutoSize = true;
            this.GENMALE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENMALE.Location = new System.Drawing.Point(173, 293);
            this.GENMALE.Name = "GENMALE";
            this.GENMALE.Size = new System.Drawing.Size(67, 25);
            this.GENMALE.TabIndex = 8;
            this.GENMALE.TabStop = true;
            this.GENMALE.Text = "Male";
            this.GENMALE.UseVisualStyleBackColor = true;
            this.GENMALE.CheckedChanged += new System.EventHandler(this.GENMALE_CheckedChanged);
            // 
            // GENFEMALE
            // 
            this.GENFEMALE.AutoSize = true;
            this.GENFEMALE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENFEMALE.Location = new System.Drawing.Point(277, 293);
            this.GENFEMALE.Name = "GENFEMALE";
            this.GENFEMALE.Size = new System.Drawing.Size(89, 25);
            this.GENFEMALE.TabIndex = 9;
            this.GENFEMALE.TabStop = true;
            this.GENFEMALE.Text = "Female ";
            this.GENFEMALE.UseVisualStyleBackColor = true;
            this.GENFEMALE.CheckedChanged += new System.EventHandler(this.GENFEMALE_CheckedChanged);
            // 
            // DATE
            // 
            this.DATE.AutoSize = true;
            this.DATE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE.Location = new System.Drawing.Point(47, 336);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(110, 19);
            this.DATE.TabIndex = 10;
            this.DATE.Text = "Date of Birth *";
            // 
            // DAY
            // 
            this.DAY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAY.FormattingEnabled = true;
            this.DAY.Location = new System.Drawing.Point(51, 360);
            this.DAY.Name = "DAY";
            this.DAY.Size = new System.Drawing.Size(86, 29);
            this.DAY.TabIndex = 11;
            this.DAY.Text = "-Day-";
            this.DAY.SelectedIndexChanged += new System.EventHandler(this.DAY_SelectedIndexChanged);
            // 
            // MONTH
            // 
            this.MONTH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MONTH.FormattingEnabled = true;
            this.MONTH.Location = new System.Drawing.Point(163, 360);
            this.MONTH.Name = "MONTH";
            this.MONTH.Size = new System.Drawing.Size(89, 29);
            this.MONTH.TabIndex = 12;
            this.MONTH.Text = "-Month-";
            this.MONTH.SelectedIndexChanged += new System.EventHandler(this.MONTH_SelectedIndexChanged);
            // 
            // YEAR
            // 
            this.YEAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YEAR.FormattingEnabled = true;
            this.YEAR.Location = new System.Drawing.Point(277, 360);
            this.YEAR.Name = "YEAR";
            this.YEAR.Size = new System.Drawing.Size(84, 29);
            this.YEAR.TabIndex = 13;
            this.YEAR.Text = "-Year-";
            this.YEAR.SelectedIndexChanged += new System.EventHandler(this.YEAR_SelectedIndexChanged);
            // 
            // REGISTER
            // 
            this.REGISTER.BackColor = System.Drawing.Color.Crimson;
            this.REGISTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REGISTER.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER.ForeColor = System.Drawing.Color.White;
            this.REGISTER.Location = new System.Drawing.Point(51, 476);
            this.REGISTER.Name = "REGISTER";
            this.REGISTER.Size = new System.Drawing.Size(183, 55);
            this.REGISTER.TabIndex = 14;
            this.REGISTER.Text = "Register Student";
            this.REGISTER.UseVisualStyleBackColor = false;
            this.REGISTER.Click += new System.EventHandler(this.REGISTER_Click);
            // 
            // ProgramCB
            // 
            this.ProgramCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramCB.FormattingEnabled = true;
            this.ProgramCB.Location = new System.Drawing.Point(51, 432);
            this.ProgramCB.Name = "ProgramCB";
            this.ProgramCB.Size = new System.Drawing.Size(310, 29);
            this.ProgramCB.TabIndex = 15;
            this.ProgramCB.Text = "-Select Program-";
            this.ProgramCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // prog
            // 
            this.prog.AutoSize = true;
            this.prog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prog.Location = new System.Drawing.Point(47, 410);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(155, 19);
            this.prog.TabIndex = 16;
            this.prog.Text = "Program to apply *";
            this.prog.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 564);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.ProgramCB);
            this.Controls.Add(this.REGISTER);
            this.Controls.Add(this.YEAR);
            this.Controls.Add(this.MONTH);
            this.Controls.Add(this.DAY);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.GENFEMALE);
            this.Controls.Add(this.GENMALE);
            this.Controls.Add(this.GEN);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.MN);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LN;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label MN;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label GEN;
        private System.Windows.Forms.RadioButton GENMALE;
        private System.Windows.Forms.RadioButton GENFEMALE;
        private System.Windows.Forms.Label DATE;
        private System.Windows.Forms.ComboBox DAY;
        private System.Windows.Forms.ComboBox MONTH;
        private System.Windows.Forms.ComboBox YEAR;
        private System.Windows.Forms.Button REGISTER;
        private System.Windows.Forms.ComboBox ProgramCB;
        private System.Windows.Forms.Label prog;
    }
}

