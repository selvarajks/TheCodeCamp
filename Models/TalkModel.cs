﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeCamp.Models
{
    public class TalkModel
    {
        public int TalkId { get; set; }        
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int Level { get; set; }
        public SpeakerModel Speaker { get; set; }
    }
}