using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que representa a un turno.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Identificador único de la cita.
        /// </summary>
        public Guid AppointmentID { get; }

        /// <summary>
        /// Fecha y hora de la cita.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Lugar de la cita médica.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Constructor de la clase Appointment.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="location"></param>
        public Appointment(DateTime date, string location)
        {
            // Genera un identificador único para la cita médica
            AppointmentID = Guid.NewGuid();

            // Utiliza el método de validación para verificar los datos al crear una instancia de cita médica
            if (IsDateValid(date) && IsLocationValid(location))
            {
                Date = date;
                Location = location;
            }
            else
            {
                throw new ArgumentException("Datos de la cita médica no válidos.");
            }
        }

        /// <summary>
        /// Método de validación para la fecha de la cita médica.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsDateValid(DateTime date)
        {
            // Verifica si la fecha está en el futuro
            return date > DateTime.Now;
        }

        /// <summary>
        /// Método de validación para la ubicación de la cita médica.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static bool IsLocationValid(string location)
        {
            return !string.IsNullOrEmpty(location);
        }
    }
}