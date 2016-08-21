Public Class Const_Object
    Public bangChuCai As Dictionary(Of String, ChuCai_Object)
    Public soDem As Dictionary(Of String, SoDem_Object)
    Public nam As Dictionary(Of String, SoDem_Object)
    Public thang As Dictionary(Of String, SoDem_Object)
    Public ngayTrongThang As Dictionary(Of String, SoDem_Object)
    Public ngayTrongTuan As Dictionary(Of String, SoDem_Object)
    Public tienTe As Dictionary(Of String, SoDem_Object)
    Public chaoHoi As Dictionary(Of String, String)

    Public Sub New()
        'Khơi tạo bảng chữ cái
        initBangChuCai()
        'Khởi tạo danh sách số đếm
        initSoDem()
        'Khởi tạo năm
        initNam()
        'Khởi tạo tháng
        initThang()
        'Khởi tạo ngày trong tháng
        initNgayTrongThang()
        'khởi tạo ngày trong tuần
        initNgayTrongTuan()
        'khởi tạo tiền tệ
        initTienTe()
        'khởi tạo chào hỏi
        initChaoHoi()
    End Sub

    Private Sub initBangChuCai()
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

    Private Sub initSoDem()
        soDem = New Dictionary(Of String, SoDem_Object)
        '0 - 20
        soDem.Add("0", New SoDem_Object With {.hinagana = "れい", .kanji = "ゼロ", .lama = "rei/zero", .nguNghia = "0"})
        soDem.Add("1", New SoDem_Object With {.hinagana = "いち", .kanji = "", .lama = "ichi", .nguNghia = "1"})
        soDem.Add("2", New SoDem_Object With {.hinagana = "に", .kanji = "", .lama = "ni", .nguNghia = "2"})
        soDem.Add("3", New SoDem_Object With {.hinagana = "さん", .kanji = "", .lama = "san", .nguNghia = "3"})
        soDem.Add("4", New SoDem_Object With {.hinagana = "し", .kanji = "よん", .lama = "shi/jon", .nguNghia = "4"})
        soDem.Add("5", New SoDem_Object With {.hinagana = "ご", .kanji = "", .lama = "go", .nguNghia = "5"})
        soDem.Add("6", New SoDem_Object With {.hinagana = "ろく", .kanji = "", .lama = "roku", .nguNghia = "6"})
        soDem.Add("7", New SoDem_Object With {.hinagana = "なな", .kanji = "", .lama = "nana", .nguNghia = "7"})
        soDem.Add("8", New SoDem_Object With {.hinagana = "はち", .kanji = "", .lama = "hachi", .nguNghia = "8"})
        soDem.Add("9", New SoDem_Object With {.hinagana = "く", .kanji = "きゅう", .lama = "ku/kyu.", .nguNghia = "9"})
        soDem.Add("10", New SoDem_Object With {.hinagana = "じゅう", .kanji = "", .lama = "ju.", .nguNghia = "10"})
        soDem.Add("11", New SoDem_Object With {.hinagana = "じゅういち", .kanji = "", .lama = "ju.ichi", .nguNghia = "11"})
        soDem.Add("12", New SoDem_Object With {.hinagana = "じゅうに", .kanji = "", .lama = "ju.ni", .nguNghia = "12"})
        soDem.Add("13", New SoDem_Object With {.hinagana = "じゅうさん", .kanji = "", .lama = "ju.san", .nguNghia = "13"})
        soDem.Add("14", New SoDem_Object With {.hinagana = "じゅうよん", .kanji = "", .lama = "ju.yon", .nguNghia = "14"})
        soDem.Add("15", New SoDem_Object With {.hinagana = "じゅうご", .kanji = "", .lama = "ju.go", .nguNghia = "15"})
        soDem.Add("16", New SoDem_Object With {.hinagana = "じゅうろく", .kanji = "", .lama = "ju.roku", .nguNghia = "16"})
        soDem.Add("17", New SoDem_Object With {.hinagana = "じゅうしち", .kanji = "", .lama = "ju.shichi", .nguNghia = "17"})
        soDem.Add("18", New SoDem_Object With {.hinagana = "じゅうはち", .kanji = "", .lama = "ju.hachi", .nguNghia = "18"})
        soDem.Add("19", New SoDem_Object With {.hinagana = "じゅうく", .kanji = "", .lama = "ju.ku", .nguNghia = "19"})
        soDem.Add("20", New SoDem_Object With {.hinagana = "にじゅう", .kanji = "", .lama = "niju.", .nguNghia = "20"})
        '100 - 900
        soDem.Add("100", New SoDem_Object With {.hinagana = "ひゃく", .kanji = "百", .lama = "hyaku", .nguNghia = "100"})
        soDem.Add("200", New SoDem_Object With {.hinagana = "にひゃく", .kanji = "二百", .lama = "nihyaku", .nguNghia = "200"})
        soDem.Add("300", New SoDem_Object With {.hinagana = "さんひゃく", .kanji = "三百", .lama = "sanbyaku", .nguNghia = "300"})
        soDem.Add("400", New SoDem_Object With {.hinagana = "よんひゃく", .kanji = "四百", .lama = "yonhyaku", .nguNghia = "400"})
        soDem.Add("500", New SoDem_Object With {.hinagana = "ごひゃく", .kanji = "五百", .lama = "gohyaku", .nguNghia = "500"})
        soDem.Add("600", New SoDem_Object With {.hinagana = "ろくひゃく", .kanji = "六百", .lama = " roppyaku", .nguNghia = "600"})
        soDem.Add("700", New SoDem_Object With {.hinagana = "ななひゃく", .kanji = "七百", .lama = "nanahyaku", .nguNghia = "700"})
        soDem.Add("800", New SoDem_Object With {.hinagana = "はちひゃく", .kanji = "八百", .lama = "happyaku", .nguNghia = "800"})
        soDem.Add("900", New SoDem_Object With {.hinagana = "きゅうひゃく", .kanji = "九百", .lama = "kyu.hyaku", .nguNghia = "900"})
        '1000 - 9000
        soDem.Add("1000", New SoDem_Object With {.hinagana = "せん", .kanji = "千", .lama = "sen", .nguNghia = "1000"})
        soDem.Add("2000", New SoDem_Object With {.hinagana = "にせん", .kanji = "二千", .lama = "nisen", .nguNghia = "2000"})
        soDem.Add("3000", New SoDem_Object With {.hinagana = "さんせん", .kanji = "三千", .lama = "sanzen", .nguNghia = "3000"})
        soDem.Add("4000", New SoDem_Object With {.hinagana = "よんせん", .kanji = "四千", .lama = "yonsen", .nguNghia = "4000"})
        soDem.Add("5000", New SoDem_Object With {.hinagana = "ごせん", .kanji = "五千", .lama = "gosen", .nguNghia = "5000"})
        soDem.Add("6000", New SoDem_Object With {.hinagana = "ろくせん", .kanji = "六千", .lama = "rokusen", .nguNghia = "6000"})
        soDem.Add("7000", New SoDem_Object With {.hinagana = "ななせん", .kanji = "七千", .lama = "nanasen", .nguNghia = "7000"})
        soDem.Add("8000", New SoDem_Object With {.hinagana = "はちせん", .kanji = "八千", .lama = "hassen", .nguNghia = "8000"})
        soDem.Add("9000", New SoDem_Object With {.hinagana = "きゅうせん", .kanji = "九千", .lama = "kyu.sen", .nguNghia = "9000"})
        '10000 - 90000
        soDem.Add("10000", New SoDem_Object With {.hinagana = "いちまん", .kanji = "一万", .lama = "ichiman", .nguNghia = "10000"})
        soDem.Add("20000", New SoDem_Object With {.hinagana = "にまん", .kanji = "二万", .lama = "niman", .nguNghia = "20000"})
        soDem.Add("30000", New SoDem_Object With {.hinagana = "さんまん", .kanji = "三万", .lama = "sanman", .nguNghia = "30000"})
        soDem.Add("40000", New SoDem_Object With {.hinagana = "よんまん", .kanji = "四万", .lama = "yonman", .nguNghia = "40000"})
        soDem.Add("50000", New SoDem_Object With {.hinagana = "ごまん", .kanji = "五万", .lama = "goman", .nguNghia = "50000"})
        soDem.Add("60000", New SoDem_Object With {.hinagana = "ろくまん", .kanji = "六万", .lama = "rokuman", .nguNghia = "60000"})
        soDem.Add("70000", New SoDem_Object With {.hinagana = "ななまん", .kanji = "七万", .lama = "nanaman", .nguNghia = "70000"})
        soDem.Add("80000", New SoDem_Object With {.hinagana = "はちまん", .kanji = "八万", .lama = "hachiman", .nguNghia = "80000"})
        soDem.Add("90000", New SoDem_Object With {.hinagana = "きゅうまん", .kanji = "九万", .lama = "kyu.man", .nguNghia = "90000"})
        '1tr, 10tr, 100tr
        soDem.Add("1000000", New SoDem_Object With {.hinagana = "ひゃくまん", .kanji = "", .lama = "hyakuman", .nguNghia = "1000000"})
        soDem.Add("10000000", New SoDem_Object With {.hinagana = "せんまん", .kanji = "", .lama = "senman", .nguNghia = "10000000"})
        soDem.Add("100000000", New SoDem_Object With {.hinagana = "いちおく", .kanji = "", .lama = "ichiku", .nguNghia = "10000000"})
    End Sub

    Private Sub initNam()
        nam = New Dictionary(Of String, SoDem_Object)
        nam.Add("Năm", New SoDem_Object With {.hinagana = "とし, ねん", .kanji = "年", .lama = "toshi", .nguNghia = "Năm"})
        nam.Add("Năm nay", New SoDem_Object With {.hinagana = "ことし", .kanji = "今年", .lama = "kotoshi", .nguNghia = "Năm nay"})
        nam.Add("Năm qua", New SoDem_Object With {.hinagana = "きょねん", .kanji = "去年", .lama = "kyonen", .nguNghia = "Năm qua"})
        nam.Add("Năm tới", New SoDem_Object With {.hinagana = "らいねん", .kanji = "来年", .lama = "rainen", .nguNghia = "Năm tới"})
        nam.Add("Năm 1", New SoDem_Object With {.hinagana = "いちねん", .kanji = "一年", .lama = "ichinen", .nguNghia = "Năm 1"})
        nam.Add("Năm 2", New SoDem_Object With {.hinagana = "にねん", .kanji = "二年", .lama = "ninen", .nguNghia = "Năm 2"})
        nam.Add("Năm 3", New SoDem_Object With {.hinagana = "さんねん", .kanji = "三年", .lama = "sannen", .nguNghia = "Năm 3"})
        nam.Add("Năm 4", New SoDem_Object With {.hinagana = "よねん", .kanji = "四年", .lama = "yonen", .nguNghia = "Năm 4"})
        nam.Add("Năm 5", New SoDem_Object With {.hinagana = "ごねん", .kanji = "五年", .lama = "gonen", .nguNghia = "Năm 5"})
        nam.Add("Năm 6", New SoDem_Object With {.hinagana = "ろくねん", .kanji = "六年", .lama = "rokunen", .nguNghia = "Năm 6"})
        nam.Add("Năm 7", New SoDem_Object With {.hinagana = "しちねん", .kanji = "七年", .lama = "shichinen", .nguNghia = "Năm 7"})
        nam.Add("Năm 8", New SoDem_Object With {.hinagana = "はちねん", .kanji = "八年", .lama = "hachinen", .nguNghia = "Năm 8"})
        nam.Add("Năm 9", New SoDem_Object With {.hinagana = "きゅうねん", .kanji = "九年", .lama = "kyu.nen", .nguNghia = "Năm 9"})
        nam.Add("Năm 10", New SoDem_Object With {.hinagana = "じゅうねん", .kanji = "十年", .lama = "ju.nen", .nguNghia = "Năm 10"})
        nam.Add("Năm 100", New SoDem_Object With {.hinagana = "ひゃくねん", .kanji = "百年", .lama = "hyakunen", .nguNghia = "Năm 100"})
        nam.Add("Năm 1000", New SoDem_Object With {.hinagana = "せんねん", .kanji = "千年", .lama = "sennen", .nguNghia = "Năm 1000"})
        nam.Add("Năm 2000", New SoDem_Object With {.hinagana = "にせんねん", .kanji = "二千年", .lama = "nisennen", .nguNghia = "Năm 2000"})
        nam.Add("Năm 2006", New SoDem_Object With {.hinagana = "にせんろくねん", .kanji = "二千六年", .lama = "nisenrokunen", .nguNghia = "Năm 2006"})
    End Sub
    
    Private Sub initThang()
        thang = New Dictionary(Of String, SoDem_Object)
        thang.Add("Tháng 1", New SoDem_Object With {.hinagana = "いちがつ", .kanji = "一月", .lama = "ichigatsu", .nguNghia = "Tháng 1"})
        thang.Add("Tháng 2", New SoDem_Object With {.hinagana = "にがつ", .kanji = "二月", .lama = "nigatsu", .nguNghia = "Tháng 2"})
        thang.Add("Tháng 3", New SoDem_Object With {.hinagana = "さんがつ", .kanji = "三月", .lama = "sangatsu", .nguNghia = "Tháng 3"})
        thang.Add("Tháng 4", New SoDem_Object With {.hinagana = "しがつ", .kanji = "四月", .lama = "shigatsu", .nguNghia = "Tháng 4"})
        thang.Add("Tháng 5", New SoDem_Object With {.hinagana = "ごがつ", .kanji = "五月", .lama = "gogatsu", .nguNghia = "Tháng 5"})
        thang.Add("Tháng 6", New SoDem_Object With {.hinagana = "ろくがつ", .kanji = "六月", .lama = "rokugatsu", .nguNghia = "Tháng 6"})
        thang.Add("Tháng 7", New SoDem_Object With {.hinagana = "しちがつ", .kanji = "七月", .lama = "shichigatsu", .nguNghia = "Tháng 7"})
        thang.Add("Tháng 8", New SoDem_Object With {.hinagana = "はちがつ", .kanji = "八月", .lama = "hachigatsu", .nguNghia = "Tháng 8"})
        thang.Add("Tháng 9", New SoDem_Object With {.hinagana = "くがつ", .kanji = "九月", .lama = "kugatsu", .nguNghia = "Tháng 9"})
        thang.Add("Tháng 10", New SoDem_Object With {.hinagana = "じゅうがつ", .kanji = "十月", .lama = "ju.gatsu", .nguNghia = "Tháng 10"})
        thang.Add("Tháng 11", New SoDem_Object With {.hinagana = "じゅういちがつ", .kanji = "十一月", .lama = "ju.ichigatsu", .nguNghia = "Tháng 11"})
        thang.Add("Tháng 12", New SoDem_Object With {.hinagana = "じゅうにがつ", .kanji = "十二月", .lama = "ju.nigatsu", .nguNghia = "Tháng 12"})
    End Sub	 	
    
    Private Sub initNgayTrongThang()
        ngayTrongThang = New Dictionary(Of String, SoDem_Object)
        ngayTrongThang.Add("Ngày 1", New SoDem_Object With {.hinagana = "ついたち", .kanji = "一日", .lama = "tsuitachi", .nguNghia = "Ngày 1"})
        ngayTrongThang.Add("Ngày 2", New SoDem_Object With {.hinagana = "ふつか", .kanji = "二日", .lama = "futsuka", .nguNghia = "Ngày 2"})
        ngayTrongThang.Add("Ngày 3", New SoDem_Object With {.hinagana = "みっか", .kanji = "三日", .lama = "mikka", .nguNghia = "Ngày 3"})
        ngayTrongThang.Add("Ngày 4", New SoDem_Object With {.hinagana = "よっか", .kanji = "四日", .lama = "yokka", .nguNghia = "Ngày 4"})
        ngayTrongThang.Add("Ngày 5", New SoDem_Object With {.hinagana = "いつか", .kanji = "五日", .lama = "itsuka", .nguNghia = "Ngày 5"})
        ngayTrongThang.Add("Ngày 6", New SoDem_Object With {.hinagana = "むいか", .kanji = "六日", .lama = "muika", .nguNghia = "Ngày 6"})
        ngayTrongThang.Add("Ngày 7", New SoDem_Object With {.hinagana = "なのか", .kanji = "七日", .lama = "nanoka", .nguNghia = "Ngày 7"})
        ngayTrongThang.Add("Ngày 8", New SoDem_Object With {.hinagana = "ようか", .kanji = "八日", .lama = "yo.ka", .nguNghia = "Ngày 8"})
        ngayTrongThang.Add("Ngày 9", New SoDem_Object With {.hinagana = "ここのか", .kanji = "九日", .lama = "kokonoka", .nguNghia = "Ngày 9"})
        ngayTrongThang.Add("Ngày 10", New SoDem_Object With {.hinagana = "とおか", .kanji = "十日", .lama = "to.ka", .nguNghia = "Ngày 10"})
        ngayTrongThang.Add("Ngày 11", New SoDem_Object With {.hinagana = "じゅういちにち", .kanji = "十一日", .lama = "ju.ichinichi", .nguNghia = "Ngày 11"})
        ngayTrongThang.Add("Ngày 12", New SoDem_Object With {.hinagana = "じゅうににち", .kanji = "十二日", .lama = "ju.ninichi", .nguNghia = "Ngày 12"})
        ngayTrongThang.Add("Ngày 13", New SoDem_Object With {.hinagana = "じゅうさんにち", .kanji = "十三日", .lama = "ju.sannichi", .nguNghia = "Ngày 13"})
        ngayTrongThang.Add("Ngày 14", New SoDem_Object With {.hinagana = "じゅうよっか", .kanji = "十四日", .lama = "ju.yokka", .nguNghia = "Ngày 14"})
        ngayTrongThang.Add("Ngày 15", New SoDem_Object With {.hinagana = "じゅうごにち", .kanji = "十五日", .lama = "ju.gonichi", .nguNghia = "Ngày 15"})
        ngayTrongThang.Add("Ngày 16", New SoDem_Object With {.hinagana = "じゅうろくにち", .kanji = "十六日", .lama = "ju.rokunichi", .nguNghia = "Ngày 16"})
        ngayTrongThang.Add("Ngày 17", New SoDem_Object With {.hinagana = "じゅうしちにち", .kanji = "十七日", .lama = "ju.shichinichi", .nguNghia = "Ngày 17"})
        ngayTrongThang.Add("Ngày 18", New SoDem_Object With {.hinagana = "じゅうはちにち", .kanji = "十八日", .lama = "ju.hachinichi", .nguNghia = "Ngày 18"})
        ngayTrongThang.Add("Ngày 19", New SoDem_Object With {.hinagana = "じゅうくにち", .kanji = "十九日", .lama = "ju.kunichi", .nguNghia = "Ngày 19"})
        ngayTrongThang.Add("Ngày 20", New SoDem_Object With {.hinagana = "はつか", .kanji = "二十日", .lama = "hatsuka", .nguNghia = "Ngày 20"})
        ngayTrongThang.Add("Ngày 21", New SoDem_Object With {.hinagana = "にじゅういちにち", .kanji = "二十一日", .lama = "niju.ichinichi", .nguNghia = "Ngày 21"})
        ngayTrongThang.Add("Ngày 22", New SoDem_Object With {.hinagana = "にじゅうににち", .kanji = "二十二日", .lama = "niju.ninichi", .nguNghia = "Ngày 22"})
        ngayTrongThang.Add("Ngày 23", New SoDem_Object With {.hinagana = "にじゅうさんにち", .kanji = "二十三日", .lama = "niju.sannichi", .nguNghia = "Ngày 23"})
        ngayTrongThang.Add("Ngày 24", New SoDem_Object With {.hinagana = "にじゅうよっか", .kanji = "二十四日", .lama = "niju.yokka", .nguNghia = "Ngày 24"})
        ngayTrongThang.Add("Ngày 25", New SoDem_Object With {.hinagana = "にじゅうごにち", .kanji = "二十五日", .lama = "niju.gonichi", .nguNghia = "Ngày 25"})
        ngayTrongThang.Add("Ngày 26", New SoDem_Object With {.hinagana = "にじゅうろくにち", .kanji = "二十六日", .lama = "niju.rokunichi", .nguNghia = "Ngày 26"})
        ngayTrongThang.Add("Ngày 27", New SoDem_Object With {.hinagana = "にじゅうしちにち", .kanji = "二十七日", .lama = "niju.shichinichi", .nguNghia = "Ngày 27"})
        ngayTrongThang.Add("Ngày 28", New SoDem_Object With {.hinagana = "にじゅうはちにち", .kanji = "二十八日", .lama = "niju.hachinichi", .nguNghia = "Ngày 28"})
        ngayTrongThang.Add("Ngày 29", New SoDem_Object With {.hinagana = "にじゅうくにち", .kanji = "二十九日", .lama = "niju.kunichi", .nguNghia = "Ngày 29"})
        ngayTrongThang.Add("Ngày 30", New SoDem_Object With {.hinagana = "さんじゅうにち", .kanji = "三十日", .lama = "sanju.nichi", .nguNghia = "Ngày 30"})
        ngayTrongThang.Add("Ngày 31", New SoDem_Object With {.hinagana = "さんじゅういちにち", .kanji = "三十一日", .lama = "sanju.ichinichi", .nguNghia = "Ngày 31"})
    End Sub
    '月 = nguyệt, trăng
    '火 = hỏa, lửa
    '水 = thủy, nước
    '木 = thảo, cây
    '金 = kim, vàng
    '土 = thổ = đất
    '日 = nhật = mặt trời
    Private Sub initNgayTrongTuan()
        ngayTrongTuan = New Dictionary(Of String, SoDem_Object)
        ngayTrongTuan.Add("Tuần", New SoDem_Object With {.hinagana = "しゅう", .kanji = "週", .lama = "shu.", .nguNghia = "Tuần"})
        ngayTrongTuan.Add("Ngày trong tuần", New SoDem_Object With {.hinagana = "ようび", .kanji = "曜日", .lama = "yo.bi", .nguNghia = "Ngày trong tuần"})
        ngayTrongTuan.Add("Thứ 2", New SoDem_Object With {.hinagana = "げつようび", .kanji = "月曜日", .lama = "getsuyo.bi", .nguNghia = "Thứ 2"})
        ngayTrongTuan.Add("Thứ 3", New SoDem_Object With {.hinagana = "かようび", .kanji = "火曜日", .lama = "kayo.bi", .nguNghia = "Thứ 3"})
        ngayTrongTuan.Add("Thứ 4", New SoDem_Object With {.hinagana = "すいようび", .kanji = "水曜日", .lama = "suiyo.bi", .nguNghia = "Thứ 4"})
        ngayTrongTuan.Add("Thứ 5", New SoDem_Object With {.hinagana = "もくようび", .kanji = "木曜日", .lama = "mokuyo.bi", .nguNghia = "Thứ 5"})
        ngayTrongTuan.Add("Thứ 6", New SoDem_Object With {.hinagana = "きんようび", .kanji = "金曜日", .lama = "kin.yo.bi", .nguNghia = "Thứ 6"})
        ngayTrongTuan.Add("Thứ 7", New SoDem_Object With {.hinagana = "どようび", .kanji = "土曜日", .lama = "doyo.bi", .nguNghia = "Thứ 7"})
        ngayTrongTuan.Add("Chủ nhật", New SoDem_Object With {.hinagana = "にちようび", .kanji = "日曜日", .lama = "nichiyo.bi", .nguNghia = "Chủ nhật"})
    End Sub

    Private Sub initTienTe()
        'ポンド pound (British pound hoặc pound sterling)	đồng bảng Anh (gọi là British pound hay pound sterling)
        'ドル dollar (US dollar)	đồng đô la Mỹ
        'ユーロ euro	đồng euro
        '円 yen	đồng yên
        'スイスフラン Swiss franc	đồng franc Thụy Sĩ
        'ルーブル rouble	đồng rúp
        'オーストラリアドル Australian dollar	đồng đô la Úc
        'カナダドル  Canadian dollar	đồng đô la Canada
        'ルピー  rupee	đồng rupi
        '元  yuan	đồng Nhân dân tệ
        tienTe = New Dictionary(Of String, SoDem_Object)
        tienTe.Add("Pound", New SoDem_Object With {.hinagana = "ポンド", .kanji = "週", .lama = "shu.", .nguNghia = "Tuần"})
        tienTe.Add("Dollar", New SoDem_Object With {.hinagana = "ドル", .kanji = "曜日", .lama = "yo.bi", .nguNghia = "Ngày trong tuần"})
        tienTe.Add("Euro", New SoDem_Object With {.hinagana = "げつようび", .kanji = "月曜日", .lama = "getsuyo.bi", .nguNghia = "Thứ 2"})
        tienTe.Add("Yên", New SoDem_Object With {.hinagana = "かようび", .kanji = "火曜日", .lama = "kayo.bi", .nguNghia = "Thứ 3"})
        tienTe.Add("Franc", New SoDem_Object With {.hinagana = "すいようび", .kanji = "水曜日", .lama = "suiyo.bi", .nguNghia = "Thứ 4"})
        tienTe.Add("Rouble", New SoDem_Object With {.hinagana = "もくようび", .kanji = "木曜日", .lama = "mokuyo.bi", .nguNghia = "Thứ 5"})
        tienTe.Add("Dollar(Úc)", New SoDem_Object With {.hinagana = "きんようび", .kanji = "金曜日", .lama = "kin.yo.bi", .nguNghia = "Thứ 6"})
        tienTe.Add("Dollar(Cananda)", New SoDem_Object With {.hinagana = "どようび", .kanji = "土曜日", .lama = "doyo.bi", .nguNghia = "Thứ 7"})
        tienTe.Add("Rupee", New SoDem_Object With {.hinagana = "にちようび", .kanji = "日曜日", .lama = "nichiyo.bi", .nguNghia = "Chủ nhật"})
        tienTe.Add("Nhân dân tệ", New SoDem_Object With {.hinagana = "にちようび", .kanji = "日曜日", .lama = "nichiyo.bi", .nguNghia = "Chủ nhật"})
    End Sub

    Private Sub initChaoHoi()
        chaoHoi = New Dictionary(Of String, String)
        chaoHoi.Add("おはようございます", "Chào buổi sáng")
        chaoHoi.Add("こんにちは", "Xin chào, chào buổi chiều")
        chaoHoi.Add("こんばんは", "Chào buổi tối")
        chaoHoi.Add("おやすみなさい", "Chúc ngủ ngon")
        chaoHoi.Add("さようなら", "Chào tạm biệt")
        chaoHoi.Add("ありがとうございます", "Xin cảm ơn")
        chaoHoi.Add("すみません", "Xin lỗi…")
        chaoHoi.Add("おねがいします", "Xin vui lòng")
    End Sub

End Class
