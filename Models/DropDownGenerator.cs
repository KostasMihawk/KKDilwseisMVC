namespace KKDilwseisMVC.Models
{
    public class DropDownGenerator
    {
        public List<Baillif> GetBaillifs()
        {
            var id = 1;
            var list = new List<Baillif>();
            return list;
        }

        //public List<Attorney> GetNotaries()
        //{
        //    var id = 1;
        //    var list = new List<Attorney>();
        //    list.Add(new Attorney
        //    {
        //        Id = id++,
        //        Name = "Ανδριανοπούλου Δήμητρας",
        //        City = "Αθήνας",
        //        Pronoun = "της",
        //        Description = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας, κάτοικο Αθηνών οδός Ακαδημίας, αριθμός 41 με Α.Φ.Μ. 055298233, Δ.Ο.Υ. ΚΕ.ΦΟ.ΔΕ. Αθηνών",
        //        GiaSunexisi = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας "
        //    });
        //    return list;
        //}

        public List<Attorney> GetNotariesNew()
        {
            var id = 1;
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Δήμητρα Ν. Ανδριανοπούλου",
                City = "Αθηνών",
                Pronoun = "της",
                Description = "κάτοικο Αθηνών οδός Ακαδημίας 41,",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας "
            });

            return list;
        }

        public List<Fund> GetFunds()
        {
            var id = 1;
            var list = new List<Fund>();
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY I FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "FRONTIER ISSUER DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });

            list.Add(new Fund
            {
                Id = id++,
                Name = "CAIRO 2 FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "CAIRO 1 FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "POSEIDON DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GRAMILTON DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "MEXICO FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY II FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY III FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY IV FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GEMINI CORE SECURITISATION DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "HOIST FINANCE AB",
                Description = "με έδρα τη Στοκχολμη Σουηδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "Poseidon Financial Investor Designated Activity Company",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "SYMBOL INVESTMENT NPLCo DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "SUNRISE I NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                //todo need to fix e8niki since it is not a fund
                Id = id++,
                Name = "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ",
                Description = "",
                MAEDAP = "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.",
                MAEDAPAdress = "που εδρεύει στην Αθήνα, οδός Αιόλου αρ. 86 με Α.Φ.Μ.: 094014201 Δ.Ο.Υ. ΦΑΕ Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "VEGA I NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "VEGA II NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "VEGA III NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "PHOENIX NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "PILLAR FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μαρούσι Αττικής, επί της Λεωφόρου Κηφισίας αριθ. 66, με ΑΦΜ 800858891  της Δ.Ο.Υ. ΦΑΕ Αθηνών και με αριθ. ΓΕΜΗ 143190101000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "ORION X SECURITISATION DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "COSMOS SECURITISATION DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            return list;
        }

        public List<Zone> GetZones()
        {
            var list = new List<Zone>();
            list.Add(new Zone
            {
                Id = 1,
                Name = "Α",
                Value = 35d,
                Tax = 8.40d,
                TaxedValue = 43.40d
            });
            list.Add(new Zone
            {
                Id = 2,
                Name = "Β",
                Value = 55d,
                Tax = 13.2d,
                TaxedValue = 68.2d
            });
            list.Add(new Zone
            {
                Id = 3,
                Name = "Γ",
                Value = 73d,
                Tax = 17.52d,
                TaxedValue = 90.52d
            });
            list.Add(new Zone
            {
                Id = 4,
                Name = "Δ",
                Value = 95,
                Tax = 22.8d,
                TaxedValue = 117.8d
            });
            list.Add(new Zone
            {
                Id = 5,
                Name = "Α20",
                Value = 28,
                Tax = 6.72d,
                TaxedValue = 34.72d
            });
            list.Add(new Zone
            {
                Id = 6,
                Name = "Β20",
                Value = 44d,
                Tax = 10.56d,
                TaxedValue = 54.56d
            });
            list.Add(new Zone
            {
                Id = 7,
                Name = "Γ20",
                Value = 58.4d,
                Tax = 14.02d,
                TaxedValue = 72.42d
            });
            list.Add(new Zone
            {
                Id = 8,
                Name = "Δ20",
                Value = 76d,
                Tax = 18.24d,
                TaxedValue = 94.24d
            });
            return list;
        }

        public List<EkthesiEpidoshsModel> GetZipFiles()
        {
            var list = new List<EkthesiEpidoshsModel>();
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "που εδρεύει στην ΚΕΡΚΥΡΑ οδός ΕΘΝ. ΑΝΤΙΣΤΑΣΕΩΣ αρ. 1",
                Name = "ΤΕΛΩΝΕΙΟ",
                Perigrafh = "ΤΕΛΩΝΕΙΟ ΚΕΡΚΥΡΑΣ,",
                Ar8ro = "στο",
                Praxh = false,
                FusikoProswpo = false,
                Signature = Signature.genericMartyras,
                HasKleisimo = Kleisimo.denExei
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "που εδρεύει στην ΚΕΡΚΥΡΑ 7Η ΠΑΡ. Ι. ΘΕΟΤΟΚΗ",
                Name = "ΕΦΚΑ",
                Perigrafh = "ΗΛΕΚΤΡΟΝΙΚΟ ΕΘΝΙΚΟ ΦΟΡΕΑ ΚΟΙΝΩΝΙΚΗΣ ΑΣΦΑΛΙΣΗΣ (e-ΕΦΚΑ) ΤΟΠΙΚΗ ΔΙΕΥΘΥΝΣΗ ΚΕΡΚΥΡΑΣ,",
                Ar8ro = "στον",
                Praxh = false,
                FusikoProswpo = false,
                Signature = Signature.genericMartyras,
                HasKleisimo = Kleisimo.denExei
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "που εδρεύει στην ΚΕΡΚΥΡΑ οδός ΣΑΜΑΡΑ αρ. 13",
                Name = "ΔΟΥ",
                Perigrafh = "Δ.Ο.Υ. ΚΕΡΚΥΡΑΣ,",
                Ar8ro = "στην",
                Praxh = false,
                FusikoProswpo = false,
                Signature = Signature.genericMartyras,
                HasKleisimo = Kleisimo.denExei
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "",
                Name = "Οφειλέτης",
                Perigrafh = "προς τον ",
                Praxh = true,
                HasKleisimo = Kleisimo.MegaloKeno,
                Signature = Signature.genericMartyras,
                FusikoProswpo = true
            });
            return list;
        }
    }
}

