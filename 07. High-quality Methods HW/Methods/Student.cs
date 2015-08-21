using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student anotherStunent)
        {
            var firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            var secondDate = DateTime.Parse(anotherStunent.OtherInfo.Substring(anotherStunent.OtherInfo.Length - 10));
            return firstDate > secondDate;
        }
    }
}
