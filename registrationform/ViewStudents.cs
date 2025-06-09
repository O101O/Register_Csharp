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


    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        MessageBox.Show(id);
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      
    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }
}