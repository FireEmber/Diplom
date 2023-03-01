using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class Exercise
    {
        public int Id { get; set; }
        public string Exercise1 { get; set; } = null!;
        public int? Discipline { get; set; }
        public int? ExerciseType { get; set; }
        public int? Test { get; set; }
        public int? ExerciseContent { get; set; }
        public int? FalseAnswers { get; set; }
        public int? TrueAnswer { get; set; }

        public virtual Discipline? DisciplineNavigation { get; set; }
        public virtual ExerciseContent? ExerciseContentNavigation { get; set; }
        public virtual ExerciseType? ExerciseTypeNavigation { get; set; }
        public virtual FalseAnswer? FalseAnswersNavigation { get; set; }
        public virtual Test? TestNavigation { get; set; }
        public virtual TrueAnswer? TrueAnswerNavigation { get; set; }
    }
}
