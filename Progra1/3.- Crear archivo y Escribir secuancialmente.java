
package farmacia;

    import java.io.*;
    import java.util.Scanner;

public class Farmacia {

   
    public static void main(String[] args) throws IOException{
        // TODO code application logic here
   
    java.io.File file = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\inventario.txt");
    
    String opcion = "";
    Scanner teclado = new Scanner (System.in);
    
     if (file.exists()) {
            
            System.out.println("el archivo ya existe !!!");
            System.exit(1);
            
     }
    
    java.io.PrintWriter inyector = new java.io.PrintWriter(file);
    
        do {
           
           
                System.out.println("ingrese el codigo del Producto");

                 String palabra = teclado.next();

                 inyector.println(palabra);

                System.out.println("ingrese el Precio");

                 palabra = teclado.next();

                 inyector.println(palabra);

                System.out.println("ingrese la descripcion");

                 palabra = teclado.next();

                 inyector.println(palabra);
                
           System.out.println("desea agregar un Producto al inventario (si/no)");
           opcion = teclado.next();
            
        } while (opcion .equals("si"));
        
        inyector.close();
    
    }
}