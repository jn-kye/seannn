namespace Sean.Models
{
    public class StudentModel
    {
        public int ID { get; set; } 
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.MiddleName + " " + this.LastName;
            }
        }
    }
}