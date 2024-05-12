
// using Hanan_csharp_backend_teamwork.src.Abstractions;
// using Hanan_csharp_backend_teamwork.src.Entities;
// namespace Hanan_csharp_backend_teamwork.src.Services;

// public class PaymentService : IPaymentService
// {
//     private readonly IPaymentRepository _paymentRepository;
//     public PaymentService(IPaymentRepository paymentRepository)
//     {
//         _paymentRepository = paymentRepository;
//     }

//     public async Task<Payment> GetPaymentByIdAsync(Guid id)
//     {
//         return await _paymentRepository.GetByIdAsync(id);
//     }

//     public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
//     {
//         return await _paymentRepository.GetAllAsync();
//     }

//     public async Task AddPaymentAsync(Payment payment)
//     {
//         await _paymentRepository.AddAsync(payment);
//     }

//     public async Task UpdatePaymentAsync(Guid id, Payment payment)
//     {
//         var existingPayment = await _paymentRepository.GetByIdAsync(id);
//         if (existingPayment == null)
//         {
//             throw new Exception("Payment not found");
//         }
//         existingPayment.Amount = payment.Amount;
//         existingPayment.PaymentDate = payment.PaymentDate;
//         existingPayment.Status = payment.Status;
//         existingPayment.PaymentMethod = payment.PaymentMethod;
//         existingPayment.TransactionId = payment.TransactionId;
//         existingPayment.UserId = payment.UserId;

//         await _paymentRepository.UpdateAsync(existingPayment);
//     }

//     public async Task DeletePaymentAsync(Guid id)
//     {
//         await _paymentRepository.DeleteAsync(id);
//     }
// }
