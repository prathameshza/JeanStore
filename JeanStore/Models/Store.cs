namespace JeanStore.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Item> Items { get; set; }
    }

}
