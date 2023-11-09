namespace Examen{
    public class Clase:Alumno{
        public String? nombreClase;
        public String? horaClase;
        public String? nombreCatedratico;


        public Clase(
            String nombre, 
            String numeroCuenta, 
            String email, 
            String nombreClase, 
            String horaClase, 
            String nombreCatedratico
        ){
            this.nombre=nombre;
            this.numeroCuenta=numeroCuenta;
            this.email=email;
            this.nombreClase=nombreClase;
            this.horaClase=horaClase;
            this.nombreCatedratico=nombreCatedratico;
        }

        public void mostrarClase (){
            Console.WriteLine($@"
            Nombre Clase:       {nombreClase}
            Hora Clase:         {horaClase}
            Nombre Catedratico: {nombreCatedratico}");
        }
    }
}