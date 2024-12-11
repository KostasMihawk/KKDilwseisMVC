using KKDilwseisMVC.Services;

namespace KKDilwseisMVC.Models
{
    public class Summary
    {
        private readonly DocXService docXManager;
        public Summary(DocXService docXService)
        {
            docXManager = docXService;
        }

        public MemoryStream CreateDilosiSunexisis(DilosiSunexisisModel model)
        {
            return docXManager.DilosiSunexisis(model);
        }
    }
}
