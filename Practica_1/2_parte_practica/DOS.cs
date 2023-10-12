//eje_2 agregar a listas diferecntes primos.perfectos,mul de 2 y 5

using System;
using System.Collections.Generic;
public class HelloWorld
{
    //funcion booleana de verificacion de primos optimizada
    // solo a ala raiz de cada primo aplicando algo de l conceto de la criba de eratosthenes. 
    static bool primo(int n){
        if(n<2) return false;
        for(int i=2;i*i<=n;i++){
            if(n%i==0) return false;
        }
        return true;
    }
    static bool perfecto(int n){
        int s=0;
        for(int i=1;i<n;i++){
            if(n%i==0) s+=i;
        }
        return s==n;
    }
    public static void Main(string[] args)
    {  
        Console.WriteLine("CUANTOS NUMEROS DESEA ANIADIR? ");
        int n=int.Parse(Console.ReadLine());
        List<int> v=new List<int>();
        List<int> mul_2=new List<int>();
        List<int> mul_5= new List<int> ();
        List<int> primos=new List<int> ();
        List<int> per=new List<int>();
        for(int i=0;i<n;i++){
            int x=int.Parse(Console.ReadLine());
            v.Add(x);
            if(x%2==0) mul_2.Add(x);
            if(x%5==0)mul_5.Add(x);
            if(perfecto(x)) per.Add(x);
            if(primo(x)) primos.Add(x);
        }
        Console.WriteLine("Numeros Primos:");
        Console.WriteLine(string.Join(", ", primos));

        Console.WriteLine("Numeros Perfectos:");
        Console.WriteLine(string.Join(", ", per));

        Console.WriteLine("Multiplos de 2:");
        Console.WriteLine(string.Join(", ", mul_2));

        Console.WriteLine("Multiplos de 5:");
        Console.WriteLine(string.Join(", ", mul_5));
        
    }
}