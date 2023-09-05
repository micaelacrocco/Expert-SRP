using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que representa a un paciente.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Nombre del paciente.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Identificación única del paciente.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Edad del paciente.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Número de teléfono del paciente.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Constructor de la clase Patient.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        /// <exception cref="ArgumentException"></exception> <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        public Patient(string name, string id, int age, string phoneNumber)
        {
            // Utiliza el método de validación para verificar los datos al crear una instancia de paciente.
            if (IsNameValid(name) && IsIDValid(id) && IsAgeValid(age) && IsPhoneNumberValid(phoneNumber))
            {
                Name = name;
                ID = id;
                Age = age;
                PhoneNumber = phoneNumber;
            }
            else
            {
                throw new ArgumentException("Datos de paciente no válidos.");
            }
        }

        /// <summary>
        /// Método de validación para el nombre.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsNameValid(string name)
        {
            // Verifica que el nombre no sea nulo o vacío
            return !string.IsNullOrEmpty(name);
        }

        /// <summary>
        /// Método de validación para el ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool IsIDValid(string id)
        {
            return !string.IsNullOrEmpty(id);
        }

        /// <summary>
        /// Método de validación para la edad.
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static bool IsAgeValid(int age)
        {
            // Verifica que la edad sea mayor que cero
            return age > 0;
        }

        /// <summary>
        /// Método de validación para el número de teléfono.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber);
        }
    }
    // Por patron Expert, la clase Patient es la experta en conocer los datos necesarios para crear una instancia de paciente y por ello los verifica.
}
