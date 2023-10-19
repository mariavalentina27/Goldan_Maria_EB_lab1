using Microsoft.AspNetCore.Mvc;

namespace Goldan_Maria_lab1.Controllers
{
    public class Soare : Controller
    {
        public string Index()
        {
            return "Buna dimineata soare!";
        }

        public string Salut()
        {
            return "Salut utilizatorule!";
        }

        public string Afisare(string n, int i)
        {
            return "S-a specificat cuvantul " + n + " si numarul " + i + ".";
        }
    }
}
