using System;

namespace princUnicaResponsabilidad
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string direccion;
        public string correoElectronico;
    }

    public class EmailService
    {
        public void EnviarCorreoElectronico(string mensaje)
        {
            // Lógica para enviar correo electrónico
        }
    }

    public class ImprimirPersona
    {
        private Persona persona;

        public ImprimirPersona(Persona persona)
        {
            this.persona = persona;
        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.WriteLine($"Edad: {persona.edad}");
            Console.WriteLine($"Dirección: {persona.direccion}");
            Console.WriteLine($"Correo electrónico: {persona.correoElectronico}");
        }
    }

}
