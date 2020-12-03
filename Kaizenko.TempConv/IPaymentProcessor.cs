namespace Kaizenko.TempConv
{
    public interface IPaymentProcessor
    {
        bool IsPaymentMade(double price);
        void MakePayment(double amount);
        void ProcessPayment(double amount);
        double ReturnChange();
        double ReturnPayment();
    }
}