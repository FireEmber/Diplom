using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class TrueAnswer
    {
        public TrueAnswer()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string TrueAnswer1 { get; set; } = null!;

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
