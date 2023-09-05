using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);
            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);*/
            Patient patient1 = new Patient("Steven Johnson", "986782342", 35, "5555-555-555");

            Doctor doctor1 = new Doctor("Armand", "Cardiologist");

            Appointment appointment1 = new Appointment(DateTime.Now, "Wall Street");

            string appointmentResult1 = AppointmentService.CreateAppointment(patient1, doctor1, appointment1);
            Console.WriteLine(appointmentResult1);

        }
    }
}
