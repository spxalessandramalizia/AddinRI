using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA_XML
    {
        //Envia o XML para a URL informada (Retorna a menssagem de resposta)
        public string Envio(string XML, string URL)
        {
            //Extrai menssagem da Intrag
            string ExtractMsg(string s)
            {
                // You should check for errors in real-world code, omitted for brevity
                var startTag = "value=";
                int startIndex = s.IndexOf(startTag) + startTag.Length;
                int endIndex = s.IndexOf("/>", startIndex);
                if (endIndex - startIndex < 0)
                {
                    return "";
                }
                else
                {
                    return s.Substring(startIndex, endIndex - startIndex);
                }
            }

            //Tenta o Envio do XML
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(URL));
                request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";
                request.Timeout = 120000;
                request.Headers.Add("strXML", XML);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    //return reader.ReadToEnd();

                    string[] linhas = reader.ReadToEnd().Split(Convert.ToChar("\n"));
                    
                    string Resposta = linhas[2];

                    return ExtractMsg(Resposta);

                    //teste para index out of range
                    //string teste = reader.ReadToEnd();
                    //Console.Out.WriteLine(teste);
                    //return teste;
                }
            }
            catch (Exception E)
            {
                return "Exceção: " + E.ToString();
            }
        }
    }
}
