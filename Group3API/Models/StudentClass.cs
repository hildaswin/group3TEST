﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Group3API.Models
{
    public partial class StudentClass
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public string StudClassGrade { get; set; }
        public string ClassStatusCode { get; set; }

        public virtual ClassTable Class { get; set; }
        public virtual Student Student { get; set; }
    }
}