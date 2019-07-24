using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.Models
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Questions { get; set; }
        public ICollection<TestTopic> TestTopics { get; set; }
    }
}
