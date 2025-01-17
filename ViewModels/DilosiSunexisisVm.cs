﻿using static KKDilwseisMVC.Services.DocXService;
using System.ComponentModel.DataAnnotations;

namespace KKDilwseisMVC.ViewModels
{
    public class DilosiSunexisisVm
    {
        [Display(Name = "Τοποθεσία")]
        public string Location { get; set; }
        [Display(Name = "Συμβολαιογράφος")]
        public int Notary { get; set; }
        [Display(Name = "Ζώνη")]
        public int Zone { get; set; }
        [Display(Name = "Αριθμός")]
        public string CaseNumber { get; set; }
        [Display(Name = "Οφειλέτης")]
        public string Debtor { get; set; }
        [Display(Name = "Γένος")]
        public Gender Gender { get; set; }

        [Display(Name = "Άρθρο 966")]
        public bool Ar8ro966 { get; set; }

        [Display(Name = "Ημερομηνία Παραγγελίας")]
        public string DateOfOrder { get; set; }
        [Display(Name = "Ημερομηνία Κατάσχεσης")]
        public string DateOfConfiscation { get; set; }
        [Display(Name = "Fund")]
        public int Fund { get; set; }
    }
}
