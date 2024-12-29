class Program{
    public static int MinimumDifference(int[] a){
        int minimum = Minimum(a);
        int sec_minimum = SecMinimum(a, minimum);  
        int diference = sec_minimum-minimum;
        return diference;
    }

    public static int SecMinimum(int[] a, int minimum){
       
        int sec_minimum = int.MaxValue;

        for(int i=0; i<a.Length; i++){
            if(a[i]>minimum && a[i]<sec_minimum){
                sec_minimum = a[i];
            }
        }
        return sec_minimum;
    }

    public static int Minimum(int[] a){

        int minimum = int.MaxValue;

        for(int i=0; i<a.Length;i++){
            if(a[i]<minimum){
                minimum = a[i];
            }
        }
        return minimum;
    }

    public static void Main(){
        int[] a = {17,98,3,95,5};
        int result = MinimumDifference(a);
        Console.WriteLine("La diferencia es: " + result);
    }
}


