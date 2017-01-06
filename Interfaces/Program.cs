using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Position
    {
        public Position() { }
        public Position(float X, float Y)
        {
            x = X;
            y = Y;
        }
        public float X
        {
            get
            {
                return x;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
        }
        static public Position operator +(Position p, Position current)
        {
            Position temp = new Position(0, 0);
            temp.x = current.x + p.x;
            temp.y = current.y + p.y;
            return temp;
        }
        static public Position operator -(Position current, Position p)
        {
            Position temp = new Position(0, 0);
            temp.x = current.x - p.x;
            temp.y = current.y - p.y;
            return temp;
        }

        private float x, y;
    }
    interface Ivehicle
    {
        void move(Position a);

    }
    class Car : Ivehicle
    {
        public Car()
        {
            m_Position = new Position(0, 0);
        }
        public Position Position
        {
            get
            {
                return m_Position;
            }
        }
        public void move(Position a)
        {
            m_Position += a;
        }
        private Position m_Position;

    }
    class Bus : Ivehicle
    {
        public Bus()
        {
            m_position = new Position(0, 0);
        }
        public void move(Position a)
        {
            m_position += a;
        }
        public Position Position
        {
            get
            {
                return m_position;
            }
        }
        private Position m_position;
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Car lambo = new Car();
            Bus greyhound = new Bus();
            lambo.move(new Position(20, 20));
            greyhound.move(new Position(30, 1));
        }
    }
}
