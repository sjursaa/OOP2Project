using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD.Models;

namespace CRUD.Pages.Sensors
{
    public class DeleteSensorModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;
        public int sensorId;

        public DeleteSensorModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            sensorId = Convert.ToInt16(Request.Query["sensorId"]);
            connectionString = _configuration.GetConnectionString("ConnectionString");
            Sensor sensor = new Sensor();
            sensor.DeleteSensor(connectionString,sensorId);
            Response.Redirect("./Sensors");
        }
    }
}
