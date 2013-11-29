package directorio;

import java.io.*;
import java.util.*;

public class Directorio {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        java.io.File file = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\archivo.txt");
        
        System.out.println("Existe el archivo " + file.exists());
        
        System.out.println("El Archivo mide " + file.length());
        
        System.out.println("el archivo puedes ser leido " + file.canRead());
         
        System.out.println("el archivo puede ser escrito " + file.canWrite());
        
        System.out.println("el archivo es un directorio " + file.isDirectory());
        
        System.out.println("es un archivo "+ file.isFile());
        
        System.out.println("es absoluto "+ file.isAbsolute());
        
        System.out.println("esta oculto "+ file.isHidden());
        
        System.out.println("la ruta absoluta es "+ file.getAbsolutePath());
        
        System.out.println("la ultima modificasion fue "+ new java.util.Date(file.lastModified()));
        
        
    }
}
