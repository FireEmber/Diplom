using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class FalseAnswer
    {
        public FalseAnswer()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string? FalseAnswersOne { get; set; }
        public string? FalseAnswersTwo { get; set; }
        public string? FalseAnswersThree { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
