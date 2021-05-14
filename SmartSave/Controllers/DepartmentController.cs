using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;

namespace SmartSave.Controllers
{
    public class DepartmentController : BaseController<DepartmentController>
    {
        private readonly IDepartmentService _service;
        public DepartmentController(IDepartmentService service) => _service = service;
        // GET: Department
        public async Task<IActionResult> Department()
        {
            Permissions permission = Permissions.View_Department;
            if (!UtilityService.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Departments());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Department department)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(department))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Department a Department  with the same Name Already Exists";
                    return View(department);
                }
                if (await (_service.Save(department)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(Department));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Department));
        }
        // GET:
        public async Task<IActionResult> ViewDepartment(int id) => View(await _service.FindDepartment(id));

        // GET:
        public async Task<IActionResult> ViewDepartmentUsers(int id = 0)
        {
            Department department = await (_service.FindDepartment(id));
            @TempData["Title"] = department.Name;
            ViewBag.DepartmentID = id;
            return View(await _service.DepartmentClients(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                Department update = await (_service.FindDepartment(department.DepartmentID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(department)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Department));
                }
                return View(department);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(department);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Department));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewDepartment", new { id });
            }

        }
        public async Task<IActionResult> ChangeDepartmentstatus(int id, bool status)
        {
            if (await (_service.ActionDepartment(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewDepartment", new { id });
        }

       public async Task<IActionResult> RemoveUser(int id, int userid)
        {
            if (await (_service.ActionUserAccess(id, userid, DatabaseAction.Remove)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewDepartmentUsers", new { id }); ;


        }


    }
}
