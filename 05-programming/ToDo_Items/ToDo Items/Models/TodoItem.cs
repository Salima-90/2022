using System.ComponentModel.DataAnnotations;
namespace ToDo_Items.Models
{
    public class TodoItem
    {   //This is to limit what data you are getting.
        //Entity framework you need a primary key. If you want to save something in the database this is done in the Model class.
        //The required words connect with the frontend and replaces the if statement. [] Attribute affecst property/method/class below it.
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Description is required")]

        [MaxLength(64, ErrorMessage = "Length of description cannot be greater than 64 characters")]

        [MinLength(2, ErrorMessage = "Length of description cannot be less than 2 characters")]

        public string? Description { get; set; }

        [Required(ErrorMessage = "Status is required")]

        public string? Status { get; set; }
    }
}
