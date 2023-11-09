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

Console.Write("Ingrese nota 1: ");
int nota1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese nota 2: ");
int nota2 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese nota 3: ");
int nota3 =  Convert.ToInt32(Console.ReadLine());

Promedio promedio = new Promedio(nota1,nota2,nota3);
Console.WriteLine(promedio.mostrarPromedio(nota1,nota2,nota3));
Console.WriteLine(promedio.mostrarPromedio());

