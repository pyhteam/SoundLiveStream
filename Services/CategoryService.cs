using SoundLiveStream.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoundLiveStream.Services
{
    public class CategoryService
    {
        private readonly string _dataFile = @"C:\Data\category.xml";
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<Category>));
        public List<Category> Categories { get; set; }

        public CategoryService()
        {
            if (!File.Exists(_dataFile))
            {
                Categories = new List<Category>()
                {
                     new Category(){Id = 1, Name ="Hài"},
                     new Category(){Id = 2, Name ="Kinh Dị"},
                     new Category(){Id = 3, Name ="Troll"},
                     new Category(){Id = 4, Name ="Winner"},
                };
            }
            else
            {
                using var stream = File.OpenRead(_dataFile);
                Categories = _serializer.Deserialize(stream) as List<Category>;
            }
        }
        public List<Category> GetAll()
        {
            return Categories.ToList();
        }
        public Category GetById(int id)
        {
            return Categories.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Category category)
        {
            if (category == null)
            {
                return false;
            }
            Categories.Add(category);
            SaveChanges();
            return true;
        }
        public void SaveChanges() 
        { 
            using var stream = File.Create(_dataFile); 
            _serializer.Serialize(stream, Categories); 
        }

    }
}
