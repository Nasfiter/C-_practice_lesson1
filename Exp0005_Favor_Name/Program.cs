// Программа по вводу имени и выбора любимого имени

 Console.Write("Введите имя пользрвателя ");
 string username = Console.ReadLine();

 if (username.ToLower() == "маша")
 {
     Console.WriteLine("Ура, это же МАША!");
 }
 else 
 {
     Console.Write("Привет ");
     Console.WriteLine(username);
 }