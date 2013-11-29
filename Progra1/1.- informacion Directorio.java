package infodir;

import java.io.*;

public class InfoDir {

  
    public static void main(String[] args) {
        // TODO code application logic here
   
    java.io.File file = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\Github\\progra-UNI\\Progra 2\\teoria");
    
    
    
    
        System.out.println("es un directorio >> "+ file.isDirectory());
        
        System.out.println("se llama >> " + file.getName());
    
        String[] arch = file.list(); 
        
         for (int i = 0; i < arch.length; i++) {
            System.out.println("contiene >> " +arch[i]);
        }
      
        
    }
}