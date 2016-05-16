using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Курсач
{
    public class ItemCollection
    {
        public List<Item> items = new List<Item>();

        public string fileName = "items.json";

        public ItemCollection()
        {
            Load();
        }


        //Сохранение
        public void Save()
        {
            using (TextWriter writer = new StreamWriter(File.Create(fileName)))
            {
                writer.WriteLine(JsonConvert.SerializeObject(items));
            }
        }

        //Загрузка
        public void Load()
        {
            using (TextReader reader = new StreamReader(File.OpenRead(fileName)))
            {
                items = JsonConvert.DeserializeObject<List<Item>>(reader.ReadLine());
            }
        }

        public void LoadDefault()
        {
           List<Item> items = new List<Item>();



            Item it1 = new Item()
            {
                Name = "kek",
                Count = 1488,
                Measure = "kgs",
                dateOfLast = DateTime.Now,
                Price = 200
            };

            items.Add(it1);
            
        }




        public void Add(List<Item> items)
        {
            this.items.AddRange(items);
        }

        public static implicit operator List<object>(ItemCollection v)
        {
            throw new NotImplementedException();
        }
    }
}
