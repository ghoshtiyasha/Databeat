using System;
class Name{


 static void Main(){
     int [] a= {9,10,3,5,4,2,1};
     int n= a.Length;
     for(int i=0; i<n-1; i++)

         for(int j=0; j<n-i-1; j++)

             if(a[j]>a[j+1]){

                 int temp = a[j];
                 a[j]=a[j+1];
                 a[j+1]=temp;

             }

    for (int k=0; k<n; k++)
        Console.Write(a[k] + " ");


}
}