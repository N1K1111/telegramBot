using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bots.Types;

namespace telegramBot
{
    public class Region
    {
        
        public static async Task HandleUpdateAsyncRegion(ITelegramBotClient botClient, Telegram.Bot.Types.Update update, CancellationToken cancellationToken)
        {
            var message = update.Message;
            var chat = message.Chat;
            var OkrugKeyboard = new ReplyKeyboardMarkup(

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
                                                        new KeyboardButton("Центральный Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Южный Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Северо-Западный Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Дальневосточный Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Сибирский Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Уральский Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Приволжский Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Северо-Кавказский Федеральный округ")
                                                    },
                                                    new KeyboardButton[]
                                                    {
                                                        new KeyboardButton("Крымский Федеральный округ")
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
                replyMarkup: OkrugKeyboard); // опять передаем клавиатуру в параметр replyMarkup

            return;
        }
    }
}
