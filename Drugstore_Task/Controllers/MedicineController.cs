using Drugstore_Task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{

    public class MedicineController : Controller
    {
        //Заготовка для обработчика ошибок и вызова сервисов с логикой
        private readonly ILogger<MedicineController> logger;
        //private readonly IMedicineService medicineService;
        public MedicineController(ILogger<MedicineController> _logger /*, IMedicineService _medicineService*/)
        {
            logger = _logger;
            //mediciveService = _medicineService;
        }

        //ЧИТАЙ ОТ ВОПРОСОВ
        /*
         страницы созданы шаблонно. Если есть мысли - пожалуйста
        а в целом все готово
         */







        //Заготовка для метода Index
        public async Task<IActionResult> Index()
        {
            /*
             * 
             *  
                    IEnumerable<SOME_FUCKING_MODEL_OF_MEDICINE_SERVICE_DTO> medicines = await medicineService.GetAll();
                    IEnumerable<MedicineViewModel> vm = medicines.Select(medicine => new MedicineViewModel
                    {
                        Id = medicines.Id,
                        Name_Product = medicines.name_product,
                        Manufacturer = medicines.manufacturer,
                        Year = medicines.Year
                    };
                    try
                    {
                        return View(vm);
                    }
                    catch(Exception ex)
                    {
                        logger.LogError(ex.Message + ". Ошибка вывода : контроллер");
                        return NotFound();
                    }
             */
            return View();
        }







        // GET: MedicineController/Details/5
        public ActionResult Details(int id)
        {
            /*
             * if(id == null)
             * {
             *      logger.LogError("В метод Details передан пустой ID");
             *      return NotFound();
             * }
             * SOME_FUCKING_MODEL_OF_MEDICINE_SERVICE_DTO medicine = await medicineService.GetByID(id);
             * if(medicine == null)
             * {
             *      return NotFound();
             * }
             * MedicineViewModel vm = new MedicineViewMode()
             * {
             *          Id = medicine.Id,
                        Name_Product = medicine.name_product,
                        Manufacturer = medicine.manufacturer,
                        Year = medicine.Year
             * };
             * return View(vm)
             */
            return View();
        }





        //Заготовка для метода Create с get и post обработкой запроса

        // GET: MedicineController/Create
        //[Authorize] - чисто шняга при которой пользователь с ролью n не имеет доступа к методу со стороны контроллера из-за прав пользователья
        //Для активации требуется установить nuget пакеn
        // [Authorize(Roles = "Admin")]

        //При переходе на страницу передачи продукта используется конкретно vm для данных
        public IActionResult Create() => View(new MedicineViewModel());

        //Далее реализация моего вида post метода(согласовать)

        /*
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct([Bind("Id,Name_Product,Manufacturer,Year")] MedicineViewModel vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            MedicineDTO medicine = new MedicineDTO()
            {
                dtoID = vm.Id,
                dtoName = vm.Name_Product,
                pdManufacturer = vm.Manufacturer,
                pdYear = vm.Year,
            };
            await medicineService.Create(medicine);
            return RedirectToAction(nameof(Index));
        }

         */


        //По сути уже устаревший код. Если твоя реализация другая - скажи
        //// POST: MedicineController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    /*
        //        MedicineViewModel vm = new MedicineViewModel();
        //    return View(vm);
        //     */

        //    return View();
        //}





        //какая-то хуйня от пинзы, что оно делает - хз, расскажи в лс(а точнее IFormCollection)

        //// GET: MedicineController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MedicineController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}







        //Заготовка для метода edit get запроса


        /// <summary>
        /// Get of edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            //var query = await medicineService.GetByID(id);
            /*
             if(query == null
            {
                return NotFound();
            }
                MedicineViewModel vm = new MedicineViewMode()
             * {
             *          Id = query.Id,
                        Name_Product = query.name_product,
                        Manufacturer = query.manufacturer,
                        Year = query.Year
             * };
             * return View(vm);

             */
            return View();
        }







        // GET: MedicineController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            /*
             if(id == null)
            {
                return NotFound();
            }
            var query = await medicineService.GetByID(id);
            if(medicine == null)
            {
                return NotFound();
            }
            MedicineViewModel vm = new MedicineViewModel
            {
                        Id = query.Id,
                        Name_Product = query.name_product,
                        Manufacturer = query.manufacturer,
                        Year = query.Year
            };
             return View(vm);
             
             
             */
            return View();
        }

        // POST: MedicineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConf(int id, IFormCollection collection /*IFormCollection или нахуй или объясняй зачем нужен*/)
        {
            /*
                var medicine = await medicineService.GetByID(id);
                if(medicine != null)
                {
                    await medicineService.Delete(id:
                }
                return RedirectToAction(nameof(Index));
             */
            return NotFound();
        }
    }
}