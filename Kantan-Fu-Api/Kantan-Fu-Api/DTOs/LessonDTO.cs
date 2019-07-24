using Kantan_Fu_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.DTOs
{
    public class LessonDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sections { get; set; }
        public TopicDTO Topic { get; set; }

        public LessonDTO(Lesson data)
        {
            Id = data.Id;
            Name = data.Name;
            Description = data.Description;
            Sections = data.Sections;
            if (data.Topic != null) { Topic = new TopicDTO(data.Topic); }
        }
        public void UpdateModel(Lesson data)
        {
            if (Name != null) { data.Name = Name; }
            if (Description != null) { data.Description = Description; }
            if (Sections != null) { data.Description = Sections; }
            if (Description != null) { data.Description = Description; }
            if (Topic != null)
            {
                data.Topic = new Topic()
                {
                    Name = data.Topic.Name,
                    Description = data.Topic.Description,
                    Lessons = data.Topic.Lessons,
                    TestTopics = data.Topic.TestTopics
                };
            }
        }
    }
}
