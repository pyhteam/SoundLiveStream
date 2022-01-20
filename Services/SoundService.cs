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
        private readonly string _dataFile = @"Data\sound.xml";
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<Sound>));
        public List<Sound> Sounds { get; set; }
        public SoundService()
        {
            if (!File.Exists(_dataFile))
            {
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
                        CategoryId =1,
                    }
                };
            }
            else
            {
                using var stream = File.OpenRead(_dataFile);
                Sounds = _serializer.Deserialize(stream) as List<Sound>;
            }
        }
        public List<Sound> GetAll()
        {
            return Sounds.ToList();
        }
        public Sound GetById(int id)
        {
            return Sounds.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Sound sound)
        {
            if (sound == null)
            {
                return false;
            }
            Sounds.Add(sound);
            SaveChanges();
            return true;
        }
        public void SaveChanges()
        {
            using var stream = File.Create(_dataFile);
            _serializer.Serialize(stream, Sounds);
        }
    }
}
