using FixedAsset.DataAccess.Data;
using FixedAsset.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FixedAsset.Controllers
{
    public class MaterialGroupController : Controller
    {
        private readonly FixedAssetDBContext _fixedAssetDBContext;

        public MaterialGroupController(FixedAssetDBContext fixedAssetDBContext)
        {
            _fixedAssetDBContext = fixedAssetDBContext;
        }
        public IActionResult Index()
        {
            var GroupMstResult = _fixedAssetDBContext.tFAMtrlGrp.ToList();
            return View(GroupMstResult);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TFAMtrlGrp tFAMtrlGrp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _fixedAssetDBContext.tFAMtrlGrp.Add(tFAMtrlGrp);
                    _fixedAssetDBContext.SaveChanges();
                    RedirectToAction("Index", "MaterialGroup");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View(tFAMtrlGrp);
            }

        }

        public IActionResult Edit(int FAMtrlGrpId)
        {
            var GrpResult = _fixedAssetDBContext.tFAMtrlGrp.FirstOrDefault(x => x.FAMtrlGrpId == FAMtrlGrpId);
            return View(GrpResult);
        }
        [HttpPost]

        public IActionResult Edit(TFAMtrlGrp tFAMtrlGrp)
        {
            if(ModelState.IsValid)
            {
                _fixedAssetDBContext.tFAMtrlGrp.Update(tFAMtrlGrp);
                _fixedAssetDBContext.SaveChanges();
                return RedirectToAction("Index", "MaterialGroup");
            }
            return View(tFAMtrlGrp);
        }
        public IActionResult Delete(int FAMtrlGrpId)
        {
            var GrpResult = _fixedAssetDBContext.tFAMtrlGrp.FirstOrDefault(x => x.FAMtrlGrpId == FAMtrlGrpId);
            _fixedAssetDBContext.tFAMtrlGrp.Remove(GrpResult);
            _fixedAssetDBContext.SaveChanges();
            return RedirectToAction("Index", "MaterialGroup"); ;
        }
    }
}
