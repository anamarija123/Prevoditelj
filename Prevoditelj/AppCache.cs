using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevoditelj
{
    class AppCache
    {
        public static string API { get; } = @"trnsl.1.1.20180129T191045Z.a5b952bbf2bf8eb6.ee486113318c5b916312f2b7dcd95ce18e2fc353";
        public static string URLDohvatiDostupneJezike { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/getLangs?key={0}&ui={1}";//key{API}, ui {izvorni}
        public static string UrlPrevediJezik { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}";//key{API},text{izvorni},lang{odredisni}

    }
}
