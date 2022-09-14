using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Login
{
    public class inputClient
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //get dijalankan ketika username, password dari client terbaca 
        //set dijalankan ketika ada vale baru 
    }
    class Client
    {
        static void Main()
        {
            inputClient client = new inputClient();

            //client input username 
            Console.WriteLine("Username : ");
            client.Username = Console.ReadLine();

            //client input password  
            Console.WriteLine("Password : ");
            client.Password = Console.ReadLine();

            //membaca panjang karakter username yang diinputkan 
            Console.WriteLine("Panjang Username : ");
            Console.WriteLine(client.Username.Length);

            //membaca panjang karakter password yang diinputkan 
            Console.WriteLine("Panjang Password : ");
            Console.WriteLine(client.Password.Length);
            Console.ReadLine();

            //mengkonversi object inputan dari client menjadi string 
            Console.WriteLine("Serialize: ");
            string jsonString = JsonSerializer.Serialize(client);
            Console.WriteLine(jsonString);
            Console.ReadLine();

            StreamWriter sw = new StreamWriter("D:\\file.json");
            sw.WriteLine(jsonString);
            sw.Close();

            string fileName = "D:\\file.json";
            string json = File.ReadAllText(fileName);
            inputClient client2 = JsonSerializer.Deserialize<inputClient>(json);
            Console.WriteLine($"username: {client2.Username}");
            Console.WriteLine($"Password: {client2.Password}");

        }
    }
}