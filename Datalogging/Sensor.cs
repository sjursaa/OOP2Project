using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datalogging
{
	internal abstract class Sensor
	{
        public string Name { get; set; }
        public double ValueLow { get; set; }
        public double ValueHigh { get; set; }

        public Sensor()
        {
            Name = string.Empty;
            ValueLow = double.MinValue;
            ValueHigh = double.MinValue;
        }

        public virtual double GetDataFromSensor()
        {
            //Impl. code
            //Task temperatureTask = new NationalInstruments.DAQmx.Task();
            //AIChannel myAIChannel;

            //myAIChannel = temperatureTask.AIChannels.CreateThermocoupleChannel();

            // returnshits
            double value = 2;
            return value;

        }
        public void WriteDataToDb(double value)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=sensordata; Integrated Security=true";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand("InsertSensorData", con);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@Timestamp", DateTime.Now));
            sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
