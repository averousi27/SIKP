//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : SIKP
//  @ File Name : KontrolMahasiswa.cs
//  @ Date : 12/28/2014
//  @ Author : 
//
//


public class KontrolMahasiswa : KerjaPraktik{
	public List<Mahasiswa> daftarMahasiswa ;
	public bool CekSksTempuh;//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : SIKP
//  @ File Name : KerjaPraktik.cs
//  @ Date : 12/28/2014
//  @ Author : 
//
//

	
	public class KerjaPraktik {
		public int idKelompok { get; set; }
		public int kodePerusahaan { get; set; }
		public string NIP { get; set; } 
		private string namaPembimbingLapangan { get; set; }
		private string tanggalMulai {  get; set; }
		private string tanggalSelesai {  get; set; }
		private string fileSuratPengantar {  get; set; }
		private string fileSuratBalasan {  get; set; }
		private string fileLaporanKP {  get; set; }
		private string fileProposalKP {  get; set; }
		private string statusKP {  get; set; } 
	}
