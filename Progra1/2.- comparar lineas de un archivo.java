package archivoscomp;

import java.util.Scanner;
import java.io.*;

/**
 *
 * @author Saeko
 */
public class Archivoscomp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException{
        // TODO code application logic here
     java.io.File miarchivo = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\archivo.txt");
     java.io.File miotroarchivo = new java.io.File("C:\\Users\\Saeko\\@Proyectos\\archivo2.txt");
     
     
     
     
      Scanner input = new Scanner(miarchivo);
      Scanner input2 = new Scanner(miotroarchivo);
        int score=0;
        int score2=0;
      
       while (input.hasNextLine()){
        
            input.nextLine();
     
            score = score +1;
    
        };
        while (input2.hasNextLine()){
        
            input2.nextLine();
       
            score2 = score2 +1;
     
        };
        
            
            if (score==score2) {
                
                System.out.println("tienen las mismas lineas");
            
        }else{
                System.out.println("tiene diferente cantidad de lineas");
            }
            
      
    
    }
}
