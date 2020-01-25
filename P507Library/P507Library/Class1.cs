

namespace P507Library
{
    public class Animal
    {
        private protected string Type { get; set; }
        protected string Name { get; set; }
        public int Age { get; set; }
    }

    public class Test:Animal
    {
        public Test()
        {
            Type = "";
        }
    }
}
