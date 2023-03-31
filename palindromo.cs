bool ChecarPalindromo(string palabra)
{
    char[] posibleAnagrama = palabra.ToCharArray();
    Array.Reverse(posibleAnagrama); //volteamos la palabra 

    return (new string(posibleAnagrama) == palabra);//comparamos la palabra al derecho y reves

}
//true
Console.WriteLine(ChecarPalindromo("ana"));
//false
Console.WriteLine(ChecarPalindromo("chris"));
