package weitedata;

import java.io.*;

public class Weitedata {

    
    public static void main(String[] args) throws IOException {
        // TODO code application logic here

        java.io.File file = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\archivo.txt");
        
        if (file.exists()) {
            
            System.out.println("el archivo ya existe");
            System.exit(1);    //forzando cierre
            
        }
        
        //creando el archivo
    
        java.io.PrintWriter output = new java.io.PrintWriter(file);
        
        // escribiendo al archivo
        
        output.println("John T Smith");
        
        output.println("90");
        
        output.println("Eric K Jones");
        
        output.println("85");
        
        //cerrando el archivo
        
        output.close();
        
    }
}