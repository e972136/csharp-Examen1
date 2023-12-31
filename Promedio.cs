namespace Examen{

    public class Promedio:PromedioInterfaz{

        int nota1;
        int nota2;
        int nota3;

        public Promedio(int nota1,int nota2,int nota3){
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;            
        }

        public String mostrarPromedio()
        { 
            return $"Promedio utilizando el metodo calculandoPromedio sin parametros {calcularPromedio()}%";
        }
        
        public String mostrarPromedio(int nota1, int nota2, int nota3)
        { 
            return $"Promedio utilizando el metodo calculandoPromedio con parametros {calcularPromedio(nota1,nota2,nota3)}%";
        }

        public double calcularPromedio()
        {
            double s = (nota1+nota2+nota3)/3.0;
            return s;
        }

        
        public double calcularPromedio(int nota1, int nota2, int nota3)
        {
            double s = (nota1+nota2+nota3)/3.0;
            return s;
        }
    }
}