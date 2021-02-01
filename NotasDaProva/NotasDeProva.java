package notasdeprova;
import java.util.Scanner;

public class NotasDeProva 
{
    public static void main(String[] args) 
    {
      Scanner leitor = new Scanner(System.in);
      int nota = leitor.nextInt(); 
      if (nota < 0) 
      {
        nota = leitor.nextInt();
      } 
      else if (nota == 0) 
      {
        System.out.println("E");
      } 
      else if (nota < 36) 
      {
        System.out.println("D");
      } 
      else if (nota < 61) 
      {
        System.out.println("C");
      }
      else if (nota < 86 ) 
      {
        System.out.println("B");
      }
      else if (nota < 101) 
      {
        System.out.println("A");
      } else 
      {
        nota = leitor.nextInt();
      }
    } 
}
