using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using NationalInstruments.DAQmx;

namespace Datalogging
{
	internal class TempSensor: Sensor, IRealSensor
	{
        public string PhysicalName { get; set; }
        public AIThermocoupleType ThermocoupleType { get; set; }
        public AITemperatureUnits TempUnits { get; set; }

        public TempSensor()
        {
            PhysicalName = "Dev1/ai0";
            Name = "Temperature";
            ValueLow = 0;
            ValueHigh = 100;
            ThermocoupleType = AIThermocoupleType.J;
            TempUnits = AITemperatureUnits.DegreesC;
        }

        // TODO, handle this shits maybes ?
        public void SetupChannel()
        {

        }

        public override double GetDataFromSensor()
        {
            Task temperatureTask = new Task();
            AIChannel myAIChannel;

            myAIChannel = temperatureTask.AIChannels.CreateThermocoupleChannel(
                PhysicalName, Name, ValueLow, ValueHigh,
                ThermocoupleType, TempUnits);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(temperatureTask.Stream);

            // TODO, investigate opt8ions
            double tempData = reader.ReadSingleSample();

            return tempData;
        }

    }
}
