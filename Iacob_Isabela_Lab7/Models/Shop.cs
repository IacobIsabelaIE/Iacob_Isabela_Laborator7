using SQLite; 
namespace Iacob_Isabela_Lab7.Models
{
    public class Shop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ShopName { get; set; }
        public string Address { get; set; }

        // Corrected the ShopDetails property
        public string ShopDetails => $"{ShopName}\n{Address}";

        // Corrected the OneToMany attribute
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ShopList> ShopLists { get; set; }
    }
}
