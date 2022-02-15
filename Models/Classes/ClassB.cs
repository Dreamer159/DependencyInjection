namespace DependencyInjectionExercise.Models.Classes
{
    public class ClassB
    {
        private int counter { get; set; }

        public int SomeOtherMethod()
        {
            return ++counter;
        }
    }
}
