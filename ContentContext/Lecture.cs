using PogBalta.ContentContext.Enums;
using PogBalta.SharedContext;

namespace PogBalta.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
    }
}