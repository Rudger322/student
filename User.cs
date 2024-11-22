namespace WindowsFormsApp3
{
    public class User
    {
        public string Citizenship { get; set; }
        public Purpose Purpose { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string Policy { get; set; }
        public bool IsLongStay { get; set; }

        public User() { }
        public User(string citizenship, Purpose purpose, DateTime dateOfEntry, string policy)
        {
            Citizenship = citizenship;
            Purpose = purpose;
            DateOfEntry = dateOfEntry;
            Policy = policy;
        }
    }
}
