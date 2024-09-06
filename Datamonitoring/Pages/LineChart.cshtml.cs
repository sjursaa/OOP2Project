using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Datamonitor.Models;

namespace Datamonitor.Pages
{
    public class LineChartModel : PageModel
    {
        public List<SensorData> sensorDataList = new List<SensorData>();
        string connectionString;
        readonly IConfiguration _configuration;

        public LineChartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            sensorDataList = SensorData();
        }

        private List<SensorData> SensorData()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            List<SensorData> sensorDataList = new List<SensorData>();
            SensorData sensorData = new SensorData();
            sensorDataList = sensorData.GetSensorData(connectionString);
            return sensorDataList;
        }
    }
}
