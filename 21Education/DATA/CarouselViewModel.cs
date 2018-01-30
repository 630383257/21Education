﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _21Education.MODEL;
namespace _21Education.DATA
{
    public class CarouselViewModel : List<Carousel>
    {
        public CarouselViewModel(List<Carousel> list) : base(list)
        {
            this.ShowCount = 1;
        }
        public int ImgWidth { get; set; }
        public int ImgHeight { get; set; }
        public string PreviewHtml { get; set; }
        public string ClassName { set; get; }
        public int ShowCount { set; get; }
    }
}
