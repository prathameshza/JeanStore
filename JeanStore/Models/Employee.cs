namespace JeanStore.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }

}
