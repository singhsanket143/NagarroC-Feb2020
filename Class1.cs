using System;

public class Test
{
    public static int power(int a, int b, int c) {
        if(b == 0) {
            return 1;
        }
        int result = power(a, b-1, c);
        
        return ((result%c) * (a%c))%c;
    }
    
    
    public static int powerEff(int a, int b, int c) {
        if(b == 0) {
            return 1;
        }
        int result = 1;
        if(b%2 == 0) {
            result = powerEff(a, b/2, c);
            return ((result%c) * (result%c))%c;
        } else {
            result = powerEff(a, b-1, c);
            return ((result%c) * (a%c))%c;
        }
        
    }
    
    public static int powerEff2(int a, int b) {
        if(b == 0) {
            return 1;
        }
        int result = 1;
        if(b%2 == 0) {
            result = powerEff2(a, b/2);
            return ((result) * (result));
        } else {
            result = powerEff2(a, b-1);
            return ((result) * (a));
        }
        
    }
    
    public static void subsequence(string str, string osf) {
        if(str.Length == 0) {
            Console.WriteLine(osf);
            return;
        }
        char ch = str[0];
        subsequence(str.Substring(1), osf+ch);
        subsequence(str.Substring(1), osf);
        
    }
    
    public static void permutations(string str, string osf) {
        if(str.Length == 0) {
            Console.WriteLine(osf);
            return;
        }
        
        for(int i = 0; i < str.Length; i++) {
            char ch = str[i];
            permutations(str.Substring(0, i) + str.Substring(i+1), osf+ch);
        }
    }
    
    public static void permutations2(string str, string osf) {
        if(str.Length == 0) {
            Console.WriteLine(osf);
            return;
        }
        bool[] visited = new bool[26];
        for(int i = 0; i < str.Length; i++) {
            if(visited[str[i] - 'a'] == false) {
                char ch = str[i];
                visited[str[i] - 'a'] = true;
                permutations2(str.Substring(0, i) + str.Substring(i+1), osf+ch);
            }
            
        }
    }
    
	public static void Main()
	{
// 		Console.WriteLine(power(2, 7, 3));
// 		Console.WriteLine(powerEff(2, 7, 3));
// 		Console.WriteLine(powerEff2(2, 7));
// 		subsequence("abc", "");
        permutations2("aab", "");
	}
}
