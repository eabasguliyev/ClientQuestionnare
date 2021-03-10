namespace WinformsTask2.Abstracts
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string GetFullname() => $"{FirstName} {LastName}";
    }
}