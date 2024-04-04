string[] data = { "sestra", "podstozh'e", "vicmundir", "duhovenstvo", "nescenichnost'", "kal'ceks", "lipa", "zasylanie", "sushchestvennoe", "polceny", "paroraspredelitel'", "stress", "tekstil'shchica", "stop", "stereobat", "laminariya", "transplantologiya", "diktor", "odontolog", "porasha", "monastyr'", "raketa-nositel'", "peremotchik", "fotohromiya", "gospodin", "natruska", "dymar'", "prolom", "vylizyvanie", "kontramarka", "fasovshchica", "kombinirovanie", "terpentin", "zolovka", "nakraplivanie", "pila", "rassadnik", "polimorfizm", "voprosnik", "vzblesk", "kolonnovozhatyj", "prigorodka", "katet", "prigorozhanin", "puhoed", "zvukousilenie", "shevelenie", "nakat", "pravdoiskatel'", "individ", "mendelist", "obsadka", "shlih", "perekupyvanie", "podmatyvanie", "samopomoshch'", "oblyubovyvanie", "realistichnost'", "mshanik", "turpan", "razbitost'", "differenciaciya", "yuzhanin", "pyatiklassnik", "chadra", "umatyvanie", "paket", "prevoznesenie", "svyatoshestvo", "shtundistka", "shalfej", "burun", "akant", "vaer", "vyshival'shchica", "guvernantka", "nepravota", "obozrevatel'", "magnitologiya", "slavistka", "hrabrost'", "zakusochnaya", "otkrytka", "prosachivanie", "dushica", "stereofoniya", "antenna", "intruziv", "chekanchik", "vygachivanie", "metafizichnost'", "frontovik", "nesuraznost'", "vodoochistitel'", "melassa", "post", "nozhevishche", "samnit", "dezinformator", "madrigal" };

Console.WriteLine(new string('-', 40));

var words = data

    // шаг1. для каждого слова создаем дополнительное слово-ключ отсортированное по алфавиту
    .Select(p => new { word = p, key = new string(p.Order().ToArray()) })

    // шаг2. группируем по слову ключу
    .GroupBy(p => p.key)

    // шаг3. к каждому слову ключу создаем список слов и их количество
    .Select(g => new { words = g.Select(p => p.word), key = g.Key, count = g.Count() })

    // шаг4. находим анаграммы
    .Where(p => p.count > 1)

    // шаг5. создаем список анаграмм в виде слово - ключ
    .SelectMany(p => p.words.Select(word => $"{word} - {p.key}"));

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine(new string('-', 40));

Console.ReadLine();