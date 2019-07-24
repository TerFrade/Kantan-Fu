using Kantan_Fu_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.DTOs
{
    public class TopicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public LessonDTO[] Lessons { get; set; }

        public TopicDTO(Topic data)
        {
            Id = data.Id;
            Name = data.Name;
            Description = data.Description;
            if (data.Lessons != null) { Lessons = data.Lessons.Select(x => new LessonDTO(x)).ToArray(); }
        }

        public void UpdateModel(Topic data)
        {
            if (Name !=null) { data.Name = Name; }
            if (Description != null) { data.Description = Description; }
            if (Lessons != null) {
                if (data.Lessons == null) { data.Lessons = new List<TestQuestion>(); }
                foreach (var existing in data.Questions.ToArray())
                {
                    if (!Questions.Any(x => x.Id == existing.Id)) { data.Questions.Remove(existing); }
                }
                foreach (var adding in Questions)
                {
                    //var obj = data.Questions.Any(x => x.Id == adding.Id);
                    var obj = data.Questions.FirstOrDefault(x => x.Id == adding.Id);
                    if (obj != null)
                    {
                        adding.UpdateModel(obj);
                        continue;
                    }

                    data.Questions.Add(new TestQuestion()
                    {
                        Order = adding.Order.Value,
                        QuestionId = adding.Question.Id,
                        TestId = data.Id,
                        Answer = adding.Answer
                    });
                }
        }
    }
}
