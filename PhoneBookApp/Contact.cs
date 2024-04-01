namespace PhoneBookApp
{
    internal class Contact(string name, string number)
    {
        public string Name { get; set; } = name;
        public string Number { get; set; } = number;

        public string this[SearchContactBy key]
        {
            get
            {
                switch (key)
                {
                    case SearchContactBy.Name: return Name;
                    case SearchContactBy.Number: return Number;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(key), key, null);
                }
            }
        }
    }

    public enum SearchContactBy
    {
        Name,
        Number
    }

}
