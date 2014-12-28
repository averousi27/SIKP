using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIKP.Controllers
{
    public class KontrolNilaiHasilKerjaPraktik : Controller
    {
        //
        // GET: /KontrolNilaiHasilKerjaPraktik/

        public ActionResult Index()
        {
            return View();
        }

        public List<NilaiHasilKerjaPraktik> ListOfNilaiHasilKerjaPraktik;
        public void SetFormNilaiPembimbingLap(string NRP, int nilaiKegiatanPembimbing, string notePembimbing);
        public void SetFormPenilaianDosbing(string NRP, int nilaiKegiatanDosbing, string noteDosbing);
        public int TotalNilai(string NRP);
        public void UpdateNilaiMhs(string NRP);
        public NilaiHasilKerjaPraktik GetNilaiMhs(string NRP);
    }
}
