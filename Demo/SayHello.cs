namespace Demo
{
    public class SayHello
    {
        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;

        public SayHello(string title, string firstName, string lastName)
        {
            _title = title;
            _firstName = firstName;
            _lastName = lastName;
        }

        public string Salutation() => $"Say hello {_title} {_firstName} {_lastName}";
    }
}
