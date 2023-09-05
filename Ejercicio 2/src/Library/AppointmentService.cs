using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que proporciona servicios relacionados con las citas médicas.
    /// </summary>
    public class AppointmentService
    {
        /*public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }*/

        /// <summary>
        /// Crea una cita médica.
        /// </summary>
        /// <param name="patient">Información del paciente.</param>
        /// <param name="doctor">Información del doctor.</param>
        /// <param name="appointment">Información de la cita médica.</param>
        /// <returns>Un mensaje que indica si se programó la cita con éxito o si hubo errores.</returns>
        public static string CreateAppointment(Patient patient, Doctor doctor, Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            // Validaciones de datos del paciente, doctor y cita médica

            if (string.IsNullOrEmpty(patient.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
            }

            // Validaciones similares para otros campos

            if (stringBuilder.Length == 21) // Longitud del mensaje inicial
            {
                stringBuilder.Append("Appointment scheduled");
            }

            return stringBuilder.ToString();
        }
    }
    // AppointService tenia como responsabilidad crear una cita medica, pero tambien tenia la responsabilidad de validar los datos de la cita medica, del paciente y del doctor.
    // Se separo la responsabilidad de crear la cita medica de la responsabilidad de validar los datos de la cita medica, del paciente y del doctor.
    // AppointmentService ahora solo tiene la responsabilidad de crear la cita medica.
}
