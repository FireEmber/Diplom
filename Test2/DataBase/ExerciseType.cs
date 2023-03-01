using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class ExerciseType
    {
        public ExerciseType()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string TaskType { get; set; } = null!;

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
