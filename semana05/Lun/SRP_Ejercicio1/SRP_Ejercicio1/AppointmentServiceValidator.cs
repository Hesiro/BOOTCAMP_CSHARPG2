using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ejercicio1
{
    public static class AppointmentServiceValidator
    {
        public static ValidationResult Validate(Appointment appointment) { 
            ValidationResult result = new ValidationResult();
            if (string.IsNullOrEmpty(appointment.Patient.Name)) {
                result.ErrorMessage.Add("La cita no puede ser creada, es necesario proporcionar un nombre.");
            }
            if (appointment.Time.Equals(DateTime.MinValue))
            {
                result.ErrorMessage.Add("La cita no puede ser creada, es necesario proporcionar una fecha correcta.");
            }
            if (string.IsNullOrEmpty(appointment.Patient.Email))
            {
                result.ErrorMessage.Add("La cita no puede ser creada, es necesario proporcionar un correo electronico correcto.");
            }
            return result;
        }
    }
}
