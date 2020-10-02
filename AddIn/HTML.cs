using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace AddIn
{
    class HTML
    {
        //Retorna HTML da Confirmação em Tabela
        public string ConfirmaTabela(List<BL_Boleta> Boletas)
        {
            string HTMLTEXTO = "<span style='color: #1f497d; font-family: calibri, sans-serif;'>Prezados,<br>Segue abaixo as confirmações da solicitação.<br></span>" +
                               "<span style='font-family: calibri, sans-serif;'><strong><span style='color: red;'>Favor conferir as informações nas boletas.</span></strong></span>";

            string HTMLHEAD = "<br><br><table style='width: 970.5pt; margin-left: .1pt; border-collapse: collapse;' width='1294'><tbody>" +
                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 93.0pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='124'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong>Opera&ccedil;&atilde;o</strong></span></p></td>" +
                              "<td style='width: 175.85pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='234'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Fundo</span></strong></span></p></td>" +
                              "<td style='width: 262.25pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='350'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Cotista</span></strong></span></p></td>" +
                              "<td style='width: 120.45pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='161'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Financeiro / Quantidade</span></strong></span></p></td>" +
                              "<td style='width: 63.8pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='85'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Cotiza&ccedil;&atilde;o</span></strong></span></p></td>" +
                              "<td style='width: 63.8pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='85'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Liquida&ccedil;&atilde;o</span></strong></span></p></td>" +
                              "<td style='width: 191.35pt; border: solid #B7B7B7 1.0pt; border-right: none; background: #C9C9C9; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='255'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Conta</span></strong></span></p></td>" +
                              "</tr>";

            string HTMLBODY = "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 93.0pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='124'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{0}</span></p></td>" +
                              "<td style='width: 175.85pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='234'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{1}</span></p></td>" +
                              "<td style='width: 262.25pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='350'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{2}</span></p></td>" +
                              "<td style='width: 120.45pt; border: none; border-bottom: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='161'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{3}</span></p></td>" +
                              "<td style='width: 63.8pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='85'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{4}</span></p></td>" +
                              "<td style='width: 63.8pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='85'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{5}</span></p></td>" +
                              "<td style='width: 191.35pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='255'><p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{6}</span></p></td>" +
                              "</tr>";

            //0 - Operação
            //1 - CODFUND + NOMEFUND
            //2 - CODCOT + NOME
            //3 - FIN/QNT
            //4 - DATA COTIZA
            //5 - DATA LIQUIDA
            //6 - CONTA LIQUIDACAO
        
            foreach (BL_Boleta B in Boletas)
            {
                string Valor = B.VALOR.ToString();
                string Operacao = B.OPERACAO;

                if (Operacao == "AP") { Operacao = "Aplicação"; Valor = string.Format("{0:N}", B.VALOR); }
                else if (Operacao == "RC") { Operacao = "Resgate por Cotas"; Valor = string.Format("{0:0.00000}", B.VALOR); }
                else if (Operacao == "R") { Operacao = "Resgate"; Valor = string.Format("{0:N}", B.VALOR); }
                else { Operacao = "Resgate Total"; Valor = "Resgate Total"; }

                HTMLHEAD = HTMLHEAD + string.Format(HTMLBODY, Operacao, B.CODFUND + " - " + B.FUNDO, B.CODCOT + " - " + B.NOME, Valor, B.COTIZACAO.ToShortDateString(), B.IMPACTO.ToShortDateString(), B.CONTA);
            }

            return "<HTML><BODY>" + HTMLTEXTO + HTMLHEAD + "</tbody></table>" + "<span style='color: #1f497d; font-family: calibri, sans-serif;'>"+ "<br>ID ORDEM (" + Boletas[0].IDORDEM + ")" + "</span>"+ "</BODY></HTML>";
        }

        //Retorna HTML da Confirmação Boleta por Boleta
        public string ConfirmaIndividual(List<BL_Boleta> Boletas)
        {
            string HTMLTEXTO = "<span style='color: #1f497d; font-family: calibri, sans-serif;'>Prezados,<br>Segue abaixo as confirmações da solicitação.<br></span>" +
                               "<span style='font-family: calibri, sans-serif;'><strong><span style='color: red;'>Favor conferir as informações nas boletas.<br></span></strong></span>";

            string HTMLBODY = "<br><table style='width: 371.0pt; border-collapse: collapse;' width='495'><tbody>" +

                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 482.688px; border: 1pt solid {0}; background: {1}; padding: 0cm 3.5pt; height: 15.75pt;' colspan='4'><p style='text-align: center;'><strong><span style='color: {2};'>{3}</span></strong></p></td>" +
                              "</tr>" +

                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 100.688px; border-right: 1pt solid #b7b7b7; border-bottom: 1pt solid #b7b7b7; border-left: 1pt solid #b7b7b7; border-image: initial; border-top: none; background: white; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: right; text-indent: 11.05pt;'><strong><span style='font-family: 'Calibri',sans-serif; color: #222222;'>Fundo:</span></strong></p></td>" +
                              "<td style='width: 371.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: white; padding: 0cm 3.5pt; height: 15.75pt;' colspan='3'><p style='text-align: center;'><span style='color: #222222;'>{4}</span></p></td>" +
                              "</tr>" +

                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 100.688px; border-right: 1pt solid #b7b7b7; border-bottom: 1pt solid #b7b7b7; border-left: 1pt solid #b7b7b7; border-image: initial; border-top: none; background: #f2f2f2; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: right; text-indent: 11.05pt;'><strong><span style='font-family: 'Calibri',sans-serif; color: #222222;'>Cotista:</span></strong></p></td>" +
                              "<td style='width: 371.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: #f2f2f2; padding: 0cm 3.5pt; height: 15.75pt;' colspan='3'><p style='text-align: center;'><span style='color: #222222;'>{5}</span></p></td>" +
                              "</tr>" +

                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 100.688px; border-right: 1pt solid #b7b7b7; border-bottom: 1pt solid #b7b7b7; border-left: 1pt solid #b7b7b7; border-image: initial; border-top: none; background: white; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: right; text-indent: 11.05pt;'><strong><span style='font-family: 'Calibri',sans-serif; color: #222222;'>{6}</span></strong></p></td>" +
                              "<td style='width: 371.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: white; padding: 0cm 3.5pt; height: 15.75pt;' colspan='3'><p style='text-align: center;'><span style='color: #222222;'>{7}</span></p></td>" +
                              "</tr>" +

                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 100.688px; border-right: 1pt solid #b7b7b7; border-bottom: 1pt solid #b7b7b7; border-left: 1pt solid #b7b7b7; border-image: initial; border-top: none; background: #f2f2f2; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: right; text-indent: 11.05pt;'><strong><span style='font-family: 'Calibri',sans-serif; color: #222222;'>Cotiza&ccedil;&atilde;o:</span></strong></p></td>" +
                              "<td style='width: 114.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: #f2f2f2; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: center;'><span style='color: #222222;'>{8}</span></p></td>" +
                              "<td style='width: 118.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: #f2f2f2; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: center;'><strong><span style='font-family: 'Calibri',sans-serif; color: #222222;'>Liquida&ccedil;&atilde;o:</span></strong></p></td>" +
                              "<td style='width: 117.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: #f2f2f2; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: center;'><span style='color: #222222;'>{9}</span></p></td>" +
                              "</tr>" +
                            
                              "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 100.688px; border-right: 1pt solid #b7b7b7; border-bottom: 1pt solid #b7b7b7; border-left: 1pt solid #b7b7b7; border-image: initial; border-top: none; background: white; padding: 0cm 3.5pt; height: 15.75pt;'><p style='text-align: right; text-indent: 11.05pt;'><strong><span style='font-family: 'Calibri',sans-serif; color: #222222;'>Conta:</span></strong></p></td>" +
                              "<td style='width: 371.688px; border-top: none; border-left: none; border-bottom: 1pt solid #b7b7b7; border-right: 1pt solid #b7b7b7; background: white; padding: 0cm 3.5pt; height: 15.75pt;' colspan='3'><p style='text-align: center;'><span style='color: #222222;'>{10}</span></p></td>" +
                              "</tr>" +

                              "</tbody></table>";

            foreach (BL_Boleta B in Boletas)
            {
                //Cores do Header
                string corborda = "#b7b7b7";
                string corbackground = "#f2f2f2";
                string corfonte = "#222222";

                if (B.OPERACAO != "AP") { corborda = "#323E4F"; corbackground = "#323E4F"; corfonte = "white";  }

                //Financeiro ou Quantidade
                string LabelFinQnt = "Financeiro:";
                string Valor = B.VALOR.ToString();
                string Operacao = B.OPERACAO;

                if (B.OPERACAO == "RC" || B.OPERACAO == "RT") { LabelFinQnt = "Quantidade:"; }

                if (Operacao == "AP") { Operacao = "Aplicação"; Valor = string.Format("{0:N}", B.VALOR); }
                else if (Operacao == "RC") { Operacao = "Resgate por Cotas"; Valor = string.Format("{0:0.00000}", B.VALOR); }
                else if (Operacao == "R") { Operacao = "Resgate"; Valor = string.Format("{0:N}", B.VALOR); }
                else { Operacao = "Resgate Total"; Valor = "Resgate Total"; } 

                HTMLTEXTO = HTMLTEXTO + string.Format(HTMLBODY, corborda, corbackground, corfonte, Operacao, B.CODFUND + " - " + B.FUNDO, B.CODCOT + " - " + B.NOME, LabelFinQnt, Valor, B.COTIZACAO.ToShortDateString(), B.IMPACTO.ToShortDateString(), B.CONTA);
            }

            return "<HTML><BODY>" + HTMLTEXTO + "<span style='color: #1f497d; font-family: calibri, sans-serif;'>" + "<br>ID ORDEM (" + Boletas[0].IDORDEM + ")" + "</span>" + "</BODY></HTML>";
        }

        //Retorna HTML da Confirmação de Recebimento
        public string ConfirmaRecebimento(List<BL_Boleta> Boletas)
        {
            Dictionary<long, BL_Cotista> Cotistas = new BL_Cotista().DadosCompleto().ToDictionary(key => key.CODCOT, value => value);

            string HTMLTEXTO = "<span style='color: #1f497d; font-family: calibri, sans-serif;'>Prezados,<br> <br> Movimentações Recebidas.<br>As confirmações serão enviadas após o processamento.<br><br></span>" +
                               "<span style='font-family: calibri, sans-serif;'><span style='color: #1f497d;'>ID ORDEM (" + Boletas[0].IDORDEM + ")</span></span>";

            if (Boletas.Exists(x => x.STATUS == "TCR Pendente" || x.STATUS == "Cadastro Pendente"))
            {
                HTMLTEXTO = "<span style='color: #1f497d; font-family: calibri, sans-serif;'>Prezados,<br> <br> Movimentações Recebidas.<br>Favor regularizar a situação cadastral para aporte.<br><br></span>" +
                               "<span style='font-family: calibri, sans-serif;'><span style='color: #1f497d;'>ID ORDEM (" + Boletas[0].IDORDEM + ")</span></span>";
            }

            string HTMLTSITUACAOHEAD = "<br><br><table style='width: 665.75pt; margin-left: .1pt; border-collapse: collapse;' width='0'><tbody><tr style='height: 15.75pt;'>" +
                          "<td style='width: 665.75pt; border: solid #B7B7B7 1.0pt; background: #EAEAEA; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' colspan='6' width='878'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Situa&ccedil;&atilde;o Cotistas para Aplica&ccedil;&atilde;o</span></strong></span></p></td></tr>" +
                          "<tr style='height: 15.75pt;'><td style='width: 211.75pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='282'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Nome</span></p></td><td style='width: 130.35pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='174'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>CPF / CNPJ</span></p></td><td style='width: 130.55pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' colspan='2' width='157'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Fundo</span></p></td><td style='width: 72.6pt; border: none; border-bottom: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='104'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Vencimento</span></p></td><td style='width: 120.5pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='161'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Situa&ccedil;&atilde;o</span></p></td></tr>";

            string HTMLSITUACAOBODY = "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 211.75pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='282'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{0}</span></p></td><td style='width: 130.35pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='174'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{1}</span></p></td><td style='width: 130.55pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' colspan='2' width='157'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{2}</span></p></td><td style='width: 72.6pt; border: none; border-bottom: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='104'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{3}</span></p></td><td style='width: 120.5pt; border: solid #B7B7B7 1.0pt; border-top: none; background: {4}; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='161'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{5}</span></p></td></tr>";

            //Retorna texto sem situação cadastral quando não tem aplicação
            if (Boletas.Where(x => x.OPERACAO == "AP").Count() == 0) { return "<HTML><BODY>" + HTMLTEXTO + "</BODY></HTML>"; }

            //Situação dos Cotistas
            foreach (BL_Boleta Boleta in Boletas.Where(x => x.OPERACAO == "AP"))
            {
                string Cor()
                {
                    if (Boleta.STATUS == "Liberado") { return "#E2EFDA"; }
                    else if (Boleta.STATUS == "Pendente") { return "#F8CBAD"; }
                    else { return "#FFB3B3"; }
                }

                HTMLTSITUACAOHEAD = HTMLTSITUACAOHEAD + String.Format(HTMLSITUACAOBODY, Boleta.NOME, Boleta.CPFCNPJ, Boleta.FUNDO, Cotistas[Boleta.CODCOT].VENCIMENTO.ToShortDateString(), Cor(), Boleta.STATUS);
            }

            return "<HTML><BODY>" + HTMLTEXTO + HTMLTSITUACAOHEAD + "</BODY></HTML>";
        }

        //Retorna HTML da Confirmação de Recebimento
        public string VerificaCadastro(List<BL_Boleta> Boletas)
        {
            Dictionary<long, BL_Cotista> Cotistas = new BL_Cotista().DadosCompleto().ToDictionary(key => key.CODCOT, value => value);

            string HTMLTEXTO = "<span style='color: #1f497d; font-family: calibri, sans-serif;'>Prezados,<br> Movimentações Recebidas.<br>As confirmações serão enviadas após o processamento.<br><br></span>" +
                               "<span style='font-family: calibri, sans-serif;'><span style='color: #1f497d;'>ID ORDEM (" + Boletas[0].IDORDEM + ")</span></span>";

            string HTMLTSITUACAOHEAD = "<br><br><table style='width: 665.75pt; margin-left: .1pt; border-collapse: collapse;' width='0'><tbody><tr style='height: 15.75pt;'>" +
                          "<td style='width: 665.75pt; border: solid #B7B7B7 1.0pt; background: #EAEAEA; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' colspan='6' width='878'><p style='text-align: center;'><span style='font-family: calibri, sans-serif;'><strong><span style='color: black;'>Situa&ccedil;&atilde;o Cotistas para Aplica&ccedil;&atilde;o</span></strong></span></p></td></tr>" +
                          "<tr style='height: 15.75pt;'><td style='width: 211.75pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='282'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Nome</span></p></td><td style='width: 130.35pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='174'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>CPF / CNPJ</span></p></td><td style='width: 130.55pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' colspan='2' width='157'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Fundo</span></p></td><td style='width: 72.6pt; border: none; border-bottom: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='104'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Vencimento</span></p></td><td style='width: 120.5pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='161'>" +
                          "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>Situa&ccedil;&atilde;o</span></p></td></tr>";

            string HTMLSITUACAOBODY = "<tr style='height: 15.75pt;'>" +
                              "<td style='width: 211.75pt; border: solid #B7B7B7 1.0pt; border-top: none; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='282'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{0}</span></p></td><td style='width: 130.35pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='174'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{1}</span></p></td><td style='width: 130.55pt; border-top: none; border-left: none; border-bottom: solid #B7B7B7 1.0pt; border-right: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' colspan='2' width='157'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{2}</span></p></td><td style='width: 72.6pt; border: none; border-bottom: solid #B7B7B7 1.0pt; background: white; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='104'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{3}</span></p></td><td style='width: 120.5pt; border: solid #B7B7B7 1.0pt; border-top: none; background: {4}; padding: 0cm 3.5pt 0cm 3.5pt; height: 15.75pt;' width='161'>" +
                              "<p style='text-align: center;'><span style='color: #222222; font-family: calibri, sans-serif;'>{5}</span></p></td></tr>";

            //Retorna texto sem situação cadastral quando não tem aplicação
            if (Boletas.Where(x => x.OPERACAO == "AP").Count() == 0) { return "<HTML><BODY>" + HTMLTEXTO + "</BODY></HTML>"; }

            //Situação dos Cotistas
            foreach (BL_Boleta Boleta in Boletas.Where(x => x.OPERACAO == "AP"))
            {
                string Cor()
                {
                    if (Boleta.STATUS == "Liberado") { return "#E2EFDA"; }
                    else if (Boleta.STATUS == "Pendente") { return "#F8CBAD"; }
                    else { return "#FFB3B3"; }
                }

                HTMLTSITUACAOHEAD = HTMLTSITUACAOHEAD + String.Format(HTMLSITUACAOBODY, Boleta.NOME, Boleta.CPFCNPJ, Boleta.FUNDO, Cotistas[Boleta.CODCOT].VENCIMENTO.ToShortDateString(), Cor(), Boleta.STATUS);
            }

            return "<HTML><BODY>" + HTMLTEXTO + HTMLTSITUACAOHEAD + "</BODY></HTML>";
        }
    }
}
