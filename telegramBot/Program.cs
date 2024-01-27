using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;


namespace telegramBot
{
    internal class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("Ключ от бота");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            
                // Обязательно ставим блок try-catch, чтобы наш бот не "падал" в случае каких-либо ошибок
                try
                {
                    // Сразу же ставим конструкцию switch, чтобы обрабатывать приходящие Update
                    switch (update.Type)
                    {
                        case UpdateType.Message:
                            {
                                // эта переменная будет содержать в себе все связанное с сообщениями
                                var message = update.Message;

                                // From - это от кого пришло сообщение
                                var user = message.From;

                                // Выводим на экран то, что пишут нашему боту, а также небольшую информацию об отправителе
                                Console.WriteLine($"{user.FirstName} ({user.Id}) написал сообщение: {message.Text}");

                                // Chat - содержит всю информацию о чате
                                var chat = message.Chat;

                                // Добавляем проверку на тип Message
                                switch (message.Type)
                                {
                                    // Тут понятно, текстовый тип
                                    case MessageType.Text:
                                        {
                                            // тут обрабатываем команду /start, остальные аналогично
                                            if (message.Text == "/start")
                                            {
                                            // Тут все аналогично Inline клавиатуре, только меняются классы
                                            // НО! Тут потребуется дополнительно указать один параметр, чтобы
                                            // клавиатура выглядела нормально, а не как абы что
                                            #region Okrug

                                            await Region.HandleUpdateAsyncRegion(botClient,update,cancellationToken);
                                            }
                                            
                                            #endregion

                                        #region Центральный округ
                                        if (message.Text == "Центральный Федеральный округ")
                                        {
                                            var Keyboard = new ReplyKeyboardMarkup(

                                                new List<KeyboardButton[]>()
                                                {
                                                        /*
                                                        new KeyboardButton[]
                                                        {
                                                            new KeyboardButton("Привет!"),
                                                             new KeyboardButton("Пока!"),
                                                             new KeyboardButton("Пока!")

                                                        },*/

                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Москва")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Московская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Воронежская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Белгородская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Тульская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Владимирская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Тверская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Ярославская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Брянская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Липецкая область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Рязанская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Курская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Калужская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Тамбовская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Ивановская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Смоленская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Орловская область")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Костромская область")
                                                    },
                                                })
                                            {
                                                // автоматическое изменение размера клавиатуры, если не стоит true,
                                                // тогда клавиатура растягивается чуть ли не до луны,
                                                // проверить можете сами
                                                ResizeKeyboard = true,
                                            };

                                            await botClient.SendTextMessageAsync(
                                                chat.Id,
                                                "Выберете Округ для поиска",
                                                replyMarkup: Keyboard); // опять передаем клавиатуру в параметр replyMarkup

                                            return;
                                        }
                                        #endregion
                                        if (message.Text == "ываЦентральный Федеральный округ")
                                        {

                                        }
                                        if (message.Text == "ывавЦентральный Федеральный округ")
                                        {

                                        }
                                        if (message.Text == "ываывЦентральный Федеральный округ")
                                        {

                                        }
                                        if (message.Text == "ываывЦентральный Федеральный округ")
                                        {

                                        }

                                            return;
                                        }



                                    // Добавил default , чтобы показать вам разницу типов Message
                                    default:
                                        {
                                            await botClient.SendTextMessageAsync(
                                                chat.Id,
                                                "Используй только текст!");
                                            return;
                                        }
                                }

                               
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            
            /*// Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");
            }*/
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };

            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            Console.ReadLine();
        }
    }
}
