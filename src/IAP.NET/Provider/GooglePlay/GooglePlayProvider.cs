using System.Threading.Tasks;

namespace IAP.NET.Provider.GooglePlay
{
    public class GooglePlayProvider : IPurchaseProvider<GoogleReceiptValidationRequest>
    {
        private readonly GooglePlayCredential _credential;

        public GooglePlayProvider(GooglePlayCredential credential)
        {
            _credential = credential;
        }

        public Task<bool> ValidationAsync(GoogleReceiptValidationRequest receiptRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}