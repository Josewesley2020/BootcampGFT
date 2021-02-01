package exibindopares;
import java.util.Scanner;

public class ExibindoPares {
    public static void main(String[] args)
    {
      Scanner texto = new Scanner(System.in);
      int numero = texto.nextInt(); 
      for (int i = 1; i <= numero ; i++) 
      {
        if (i % 2 == 0)
        {
            System.out.println(i);
        }
      }
    } 
}
