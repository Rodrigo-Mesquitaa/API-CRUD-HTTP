using System.Collections.Generic;

namespace Model.RetornoAPI
{
    public class Retorno
    {
        public Retorno()
        {
            Erros = new List<string>();
        }
        
        public bool Sucesso { get; set; }
        public List<string> Erros { get; set; }
    }
}
