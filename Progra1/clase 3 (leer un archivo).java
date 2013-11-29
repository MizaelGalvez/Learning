
package leerarchivo;

import java.io.*;
import java.util.Scanner;

public class Leerarchivo {

 
    public static void main(String[]  args) throws IOException {
        // TODO code application logic here
    
        //clreamos la instancia File
        
        java.io.File file = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\archivo.txt");
     
        
        // declarando el escanner con el nombre de  input.
        
        Scanner input = new Scanner(file);
        
        while (input.hasNext()){
        
            String firsname = input.next();
            
            String mi = input.next();
            
            String lastname = input.next();
            
            int score = input.nextInt();
            
            System.out.println( firsname +" "+ mi +" "+ lastname +" "+ score);
            
            
        
        };
        
        
        input.close();
    
    
    
    
    
    }
}