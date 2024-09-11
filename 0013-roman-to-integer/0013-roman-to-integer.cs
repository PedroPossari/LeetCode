public class Solution {
    public int RomanToInt(string s) {
int sum = 0;
        for (int i = 0; i < s.Length; i++) {
            int current = GetValue(s[i]);

            
            if (i + 1 < s.Length && current < GetValue(s[i + 1])) {
                sum -= current; 
            } else {
                sum += current; 
            }
        }

        return sum;
    }

    private int GetValue(char symbol) {
        switch (symbol) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}