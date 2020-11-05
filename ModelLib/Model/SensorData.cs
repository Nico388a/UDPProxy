using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class SensorData
    {
        //'Id, Name, Temperature, CO2'

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _temperature;

        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        private double _cO2;

        public double CO2
        {
            get { return _cO2; }
            set { _cO2 = value; }
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Temperature + " " + CO2;
        }

        public SensorData(int id, string name, double temperature, double cO2)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            CO2 = cO2;
        }

        public SensorData()
        {
            
        }
    }
}
