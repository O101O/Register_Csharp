using System.Data;
using System.Diagnostics;

namespace registrationform;

public partial class ViewStudents : Form
{
    
    public ViewStudents()
    {
        InitializeComponent();
    }

    private void ViewStudents_Load(object sender, EventArgs e)
    {
        Student st = new Student();

        DataTable dt = st.getStudent();

        dataGridView1.DataSource = dt;
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Debug.WriteLine(dt.Rows[i]["name"]);
            }
        }
        else
        {
            MessageBox.Show("No student found");    
        }
    }

    private void Search_Click(object sender, EventArgs e)
    {
       
    }
    
    
}