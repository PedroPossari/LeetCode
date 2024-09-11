public class Solution {
    public bool IsPalindrome(int x) {
        
        string number = Convert.ToString(x);
        
        string numberInvertido = new string(number.Reverse().ToArray());
        
            if(number == numberInvertido){
                
                return true;
            
            }
        
        return false;
        
    }
}