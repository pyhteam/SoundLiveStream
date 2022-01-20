using SoundLiveStream.DTO;
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
    public class SoundService
    {
        private readonly string _dataFile = @"C:\Data\sound.xml";
        private readonly string _dataFile2 = @"C:\Data\category.xml";

        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<Sound>));
        private readonly XmlSerializer _serializer2 = new XmlSerializer(typeof(List<Category>));

        public List<Sound> Sounds { get; set; }
        public List<Category> Categories { get; set; }
        public SoundService()
        {
            if (File.Exists(_dataFile) && !File.Exists(_dataFile2))
            {
                Categories = new List<Category>()
                {
                     new Category(){Id = 1, Name ="Hài"},
                     new Category(){Id = 2, Name ="Kinh Dị"},
                     new Category(){Id = 3, Name ="Troll"},
                     new Category(){Id = 4, Name ="Winner"},
                };
                Sounds = new List<Sound>()
                {
                    new Sound()
                    {
                        Id = 1,
                        Link ="https://zingmp3.vn/bai-hat/Yeu-Anh-Nhat-Doi-LyLy/ZUFOA9C9.html",
                        Name =" Yeu Anh Nhat Doi",
                        CategoryId =1,
                    },
                    new Sound()
                    {
                        Id = 2,
                        Link ="https://soundcloud.com/den1305/den-mang-tien-ve-cho-me-ft-nguyen-thao?utm_source=clipboard&utm_medium=text&utm_campaign=social_sharing",
                        Name ="Mang Tiền Về Cho Mẹ",
                        CategoryId =1,
                    },
                    new Sound()
                    {
                        Id = 3,
                        Link ="https://soundcloud.com/youngcrizzal/lac?utm_source=clipboard&utm_medium=text&utm_campaign=social_sharing",
                        Name ="Lạc - Rhymastic",
                        CategoryId =2,
                    }
                };
            }
            else
            {
                using var stream = File.OpenRead(_dataFile);
                Sounds = _serializer.Deserialize(stream) as List<Sound>;

                using var stream2 = File.OpenRead(_dataFile2);
                Categories = _serializer2.Deserialize(stream2) as List<Category>;
            }
        }
        public List<Sound> GetAll()
        {
            return Sounds.ToList();
        }
        public List<SoundOutput> Get()
        {
            var qurey = Sounds.Join(
                Categories,
                s => s.CategoryId,
                c => c.Id,
                (s, c) => new SoundOutput()
                {
                    Name = s.Name,
                    Id = s.Id,
                    Link = s.Link,
                    CategoryId = s.CategoryId,
                    CategoryName = c.Name
                }
               ).ToList();
            return qurey;
            
        }
        public Sound GetById(int id)
        {
            return Sounds.FirstOrDefault(x => x.Id == id);
        }
        public List<Sound> GetByCategory(int categoryId)
        {
           var sounds = Sounds.Where(x=>x.CategoryId == categoryId).OrderByDescending(x=>x.Id).ToList();
           return sounds;
        }
        public bool Add(Sound sound)
        {
            if (sound == null)
            {
                return false;
            }
            Sounds.Add(sound);
            if (SaveChanges() != 1)
            {
                return false;
            }
            return true;
        }
        public int SaveChanges()
        {
            if (!Directory.Exists(@"C:\Data"))
            {
                Directory.CreateDirectory(@"C:\Data");
            }
            try
            {
                using var stream = File.Create(_dataFile);
                _serializer.Serialize(stream, Sounds);

                return 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }  
        }
    }
}
