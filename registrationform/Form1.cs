namespace registrationform;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void gother_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string gender = "";
        List<string> hobbies = new List<string>();

        foreach (RadioButton rb in gbGender.Controls)
        {
            if(rb.Checked)
                gender = rb.Text;
        }

        foreach (CheckBox cb in ghobbies.Controls)
        {
            if (cb.Checked)
                hobbies.Add(cb.Text);
        }

        Student student = new Student();
        student.Name = name.Text;
        student.Roll = int.Parse(roll.Text);
        student.Dob = date.Text;  
        student.Gender = gbGender.Text;
        student.Email = mail.Text;
        student.Mobile = number.Text;
        student.Password = password.Text;
        student.City = city.Text;
        student.Address = address.Text;
        student.Hobbies = hobbies.ToArray(); // example, or get from checkbox list

        student.Register();

        MessageBox.Show("Registration Successful!");
    }

    private void name_TextChanged(object sender, EventArgs e)
    {
        
    }
    
}