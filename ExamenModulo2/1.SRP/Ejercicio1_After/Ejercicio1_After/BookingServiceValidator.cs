using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1_After
{
    public static class BookingServiceValidator
    {
        public static ValidationResult Validate(Booking booking)
        {
            ValidationResult result = new ValidationResult();

            if (string.IsNullOrEmpty(booking.Usuario.Name))
                result.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar un nombre.");            

            if (string.IsNullOrEmpty(booking.Usuario.Email) || !booking.Usuario.Email.Contains("@"))
                result.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar un email valido.");            

            if (booking.CheckIn.Equals(DateTime.MinValue))
                result.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar la hora de la reserva.");            

            if (booking.CheckOut.Equals(DateTime.MinValue))
                result.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar la hora de la reserva.");            

            if (booking.CheckIn > booking.CheckOut)
                result.ErrorMessage.Add("La reserva no puede ser agendada, debido a que la fecha de salida no puede ser menor a la fecha de entrada.");

            return result;
        }
    }
}
