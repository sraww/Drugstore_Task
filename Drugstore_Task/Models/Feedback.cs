using System.ComponentModel.DataAnnotations;

namespace Drugstore_Task.Models
{
    public class Feedback // Модель FeedBack 
    {
        [Display(Name = " Введите Имя")]
        [Required(ErrorMessage ="Вам нужно ввести  ваше имя")]
        public string Name { get; set; }

        [Display(Name = " Введите Фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести  вашу фамилию")]
        public string Surname { get; set; }

        [Display(Name = " Введите ваш возраст")]
        [Required(ErrorMessage = "Вам нужно ввести  ваш возраст")]
        public string Age { get; set; }

        [Display(Name = " Введите вашу почту")]
        [Required(ErrorMessage = "Вам нужно ввести  вашу почту")]
        public string Email { get; set; } 

        [Display(Name = " Введите ваше сообщение")]
        [StringLength(0, ErrorMessage ="Сообщение не может быть пустым!")]
        public string Message { get; set; }
        [Display(Name = " Введите ваш номер телефона")]
        [StringLength(0, ErrorMessage ="Поле не должно быть пустым")]
        public int Number { get; set; }
        
    }
}
