using KKDilwseisMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Policy;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Zone = KKDilwseisMVC.Models.Zone;

namespace KKDilwseisMVC.Services
{
    public class DocXService
    {
        private double fontSize = 12;
        private string fontFamily = "Times new roman";
        private Formatting Formatting = new Formatting
        {
            Spacing = 1.2,
            Size = 12
        };
        public Paragraph AddToParagraph(Paragraph paragraph, string text)
        {
            paragraph.Append(text).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }
        public Paragraph AddToParagraph(Paragraph paragraph, string text, double fontSize, string fontFamily)
        {
            paragraph.Append(text).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }

        public Paragraph AddNewLine(Paragraph paragraph)
        {
            return paragraph.AppendLine();
        }

        public Paragraph AddToParagraphBoldText(Paragraph paragraph, string text)
        {
            paragraph.Append(text).Bold().FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }

        public Paragraph AddToParagraphBoldAndUnderlinedText(Paragraph paragraph, string text)
        {
            paragraph.Append(text).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }
        public Paragraph AddtoParagraphWithUnderlineText(Paragraph paragraph, string text)
        {
            paragraph.Append(text).UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }
        public Paragraph AddtoParagraphWithItalic(Paragraph paragraph, string text)
        {
            paragraph.Append(text).Italic().FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }
        private string GetCorrectMonthInFuckingGreek()
        {
            switch (DateTime.Now.Month)
            {
                case 1:
                    return "Ιανουαρίου";
                case 2:
                    return "Φεβρουαρίου";
                case 3:
                    return "Μαρτίου";
                case 4:
                    return "Απριλίου";
                case 5:
                    return "Μαϊου";
                case 6:
                    return "Ιουνίου";
                case 7:
                    return "Ιουλίου";
                case 8:
                    return "Αυγούστου";
                case 9:
                    return "Σεπτεμβρίου";
                case 10:
                    return "Οκτωβρίου";
                case 11:
                    return "Νοεμβρίου";
                case 12:
                    return "Δεκεμβρίου";
                default:
                    return "";
            }


        }
        public string EpiloghArthrouBasiGenous(Gender gender)
        {
            if (gender == Gender.Man)
                return "του ";
            else if (gender == Gender.Woman)
                return "της ";
            else
                return "της";
        }

        public string EpilogiArthrouBasiGenousGenikiPtwsh(Gender gender)
        {

            if (gender == Gender.Man)
                return "τον ";
            else if (gender == Gender.Woman)
                return "την ";
            else
                return "την";
        }

        public string EpilogiArthouOfileti(Gender gender)
        {
            if (gender == Gender.Man)
            {
                return "του οφειλέτη";
            }
            else
            {
                return "της οφειλέτιδας";
            }
        }
        public string PraxiHPinakas(bool isPinakas)
        {
            return isPinakas ? "(ΠΙΝΑΚΑΣ ΚΑΤΑΤΑΞΗΣ - ΠΡΟΣΚΛΗΣΗ ΔΑΝΕΙΣΤΩΝ)" : "(ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
        }

        public string ArthroSunexisisPlistiriasmou(bool Article)
        {
            return Article ? "966" : "973";
        }

        public enum Gender
        {
            [Display(Name = "Ανδρας")]
            Man,
            [Display(Name = "Γυναίκα")]
            Woman,
            [Display(Name = "Τράπεζα/Εταιρεία")]
            Etaireia
        }

        public DocX CreatePricingAndNameTable(DocX doc, Zone zone, bool isFusikoProswpo, bool? ZoneB)
        {
            Table t = doc.AddTable(9, 2);
            doc.MarginBottom = 0;
            doc.MarginTop = 20;

            var imagepath = "..\\KKDilwseisMVC\\eldim.png";
            t.SetColumnWidth(0, 200d);
            t.SetColumnWidth(1, 300d);
            t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
            t.Alignment = Alignment.center;

            Xceed.Document.NET.Image image = doc.AddImage(imagepath);
            var picture = image.CreatePicture();

            if (isFusikoProswpo)
            {
                t.Rows[0].Cells[0].Paragraphs.First().AppendPicture(picture).Alignment = Alignment.center;
                t.Rows[1].Cells[0].Paragraphs.First().Append("ΕΛΛΗΝΙΚΗ ΔΗΜΟΚΡΑΤΙΑ").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[2].Cells[0].Paragraphs.First().Append("ΥΠΟΥΡΓΕΙΟ ΔΙΚΑΙΟΣΥΝΗΣ").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[1].Cells[1].Paragraphs.First().Append("Η παρούσα αποτελεί φορολογικό στοιχείο και δεν απαιτείται η έκδοση άλλου παραστατικού").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[5].Cells[1].Paragraphs.First().Append("Ζώνη " + zone.Name).Font(fontFamily).Bold().Alignment = Alignment.right;
                t.Rows[6].Cells[1].Paragraphs.First().Append("Νόμιμη Αμοιβή €" + zone.Value.ToString("F")).Font(fontFamily).Bold().Alignment = Alignment.right;
                t.Rows[7].Cells[1].Paragraphs.First().Append("ΦΠΑ 24% €" + zone.Tax.ToString("F")).Font(fontFamily).Bold().Alignment = Alignment.right;
                t.Rows[8].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ €" + zone.TaxedValue.ToString("F")).Font(fontFamily).Bold().Alignment = Alignment.right;
            }
            else
            {
                t.Rows[0].Cells[0].Paragraphs.First().AppendPicture(picture).Alignment = Alignment.center;
                t.Rows[1].Cells[0].Paragraphs.First().Append("ΕΛΛΗΝΙΚΗ ΔΗΜΟΚΡΑΤΙΑ").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[2].Cells[0].Paragraphs.First().Append("ΥΠΟΥΡΓΕΙΟ ΔΙΚΑΙΟΣΥΝΗΣ").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[1].Cells[1].Paragraphs.First().Append("Η παρούσα αποτελεί φορολογικό στοιχείο και δεν απαιτείται η έκδοση άλλου παραστατικού").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[5].Cells[1].Paragraphs.First().Append("Ζώνη Α").Font(fontFamily).Bold().Alignment = Alignment.right;
                t.Rows[6].Cells[1].Paragraphs.First().Append("Νόμιμη Αμοιβή € 35.00").Font(fontFamily).Bold().Alignment = Alignment.right;
                t.Rows[7].Cells[1].Paragraphs.First().Append("ΦΠΑ 24% € 8.40").Font(fontFamily).Bold().Alignment = Alignment.right;
                t.Rows[8].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ € 43.40").Font(fontFamily).Bold().Alignment = Alignment.right;
            }
            doc.InsertTable(t);
            return doc;
        }

        public DocX AddHeaderToDocument(DocX doc, string fontFamilyCustom)
        {
            string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΕΩΣ";

            var headerFormat = new Formatting();
            headerFormat.FontFamily = new Xceed.Document.NET.Font(fontFamilyCustom ?? fontFamily);
            headerFormat.Size = 13D;
            headerFormat.Bold = true;
            //headerFormat.UnderlineStyle = UnderlineStyle.singleLine;
            headerFormat.Spacing = 1.2;
            
            Paragraph headParagraph = doc.InsertParagraph("", false, headerFormat);
            headParagraph.Alignment = Alignment.center;   
            AddNewLine(headParagraph);
            AddToParagraphBoldText(headParagraph, "ΕΚΘΕΣΗ ΕΠΙΔΟΣΕΩΣ");
            AddNewLine(headParagraph);
            AddToParagraph(headParagraph, "Αριθμός ............");

           

            return doc;
        }

        

        public DocXHelper CreateIntroParagraphDilosiSunexisis(DocX doc, string location, string locationUpiresias, bool isFusikoProsopo, string DateOfConfiscation, string NotaryDescription, string DateOfOrder, string NotaryName, string NotaryCity, string NotaryPronoun)
        {
            Paragraph introParagraph = doc.InsertParagraph("", false, Formatting);
            introParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            introParagraph.Alignment = Alignment.both;
            AddNewLine(introParagraph);
            if (isFusikoProsopo)
            {
                AddToParagraph(introParagraph, $"{location} Κέρκυρας, σήμερα στις ...................................... ");
            }
            else
            {
                AddToParagraph(introParagraph, $"Στην πόλη της Κέρκυρας, σήμερα στις ...................................... ");
            }
            AddToParagraph(introParagraph, "(     ) του μηνός " + GetCorrectMonthInFuckingGreek() + " του έτους δύο χιλιάδες είκοσι τέσσερα (2024), ημέρα .......................................... και ώρα ........");
            AddToParagraph(introParagraph, ", εγώ η Δικαστική Επιμελήτρια της περιφέρειας του Εφετείου Κέρκυρας, με έδρα το Πρωτοδικείο Κέρκυρας, ................................, ΑΦΜ ................., κάτοικος Κέρκυρας, οδός Μ. Μεθοδίου αρ. 3, μετά από έγγραφη παραγγελία ");
            AddToParagraph(introParagraph, "που μου δόθηκε στις ");
            AddToParagraphBoldText(introParagraph, DateOfOrder);
            AddToParagraph(introParagraph, " από " + ProNounChange(NotaryPronoun) + " Συμβολαιογράφο " + NotaryCity + " ");
            AddToParagraphBoldText(introParagraph, NotaryName + " ");
            AddToParagraph(introParagraph, NotaryDescription + " ως υπάλληλο του πλειστηριασμού, ");
            return new DocXHelper() { doc = doc, p = introParagraph };
        }

        public DocXHelper EpispeudonParagraphDilosi(DocXHelper helper,bool isFusikoProsopo, Gender gender, string ofeileths, string upiresia, string location, string article)
        {
            if (isFusikoProsopo)
            {
                AddToParagraph(helper.p, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldText(helper.p, $"προς {EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeileths},");
            }
            else
            {
                AddToParagraph(helper.p, $"ήλθα για να επιδώσω ");
                AddToParagraph(helper.p, article);
                AddToParagraphBoldText(helper.p, $" {upiresia}");
                AddToParagraph(helper.p, $" {location}, και εκπροσωπείται νόμιμα,");
            }
            AddToParagraph(helper.p, " προς γνώση και για τις νόμιμες συνέπειες, ");
            return new DocXHelper() { doc = helper.doc, p = helper.p };
        }

        public DocXHelper ParagraphAkrivesAdigrafoDilosi(DocXHelper helper, Gender gender, string documentNumber, string sumbolaiografos, string ofeileths, bool Article, string DateOfConfiscation, string FundName, string FundDesc, string MaedapName, string MaedapAdress, string NotaryPronoun)
        {
            
            AddToParagraph(helper.p, $"ακριβές επικυρωμένο αντίγραφο της υπ΄ αριθμόν");
            AddToParagraphBoldText(helper.p, $" {documentNumber} ΠΡΑΞΗΣ ΔΗΛΩΣΗΣ-ΕΝΤΟΛΗΣ ΣΥΝΕΧΙΣΗΣ ΠΛΕΙΣΤΗΡΙΑΣΜΟΥ ΚΑΤΑ ΤΟ ΑΡΘΡΟ " + ArthroSunexisisPlistiriasmou(Article) + " ΤΟΥ Κ.ΠΟΛ.Δ.,");
            AddToParagraph(helper.p, $" των πράξεων {NotaryPronoun} ως άνω Συμβολαιογράφου, για πλειστηριασμό που θα διενεργηθεί στις ");
            AddToParagraphBoldAndUnderlinedText(helper.p, DateOfConfiscation);
            AddToParagraph(helper.p, " επισπευδόμενης από την εταιρεία ειδικού σκοπού τιτλοποίησης με την επωνυμία ");
            AddToParagraphBoldText(helper.p, "«" + FundName + "»");
            AddToParagraph(helper.p, " , " + FundDesc + ", επ' ονόματι και για λογαριασμό της οποίας ενεργεί η εταιρεία με την επωνυμία ");
            AddToParagraphBoldText(helper.p, "«" + MaedapName + "»");
            AddToParagraph(helper.p, " η οποία εδρεύει " + MaedapAdress + " όπως εκπροσωπείται νόμιμα,");
            AddToParagraph(helper.p, " κατά " + EpilogiArthouOfileti(gender) + " ");
            AddToParagraphBoldText(helper.p, ofeileths);
            AddToParagraph(helper.p, ".");
            return new DocXHelper() { doc = helper.doc, p = helper.p };
        }

        public DocX ParagrafosPraxis(DocX doc, bool? isPraxi, string keimenoPraxis)
        {

            if (isPraxi == true)
            {
                Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
                paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                paragraph.Alignment = Alignment.both;
                AddToParagraph(paragraph, keimenoPraxis);
                if (string.IsNullOrEmpty(keimenoPraxis))
                {
                    AddNewLine(paragraph);
                    AddNewLine(paragraph);
                    AddNewLine(paragraph);
                }
                return doc;
            }
            else 
            {                
                return doc;
            }
            

        }

        public DocX ParagrafosSuntaxisEkthesis(DocX doc)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddToParagraph(paragraph, $"Σε ένδειξη των παραπάνω συντάχθηκε η παρούσα σε δύο πρωτότυπα και αφού διαβάστηκε και βεβαιώθηκε υπογράφεται το περιεχόμενό της, υπογράφεται νόμιμα όπως ακολουθεί");
            return doc;
        }

        public DocX ParagrafosUpografis(DocX doc, bool? isPraxi, bool isFusikoProsopo, Signature signature)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddNewLine(paragraph);
            switch (signature)
            {
                case Signature.paralavon:
                    AddToParagraph(paragraph, $".. παραλαβ.....                                             η Δικαστική Επιμελήτρια ");
                    break;
                case Signature.paredros:
                    AddToParagraph(paragraph, $".. παραλαβ..... Πάρεδρος                                            η Δικαστική Επιμελήτρια ");
                    break;
                case Signature.ypallilos:
                    AddToParagraph(paragraph, $".. παραλαβ..... εξουσιοδοτημεν.... Υπάλληλος                       η Δικαστική Επιμελήτρια ");
                    break;
                case Signature.genericMartyras:
                    AddToParagraph(paragraph, $".. .....αρ...........                                                                     η Δικαστική Επιμελήτρια ");
                    break;
                default:
                    break;
            }
            return doc;
        }
        private string ProNounChange(string pronoun)
        {
            if (pronoun == "της") return "την";
            else if (pronoun == "του") return "τον";
            else return pronoun;

        }


        public MemoryStream DilosiSunexisis(DilosiSunexisisModel model)
        {
            using (DocX doc = DocX.Create(String.Format(model.Debtor + ".docx", DateTime.Now)))
            {
                CreatePricingAndNameTable(doc, model.Zone, model.IsFusikoProsopo, model.ZoneB);
                AddHeaderToDocument(doc, null);
                var helper = CreateIntroParagraphDilosiSunexisis(doc, model.Location, model.Address, model.IsFusikoProsopo, model.DateOfConfiscation, model.Notary.Description, model.DateOfOrder, model.Notary.Name, model.Notary.City, model.Notary.Pronoun);
                EpispeudonParagraphDilosi(helper, model.IsFusikoProsopo, model.Gender, model.Debtor, model.Upiresia, model.LocationUpiresias, model.Ar8roUpiresias);
                ParagraphAkrivesAdigrafoDilosi(helper, model.Gender, model.CaseNumber, model.Notary.Name, model.Debtor, model.Ar8ro966, model.DateOfConfiscation, model.Fund.Name, model.Fund.Description, model.Fund.MAEDAP, model.Fund.MAEDAPAdress, model.Notary.Pronoun);
                ParagrafosPraxis(helper.doc, model.PraxiUpiresias, model.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, model.PraxiUpiresias, model.IsFusikoProsopo, model.Signature); 
                return CreateAndReturnDocAsMemoryStream(doc);
            }

        }

        public MemoryStream CreateAndReturnDocAsMemoryStream(DocX doc)
        {
            var ms = new MemoryStream();
            doc.SaveAs(ms);
            ms.Position = 0;
            return ms;
        }
    }
}
