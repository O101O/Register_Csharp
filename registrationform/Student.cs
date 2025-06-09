using System.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace registrationform;



public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Dob { get; set; }
    public int Roll { get; set; }
    public string Gender { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string[] Hobbies { get; set; }
    public string Password{ get; set; }


    string connStr;
    MySqlConnection conn;
    MySqlCommand cmd;
    
    public Student()
    {
        connStr = "server=localhost;port=3306;userid=root;password=;database=student";
        conn = new MySqlConnection(connStr);
        conn.Open();
    }

    
    public void Register()
    {
        // Join hobbies array into a single string (handle null case)
        string hobbiesStr = Hobbies != null ? string.Join(",", Hobbies) : "";
        
        //string qry = $"INSERT INTO students VALUES (null

        // SQL query with parameters (specify all columns)
        string query = @"INSERT INTO students (Name, Roll, Dob, Gender, Email, Mobile, Password, City, Address, Hobbies) VALUES(@Name, @Roll, @Dob, @Gender, @Email, @Mobile, @Password, @City, @Address, @Hobbies)";

        using (conn)
        {
            using (cmd = new MySqlCommand(query, conn))
            {
                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Roll", Roll);
                cmd.Parameters.AddWithValue("@Dob", Dob);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Hobbies", hobbiesStr);
                cmd.ExecuteNonQuery();
            }
        }
    }
    


    public void update() { }

    public DataTable getStudent()
    {
        string qry = "SELECT * FROM students";
        cmd = new MySqlCommand(qry, conn);
        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        return dt;
    }
        public void getStudentsById(){}

        public void searchStudent()
        {
            
        }
        public void delete(){}


    
    
    
}