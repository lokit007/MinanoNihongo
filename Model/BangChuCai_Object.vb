Public Class BangChuCai_Object
    Public bangChuCai As Dictionary(Of String, ChuCai_Object)

    Public Sub New()
        bangChuCai = New Dictionary(Of String, ChuCai_Object)
        'hàng a
        bangChuCai.Add("a", New ChuCai_Object With {.hinagana = "あ", .katakana = "ア", .lama = "a", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("i", New ChuCai_Object With {.hinagana = "い", .katakana = "イ", .lama = "i", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("u", New ChuCai_Object With {.hinagana = "う", .katakana = "ウ", .lama = "u", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("e", New ChuCai_Object With {.hinagana = "え", .katakana = "エ", .lama = "e", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("o", New ChuCai_Object With {.hinagana = "お", .katakana = "オ", .lama = "o", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ka
        bangChuCai.Add("ka", New ChuCai_Object With {.hinagana = "か", .katakana = "カ", .lama = "ka", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ki", New ChuCai_Object With {.hinagana = "き", .katakana = "キ", .lama = "ki", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ku", New ChuCai_Object With {.hinagana = "く", .katakana = "ク", .lama = "ku", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ke", New ChuCai_Object With {.hinagana = "け", .katakana = "ケ", .lama = "ke", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ko", New ChuCai_Object With {.hinagana = "こ", .katakana = "コ", .lama = "ko", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng sa
        bangChuCai.Add("sa", New ChuCai_Object With {.hinagana = "さ", .katakana = "サ", .lama = "sa", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("shi", New ChuCai_Object With {.hinagana = "し", .katakana = "シ", .lama = "shi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("su", New ChuCai_Object With {.hinagana = "す", .katakana = "ス", .lama = "su", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("se", New ChuCai_Object With {.hinagana = "せ", .katakana = "セ", .lama = "se", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("so", New ChuCai_Object With {.hinagana = "そ", .katakana = "ソ", .lama = "so", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ta
        bangChuCai.Add("ta", New ChuCai_Object With {.hinagana = "た", .katakana = "タ", .lama = "ta", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("chi", New ChuCai_Object With {.hinagana = "ち", .katakana = "チ", .lama = "chi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("tsu", New ChuCai_Object With {.hinagana = "つ", .katakana = "ツ", .lama = "tsu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("te", New ChuCai_Object With {.hinagana = "て", .katakana = "テ", .lama = "te", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("to", New ChuCai_Object With {.hinagana = "と", .katakana = "ト", .lama = "to", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng na
        bangChuCai.Add("na", New ChuCai_Object With {.hinagana = "な", .katakana = "ナ", .lama = "na", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ni", New ChuCai_Object With {.hinagana = "に", .katakana = "ニ", .lama = "ni", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("nu", New ChuCai_Object With {.hinagana = "ぬ", .katakana = "ヌ", .lama = "nu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ne", New ChuCai_Object With {.hinagana = "ね", .katakana = "ネ", .lama = "ne", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("no", New ChuCai_Object With {.hinagana = "の", .katakana = "ノ", .lama = "no", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ha
        bangChuCai.Add("ha", New ChuCai_Object With {.hinagana = "は", .katakana = "ハ", .lama = "ha", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("hi", New ChuCai_Object With {.hinagana = "ひ", .katakana = "ヒ", .lama = "hi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("hu", New ChuCai_Object With {.hinagana = "ふ", .katakana = "フ", .lama = "fu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("he", New ChuCai_Object With {.hinagana = "へ", .katakana = "ヘ", .lama = "he", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ho", New ChuCai_Object With {.hinagana = "ほ", .katakana = "ホ", .lama = "ho", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ma
        bangChuCai.Add("ma", New ChuCai_Object With {.hinagana = "ま", .katakana = "マ", .lama = "ma", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("mi", New ChuCai_Object With {.hinagana = "み", .katakana = "ミ", .lama = "mi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("mu", New ChuCai_Object With {.hinagana = "む", .katakana = "ム", .lama = "mu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("me", New ChuCai_Object With {.hinagana = "め", .katakana = "メ", .lama = "me", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("mo", New ChuCai_Object With {.hinagana = "も", .katakana = "モ", .lama = "mo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ra
        bangChuCai.Add("ra", New ChuCai_Object With {.hinagana = "ら", .katakana = "ラ", .lama = "ra", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ri", New ChuCai_Object With {.hinagana = "り", .katakana = "リ", .lama = "ri", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ru", New ChuCai_Object With {.hinagana = "る", .katakana = "ル", .lama = "ru", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("re", New ChuCai_Object With {.hinagana = "れ", .katakana = "レ", .lama = "re", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ro", New ChuCai_Object With {.hinagana = "ろ", .katakana = "ロ", .lama = "ro", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ya - wa
        bangChuCai.Add("ya", New ChuCai_Object With {.hinagana = "や", .katakana = "ヤ", .lama = "ya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("yu", New ChuCai_Object With {.hinagana = "ゆ", .katakana = "ユ", .lama = "yu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("yo", New ChuCai_Object With {.hinagana = "よ", .katakana = "ヨ", .lama = "yo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("wa", New ChuCai_Object With {.hinagana = "わ", .katakana = "ワ", .lama = "wa", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("wu", New ChuCai_Object With {.hinagana = "ん", .katakana = "ン", .lama = "n", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("wo", New ChuCai_Object With {.hinagana = "を", .katakana = "ヲ", .lama = "wo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ga
        bangChuCai.Add("ga", New ChuCai_Object With {.hinagana = "が", .katakana = "ガ", .lama = "ga", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("gi", New ChuCai_Object With {.hinagana = "ぎ", .katakana = "ギ", .lama = "gi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("gu", New ChuCai_Object With {.hinagana = "ぐ", .katakana = "グ", .lama = "gu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ge", New ChuCai_Object With {.hinagana = "げ", .katakana = "ゲ", .lama = "ge", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("go", New ChuCai_Object With {.hinagana = "ご", .katakana = "ゴ", .lama = "go", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng za
        bangChuCai.Add("za", New ChuCai_Object With {.hinagana = "ざ", .katakana = "ザ", .lama = "za", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("zi", New ChuCai_Object With {.hinagana = "じ", .katakana = "ジ", .lama = "ji", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("zu", New ChuCai_Object With {.hinagana = "ず", .katakana = "ズ", .lama = "zu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ze", New ChuCai_Object With {.hinagana = "ぜ", .katakana = "ゼ", .lama = "ze", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("zo", New ChuCai_Object With {.hinagana = "ぞ", .katakana = "ゾ", .lama = "zo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng da
        bangChuCai.Add("da", New ChuCai_Object With {.hinagana = "だ", .katakana = "ダ", .lama = "da", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("di", New ChuCai_Object With {.hinagana = "ぢ", .katakana = "ヂ", .lama = "ji", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("du", New ChuCai_Object With {.hinagana = "づ", .katakana = "ヅ", .lama = "du", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("de", New ChuCai_Object With {.hinagana = "で", .katakana = "デ", .lama = "de", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("do", New ChuCai_Object With {.hinagana = "ど", .katakana = "ド", .lama = "do", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng ba
        bangChuCai.Add("ba", New ChuCai_Object With {.hinagana = "ば", .katakana = "バ", .lama = "ba", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("bi", New ChuCai_Object With {.hinagana = "び", .katakana = "ビ", .lama = "bi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("bu", New ChuCai_Object With {.hinagana = "ぶ", .katakana = "ブ", .lama = "bu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("be", New ChuCai_Object With {.hinagana = "べ", .katakana = "ベ", .lama = "be", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("bo", New ChuCai_Object With {.hinagana = "ぼ", .katakana = "ボ", .lama = "bo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng pa
        bangChuCai.Add("pa", New ChuCai_Object With {.hinagana = "ぱ", .katakana = "パ", .lama = "pa", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("pi", New ChuCai_Object With {.hinagana = "ぴ", .katakana = "ピ", .lama = "pi", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("pu", New ChuCai_Object With {.hinagana = "ぷ", .katakana = "プ", .lama = "pu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("pe", New ChuCai_Object With {.hinagana = "ぺ", .katakana = "ペ", .lama = "pe", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("po", New ChuCai_Object With {.hinagana = "ぽ", .katakana = "ポ", .lama = "po", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng kya - gya
        bangChuCai.Add("kya", New ChuCai_Object With {.hinagana = "きゃ", .katakana = "キャ", .lama = "kya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("kyu", New ChuCai_Object With {.hinagana = "きゅ", .katakana = "キュ", .lama = "kyu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("kyo", New ChuCai_Object With {.hinagana = "きょ", .katakana = "キョ", .lama = "kyo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("gya", New ChuCai_Object With {.hinagana = "ぎゃ", .katakana = "ギャ", .lama = "gya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("gyu", New ChuCai_Object With {.hinagana = "ぎゅ", .katakana = "ギュ", .lama = "gyu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("gyo", New ChuCai_Object With {.hinagana = "ぎょ", .katakana = "ギョ", .lama = "gyo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng sha - ja
        bangChuCai.Add("sha", New ChuCai_Object With {.hinagana = "しゃ", .katakana = "シャ", .lama = "sha", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("shu", New ChuCai_Object With {.hinagana = "しゅ", .katakana = "シュ", .lama = "shu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("sho", New ChuCai_Object With {.hinagana = "しょ", .katakana = "ショ", .lama = "sho", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ja", New ChuCai_Object With {.hinagana = "じゃ", .katakana = "ジャ", .lama = "ja", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ju", New ChuCai_Object With {.hinagana = "じゅ", .katakana = "ジュ", .lama = "ju", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("jo", New ChuCai_Object With {.hinagana = "じょ", .katakana = "ジョ", .lama = "jo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng hya - bya - pya
        bangChuCai.Add("hya", New ChuCai_Object With {.hinagana = "ひゃ", .katakana = "ヒャ", .lama = "hya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("hyu", New ChuCai_Object With {.hinagana = "ひゅ", .katakana = "ヒュ", .lama = "hyu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("hyo", New ChuCai_Object With {.hinagana = "ひょ", .katakana = "ヒョ", .lama = "hy0", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("bya", New ChuCai_Object With {.hinagana = "びゃ", .katakana = "ビャ", .lama = "bya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("byu", New ChuCai_Object With {.hinagana = "びゅ", .katakana = "ビュ", .lama = "byu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("byo", New ChuCai_Object With {.hinagana = "びょ", .katakana = "ビョ", .lama = "byo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("pya", New ChuCai_Object With {.hinagana = "ぴゃ", .katakana = "ピャ", .lama = "pya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("pyu", New ChuCai_Object With {.hinagana = "ぴゅ", .katakana = "ピュ", .lama = "pyu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("pyo", New ChuCai_Object With {.hinagana = "ぴょ", .katakana = "ピョ", .lama = "pyo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng cha
        bangChuCai.Add("cha", New ChuCai_Object With {.hinagana = "ちゃ", .katakana = "チャ", .lama = "cha", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("chu", New ChuCai_Object With {.hinagana = "ちゅ", .katakana = "チュ", .lama = "chu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("cho", New ChuCai_Object With {.hinagana = "ちょ", .katakana = "チョ", .lama = "cho", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng nya
        bangChuCai.Add("nya", New ChuCai_Object With {.hinagana = "にゃ", .katakana = "ニャ", .lama = "nya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("nyu", New ChuCai_Object With {.hinagana = "にゅ", .katakana = "ニュ", .lama = "nyu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("nyo", New ChuCai_Object With {.hinagana = "にょ", .katakana = "ニョ", .lama = "nyo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng mya
        bangChuCai.Add("mya", New ChuCai_Object With {.hinagana = "みゃ", .katakana = "ミャ", .lama = "mya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("myu", New ChuCai_Object With {.hinagana = "みゅ", .katakana = "ミュ", .lama = "myu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("myo", New ChuCai_Object With {.hinagana = "みょ", .katakana = "ミョ", .lama = "myo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        'hàng rya
        bangChuCai.Add("rya", New ChuCai_Object With {.hinagana = "りゃ", .katakana = "リャ", .lama = "rya", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ryu", New ChuCai_Object With {.hinagana = "りゅ", .katakana = "リュ", .lama = "ryu", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})
        bangChuCai.Add("ryo", New ChuCai_Object With {.hinagana = "りお", .katakana = "リョ", .lama = "ryo", .cachViet = "viet_a.jpg", .cachDoc = "doc_a.mpg"})

    End Sub

End Class
