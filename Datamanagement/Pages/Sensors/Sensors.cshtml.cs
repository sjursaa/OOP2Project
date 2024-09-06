using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using CRUD.Models;

namespace CRUD.Pages.Sensors
{
    public class SensorsModel : PageModel
    {
		readonly IConfiguration _configuration;
		public List<Sensor> sensors = new List<Sensor>();
		public string connectionString;
		public SensorsModel(IConfiguration configuration)
		{
			_configuration = configuration;
		}
        public void OnGet()
        {
			sensors = GetSensorList();
        }
		private List<Sensor> GetSensorList()
		{
			connectionString = _configuration.GetConnectionString("ConnectionString");
			List<Sensor> sensorList = new List<Sensor>();
			Sensor sensor = new Sensor();
			sensorList = sensor.GetSensors(connectionString);
			return sensorList;
		}
    }
}
