namespace registrationform;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        name = new System.Windows.Forms.TextBox();
        roll = new System.Windows.Forms.TextBox();
        label1Student = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        date = new System.Windows.Forms.DateTimePicker();
        number = new System.Windows.Forms.TextBox();
        mail = new System.Windows.Forms.TextBox();
        password = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        checkBox1 = new System.Windows.Forms.CheckBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox3 = new System.Windows.Forms.CheckBox();
        city = new System.Windows.Forms.ComboBox();
        label9 = new System.Windows.Forms.Label();
        address = new System.Windows.Forms.TextBox();
        label10 = new System.Windows.Forms.Label();
        gbGender = new System.Windows.Forms.GroupBox();
        gother = new System.Windows.Forms.RadioButton();
        gfemale = new System.Windows.Forms.RadioButton();
        gmale = new System.Windows.Forms.RadioButton();
        ghobbies = new System.Windows.Forms.GroupBox();
        submit = new System.Windows.Forms.Button();
        gbGender.SuspendLayout();
        ghobbies.SuspendLayout();
        SuspendLayout();
        // 
        // name
        // 
        name.Location = new System.Drawing.Point(257, 89);
        name.Name = "name";
        name.Size = new System.Drawing.Size(275, 23);
        name.TabIndex = 0;
        name.TextChanged += name_TextChanged;
        // 
        // roll
        // 
        roll.Location = new System.Drawing.Point(257, 133);
        roll.Name = "roll";
        roll.Size = new System.Drawing.Size(275, 23);
        roll.TabIndex = 1;
        // 
        // label1Student
        // 
        label1Student.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1Student.Location = new System.Drawing.Point(208, 10);
        label1Student.Name = "label1Student";
        label1Student.Size = new System.Drawing.Size(383, 49);
        label1Student.TabIndex = 2;
        label1Student.Text = "Student Registration Form";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(199, 89);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(39, 23);
        label1.TabIndex = 3;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(199, 133);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(60, 23);
        label2.TabIndex = 4;
        label2.Text = "Roll No:";
        // 
        // date
        // 
        date.CustomFormat = "yyyy-MM-dd";
        date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        date.Location = new System.Drawing.Point(257, 171);
        date.Name = "date";
        date.Size = new System.Drawing.Size(275, 23);
        date.TabIndex = 5;
        // 
        // number
        // 
        number.Location = new System.Drawing.Point(257, 211);
        number.Name = "number";
        number.Size = new System.Drawing.Size(275, 23);
        number.TabIndex = 6;
        // 
        // mail
        // 
        mail.Location = new System.Drawing.Point(257, 254);
        mail.Name = "mail";
        mail.Size = new System.Drawing.Size(275, 23);
        mail.TabIndex = 7;
        // 
        // password
        // 
        password.Location = new System.Drawing.Point(257, 299);
        password.Name = "password";
        password.Size = new System.Drawing.Size(275, 23);
        password.TabIndex = 8;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(199, 171);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(60, 23);
        label3.TabIndex = 9;
        label3.Text = "Date:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(184, 211);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(75, 23);
        label4.TabIndex = 10;
        label4.Text = "Mobile No:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(186, 299);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(75, 23);
        label5.TabIndex = 11;
        label5.Text = "Password:";
        label5.Click += label5_Click;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(173, 254);
        label6.Name = "label6";
        label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label6.Size = new System.Drawing.Size(75, 23);
        label6.TabIndex = 12;
        label6.Text = "Email";
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(35, 20);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(104, 24);
        checkBox1.TabIndex = 18;
        checkBox1.Text = "Sports";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.Location = new System.Drawing.Point(99, 20);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(104, 24);
        checkBox2.TabIndex = 19;
        checkBox2.Text = "Dance";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // checkBox3
        // 
        checkBox3.Location = new System.Drawing.Point(161, 20);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(104, 24);
        checkBox3.TabIndex = 20;
        checkBox3.Text = "Music";
        checkBox3.UseVisualStyleBackColor = true;
        checkBox3.CheckedChanged += checkBox3_CheckedChanged;
        // 
        // city
        // 
        city.FormattingEnabled = true;
        city.Items.AddRange(new object[] { "Kathmandu", "Lalitpur", "Bhaktapur" });
        city.Location = new System.Drawing.Point(257, 515);
        city.Name = "city";
        city.Size = new System.Drawing.Size(275, 23);
        city.TabIndex = 22;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(199, 515);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(65, 23);
        label9.TabIndex = 23;
        label9.Text = "City";
        // 
        // address
        // 
        address.Location = new System.Drawing.Point(257, 564);
        address.Name = "address";
        address.Size = new System.Drawing.Size(275, 23);
        address.TabIndex = 24;
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(186, 564);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(65, 23);
        label10.TabIndex = 25;
        label10.Text = "Address :";
        // 
        // gbGender
        // 
        gbGender.Controls.Add(gother);
        gbGender.Controls.Add(gfemale);
        gbGender.Controls.Add(gmale);
        gbGender.Location = new System.Drawing.Point(208, 347);
        gbGender.Name = "gbGender";
        gbGender.Size = new System.Drawing.Size(341, 55);
        gbGender.TabIndex = 26;
        gbGender.TabStop = false;
        gbGender.Text = "Gender";
        gbGender.Enter += groupBox1_Enter;
        // 
        // gother
        // 
        gother.Location = new System.Drawing.Point(176, 20);
        gother.Name = "gother";
        gother.Size = new System.Drawing.Size(104, 24);
        gother.TabIndex = 27;
        gother.TabStop = true;
        gother.Text = "Other";
        gother.UseVisualStyleBackColor = true;
        gother.CheckedChanged += gother_CheckedChanged;
        // 
        // gfemale
        // 
        gfemale.Location = new System.Drawing.Point(99, 20);
        gfemale.Name = "gfemale";
        gfemale.Size = new System.Drawing.Size(87, 24);
        gfemale.TabIndex = 27;
        gfemale.TabStop = true;
        gfemale.Text = "female";
        gfemale.UseVisualStyleBackColor = true;
        // 
        // gmale
        // 
        gmale.Location = new System.Drawing.Point(18, 20);
        gmale.Name = "gmale";
        gmale.Size = new System.Drawing.Size(75, 24);
        gmale.TabIndex = 17;
        gmale.TabStop = true;
        gmale.Text = "Male";
        gmale.UseVisualStyleBackColor = true;
        // 
        // ghobbies
        // 
        ghobbies.Controls.Add(checkBox3);
        ghobbies.Controls.Add(checkBox2);
        ghobbies.Controls.Add(checkBox1);
        ghobbies.Location = new System.Drawing.Point(208, 429);
        ghobbies.Name = "ghobbies";
        ghobbies.Size = new System.Drawing.Size(341, 55);
        ghobbies.TabIndex = 28;
        ghobbies.TabStop = false;
        ghobbies.Text = "Hobbies";
        // 
        // submit
        // 
        submit.Location = new System.Drawing.Point(336, 621);
        submit.Name = "submit";
        submit.Size = new System.Drawing.Size(75, 23);
        submit.TabIndex = 29;
        submit.Text = "Submit";
        submit.UseVisualStyleBackColor = true;
        submit.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 731);
        Controls.Add(date);
        Controls.Add(submit);
        Controls.Add(ghobbies);
        Controls.Add(gbGender);
        Controls.Add(address);
        Controls.Add(city);
        Controls.Add(label6);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(password);
        Controls.Add(mail);
        Controls.Add(number);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(label1Student);
        Controls.Add(roll);
        Controls.Add(name);
        Controls.Add(label5);
        Controls.Add(label9);
        Controls.Add(label10);
        Text = "Form1";
        gbGender.ResumeLayout(false);
        ghobbies.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.GroupBox ghobbie;

    private System.Windows.Forms.GroupBox ghobbies;
    private System.Windows.Forms.Button submit;

    private System.Windows.Forms.ComboBox city;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox address;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.GroupBox gbGender;
    private System.Windows.Forms.RadioButton gmale;
    private System.Windows.Forms.RadioButton gfemale;
    private System.Windows.Forms.RadioButton gother;

    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;

    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.TextBox roll;
    private System.Windows.Forms.Label label1Student;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker date;
    private System.Windows.Forms.TextBox number;
    private System.Windows.Forms.TextBox mail;
    private System.Windows.Forms.TextBox password;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    #endregion
}