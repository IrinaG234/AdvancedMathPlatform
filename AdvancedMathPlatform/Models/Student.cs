namespace AdvancedMathPlatform.Models
{
//mostenire
public class Student : User
    {
        public string SchoolLevel { get; private set; }

        public Student(int id, string firstName, string lastName, string email, string level)
            : base(id, firstName, lastName, email)
        {
            SchoolLevel = level;
        }
    }
}
