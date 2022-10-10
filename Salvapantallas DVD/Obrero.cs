using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvapantallas_DVD
{
    public class Obrero
    {
        UserControl _control;
        Form _backgroundForm;
        Point _velocidad;

        public EventHandler EsquinaTocada;



        public Obrero (UserControl control, Form backgroundForm, Point velocidad)
        {
            _control = control;
            _backgroundForm = backgroundForm;
            _velocidad = velocidad;
        }

        public void Avanzar ()
        {
            Size screenSize = _backgroundForm.Size;
            Point screenLocation = _backgroundForm.Location;

            Point posicion = _control.Location;

            int nextX, nextY;

            bool bordeX = false, bordeY = false;


            //Avance y limites carrera X
            nextX = posicion.X + _velocidad.X;

            if (nextX > screenSize.Width - _control.Width)
            {
                //nextX = screenSize.Width - _control.Width;
                _velocidad.X = -_velocidad.X;
                bordeX = true;
            }
            else if (nextX < screenLocation.X)
            {
                //nextX = screenLocation.X;
                _velocidad.X = -_velocidad.X;
                bordeX = true;
            }

            //Avance y limites carrera Y
            nextY = posicion.Y + _velocidad.Y;

            if (nextY > screenSize.Height - _control.Height)
            {
                //nextY = screenSize.Height - _control.Height;
                _velocidad.Y = -_velocidad.Y;
                bordeY = true;
            }
            else if (nextY < screenLocation.Y)
            {
               // nextY = screenLocation.Y;
                _velocidad.Y = -_velocidad.Y;
                bordeY = true;
            }

            _control.Location = new Point(nextX, nextY);

            if (bordeX == true || bordeY == true) //En el borde
                ChangeColorRandomly();

            if (bordeX == true && bordeY == true) //En la esquina
                EsquinaTocada.Invoke(this, null);

        }


        public void ChangeColorRandomly()
        {
            var rand = new Random();
            int r = (int)rand.NextInt64(0, 255);
            int g = (int)rand.NextInt64(0, 255);
            int b = (int)rand.NextInt64(0, 255);
            _control.BackColor = Color.FromArgb(r, g, b);
        }
    }

}
