using WorkingWithFiles.Entities;

string sourcePath = @"C:\Users\jpoli\source\repos\CSharpBasico\WorkingWithFiles\file1.txt";
string targetPath = @"C:\Users\jpoli\source\repos\CSharpBasico\WorkingWithFiles\file2.txt";

#region FileInfo
//try
//{
//    FileInfo fileInfo = new(sourcePath);
//    fileInfo.CopyTo(targetPath);

//    string[] lines = File.ReadAllLines(sourcePath);

//    foreach (string line in lines)
//    {
//        Console.WriteLine(line);
//    }

//}catch (IOException ex)
//{
//    Console.WriteLine("An error occurred");
//    Console.WriteLine(ex.Message);
//}
#endregion
#region FileStream and StreamReader
//try
//{
//    using (StreamReader sr = File.OpenText(sourcePath))
//    {
//        while (!sr.EndOfStream)
//        {
//            string line = sr.ReadLine();
//            Console.WriteLine(line);
//        }
//    }
//}
//catch (IOException ex)
//{
//    Console.WriteLine("An error accurred");
//    Console.WriteLine(ex.Message);
//}
#endregion
#region StreamWriter
//try
//{
//    string[] lines = File.ReadAllLines(sourcePath);
//    using StreamWriter sw = File.AppendText(targetPath);
//    foreach (string line in lines)
//    {
//        sw.WriteLine(line.ToUpper());
//    }
//}
//catch (IOException ex)
//{

//    Console.WriteLine("An error occurred");
//    Console.WriteLine(ex.Message);
//}
#endregion
#region Directory and DirectoryInfo
//string path = @"C:\Users\jpoli\source\repos\CSharpBasico\WorkingWithFiles\myfolder";

//try
//{
//    //Lista Pastas
//    var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

//    Console.WriteLine("Folders:");
//    foreach (string s in folder)
//    {
//        Console.WriteLine(s);
//    }

//    //Lista arquivos
//    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

//    Console.WriteLine("Files:");
//    foreach (string s in files)
//    {
//        Console.WriteLine(s);
//    }

//    //Cria uma pasta
//    Directory.CreateDirectory(path + @"\newfolder");
//}
//catch (IOException ex)
//{

//    Console.WriteLine("An error occurred");
//    Console.WriteLine(ex.Message);
//}
#endregion
#region Path
//string path = @"C:\Users\jpoli\source\repos\CSharpBasico\WorkingWithFiles\file1.txt";
//Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
//Console.WriteLine("PathSeparator: " + Path.PathSeparator);
//Console.WriteLine("GetTempPath: " + Path.GetTempPath());
//Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
//Console.WriteLine("GetFileName: " + Path.GetFileName(path));
//Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
//Console.WriteLine("GetExtension: " + Path.GetExtension(path));
//Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
#endregion

#region csv Working
string listEmployees = @"C:\Users\jpoli\source\repos\CSharpBasico\WorkingWithFiles\employees.txt";
try
{
    using StreamReader sr = new(listEmployees);
    List<Employee> list = new();

    while (!sr.EndOfStream)
    {
        list.Add(new Employee(sr.ReadLine()));
    }

    list.Sort();

    foreach (Employee emp in list)
    {
        Console.WriteLine(emp);
    }
}
catch (IOException e)
{

    Console.WriteLine("Error");
    Console.WriteLine(e.Message);
}
#endregion