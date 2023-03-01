using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class Discipline
    {
        public Discipline()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string Discipline1 { get; set; } = null!;

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
