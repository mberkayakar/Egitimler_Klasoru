namespace EfCore.Entities
{
    public class Adress
    {
        public int ID { get; set; }

        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }        
        public User User { get; set; } // Navigation propertiy den kaynaklı olarak joinlemelerde bu kullanılacağı için
        public int UserId { get; set; }  // yazma zorunluluğu bulunmamamktadır. 

       


    }
}
