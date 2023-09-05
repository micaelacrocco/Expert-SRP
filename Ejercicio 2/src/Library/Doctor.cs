using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que representa a un doctor.
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Nombre del doctor.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Especialidad del doctor.
        /// </summary>
        public string Specialization { get; set; }

        /// <summary>
        /// Constructor de la clase Doctor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="specialization"></param>
        /// <exception cref="ArgumentException"></exception> <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="specialization"></param>
        public Doctor(string name, string specialization)
        {
            // Utiliza el método de validación para verificar los datos al crear una instancia de doctor
            if (IsNameValid(name) && IsSpecializationValid(specialization))
            {
                Name = name;
                Specialization = specialization;
            }
            else
            {
                throw new ArgumentException("Datos del doctor no válidos.");
            }
        }

        /// <summary>
        /// Método de validación para el nombre del doctor.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsNameValid(string name)
        {
            // Verifica que el nombre no sea nulo o vacío
            return !string.IsNullOrEmpty(name);
        }

        /// <summary>
        /// Método de validación para la especialización del doctor.
        /// </summary>
        /// <param name="specialization"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="specialization"></param>
        /// <returns></returns>
        public static bool IsSpecializationValid(string specialization)
        {
            return !string.IsNullOrEmpty(specialization);
        }
    }
}