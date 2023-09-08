namespace App.Modules.Base
{
    abstract class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string RA { get; private set; }

        public Student(string name, int age, string ra)
        {
            Name = name;
            Age = age;
            RA = ra;
        }
    }
}