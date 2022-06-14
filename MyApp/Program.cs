Console.Write("Ingrese una ruta: ");
string path = Console.ReadLine()!;

mostrarDirectorio(path);

void mostrarDirectorio(string path) {

  if (Directory.Exists(path)) {
      
    List<string> listadoCarpetas = Directory.GetDirectories(path).ToList();

    foreach (string carpeta in listadoCarpetas) {

      string[] carpetaAMostrar = carpeta.Split("\\");

      Console.WriteLine("/" + carpetaAMostrar[carpetaAMostrar.Length - 1]);
    };

    foreach (string carpeta in Directory.GetFiles(path)) {
      
      string[] carpetaAMostrar = carpeta.Split("\\");

      Console.WriteLine(carpetaAMostrar[carpetaAMostrar.Length - 1]);
    };
  };
};