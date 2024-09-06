using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages.Sensors
{
    public class EditSensorModel : PageModel
    {
        readonly IConfiguration _configuration;
        public Sensor sensordb = new Sensor();
        public string connectionString;
        public int sensorId;
        public EditSensorModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            sensorId = Convert.ToInt32(Request.Form["SensorId"]);
            Sensor sensor = new Sensor();
            connectionString = _configuration.GetConnectionString("ConnectionString");
            sensordb = sensor.GetSensorData(connectionString, sensorId);
        }

        public void OnPost()
        {
            Sensor sensor = new Sensor();

            sensor.SensorName = Request.Form["SensorName"];
            sensor.SensorType = Request.Form["SensorType"];
            sensor.SensorLocation = Request.Form["SensorLocation"];

            connectionString = _configuration.GetConnectionString("ConnectionString");

            sensor.CreateSensor(connectionString, sensor);

            Response.Redirect("./Sensors");

        }
    }
}
