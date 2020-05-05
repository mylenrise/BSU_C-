using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide
{
    class Shoe
    {
        public static List<Shoe> shoes;

        Dictionary<int, string> types;
        void dictInit()
        {
            types = new Dictionary<int, string>(6);

            types.Add(201, "Sneakers");
            types.Add(202, "Boots");
            types.Add(203, "Loafers");
            types.Add(204, "Heels");
            types.Add(205, "Flats");
            types.Add(206, "Slippers");

        }

        String name;
        int type_id;
        Double price;
        int num;
        int id;

        public Shoe(/*int id,*/ String name, int type_id, Double price, int num)
        {
            dictInit();
            //this.Id = id;
            this.Name = name;
            this.Type_id = type_id;
            this.Price = price;
            this.Num = num;
        }

        public string Name { get => name; set => name = value; }
        public int Type_id { get => type_id; set => type_id = value; }
        public double Price { get => price; set => price = value; }
        public int Num { get => num; set => num = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return "'" + Name + "', '" + Type_id + "', '" + Price + "', '" + Num + "')";
        }
        public string GetRawString()
        {
            return Name + " " + Type_id + " " + Price + " " + Num;
        }
    }
}
