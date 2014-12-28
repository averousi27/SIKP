using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIKP.Controllers
{
    public class KontrolPegawai : Controller
    {
        //
        // GET: /KontrolPegawai/

        public ActionResult Index()
        {
            return View();
        }

        public List<Pegawai> ListOfPegawai;
        public void SetFormAddPegawai(string NIP, string namaPegawai, string jabatanPegawai, string passwordPegawai);
        public void UpdateFormPegawai(string NIP);
        public Pegawai GetUserInfo(string NIP);
        public void SetFormAddPembimbingLap(string NIP, string namaPegawai, string jabatanPegawai, string passwordPegawai);
        public void ViewMhsBimbinganLap(string NIP);
       }
}
