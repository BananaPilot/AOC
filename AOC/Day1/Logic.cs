using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Day1
{
    public class Logic
    {
        private int _displayValue { get; set; } = 50;

        public int Password { get; set; } = 0;
        public int DisplayValue { get { return _displayValue; } set { _displayValue = value; OnDisplayValueChanged(); } }

        private event EventHandler DisplayValueChanged;

        private void OnDisplayValueChanged()
        {
            DisplayValueChanged?.Invoke(this, EventArgs.Empty);

            if (DisplayValue == 100) DisplayValue = 0;
            if (DisplayValue == -1) DisplayValue = 99;
        }

        public (string, int) GetValuesFromLine(string line)
        {
            return (line[..1], int.Parse(line.Substring(1, line.Length - 1)));
        }
    }
}
