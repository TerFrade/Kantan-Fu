using Kantan_Fu_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.DTOs
{
    public class TestDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Questions { get; set; }

        public TestDTO(Test data)
        {
            Id = data.Id;
            Name = data.Name;
            Description = data.Description;
            Questions = data.Questions;
        }

        public void UpdateModel(Test data)
        {
            if(Id != null) { data.Id = Id; }
            if (Name != null) { data.Name = Name; }
            if (Description != null) { data.Description = Description; }
            if (Questions != null) { data.Questions = Questions; }
        }
    }
}
