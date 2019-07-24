using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.Models
{
    public class TestTopic
    {
        public Guid TestId { get; set; }
        [Required, ForeignKey("TestId")] public Test Test { get; set; }
        public int TopicId { get; set; }
        [Required, ForeignKey("TopicId")] public Topic Topic { get; set; }
    }
}
