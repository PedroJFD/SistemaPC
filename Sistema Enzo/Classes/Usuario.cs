using Newtonsoft.Json;

public class Usuario
{
    public string usuario { get; set;}
    public string senha { get; set;}
    public string cpf { get; set;}

    public Usuario(string usuario, string senha, string cpf)
    {
        this.usuario = usuario;
        this.senha = senha;
        this.cpf = cpf;
    }

    public Usuario()
    {

    }

    public bool JsonSerealizarLista(List<Usuario> lista, string path)
    {
        var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
        return SaveFileEmpresa(strJson, path);
    }

    private static string OpenFileEmpresa(string path)
    {
        try
        {
            var strJson = "";
            using (StreamReader sw = new StreamReader(path))
            {
                strJson = sw.ReadToEnd();
            }
            return strJson;
        }
        catch (Exception ex)
        {
            return "Falha: " + ex.Message;
        }
    }

    public static List<Usuario> JsonDesserealizarLista(string path)
    {
        var strJson = OpenFileEmpresa(path);
        if (strJson.Contains("Falha"))
        {
            var listaempresas = new List<Usuario>();
            Usuario conexao = new Usuario();
            listaempresas.Add(conexao);
            return listaempresas;
        }
        else
        {

            return JsonConvert.DeserializeObject<List<Usuario>>(strJson);

        }
    }

    private bool SaveFileEmpresa(string strJson, string path)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(strJson);
            }

            return true;
        }
        catch (Exception error)
        {
            return false;
        }
    }
}