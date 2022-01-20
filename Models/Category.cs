﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLiveStream.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Sound> Sounds { get; set; }
    }
}
