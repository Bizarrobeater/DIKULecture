namespace DIKULecture
{
    class Person
    {
        internal string name;
        internal string occupation;
        internal int age;

        public Person(string name, string occupation, int age)
        {
            this.name = name;
            this.occupation = occupation;
            this.age = age;
        }

        public string GetName() => name;
    }
}
