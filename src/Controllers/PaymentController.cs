
// using Hanan_csharp_backend_teamwork.src.Abstractions;
// using Hanan_csharp_backend_teamwork.src.Entities;
// using Microsoft.AspNetCore.Mvc;
// using sda_onsite_2_csharp_backend_teamwork.src.Controllers;

// namespace Hanan_csharp_backend_teamwork.src.Controllers;

// public class PaymentController : BaseController
// {
//     private readonly IPaymentService _paymentService;

//     public PaymentController(IPaymentService paymentService)
//     {
//         _paymentService = paymentService;
//     }

//     [HttpGet("{id}")]
//     public async Task<ActionResult<Payment>> GetPaymentById(Guid id)
//     {
//         var payment = await _paymentService.GetPaymentByIdAsync(id);
//         if (payment == null)
//         {
//             return NotFound();
//         }
//         return payment;
//     }

//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Payment>>> GetAllPayments()
//     {
//         var payments = await _paymentService.GetAllPaymentsAsync();
//         return Ok(payments);
//     }

//     [HttpPost]
//     public async Task<ActionResult<Payment>> AddPayment(Payment payment)
//     {
//         await _paymentService.AddPaymentAsync(payment);
//         return CreatedAtAction(nameof(GetPaymentById), new { id = payment.Id }, payment);
//     }

//     [HttpPut("{id}")]
//     public async Task<IActionResult> UpdatePayment(Guid id, Payment payment)
//     {
//         if (id != payment.Id)
//         {
//             return BadRequest();
//         }

//         try
//         {
//             await _paymentService.UpdatePaymentAsync(id, payment);
//         }
//         catch (Exception)
//         {
//             return NotFound();
//         }

//         return NoContent();
//     }

//     [HttpDelete("{id}")]
//     public async Task<IActionResult> DeletePayment(Guid id)
//     {
//         await _paymentService.DeletePaymentAsync(id);
//         return NoContent();
//     }
// }
