using System;
using System.Collections.Generic;

namespace Test2.DataBase
{
    public partial class Test
    {
        public Test()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string TestName { get; set; } = null!;

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
