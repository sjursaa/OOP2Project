using System.Data.SqlClient;

namespace CRUD.Models
{
	public class Sensor
	{
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public string SensorType { get; set; }
		public string SensorLocation {  get; set; }

        public List<Sensor> GetSensors(string connectionString)
		{
			List<Sensor> sensorList = new List<Sensor>();
			SqlConnection con = new SqlConnection(connectionString);

			// TODO swap Sensor table with view containing the 4 props
			string selectSQL = "select SensorID, Name, TypeName, City from GetSensorData";

			con.Open();

			SqlCommand cmd = new SqlCommand(selectSQL, con);
			SqlDataReader reader = cmd.ExecuteReader();

			if(reader != null )
			{
				while(reader.Read())
				{
					Sensor sensor = new Sensor();

					sensor.SensorId = Convert.ToInt32(reader["SensorID"]);
					sensor.SensorName = reader["Name"].ToString();
					sensor.SensorType = reader["TypeName"].ToString();
					sensor.SensorLocation = reader["City"].ToString();

					sensorList.Add(sensor);
				}
			}

			return sensorList;
		}
		public Sensor GetSensorData (string connectionString, int sensorId) 
		{
			SqlConnection con = new SqlConnection(connectionString);

			string selectSQL = "select SensorID, Name, TypeName, City from GetSensorData";

			con.Open();

			SqlCommand cmd = new SqlCommand(selectSQL, con);
			SqlDataReader reader = cmd.ExecuteReader();

			Sensor sensor = new Sensor();
			
			if(reader != null )
			{
				while(reader.Read())
				{
					sensor.SensorId = Convert.ToInt32(reader["SensorID"]);
					sensor.SensorName = reader["Name"].ToString();
				}
			}

			return sensor;
		}
		public void CreateSensor (string connectionString, Sensor sensor) 
		{
			try
			{
				//TODO add storedprocedure CreateSensor
				using (SqlConnection con = new SqlConnection( connectionString ))
				{
					SqlCommand cmd = new SqlCommand("CreateSensor", con);
					cmd.CommandType = System.Data.CommandType.StoredProcedure;

					cmd.Parameters.Add(new SqlParameter("@Name", sensor.SensorName));
					cmd.Parameters.Add(new SqlParameter("@Type", sensor.SensorType));
					cmd.Parameters.Add(new SqlParameter("@Location", sensor.SensorLocation));

					con.Open ();
					cmd.ExecuteNonQuery();
					con.Close ();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}	
		}
		public void EditSensor (string connectionString, Sensor sensor) 
		{
			try
			{
				//TODO add storedprocedure UpdateSensor
				using (SqlConnection con = new SqlConnection( connectionString ))
				{
					SqlCommand cmd = new SqlCommand("UpdateSensor", con);
					cmd.CommandType = System.Data.CommandType.StoredProcedure;

					cmd.Parameters.Add(new SqlParameter("@Name", sensor.SensorName));
					cmd.Parameters.Add(new SqlParameter("@Type", sensor.SensorType));
					cmd.Parameters.Add(new SqlParameter("@Location", sensor.SensorLocation));

					con.Open ();
					cmd.ExecuteNonQuery();
					con.Close ();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}	
		}
		public void DeleteSensor (string connectionString, int sensorId) 
		{ 
			try
			{
				//TODO add storedprocedure DeleteSensor
				using (SqlConnection con = new SqlConnection( connectionString ))
				{
					SqlCommand cmd = new SqlCommand("DeleteSensor", con);
					cmd.CommandType = System.Data.CommandType.StoredProcedure;

					cmd.Parameters.Add(new SqlParameter("@SensorID", sensorId));

					con.Open ();
					cmd.ExecuteNonQuery();
					con.Close ();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}	
		}

    }
}
