﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Group3API.Models
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            ClassSchedules = new HashSet<ClassSchedule>();
        }

        public string WeekDayId { get; set; }

        public virtual ICollection<ClassSchedule> ClassSchedules { get; set; }
    }
}