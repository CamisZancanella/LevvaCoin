using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoins.Models
{
    [Table("users")]

    public class User
    {
        [Column("id")]

        public in Id { get; set; }

       [Column("name")]

       public string? Name { get; set; }

       [Column("name")]

       public string? Email { get; set; }
       
       [Column("password")]

       public string? Password { get; set; }
    }
}
