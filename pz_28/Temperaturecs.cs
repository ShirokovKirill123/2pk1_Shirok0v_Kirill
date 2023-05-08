using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс для работы с температурой
class Temperature
{
    public event EventHandler<TemperatureEventArgs> TemperatureChanged;

    // Метод для запуска увеличения температуры
    public void Start()
    {       
        for (int i = -30; i <= 40; i++)
        {
            // Создаем экземпляр класса TemperatureEventArgs и передаем значение температуры
            TemperatureEventArgs args = new TemperatureEventArgs();
            args.Temperature = i;

            OnTemperatureChanged(args);

            // Задержка 
            System.Threading.Thread.Sleep(100);
        }
    }

    // Метод для вызова события TemperatureChanged 
    protected virtual void OnTemperatureChanged(TemperatureEventArgs e)
    {
        EventHandler<TemperatureEventArgs> handler = TemperatureChanged;
        if (handler != null)
        {
            handler(this, e);
        }
    }
}
