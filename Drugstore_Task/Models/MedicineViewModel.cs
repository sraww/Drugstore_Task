using System.ComponentModel.DataAnnotations;
namespace Drugstore_Task.Models
{
    public class MedicineViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Скажите название лекарства.")]
        [Required(ErrorMessage = "Такого лекарства нет.")]
        public string Name_Product { get; set; }

        [Display(Name = "Назовите производителя лекарства")]
        [Required(ErrorMessage = "Такого производителя нет")]
        public string Manufacturer{ get; set; }

        [Display(Name = " Год выпуска")]
        [Required(ErrorMessage = "Год выпуска не найден.")]
        public int Year { get; set; }
    }
}