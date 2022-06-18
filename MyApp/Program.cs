Console.Write("Ingrese una ruta: ");
string path = Console.ReadLine()!;
string archivoCSV = Directory.GetCurrentDirectory() + "\\index.csv";

if ( !File.Exists(archivoCSV) ) {
  File.Create(archivoCSV);
};

mostrarDirectorioYGuardarContenido(path);

void mostrarDirectorioYGuardarContenido(string path) {

  if (Directory.Exists(path)) {

    StreamWriter sr = new StreamWriter(archivoCSV);

      
    List<string> listadoCarpetas = Directory.GetDirectories(path).ToList();

    Console.WriteLine("-----Carpetas-----");

    int aux = 1;

    foreach (string carpeta in listadoCarpetas) {

      string[] carpetaAMostrar = carpeta.Split("\\");
      Console.WriteLine("/" + carpetaAMostrar[carpetaAMostrar.Length - 1]);

      sr.WriteLine($"{ aux },{ carpetaAMostrar[carpetaAMostrar.Length - 1] }");

      aux++;
    };

    Console.WriteLine("-----Archivos-----");

    foreach (string archivo in Directory.GetFiles(path)) {
      
      string[] archivoAMostrar = archivo.Split("\\");
      string[] archivoArray = archivoAMostrar[archivoAMostrar.Length - 1].Split(".");
      string nombreArchivo = archivoArray[0];
      string extensionArchivo = archivoArray[archivoArray.Length - 1];

      Console.WriteLine(archivoAMostrar[archivoAMostrar.Length - 1]);

      sr.WriteLine($"{ aux },{ nombreArchivo },{ extensionArchivo }");

      aux++;
    };

    sr.Close();
  } else {
    Console.WriteLine("El directorio no existe");
  };
};