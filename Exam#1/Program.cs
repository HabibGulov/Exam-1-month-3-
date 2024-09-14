#region Task#1
// string path = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFile.txt";
// using (File.Create(path))
// {

// }
// string text = " Hello!";
// File.WriteAllText(path, text);
// File.Delete(path);
#endregion

#region Task#2
// using System.Text.Json;

// string path = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\JsonFile.json";

// string text = File.ReadAllText(path);
// Person person = JsonSerializer.Deserialize<Person>(text)!;
// person.Name="Someine";

// string newtext = JsonSerializer.Serialize(person);
// File.WriteAllText(path, newtext);
#endregion

#region Task#3

// string path = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder";
// Directory.CreateDirectory(path);
// string filePath1 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile1.txt";
// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";
// string filePath3 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile3.txt";
// File.Create(filePath1);
// File.Create(filePath2);
// File.Create(filePath3);
// string[] files = Directory.GetFiles(path);
// foreach(string file in files)
// {
//     System.Console.WriteLine(file);
// }

// Directory.Delete(path, true); удаления папки в котором есть файлы

#endregion

#region Task#4

// using System.IO.Compression;

// string path = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder";
// string pathZip = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder.zip";
// string[] strings = Directory.GetFiles(path);
// ZipFile.CreateFromDirectory(path, pathZip);

#endregion

#region  Task#5

// string path = @"C:\Users\HP\OneDrive\";
// string[] files = Directory.GetFiles(path, "MyFile*", SearchOption.AllDirectories);
// foreach(string file in files)
// {
//     System.Console.WriteLine(file);
// }

#endregion

#region Task#6

// string filePath1 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile1.txt";
// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";

// // System.Console.WriteLine(File.Equals(filePath1, filePath2)); 
// string fileInfo1 = File.ReadAllText(filePath1);
// string fileInfo2 = File.ReadAllText(filePath2);
// if(fileInfo1==fileInfo2)
// {
//     System.Console.WriteLine(true);
// }
// else
// {
//     System.Console.WriteLine(false);
// }

#endregion

#region Task#7

// string filePath1 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile1.txt";
// string text = File.ReadAllText(filePath1);
// System.Console.WriteLine(text);

#endregion

#region Task#8

// string filePath = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile1.txt";
// string renamedfilePath = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\RenamedMyFile1.txt";

// File.Copy(filePath, renamedfilePath);
// File.Delete(filePath);

#endregion

#region Task#9

// string folderPath = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\";
// // string newfolderPath = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyNewFolder\My";
// string[] files = Directory.GetFiles(folderPath, "*");
// for (int i = 0; i < files.Length; i++)
// {
//     string newfolderPath = $@"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyNewFolder\MyFile{i}.txt";
//     File.Copy(files[i], newfolderPath);
// }

#endregion

#region Task #10

// using System.Text.Json;

// Person person = new Person();
// person.Id=3;
// person.Name="Ali";
// string jsonFormat = JsonSerializer.Serialize(person);

// string filePath3 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile3.txt";
// File.WriteAllText(filePath3, jsonFormat);

// string receivedText = File.ReadAllText(filePath3);
// Person person1 = JsonSerializer.Deserialize<Person>(receivedText)!;
// System.Console.WriteLine(person1.Id);

#endregion

#region Task#11

// string path = @"C:\Users\HP\OneDrive\";
// // bool isExist = File.Exists(path);
// string searchedFile = "MyFile2.txt";
// try
// {
//     string[] strings = Directory.GetFiles(path, searchedFile, SearchOption.AllDirectories);
//     if (strings[0] != null)
//     {
//         System.Console.WriteLine(true);
//     }
//     else
//     {
//         System.Console.WriteLine(false);
//     }
// }
// catch//(Exception ex)//
// {
//     // System.Console.WriteLine(ex.Message);
//     System.Console.WriteLine(false);
// }

#endregion

#region Task#12

// string path = @"C:\Users\HP\OneDrive\";
// string[] allFilesAndDirectories = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
// foreach(string i in allFilesAndDirectories)
// {
//     System.Console.WriteLine(i);
// }

#endregion

#region  Task#13

// string path = @"C:\Users\HP\OneDrive\Рабочий стол\";
// string[] files = Directory.GetFiles(path, "*.log", SearchOption.AllDirectories);
// foreach(string file in files)
// {
//     File.Delete(file);
// }

#endregion

#region Task#14

// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";
// string text = File.ReadAllText(filePath2);
// string newText = text.ToUpper();
// File.WriteAllText(filePath2, newText);

#endregion

#region Task#15

// using System.IO.Compression;

// string filePath4 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyNewFolder2";
// string pathZip = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder.zip";
// Directory.CreateDirectory(filePath4);
// ZipFile.ExtractToDirectory(pathZip, filePath4);

#endregion

#region Task#16

// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";
// FileInfo fileInfo = new FileInfo(filePath2);
// System.Console.WriteLine(fileInfo.Length);

#endregion

#region Task#17

// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";
// FileInfo fileInfo = new FileInfo(filePath2);
// System.Console.WriteLine("Последний доступ"+fileInfo.LastAccessTime);
// System.Console.WriteLine("Последнее добавление текста"+fileInfo.LastWriteTime);

#endregion

#region Task#18

// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";
// string anotherFilePath = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyNewFolder\MyFile2.txt";
// File.Move(filePath2, anotherFilePath);

#endregion

#region Task#19

// string filePath2 = @"C:\Users\HP\OneDrive\Рабочий стол\Exam#1(month#3)\MyFolder\MyFile2.txt";
// using(FileStream file = new FileStream(filePath2, FileMode.OpenOrCreate))
// {
//     string text = "Hello";
//     file.Write(text);
// }                                  не смог конвертировать в байт.

#endregion

#region Task#20

// string path = @"C:\Users\HP\OneDrive\";
// string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
// foreach(string file in files)
// {
//     System.Console.WriteLine(file);
// }

#endregion