using System.Security.Policy;

public class Computador
{
    public string processador { get; set; }
    public string placaMae { get; set; }
    public string memoriaRam { get; set; }
    public string placaVideo { get; set; }
    public string ssd { get; set; }
    public string gabinete { get; set; }
    public string fonte { get; set; }
    public string cooler { get; set; }

    public Computador(string processador, string placaMae, string memoriaRam, string placaVideo, string ssd, string gabinete, string fonte, string cooler)
    {
        this.processador = processador;
        this.placaMae = placaMae;
        this.memoriaRam = memoriaRam;
        this.placaVideo = placaVideo;
        this.ssd = ssd;
        this.gabinete = gabinete;
        this.fonte = fonte;
        this.cooler = cooler;
    }

    
}