using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1_After
{
    public class BookingService
    {
        public string Create(Booking booking)
        {
            StringBuilder message = new StringBuilder();            
            message.Append($"Iniciando reserva {DateTime.Now.ToLongTimeString()}...");
            ValidationResult result = BookingServiceValidator.Validate(booking);
            if (result.IsValid) 
            {
                message.Append($"La cita quedo agendada para el usuario {booking.Usuario.Name}.");
            }
            else
            {
                foreach (var err in result.ErrorMessage) { 
                    message.Append(err.ToString());
                }
            }
            return message.ToString().Replace(".", Environment.NewLine);            
        }
    }
}
