using AngleSharp;
using Task18._4._1.Classes;
using Task18._4._1.Receiver;
using Task18._4._1.Sender;
using YoutubeExplode;

while (true)
{ 
    Console.Clear();

    Console.WriteLine("Введите адресс ресурса: ");
    string url = Console.ReadLine();

    User user = new User();
    Youtube youtube = new Youtube(url);

    Console.WriteLine("Выбирете число:\n1 - получить информацию о видео\n2 - скачать видео\n3-выход из приложения.");

    int.TryParse(Console.ReadLine(),out int number);

    switch (number)
    {
        case 1:
            Console.Clear();
            user.SetCommand(new GetInfoCommand(youtube));
            user.Run();
            break;
        case 2:
            Console.Clear();
            user.SetCommand(new DownLoadCommand(youtube));
            user.Run();
            Console.WriteLine("Загрузка видео началась.");
            break;
        case 3:
            Console.WriteLine("Приложение закрывается.");
            return;               
        default:
            Console.WriteLine("Нет такого действия.");
            break;
    }

    Console.ReadLine();

}





//("https://www.youtube.com/watch?v=Wf-JIs6kvdg");



