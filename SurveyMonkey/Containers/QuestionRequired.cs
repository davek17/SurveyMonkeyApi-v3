﻿using Newtonsoft.Json;
using SurveyMonkey.Enums;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public class QuestionRequired
    {
        public string Text { get; set; }
        public QuestionRequiredType? Type { get; set; }
        public string Amount { get; set; }
    }
}