﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.Models
{
    public class Lesson
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sections { get; set; }
        public int TopicId { get; set; }
        [Required, ForeignKey("TopicId")] public Topic Topic { get; set; }
    }
}
