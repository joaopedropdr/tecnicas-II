using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace exercicio1
{
    public delegate void MultaHandler(Multa multa);
    public class CentralDeMultas
    {
        private List<Multa> multas = new List<Multa>();
        public event MultaHandler MultaRegistrada;
        public void registrarMulta(Multa multa) 
        { 

            multas.Add(multa);
            // O ?.Invoke garante que só dispare se houver alguém "ouvindo"
            MultaRegistrada?.Invoke(multa);
            Console.WriteLine($"Multa registrada: {multa.Placa} - {multa.TipoInfracao} - {multa.Valor} - {multa.Data}");
        }

        public void SalvarMultaJson()
        {
            var caminho = "multasTeste2.json";
            if(!File.Exists(caminho))
            {
                string json = JsonSerializer.Serialize(multas, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminho, json);
                Console.WriteLine("Multas Salvas");
            }
            
        }
        public void GetMultaJson()
        {
            var caminho = $"multasTeste2.json";
            if (File.Exists(caminho))
            {
                string jsonString = File.ReadAllText(caminho);
                List<Multa> multas = JsonSerializer.Deserialize<List<Multa>>(jsonString);
                foreach (var m in multas)
                {

                    Console.WriteLine($"Multa encontrada: {m.Placa} - {m.TipoInfracao} - {m.Valor} - {m.Data}");

                }
            }

        }
        public List<Multa> getMultas() 
        {
            return multas;
        }

    }
}
