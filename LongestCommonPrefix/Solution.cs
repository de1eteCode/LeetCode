namespace LongestCommonPrefix;

public class Solution {

    public string LongestCommonPrefix(string[] strs) {
        var str = "";

        if (strs.Length < 1) {
            return str;
        }

        var minLenght = strs.Min(e => e.Length);

        for (var i = 0; i < minLenght; i++) {
            var chr = strs[0][i];

            for (var y = 1; y < strs.Length; y++) {
                if (chr != strs[y][i]) {
                    return str;
                }
            }

            str += chr;
        }

        return str;
    }
}