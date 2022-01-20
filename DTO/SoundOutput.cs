using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLiveStream.DTO
{
    public class SoundOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
