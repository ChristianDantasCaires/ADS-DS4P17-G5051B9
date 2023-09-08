using App.Modules;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var christian = new StudentIdentifier("Christian Dantas Caires", 19, "G5051B9");
            var clovis = new StudentIdentifier("Clovis", 55, "31FASM8");
            var eminem = new StudentIdentifier("Marshall Bruce Mathers III", 50, "ABC1010");

            christian.RAChecker("G5051B9");
            clovis.RAChecker("G5051B9");
            eminem.RAChecker("ABC1010");
        }
    }
}
