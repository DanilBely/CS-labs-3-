using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Circle
    {
        readonly int id;
        private double r;
        public double Ox, Oy;
        static int count = 0;
        const double PI = Math.PI;

        public double R //свойство
        {
            set
            {
                if (value < 0)
                {
                    Console.Write("Радиус должен быть положительным: ");
                    r = Convert.ToDouble(Console.ReadLine());
                }
                else { r = value; }
            }
            get { return r; }//методы-аксессоры гет - получатель сет-установщик
        }


        //Конструкторы
        public Circle()//без параметр
        {
            Ox = 2;
            Oy = 3;
            R = 6;
            count++;
        }

        public Circle(double r)//с параметром
        {
            R = r; Ox = 14; Oy = 13; count++;
        }

        public Circle(double Ox, double Oy, double R)//по умолоч
        {
            this.Ox = Ox;
            this.Oy = Oy;//обеспечивает доступ к текущему экземпляру класса
            this.R = R;
            count++;
        }

        static Circle()//статич конст вызывается один раз при создании объектов
        {
            Console.WriteLine("Статический конструктор");
        }

        public virtual Boolean Equals(Circle a)// метод проверки 
        {
            if (a == null) return false;//если передаваеый объект пустой, то false
            if (this.GetType() != a.GetType()) return false;
            if (this.Ox != a.Ox) return false;
            if (this.Oy != a.Oy) return false;
            if (this.R != a.R) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hashcode = this.id.GetHashCode();
            hashcode = 7 * hashcode + this.Ox.GetHashCode();
            hashcode = 7 * hashcode + this.Oy.GetHashCode();
            hashcode = 7 * hashcode + this.R.GetHashCode();
            return hashcode;
        }

        private Circle(double x, double y)//конструктор 
        {
            R = 1; Ox = x; Oy = y;
            count++;
        }

        public override string ToString() //переопределение метода базового класса обджект 
        {
            return "Информация о окружности: \nКоординаты центра:" + this.Ox + "," + this.Oy + " Радиус окружности: " + this.R;
        }

        
        public double Square()
        {
            return PI * this.R * this.R;
        }

        public double line()
        {
            return Math.PI * 2 * this.R;
        }

        public static void DisplayCount()
        {
            Console.WriteLine($"Создано {count} объектов класса Circle");
        }
        public void SRORIFM(ref double Ox, ref double Oy, ref double R, out int srorifm)
        {
            srorifm = (int)(Ox + Oy + R) / 2;
        }
    }
}


