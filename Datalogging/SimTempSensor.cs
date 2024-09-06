using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using NationalInstruments.DAQmx;

namespace Datalogging
{
	internal class SimTempSensor: Sensor, ISimulatedSensor
	{
        private double tempData = 20;

        public string ThermocoupleType { get; set; }
        public string TempUnits { get; set; }

        public SimTempSensor()
        {
            //PhysicalName = "Dev1/ai0/sim";
            Name = "Simulated Temperature";
            ValueLow = 0;
            ValueHigh = 100;
            ThermocoupleType = "J";
            TempUnits = "DegreesC";
        }

        public override double GetDataFromSensor()
        {
            // TODO, investigate opt8ions
            Random random = new Random();

            //double tempData = 20;
            tempData += random.NextDouble();

            return tempData;
        }
    }
}
