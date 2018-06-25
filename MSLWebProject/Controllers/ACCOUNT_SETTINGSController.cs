using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSLWebProject.Data;

namespace MSLWebProject.Controllers
{
    public class ACCOUNT_SETTINGSController : Controller
    {
        private Entities db = new Entities();

        // GET: ACCOUNT_SETTINGS
        public async Task<ActionResult> Index()
        {
            return View(await db.ACCOUNT_SETTINGS.ToListAsync());
        }

        // GET: ACCOUNT_SETTINGS/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACCOUNT_SETTINGS aCCOUNT_SETTINGS = await db.ACCOUNT_SETTINGS.FindAsync(id);
            if (aCCOUNT_SETTINGS == null)
            {
                return HttpNotFound();
            }
            return View(aCCOUNT_SETTINGS);
        }

        // GET: ACCOUNT_SETTINGS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACCOUNT_SETTINGS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AC_ACCOUNT,SQ_ACCOUNT_SETTING_VERSION,AC_ACCOUNT_TYPE,DS_ACCOUNT,AC_DEFAULT_IBAN,AM_CHEQUE_LIMIT,DT_SETTING_VALID_FROM,DT_SETTING_VALID_TO,DT_VALID_FROM,DT_VALID_TO,AC_CREATION_USER,TS_CREATION,AC_LAST_UPDATE_USER,TS_LAST_UPDATE")] ACCOUNT_SETTINGS aCCOUNT_SETTINGS)
        {
            if (ModelState.IsValid)
            {
                db.ACCOUNT_SETTINGS.Add(aCCOUNT_SETTINGS);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(aCCOUNT_SETTINGS);
        }

        // GET: ACCOUNT_SETTINGS/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACCOUNT_SETTINGS aCCOUNT_SETTINGS = await db.ACCOUNT_SETTINGS.FirstAsync(AC => AC.AC_ACCOUNT == id);
            if (aCCOUNT_SETTINGS == null)
            {
                return HttpNotFound();
            }
            return View(aCCOUNT_SETTINGS);
        }

        // POST: ACCOUNT_SETTINGS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AC_ACCOUNT,SQ_ACCOUNT_SETTING_VERSION,AC_ACCOUNT_TYPE,DS_ACCOUNT,AC_DEFAULT_IBAN,AM_CHEQUE_LIMIT,DT_SETTING_VALID_FROM,DT_SETTING_VALID_TO,DT_VALID_FROM,DT_VALID_TO,AC_CREATION_USER,TS_CREATION,AC_LAST_UPDATE_USER,TS_LAST_UPDATE")] ACCOUNT_SETTINGS aCCOUNT_SETTINGS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCCOUNT_SETTINGS).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(aCCOUNT_SETTINGS);
        }

        // GET: ACCOUNT_SETTINGS/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACCOUNT_SETTINGS aCCOUNT_SETTINGS = await db.ACCOUNT_SETTINGS.FindAsync(id);
            if (aCCOUNT_SETTINGS == null)
            {
                return HttpNotFound();
            }
            return View(aCCOUNT_SETTINGS);
        }

        // POST: ACCOUNT_SETTINGS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            ACCOUNT_SETTINGS aCCOUNT_SETTINGS = await db.ACCOUNT_SETTINGS.FindAsync(id);
            db.ACCOUNT_SETTINGS.Remove(aCCOUNT_SETTINGS);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
