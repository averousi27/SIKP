using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIKP.Controllers
{
    public class KontrolMahasiswa : Controller
    {
        //
        // GET: /KontrolMahasiswa/

        public ActionResult Index()
        {
            return View();
        }

        public List<Mahasiswa> ListOfMahasiswa;
        public bool CekSksTempuh (string NRP);
        public void SetFormPengajuan(string NRP, string namaMahasiswa, int sksTempuh, int idPerusahaan, string note);
        public void ViewDetailInformasiMhs(string NRP, int idKelompok);
        public void ViewHistoriMhs(string keyword);
        public void ChangePassword(string NRP); 
        public void SetFormAddMhs(string NRP, string passwordMahasiswa, int sksTempuhSaatIni);
        public bool CekUserPassword(string NRP, string passwordMahasiswa);



    }
}
