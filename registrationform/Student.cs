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

    
    public void Register()
    {
        string connStr = "server=localhost;port=3306;userid=root;password=;database=student";

        // Join hobbies array into a single string (handle null case)
        string hobbiesStr = Hobbies != null ? string.Join(",", Hobbies) : "";
        
        //string qry = $"INSERT INTO students VALUES (null

        // SQL query with parameters (specify all columns)
        string query = @"INSERT INTO students (Name, Roll, Dob, Gender, Email, Mobile, Password, City, Address, Hobbies) VALUES(@Name, @Roll, @Dob, @Gender, @Email, @Mobile, @Password, @City, @Address, @Hobbies)";

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
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

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
    
    
        public void update(){}
        public void getStudent(){}
        public void getStudentsById(){}
        public void searchStudent(){}
        public void delete(){}


    
    
    
}