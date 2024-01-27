using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telegramBot
{
    internal class Cities
    {
        public List<string> citi = new List<string>();
        
        Cities()
        {
            citi.AddRange(cities);
        }
        string[] cities = 
        {
            "Москва",
            "СанктПетербург",
            "Ростов",
            "НижнийНовгород",
            "Саратов",
            "Воронеж",
            "Тула",
            "Рязань",
            "Чехов",
            "Троцк",
            "Подольск",
            "Одинцово",
            "Голицино",
            "Звенигород",
            "Истра",
            "Калуга",
            "Коломна"
        };
    }

    enum City
    {
        Москва,
        СанктПетербург,
        Ростов,
        НижнийНовгород,
        Саратов,
        Воронеж,
        Тула,
        Рязань,
        Чехов,
        Троцк,
        Подольск,
        Одинцово,
        Голицино,
        Звенигород,
        Истра,
        Калуга,
        Коломна,

    }
}
