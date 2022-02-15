using DependencyInjectionExercise.Models.Interfaces;

namespace DependencyInjectionExercise.Models.Classes
{
    public class ClassA : InterfaceA
    {
        public void SomeMethod()
        {
            Console.WriteLine("Hello World!");//
        }
    }
}
