using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ejercicio1
{
    public class AccountService
    {
        //public string Create(string name, string email, DateTime time)
        //{
        //    StringBuilder message = new StringBuilder();
        //    bool isValid = true;
        //    message.Append($"Iniciando cita {DateTime.Now.ToLongTimeString()}.....");
        //    if (string.IsNullOrEmpty(name)) {
        //        message.Append("La cita no puede ser creada, es necesario proporcionar un nombre.");
        //        isValid = false;
        //    }
        //    if (string.IsNullOrEmpty(email) || !email.Contains('@'))
        //    {
        //        message.Append("La cita no puede ser creada, es necesario proporcionar un correo electronico valido.");
        //        isValid = false;
        //    }
        //    if (time.Equals(DateTime.MinValue)) {
        //        message.Append("La cita no puede ser creada, es necesario proporcionar una fecha.");
        //        isValid = false;
        //    }
        //    return message.ToString().Replace(".", Environment.NewLine);
        //}

        public string Create(Appointment appointment) {
            ValidationResult result = AppointmentServiceValidator.Validate(appointment);
            return result.IsValid ? 
                $"La cita ha sido agendada para el paciente {appointment.Patient.Name}" :
                string.Join(Environment.NewLine, result.ErrorMessage);
        }
    }
}
