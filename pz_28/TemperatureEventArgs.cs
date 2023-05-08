using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс для передачи аргументов события TemperatureChanged

class TemperatureEventArgs : EventArgs
{
    public int Temperature { get; set; }
}
