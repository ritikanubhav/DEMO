using System.Data.SqlClient;

namespace DEMO
{
	public class FirstTableRepo
	{
		public void insert(int id,string name,int age)
		{

			//1.get connection string
			string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=demo;Integrated Security=True";

			//2.add connection string to new sql connection
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;

			//3.write a string command
			string sqlInsert = $"insert into FirstTable values (@id,@name,@age)";

			//4.create a sql command
			SqlCommand cmd = new SqlCommand();

			//5.add parameter to command
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@age", age);

			// 6.add string command to sql command
			cmd.CommandText = sqlInsert;
			cmd.Connection = connection;

			try
			{
				//7.open connection 
				connection.Open();

				//8.execute query command
				cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted values");
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				//9.finally close the connection
				connection.Close();
			}
		}

		public List<int> GetAgeById(string name)
		{

			//1.get connection string
			string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=demo;Integrated Security=True";

			//2.add connection string to new sql connection
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;

			//3.write a string command 
			string sqlRead = $"select age from FirstTable where name=@name";

			//4.create a sql command
			SqlCommand cmd = new SqlCommand();

			//5.add parameter to command 
			cmd.Parameters.AddWithValue("@name", name);

			// 6.add string command to sql command
			cmd.CommandText = sqlRead;
			cmd.Connection = connection;

			try
			{
				//7.open connection 
				connection.Open();

				//8.execute reader command
				SqlDataReader reader=cmd.ExecuteReader();
				List<int> ages= new List<int>();

				//9. read the reader (if multiple rows then put this in while loop)
				while (reader.Read())
				{
					//10.store value in variable
					ages.Add(Convert.ToInt32(reader["age"]));
				}
				
				foreach (int age in ages)
				{
					Console.WriteLine("Age Received: " + age);
				}
				return ages;
			}
			catch (Exception ex)
			{
				throw(ex);
			}
			finally
			{
				//11.finally close the connection
				connection.Close();
			}
		}
	}
}
