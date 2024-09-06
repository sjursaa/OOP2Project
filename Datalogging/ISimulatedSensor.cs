using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogging
{
	internal interface ISimulatedSensor
	{
        string Name { get; set; }
        double ValueLow { get; set; }
        double ValueHigh { get; set; }
        double GetDataFromSensor();
	}
}
