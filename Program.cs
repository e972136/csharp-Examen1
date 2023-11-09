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

Promedio promedio = new Promedio(100,65,35);
Console.WriteLine(promedio.calcularPromedio());