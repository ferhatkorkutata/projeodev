using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUygulamasi1.Models
{
    public class KitapTuru
    {
        [Key] //Primary Key
        public int Id { get; set; }
        [Required(ErrorMessage ="Kitap Türü Boş Bırakılamaz.")] //Not Null
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad {  get; set; }
    }
}
