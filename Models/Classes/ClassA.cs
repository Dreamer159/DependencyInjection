using DependencyInjectionExercise.Models.Interfaces;

namespace DependencyInjectionExercise.Models.Classes
{
    public class ClassA : InterfaceA
    {
        private int counter;
        public int SomeMethod()
        {
            return ++counter;
        }
    }
}
