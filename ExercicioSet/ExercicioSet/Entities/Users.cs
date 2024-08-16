namespace ExercicioSet.Entities
{
    internal class Users
    {
        public string Name { get; set; }
        public DateTime AcessTime { get; set; }

        public Users(string name, DateTime acessTime)
        {
            Name = name;
            AcessTime = acessTime;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Users))
            {
                return false;
            }
            Users other = obj as Users;

            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name},{AcessTime:yyyy-MM-ddTHH:mm:ss}";
        }
    }
}
