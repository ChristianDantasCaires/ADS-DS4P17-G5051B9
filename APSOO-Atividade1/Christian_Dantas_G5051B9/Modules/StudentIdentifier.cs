using App.Modules.Base;

namespace App.Modules
{
    class StudentIdentifier : Student
    {
        public StudentIdentifier(string name, int age, string ra) : base(name, age, ra) { }

        public void RAChecker(string ra)
        {
            if (ra == RA)
            {
                Console.WriteLine("Este RA pertence ao estudante {0}. RA: {1} com idade {2}.", Name, RA, Age);
            }
            else
            {
                Console.WriteLine("RA não encontrado!");
            }
        }
    }
}
