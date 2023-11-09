namespace Examen{
    public abstract class Alumno{
        public String? nombre;
        public String? numeroCuenta;
        public String? email;

        public void mostrarAlumno (){
            Console.WriteLine($@"
            Nombre:             {nombre}
            Numero Cuenta:      {numeroCuenta}
            Correo:             {email}");
        }
    }
}