using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD.Models;

namespace CRUD.Pages.Sensors
{
    public class NewSensorModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;
        public NewSensorModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
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
