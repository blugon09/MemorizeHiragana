using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Hiragana {

    public static Dictionary<string, string> HiraganaMap() {
        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("あ", "아");
        map.Add("い", "이");
        map.Add("う", "우");
        map.Add("え", "에");
        map.Add("お", "오");

        map.Add("か", "카");
        map.Add("き", "키");
        map.Add("く", "쿠");
        map.Add("け", "케");
        map.Add("こ", "코");

        map.Add("さ", "사");
        map.Add("し", "시");
        map.Add("す", "스");
        map.Add("せ", "세");
        map.Add("そ", "소");

        map.Add("ざ", "자");
        map.Add("じ", "지");
        map.Add("ず", "즈");
        map.Add("ぜ", "제");
        map.Add("ぞ", "조");

        map.Add("た", "타");
        map.Add("ち", "치");
        map.Add("つ", "츠");
        map.Add("て", "테");
        map.Add("と", "토");

        map.Add("だ", "다");
        map.Add("ぢ", "지");
        map.Add("づ", "즈");
        map.Add("で", "데");
        map.Add("ど", "도");

        map.Add("な", "나");
        map.Add("に", "니");
        map.Add("ぬ", "누");
        map.Add("ね", "네");
        map.Add("の", "노");

        map.Add("は", "하");
        map.Add("ひ", "히");
        map.Add("ふ", "후");
        map.Add("へ", "헤");
        map.Add("ほ", "호");

        map.Add("ば", "바");
        map.Add("び", "비");
        map.Add("ぶ", "부");
        map.Add("べ", "베");
        map.Add("ぼ", "보");

        map.Add("ぱ", "파");
        map.Add("ぴ", "피");
        map.Add("ぷ", "푸");
        map.Add("ぺ", "페");
        map.Add("ぽ", "포");

        map.Add("ま", "마");
        map.Add("み", "미");
        map.Add("む", "무");
        map.Add("め", "메");
        map.Add("も", "모");

        map.Add("や", "야");
        map.Add("ゆ", "유");
        map.Add("よ", "요");

        map.Add("ら", "라");
        map.Add("り", "리");
        map.Add("る", "루");
        map.Add("れ", "레");
        map.Add("ろ", "로");

        map.Add("わ", "와");
        map.Add("を", "오");
        return map;
    }

    public static List<string> HiraganaList() {
        List<string> list = new List<string>();
        list.Add("あ");
        list.Add("い");
        list.Add("う");
        list.Add("え");
        list.Add("お");

        list.Add("か");
        list.Add("き");
        list.Add("く");
        list.Add("け");
        list.Add("こ");

        list.Add("さ");
        list.Add("し");
        list.Add("す");
        list.Add("せ");
        list.Add("そ");

        list.Add("ざ");
        list.Add("じ");
        list.Add("ず");
        list.Add("ぜ");
        list.Add("ぞ");

        list.Add("た");
        list.Add("ち");
        list.Add("つ");
        list.Add("て");
        list.Add("と");

        list.Add("だ");
        list.Add("ぢ");
        list.Add("づ");
        list.Add("で");
        list.Add("ど");

        list.Add("な");
        list.Add("に");
        list.Add("ぬ");
        list.Add("ね");
        list.Add("の");

        list.Add("は");
        list.Add("ひ");
        list.Add("ふ");
        list.Add("へ");
        list.Add("ほ");

        list.Add("ば");
        list.Add("び");
        list.Add("ぶ");
        list.Add("べ");
        list.Add("ぼ");

        list.Add("ぱ");
        list.Add("ぴ");
        list.Add("ぷ");
        list.Add("ぺ");
        list.Add("ぽ");

        list.Add("ま");
        list.Add("み");
        list.Add("む");
        list.Add("め");
        list.Add("も");

        list.Add("や");
        list.Add("ゆ");
        list.Add("よ");

        list.Add("ら");
        list.Add("り");
        list.Add("る");
        list.Add("れ");
        list.Add("ろ");

        list.Add("わ");
        list.Add("を");
        return list;
    }

    public static string RandomHiragana() {
        return HiraganaList()[Random.Range(0, HiraganaList().Count)];
    }
}
