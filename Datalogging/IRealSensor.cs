using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogging
{
	interface IRealSensor
	{
        string PhysicalName { get; set; }
        string Name { get; set; }
        double ValueLow { get; set; }
        double ValueHigh { get; set; }
        double GetDataFromSensor();
    }

}
