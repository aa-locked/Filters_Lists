using FixedAsset.DataAccess.Data;
using FixedAsset.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FixedAsset.Controllers
{
    public class MaterialSubGroupController : Controller
    {
        private readonly FixedAssetDBContext _fixedAssetDBContext;

        public MaterialSubGroupController(FixedAssetDBContext fixedAssetDBContext)
        {
            _fixedAssetDBContext = fixedAssetDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> items = _fixedAssetDBContext.tFAMtrlGrp.ToList().Select(u => new SelectListItem
            {
                Value = u.FAMtrlGrpId.ToString(),
                Text = u.GrpDesc.ToString(),
            });
            ViewBag.GroupList = items;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TFAMtrlSubGrp tFAMtrlSubGrp)
        {
            if (ModelState.IsValid)
            {
                _fixedAssetDBContext.tFAMtrlSubGrp.Add(tFAMtrlSubGrp);
                _fixedAssetDBContext.SaveChanges();
                return RedirectToAction("Index", "MaterialSubGroup");
            }
            return View();
        }
    }
}
