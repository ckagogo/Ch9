using System;

namespace Ex2
{
    class Program
    {
        class Room
        {
            int length;
            int width;
            int height;

            public Room(int len, int wid, int high)
            {
                length = len;
                width = wid;
                height = high;
            }


            public double Area()
            {
                return length * width * height;
            }


            static void Main(string[] args)
            {
                Room[] rooms = new Room[8];
                int x;
                int len = 8;
                int wid = 8;
                int high = 8;

                for(x =0; x< rooms.Length; ++x)
                {
                    rooms[x] = new Room(len, wid, high);
                    len += 2;
                    wid += 1;

                    if (x % 2 == 1)
                        high = +1;

                }

                for (x = 0; x < rooms.Length; ++x)
                {
                    Console.WriteLine("For a {0} x {1} x {2} foot room", rooms[x].length, rooms[x].width, rooms[x].height);
                    Console.WriteLine("       Two walls are {0} long and {1} high", rooms[x].length, rooms[x].width, rooms[x].height);
                    Console.WriteLine("           and the other two walls are {0} long and {1} high", rooms[x].length, rooms[x].width, rooms[x].height);
                    Console.WriteLine("       Total wall area is {0}, so you need {1} gallon(s) of paint.", rooms[x].length, rooms[x].width, rooms[x].height);

                }



            }

        }
    }
}

