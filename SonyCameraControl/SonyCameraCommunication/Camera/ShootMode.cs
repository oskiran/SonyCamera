﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonyCameraCommunication.Camera
{
    public class ShootMode
    {
        public string method { get; set; }
        public List<string> @params { get; set; }
        public int id { get; set; }
        public string version { get; set; }
    }
}
