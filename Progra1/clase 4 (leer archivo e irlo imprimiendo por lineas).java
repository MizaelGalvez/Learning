package leer.e.imprimir;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class LeerEImprimir {


    public static void main(String[] args) {
        // TODO code application logic here
        
        
        System.out.println("ingresa el nombre del archivo(ruta completa): ");
        
        Scanner teclado = new Scanner(System.in);
        
        String rutarchivo = teclado.next();
        
        Scanner inputStream = null;
        
        System.out.println("el archivo "+ rutarchivo + "\n" + "contiene la siguiente infnformacion ");
        
        try{
        
           inputStream = new Scanner(new File(rutarchivo));
            
        }catch(FileNotFoundException e){
        
            System.out.println("error al abrir el archivo "+ rutarchivo);
            
            System.exit(0);
            
        }
        
        
        while(inputStream.hasNextLine()) {
        
            String line = inputStream.nextLine();
            
            System.out.println(line);
        
        }
    
        inputStream.close();    
    
    }
}