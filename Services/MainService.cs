using System;

namespace app.Services {

    public class MainService {
     
    public bool Bestanden { get; set; } 
    public int RichtigeAntworten = 0;
    public int AntwortenGegeben = 0;
    
 public List<string> FalscheAntworten = new List<string> { };
 public List<string> RichtigeAntwortenListe = new List<string> { }; // Work-In-Progress 

public void FrageFalsch() {
        AntwortenGegeben++;
}
    
public void FrageRichtig() {
        
        RichtigeAntworten++;
        AntwortenGegeben++;
       }  
    }
}