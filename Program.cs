using System.Linq;
using Module14.Modules;

namespace Module14
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>
            {
                new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
                new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };

            var sortedPhoneBook = phoneBook.OrderBy(x => x.Name).ThenBy(x => x.LastName);
            int contactCountOnPage = 2; //Кол-во контактов на странице
            int phoneBookPages = sortedPhoneBook.Count() / contactCountOnPage; //Кол-во страниц

            while (true)
            {
                Console.WriteLine("Введите нужную вам страницу телефонной книги: ");
                var isInputValid = Int32.TryParse(Console.ReadLine(),out int input);

                if (isInputValid && input <= phoneBookPages)
                {
                    var result = sortedPhoneBook.Skip((input - 1) * contactCountOnPage).Take(contactCountOnPage);

                    Console.WriteLine($"На {input} странице контактов : ");
                    foreach (var contact in result)
                        Console.WriteLine($"{contact.Name} {contact.LastName}. Телефон - {contact.PhoneNumber}. Email - {contact.Email}");
                    Console.WriteLine();
                }
                else
                    Console.WriteLine($"Вы выбрали несуществующую страницу (всего страниц {phoneBookPages}) или ввели некорректное значение");
            }


        }


    }
}