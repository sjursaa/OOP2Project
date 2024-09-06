using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using NationalInstruments.DAQmx;

namespace Datalogging
{
	public partial class Form1 : Form
	{
		// TODO add tmpUnitselector
		// TODO add storageselector (store: y/n)
		// TODO refactor add sensor/btnGetData, consolidate
		// TODO add logging/timeseries functionality

		// TODO add relativenumber to vimrc (unrelate)
		public Form1()
		{
			InitializeComponent();
		}
		Sensor[] sensorArray = new Sensor[3];

		private void btnGetData1_Click(object sender, EventArgs e)
		{
			try
			{
				double tempData = sensorArray[0].GetDataFromSensor();
				sensorArray[0].WriteDataToDb(tempData);
				txtTemperature.Text = tempData.ToString("0.0");
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.ToString());
                MessageBox.Show("plz create sensor first");
			}
		}

		private void btnAddSensor1_Click(object sender, EventArgs e)
		{
			if (cboSensorType1.Text == "Temperatur")
			{
				sensorArray[0] = new TempSensor();
			}
			if (cboSensorType1.Text == "Sim Temperatur")
			{
				sensorArray[0] = new SimTempSensor();
			}
		}

		private void btnAddSensor2_Click(object sender, EventArgs e)
		{
			if (cboSensorType2.Text == "Temperatur")
			{
				sensorArray[1] = new TempSensor();
			}
			if (cboSensorType2.Text == "Sim Temperatur")
			{
				sensorArray[1] = new SimTempSensor();
			}

		}

		private void btnAddSensor3_Click(object sender, EventArgs e)
		{
			if (cboSensorType3.Text == "Temperatur")
			{
				sensorArray[2] = new TempSensor();
			}
			if (cboSensorType3.Text == "Sim Temperatur")
			{
				sensorArray[2] = new SimTempSensor();
			}

		}

		private void btnGetData2_Click(object sender, EventArgs e)
		{
			double tempData = sensorArray[1].GetDataFromSensor();
			txtTemperature2.Text = tempData.ToString("0.0");
		}

		private void btnGetData3_Click(object sender, EventArgs e)
		{
			double tempData = sensorArray[1].GetDataFromSensor();
			txtTemperature3.Text = tempData.ToString("0.0");
		}
	}
}
