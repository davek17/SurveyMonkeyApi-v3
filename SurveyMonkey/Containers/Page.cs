﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public class Page : IPageableContainer
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        internal string Href { get; set; }
        public int? Position { get; set; }
        public int? QuestionCount { get; set; }
        public List<Question> Questions { get; set; }
    }
}