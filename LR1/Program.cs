
using LR1;
using System;


Console.WriteLine("Для выхода нажмите esc, для продолжения enter");
String RUstr1 = "Однажды весною, в час небывало жаркого заката, в Москве, на Патриарших прудах, появились два гражданина.";
String RUstr2 = "Первый из них, одетый в летнюю серенькую пару, был маленького роста, упитан, лыс, свою приличную шляпу пирожком нес в руке, а на хорошо выбритом лице его помещались сверхъестественных размеров очки в черной роговой оправе.";
String RUstr3 = "Второй – плечистый, рыжеватый, вихрастый молодой человек в заломленной на затылок клетчатой кепке – был в ковбойке, жеваных белых брюках и в черных тапочках.";
String[] textsRU = new[] { RUstr1, RUstr2, RUstr3 };

String ENstr1 = "One spring, at the hour of an unprecedented hot sunset, two citizens appeared in Moscow, on the Patriarch's Ponds.";
String ENstr2 = "The first of them, dressed in a summer gray pair, was short, well-fed, bald, carried his decent hat like a pie in his hand, and on his well-shaven face there were supernatural-sized glasses with black horn rims.";
String ENstr3 = "The second – a broad–shouldered, reddish-haired, curly-haired young man with a checkered cap twisted on the back of his head - was wearing a cowboy shirt, chewed white trousers and black slippers.";
String[] textsEN = new[] { ENstr1, ENstr2, ENstr3 };


Random rnd = new Random();

var dictionary = new Dictionary<Languages, string[]>();
dictionary.Add(Languages.RU, textsRU);
dictionary.Add(Languages.EN, textsEN);

bool b = false;
Languages leng = Languages.RU; ;


while (!b)
{
    Console.WriteLine("Выберете язык ввода: RU/EN");
    b = Enum.TryParse(Console.ReadLine(), out leng);
}

OverallResults overallResults = new OverallResults();


do
{
    Result result = new Result();
    result.text_number = rnd.Next(dictionary[leng].Length);
    Console.WriteLine(dictionary[leng][result.text_number]);

    DateTime startedAt = DateTime.Now;
    String? r_str = Console.ReadLine();

    result.span = DateTime.Now - startedAt;
    if (r_str != null)
    {
        result.errors = Result.Diff(dictionary[leng][result.text_number], r_str);

    }
    result.CalcSpeed(r_str);
    overallResults.ResultList?.Add(result);
    Console.WriteLine("время: " + result.span);
    Console.WriteLine("количество ошибок: " + result.errors);
    Console.WriteLine("скорость: " + result.speed);

    Console.WriteLine("еще раз? (да - enter, нет - esc)");

} while (Console.ReadKey().Key != ConsoleKey.Escape);



Console.WriteLine("Cтатистика: попыток - {0}, средняя скорость - {1} зн/мин, лучшая - {2} зн/мин, худшая {3} зн/мин", 
    overallResults.ResultList.Count, overallResults.AverageSpeed(), overallResults.MaxSpeed(), overallResults.MinSpeed());



enum Languages
{
    RU,
    EN
}