// using Hanan_csharp_backend_teamwork.src.Abstractions;
// using Hanan_csharp_backend_teamwork.src.Entities;
// using Microsoft.EntityFrameworkCore;
// using sda_onsite_2_csharp_backend_teamwork.src.Databases;
// namespace Hanan_csharp_backend_teamwork.src.Repositories;

// public class PaymentRepository : IPaymentRepository
// {
//     private readonly DatabaseContext _context;
//     private DbSet<Payment> _payment;

//     public PaymentRepository(DatabaseContext context)
//     {
//         _context = context;
//         _payment = _context.Payments;
//     }
//     public async Task<Payment> GetByIdAsync(Guid id)
//     {
//         return await _payment.FindAsync(id);
//     }
//     public async Task<IEnumerable<Payment>> GetAllAsync()
//     {
//         return await _payment.ToListAsync();
//     }
//     public async Task AddAsync(Payment payment)
//     {
//         await _payment.AddAsync(payment);
//         await _context.SaveChangesAsync();
//     }

//     public async Task UpdateAsync(Payment payment)
//     {
//         _payment.Update(payment);
//         await _context.SaveChangesAsync();
//     }
//     public async Task DeleteAsync(Guid id)
//     {
//         var payment = await GetByIdAsync(id);
//         if (payment != null)
//         {
//             _payment.Remove(payment);
//             await _context.SaveChangesAsync();
//         }
//     }
// }

