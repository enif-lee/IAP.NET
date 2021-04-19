using System.Threading.Tasks;

namespace IAP.NET.Provider
{
    public interface IPurchaseProvider<T> where T : IReceiptValidationRequest 
    {
        Task<bool> ValidationAsync(T receiptRequest);
    }
}