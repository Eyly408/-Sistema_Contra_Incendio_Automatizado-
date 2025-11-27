using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMonitoreo
{
    //Define la clase, los using, el namespace y crea el generador Random.
    public class SistemaMonitoreo
    {

        Random rnd = new Random();
        public int ObtenerTemperatura()
        {
            int temperatura = rnd.Next(15, 81);
            return temperatura;
        }

        public double ObtenerHumo(int temperatura)
        {
            double humo = (temperatura * 1.2) + rnd.Next(-10, 11);
            
            if (humo < 0)
            {
                humo = 0;
            }

            if(humo > 100)
            {
                humo = 100;
            }

            return Math.Round(humo, 1);
        }

    }
}
