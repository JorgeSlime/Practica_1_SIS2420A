//eje_1 .- entero a literal


using System;
public static class LITERAL{
    public static string ConvertirNumeroALetras(int numero)
    {
        switch (numero)
        {
            case 0:
                return "Cero";
            case 1:
                return "Uno";
            case 2:
                return "Dos";
            case 3:
                return "Tres";
            case 4:
                return "Cuatro";
            case 5:
                return "Cinco";
            case 6:
                return "Seis";
            case 7:
                return "Siete";
            case 8:
                return "Ocho";
            case 9:
                return "Nueve";
            case 10:
                return "Diez";
            case 11:
                return "Once";
            case 12:
                return "Doce";
            case 13:
                return "Trece";
            case 14:
                return "Catorce";
            case 15:
                return "Quince";
            case 16:
                return "Dieciséis";
            case 17:
                return "Diecisiete";
            case 18:
                return "Dieciocho";
            case 19:
                return "Diecinueve";
            case 20:
                return "Veinte";
            case 30:
                return "Treinta";
            case 40:
                return "Cuarenta";
            case 50:
                return "Cincuenta";
            case 60:
                return "Sesenta";
            case 70:
                return "Setenta";
            case 80:
                return "Ochenta";
            case 90:
                return "Noventa";
            case 100:
                return "Cien";
            default:
                if (numero > 20 && numero < 100)
                {
                    int decena = (numero / 10) * 10;
                    int unidad = numero % 10;
                    return $"{ConvertirNumeroALetras(decena)} y {ConvertirNumeroALetras(unidad)}";
                }
                else if (numero >= 100 && numero < 1000)
                {
                    int centena = numero / 100;
                    int resto = numero % 100;
                    if (resto == 0)
                    {
                        return $"{ConvertirNumeroALetras(centena)}cientos";
                    }
                    else
                    {
                        return $"{ConvertirNumeroALetras(centena)}cientos {ConvertirNumeroALetras(resto)}";
                    }
                }
                else if (numero >= 1000 && numero < 10000)
                {
                    int millar = numero / 1000;
                    int resto = numero % 1000;
                    if (resto == 0)
                    {
                        return $"{ConvertirNumeroALetras(millar)} mil";
                    }
                    else
                    {
                        return $"{ConvertirNumeroALetras(millar)} mil {ConvertirNumeroALetras(resto)}";
                    }
                }
                else if (numero == 10000)
                {
                    return "Diez mil";
                }
                else
                {
                    return "Número fuera de rango";
                }
        }
    }

}
public class HelloWorld
{
    public static void Main(string[] args)
    {  
        Console.WriteLine("INGRESE EL NUMERO QUE DESEE SABER SU FORMA LITERAL");
        int n=int.Parse(Console.ReadLine());
        string s=LITERAL.ConvertirNumeroALetras(n);
        Console.WriteLine ($"EL numero convertido a literal es: {s}");
    }
}