using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class ExerciseContent
    {
        public ExerciseContent()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string Content { get; set; } = null!;

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
