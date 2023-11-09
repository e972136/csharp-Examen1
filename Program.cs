using Examen;

Clase clase = new Clase(
                "Master Gaspar Calix",
                "T62111106",
                "e972136@unitec.edu",
                "Prrogramacion II",
                "18:00 - 19:00",
                "Ing Roger Ivan Gurdian"
                );

clase.mostrarClase();
clase.mostrarAlumno();

int nota1;
int nota2;
int nota3;

try{
    Console.Write("Ingrese nota 1: ");
    nota1 =  Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese nota 2: ");
    nota2 =  Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese nota 3: ");
    nota3 =  Convert.ToInt32(Console.ReadLine());
}catch(Exception e){
    Console.WriteLine("Error en ingreso:\n"+e);    
    nota1 = 0;
    nota2 = 0;
    nota3 = 0;
}


Promedio promedio = new Promedio(nota1,nota2,nota3);
Console.WriteLine(promedio.mostrarPromedio(nota1,nota2,nota3));
Console.WriteLine(promedio.mostrarPromedio());

