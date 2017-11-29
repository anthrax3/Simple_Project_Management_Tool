﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Project_Management_Tool.Models
{
    public class ViewTasksModel
    {
        public int Serial { get; set; }
        public string AssignTo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}