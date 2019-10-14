using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using Sistema___CPA.Arquivos;

//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
 
namespace Sistema___CPA
{
    public partial class Window : Form
    {
        public int ProvaID = -1;
        //ID SelectEd
        public Dictionary<int, int> Provas = new Dictionary<int, int>();
        DataBase Data = new DataBase();

          public string Login = "";
          public bool Session = false;
        
        public Window()
        {
           
            
            InitializeComponent();
          
              

                Data.Init();
                ExibirProvas();
                Questoes.AllowUserToAddRows = false;
                foreach (DataGridViewColumn column in Questoes.Columns)
                {
                    if (column.Index == 0)
                    {
                        column.ReadOnly = true;
                    }
                }
                CreateChart();
                EixoText.Text = "Nenhum";
                QuestaoText.Text = "Nenhuma";
                Pessimol.Text = "0";
                Ruiml.Text = "0";
                Boml.Text = "0";

                Regularl.Text = "0";

                Otimol.Text = "0";

                NaoSeil.Text = "0";
                Pessimo2.Text = "0";
                Ruim2.Text = "0";
                Bom2.Text = "0";

                Regular2.Text = "0";

                Otimo2.Text = "0";

                NaoSei2.Text = "0";

            this.StartPosition = FormStartPosition.CenterScreen;
 
        }
        public DataTable GetData(string query)
        {

            using (var connection = Data.conn)
            {
                Data.OpenConnection();
                using (MySqlDataAdapter sda = new MySqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                   
                    return dt;
                }
            }
        }
        private void CreateChart()
        {





        }


        //private void CreateChart(int Prova,int Questao)
        //{

        //    GraficoQuestao.Series.Clear();

        //    //Fetch the Statistical data from database.
        //    string Query = "SELECT questoes.id, questoes.questao, (SELECT DISTINCT            COUNT(*) FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '1.Péssimo'                AND questoes.id = 31) AS Pessimo,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '2.Ruim'                AND questoes.id = 31) AS Ruim,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '3.Regular'                AND questoes.id = 31) AS Regular,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '4.Bom'                AND questoes.id = 31) AS Bom,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '5.Ótimo'                AND questoes.id = 31) AS Otimo,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '6.NOS (Não sei Opinar)'                AND questoes.id = 31) AS NaoSei FROM  questoes,    provas WHERE questoes.provas_id = 6        AND questoes.id = 31";
        //    Query.Replace("31", Questao.ToString());
        //    Query.Replace("6", Prova.ToString());

        //   // MessageBox.Show(Query);
        //         DataTable dt = GetData(Query);


        //    string[] xval = { "Pessimo", "Ruim", "Bom", "Regular", "Otimo", "NaoSei" };
        //    double[] yval = { 0, 0, 0, 0, 0, 0 };
        //    for (int i = 0; i < 6; i++)
        //    {
        //        GraficoQuestao.Series.Add(xval[i]);

        //        object field = dt.Rows[0][xval[i]];
        //        yval[i] = int.Parse(field.ToString());

        //    }


        //    GraficoQuestao.Series[xval[0]].Color = Color.Red;
        //    GraficoQuestao.Series[xval[1]].Color = Color.Yellow;
        //    GraficoQuestao.Series[xval[2]].Color = Color.Blue;
        //    GraficoQuestao.Series[xval[3]].Color = Color.Green;
        //    GraficoQuestao.Series[xval[4]].Color = Color.Coral;
        //    GraficoQuestao.Series[xval[5]].Color = Color.Pink;


        //    GraficoQuestao.Series[0].Points.DataBindXY(xval, yval);
        //    GraficoQuestao.Legends[0].Enabled = true;
        //    GraficoQuestao.ChartAreas[0].Area3DStyle.Enable3D = true;


        //}
        public void LimparGrid(DataGridView DataGrid)
        {
            for (int i = DataGrid.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = DataGrid.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    DataGrid.Rows.RemoveAt(i);
                }
            }
        }
        public void ExibirProvas()
        {
            //id,nome,id,titulo,tempo,status,tipo_avalia_id,letivo
            //1,"Técnico Administrativo",1,"Avaliação Institucional",80,1,1,2019 / 2
            string query = "SELECT `provas`.*, `provas`.`id`as provaID, `tipo_avalia`.`nome`  FROM `tipo_avalia`,`provas` WHERE `provas`.`id` is not null and `tipo_avalia`.`id` = `provas`.`tipo_avalia_id`;";

            Provas.Clear();
            ListaProvas.Items.Clear();
            Data.processQuery(query, nResult =>
            {
                int Count = 0;
                while (nResult.Read())
                {
                    if (String.IsNullOrEmpty(nResult["provaID"].ToString()))
                        return;

                    string Titulo = nResult["provaID"].ToString() + " - " + nResult["letivo"].ToString() + "  " + nResult["titulo"].ToString() + " : " + nResult["nome"].ToString();
                    int IDPROVA = int.Parse(nResult["provaID"].ToString());

                    ListaProvas.Items.Add(Titulo);
                    Provas.Add(Count, IDPROVA);
                    Liberar.SelectedIndex = int.Parse(nResult["status"].ToString());
                    Count++;
                }
                nResult.Close();
            });

        }
        public void ExibirQuestoes(int ProvaIndex)
        {

            if (ListaProvas.SelectedIndex == -1)
                return;

 
            int _ProvaIndex = Provas[ListaProvas.SelectedIndex];

            //id,nome,id,titulo,tempo,status,tipo_avalia_id,letivo
            //1,"Técnico Administrativo",1,"Avaliação Institucional",80,1,1,2019 / 2
            string query = "SELECT `questoes`.*,`eixos`.`nome` as nome_eixo, `eixos`.`id` as id_eixo FROM `questoes`,`eixos` WHERE `questoes`.`eixo` = `eixos`.`id` AND `provas_id` = " + _ProvaIndex;

           

            int i = 0;
            Questoes.Rows.Clear();
            Data.processQuery(query, nResult =>
            {
                while (nResult.Read())
                {
                    if (String.IsNullOrEmpty(nResult["id"].ToString()))
                        return;

                    Questoes.Rows.Add();

                    string Titulo = nResult["id"].ToString() + " - " + nResult["questao"].ToString();
                    Questoes.Rows[i].Cells["id"].Value = int.Parse(nResult["id"].ToString());
                    Questoes.Rows[i].Cells["questao"].Value = Convert.ToString(nResult["questao"]);
                    int selectedIndex = Convert.ToInt32(nResult["id_eixo"]) - 1;
                     Questoes.Rows[i].Cells["eixo"].Value = eixo.Items[selectedIndex];
                    Questoes.Rows[i].Cells["count"].Value = Convert.ToString(i + 1);
                    i++;
                    
                }
                nResult.Close();
                LimparGrid(Questoes);
            });
            
            

 
        }

        public string getPercent(int x, int Total)
        {
            return String.Format("{0:0.00}", (float)((x * 100.0) / Total));
        }
        private void ListaProvas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nIndex = ListaProvas.SelectedIndex;

            if (nIndex == -1)
                return;


            int Index = Provas[nIndex];
  
            string query = "SELECT * FROM `tipo_avalia`,`provas` WHERE `provas`.`id` = " + Index + " and `tipo_avalia`.`id` = `provas`.`tipo_avalia_id`;";
            
            Data.processQuery(query, nResult =>
            {
                if (nResult.Read())
                {
                    if (String.IsNullOrEmpty(nResult["id"].ToString()))
                        return;

                    NomeProva.Text = nResult["titulo"].ToString();
                    Letivo.Text = nResult["letivo"].ToString();

                    Aplicado.SelectedIndex = int.Parse(nResult["tipo_avalia_id"].ToString()) - 1;
                    ProvaID = int.Parse(nResult["id"].ToString());
                    Liberar.SelectedIndex = int.Parse(nResult["status"].ToString());
                }
                nResult.Close();
                ExibirQuestoes(Index);
            });


            string Query = "SELECT  distinct      provas.letivo,    provas.titulo,    tipo_avalia.nome,        (SELECT DISTINCT            COUNT(*)        FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia        WHERE                historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6  and opcoes.opcao = '5.Ótimo') AS Otimo,                (SELECT DISTINCT            COUNT(*)        FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia        WHERE                historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6  and opcoes.opcao = '2.Ruim') AS Ruim,                 (SELECT DISTINCT            COUNT(*)        FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia        WHERE                historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6  and opcoes.opcao = '1.Péssimo') AS Pessimo,                         (SELECT DISTINCT            COUNT(*)        FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia        WHERE                historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6  and opcoes.opcao = '4.Bom') AS Bom,                         (SELECT DISTINCT            COUNT(*)        FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia        WHERE                historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6  and opcoes.opcao = '3.Regular') AS Regular,                         (SELECT DISTINCT            COUNT(*)        FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia        WHERE                historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6  and opcoes.opcao = '6.NOS (Não sei Opinar)') AS NaoSei                FROM    provas,    questoes,    respostas,    historico,    opcoes,    tipo_avalia  WHERE    historico.provas_id = provas.id        AND opcoes.id = respostas.resposta        AND provas.id = questoes.provas_id        AND respostas.questoes_id = questoes.id        AND historico.id = respostas.historico_id        AND tipo_avalia.id = provas.tipo_avalia_id        AND questoes.provas_id = 6";
            Query = Query.Replace("6", "" + Provas[nIndex]);


            int pPessimo = 0;
            int pRuim = 0;
            int pBom = 0;
            int pRegular = 0;
            int pOtimo = 0;
            int pNaoSei = 0;

            DataTable dt = GetData(Query);
            int Total = 0;
            try
            {
                if (dt != null)
                {
                    string[] xval = { "Pessimo", "Ruim", "Bom", "Regular", "Otimo", "NaoSei" };

                    for (int i = 0; i < 6; i++)
                    {

                        int Valor = int.Parse(dt.Rows[0][xval[i]].ToString());
                        Total += Valor;
                        if (i == 0)
                        {
                        
                            Pessimo2.Text = Valor.ToString();
                            pPessimo += Valor;
                        }
                        else if (i == 1)
                        {
                            Ruim2.Text = Valor.ToString();
                            pRuim += Valor;
                        }
                        else if (i == 2)
                        {
                            Bom2.Text = Valor.ToString();
                            pBom += Valor;
                        }
                        else if (i == 3)
                        {
                            Regular2.Text = Valor.ToString();
                            pRegular += Valor;
                        }
                        else if (i == 4)
                        {
                            Otimo2.Text = Valor.ToString();
                            pOtimo += Valor;
                        }
                        else if (i == 5)
                        {
                            NaoSei2.Text = Valor.ToString();
                            pNaoSei += Valor;
                        }
                    }
                }

                progressBar1.Value = (int)((pPessimo * 100.0) / Total);
                Pessimo2.Text += " (" + getPercent(pPessimo,Total) + "%)";
                progressBar1.CustomText = Pessimo2.Text;

                Ruim2.Text  += " (" + getPercent(pRuim, Total) + "%) ";
                progressBar2.Value = (int)((pPessimo * 100.0) / Total);
                progressBar2.CustomText = Ruim2.Text;

                Bom2.Text += " (" + getPercent(pBom, Total) + "%)";
                progressBar3.Value = (int)((pBom * 100.0) / Total);
                progressBar3.CustomText = Bom2.Text;


                Regular2.Text += " (" + getPercent(pRegular, Total) + "%)";
                progressBar4.Value = (int)((pRegular * 100.0) / Total);
                progressBar4.CustomText = Regular2.Text;


                Otimo2.Text += " (" + getPercent(pOtimo, Total) + "%)";
                progressBar5.Value = (int)((pOtimo * 100.0) / Total);
                progressBar5.CustomText = Otimo2.Text;


                NaoSei2.Text += " (" + getPercent(pNaoSei, Total) + "%)";
                progressBar6.Value = (int)((pNaoSei * 100.0) / Total);
                progressBar6.CustomText = NaoSei2.Text;

            }
            catch(Exception Ex)
            {
                Pessimo2.Text = "0";
                Ruim2.Text = "0";
                Bom2.Text = "0";

                Regular2.Text = "0";

                Otimo2.Text = "0";

                NaoSei2.Text = "0";

                progressBar1.Reset();

                progressBar2.Reset();

                    progressBar3.Reset();

                progressBar4.Reset();

                progressBar5.Reset();

                progressBar6.Reset();

                return;
            }
            
            

          
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int nIndex = ListaProvas.SelectedIndex;

            if (nIndex == -1)
                return;


            if (!Data.sendMenssage("Deseja salvar as alterações feita nesta questão?"))
            {
                return;
            }

            if (Questoes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow rRow in Questoes.SelectedRows)
                {
                    try
                    {
                        if (String.IsNullOrEmpty(rRow.Cells["questao"].Value.ToString()))
                        {
                            MessageBox.Show("Preencha todos os campos da questão!");
                            return;
                        }
                    }
                    catch(Exception Ex)
                    {
                        continue;
                    }
                    int selectedIndex = eixo.Items.IndexOf(rRow.Cells["eixo"].Value) + 1;
                    int id = Convert.ToInt32(rRow.Cells["id"].Value.ToString());
                    string name = rRow.Cells["questao"].Value.ToString();
                    Data.processQuery("UPDATE `provas`.`questoes` SET `questao` = '" + name + "', `eixo` = '" + selectedIndex + "'  WHERE `questoes`.`id` = " + id, nResult =>
                    {
                        if (nResult.Read())
                        {
                            if (String.IsNullOrEmpty(nResult["id"].ToString()))
                                return;

                          
                            Liberar.SelectedIndex = int.Parse(nResult["status"].ToString());
                        }
                        nResult.Close();
                        ExibirQuestoes(Provas[nIndex]);
                    });
 
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(!Data.sendMenssage("Deseja incluir esta prova?"))
            {
                return;
            }
            if (String.IsNullOrEmpty(NomeProva.Text) || String.IsNullOrEmpty(Letivo.Text) || Aplicado.SelectedIndex == -1 || Liberar.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos da prova!");
                return;
            }

            //1 Avaliação Institucional 80 1 1 2019 / 2
            string Query = "INSERT INTO `provas`.`provas` (`id`, `titulo`, `tempo`, `status`, `tipo_avalia_id`, `letivo`) VALUES(NULL, '" + NomeProva.Text + "', '80', '1', '" + (Aplicado.SelectedIndex + 1) + "', '" + Letivo.Text + "');";
            if (Data.Query(Query))
            {
                MessageBox.Show("Prova foi inserida com Sucesso");
                ExibirProvas();
            }
        }

        private void Questoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int Selected = e.RowIndex;
            if (Selected == -1)
                return;

            int Index = ListaProvas.SelectedIndex;
            if (Index == -1)
                return;

            Index = Provas[Index];

            if (String.IsNullOrEmpty(NomeProva.Text) || String.IsNullOrEmpty(Letivo.Text) || Aplicado.SelectedIndex == -1 || Liberar.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos da prova!");
                return;
            }

            Data.processQuery("SELECT * FROM `questoes` WHERE `provas_id` =" + Index, nResult =>
            {
                if (nResult.Read())
                {

                }

            });



        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int nIndex = ListaProvas.SelectedIndex;

            if (nIndex == -1)
                return;

            if(Liberar.SelectedIndex == -1)
            {
                Liberar.SelectedIndex = 1;
            }
            string Query = " UPDATE `provas`.`provas` SET `titulo` = '" + NomeProva.Text + "', `status` = '" + Liberar.SelectedIndex + "', `tipo_avalia_id` = '" + (Aplicado.SelectedIndex + 1) + "', `letivo` = '" + Letivo.Text + "' WHERE `provas`.`id` = " + Provas[nIndex];
            if (Data.Query(Query))
            {
                MessageBox.Show("Prova foi alterada com Sucesso");
                ExibirProvas();
            }


        }

        private void Eixo_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int nIndex = ListaProvas.SelectedIndex;

            if (nIndex == -1)
                return;

            if (!Data.sendMenssage("Deseja incluir uma nova questão?"))
            {
                return;
            }
            // SELECT id FROM questoes where questoes.provas_id = 1 ORDER BY id DESC LIMIT 1;
            int IndexProva = Provas[nIndex];
            string Query = "INSERT INTO `provas`.`questoes` (`id`, `questao`, `tipo`, `provas_id`, `eixo`) VALUES(NULL, 'Edite a Questão', '0', '" + IndexProva + "', '1');";






            if (Data.Query(Query))
            {
                string getID = " SELECT id FROM questoes ORDER BY id DESC LIMIT 1;";
                Data.processQuery(getID, nResult =>
                {
                    if (nResult.Read())
                    {
                        int IndexQuest = int.Parse(nResult["id"].ToString());
                        string _Query = "INSERT INTO `opcoes` (`opcao`, `questoes_id`) VALUES('1.Péssimo', " + IndexQuest + "),('2.Ruim', " + IndexQuest + "),('3.Regular', " + IndexQuest + "),('4.Bom', " + IndexQuest + "),('5.Ótimo', " + IndexQuest + "),('6.NOS (Não sei Opinar)', " + IndexQuest + "); ";
                        if (Data.Query(_Query))
                        {
                            ExibirQuestoes(IndexProva);
                        }
                    }

                });

            }







        }
        private void Button2_Click(object sender, EventArgs e)
        {
            int nIndex = ListaProvas.SelectedIndex;

            if (nIndex == -1)
                return;

            if (!Data.sendMenssage("Deseja excluir a pergunta selecionada?"))
            {
                return;
            }
            try
            {

                if (Questoes.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow rRow in Questoes.SelectedRows)
                    {
                        if (rRow.Index >= Questoes.Rows.Count)
                            continue;

                        if (String.IsNullOrEmpty(rRow.Cells["id"].Value.ToString()))
                            continue;

                        int id = Convert.ToInt32(rRow.Cells["id"].Value.ToString());
                        string name = rRow.Cells["questao"].Value.ToString();

                        Data.processQuery("DELETE FROM `opcoes` WHERE `questoes_id` = " + id, nResult => { if (nResult.Read()) { } });

                        Data.processQuery("DELETE FROM  `questoes` WHERE `questoes`.`id` = " + id, nResult => { if (nResult.Read()) { } });


                    //    MessageBox.Show("Questão foi excluída com Sucesso");
                        ExibirQuestoes(Provas[nIndex]);

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("A questão não pode ser apagada pois já foi respondida");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int nIndex = ListaProvas.SelectedIndex;

            if (nIndex == -1)
                return;

            string DeleteHistorico = "DELETE FROM `historico` WHERE `provas_id` = " + Provas[nIndex];
            string DeleteProva = "DELETE FROM `provas` WHERE `provas`.`id` = " + Provas[nIndex];

        }

        private void Questoes_SelectionChanged(object sender, EventArgs e)
        {

            int rowindex = Questoes.CurrentRow.Index;


            int nIndex = ListaProvas.SelectedIndex;

            // MessageBox.Show(rowindex + " - " + nIndex);
            if (nIndex == -1)
                return;
            if (rowindex == -1)
                return;

            EixoText.Text = "Nenhum";
            QuestaoText.Text = "Nenhuma";
            Pessimol.Text = "0";
            Ruiml.Text = "0";
            Boml.Text = "0";

            Regularl.Text = "0";

            Otimol.Text = "0";

            NaoSeil.Text = "0";

            if (Questoes.SelectedRows.Count > 0)
            {
                int Pessimo = 0;
                int Ruim = 0;
                int Bom = 0;
                int Otimo = 0;
                int Regular = 0;
                int NaoSei = 0;
                foreach (DataGridViewRow rRow in Questoes.SelectedRows)
                {


                    string Query = "SELECT DISTINCT questoes.id, questoes.questao,eixos.nome as nomeeixo, (SELECT DISTINCT            COUNT(*) FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = @                AND opcoes.opcao = '1.Péssimo'                AND questoes.id = ?) AS Pessimo,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = @                AND opcoes.opcao = '2.Ruim'                AND questoes.id = ?) AS Ruim,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = @                AND opcoes.opcao = '3.Regular'                AND questoes.id = ?) AS Regular,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = @                AND opcoes.opcao = '4.Bom'                AND questoes.id = ?) AS Bom,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = @                AND opcoes.opcao = '5.Ótimo'                AND questoes.id = ?) AS Otimo,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = @                AND opcoes.opcao = '@.NOS (Não sei Opinar)'                AND questoes.id = ?) AS NaoSei FROM  questoes,    provas,eixos WHERE questoes.provas_id = @        AND questoes.id = ? and eixos.id = questoes.eixo";
                    Query = Query.Replace("?", "" + int.Parse(rRow.Cells["id"].Value.ToString()));
                    Query = Query.Replace("@", "" + Provas[nIndex]);


                    int Total = 0;
                    Data.processQuery(Query, nResult =>
                    {
                        while (nResult.Read())
                        {
                            if (String.IsNullOrEmpty(nResult["Pessimo"].ToString()))
                                return;

                            string[] xval = { "Pessimo", "Ruim", "Bom", "Regular", "Otimo", "NaoSei" };

                            for (int i = 0; i < 6; i++)
                            {

                                int Valor = int.Parse(nResult[xval[i]].ToString());

                                if (i == 0)
                                    Pessimo += Valor;
                                else if (i == 1)
                                    Ruim += Valor;
                                else if (i == 2)
                                    Bom += Valor;
                                else if (i == 3)
                                    Regular += Valor;
                                else if (i == 4)
                                    Otimo += Valor;
                                else if (i == 5)
                                    NaoSei += Valor;
                            }
                            QuestaoText.Text = nResult["questao"].ToString();
                            EixoText.Text = nResult["nomeeixo"].ToString();
                        }
                        Total = Pessimo + Ruim + Bom + Regular + Otimo + NaoSei;
                        Pessimol.Text = "" + Pessimo + " (" +getPercent(Pessimo, Total)+"%)";
                        Ruiml.Text = "" + Ruim + " (" + getPercent(Ruim, Total) + "%)";
                        Boml.Text = "" + Bom + " (" + getPercent(Bom, Total) + "%)";

                        Regularl.Text = "" + Regular + " (" + getPercent(Regular, Total) + "%)";

                        Otimol.Text = "" + Otimo + " (" + getPercent(Otimo, Total) + "%)";

                        NaoSeil.Text = "" + NaoSei + " (" + getPercent(NaoSei, Total) + "%)";
                        nResult.Close();

                    });

                }
            }
        }

        private void Questoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {


            int rowindex = Questoes.CurrentRow.Index;


            int nIndex = ListaProvas.SelectedIndex;

            // MessageBox.Show(rowindex + " - " + nIndex);
            if (nIndex == -1)
                return;
            if (rowindex == -1)
                return;

    
            if (Questoes.SelectedRows.Count > 0)
            {
                int Pessimo = 0, Ruim = 0, Regular = 0, Bom = 0, Otimo = 0, NaoSei = 0;
                foreach (DataGridViewRow rRow in Questoes.SelectedRows)
                {

                    string Query = "SELECT DISTINCT questoes.id, questoes.questao,eixos.nome as nomeeixo, (SELECT DISTINCT            COUNT(*) FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '1.Péssimo'                AND questoes.id = 31) AS Pessimo,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '2.Ruim'                AND questoes.id = 31) AS Ruim,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '3.Regular'                AND questoes.id = 31) AS Regular,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '4.Bom'                AND questoes.id = 31) AS Bom,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '5.Ótimo'                AND questoes.id = 31) AS Otimo,    (SELECT DISTINCT            COUNT(*)        FROM            provas, questoes, respostas, historico, opcoes, tipo_avalia        WHERE            historico.provas_id = provas.id                AND opcoes.id = respostas.resposta                AND provas.id = questoes.provas_id                AND respostas.questoes_id = questoes.id                AND historico.id = respostas.historico_id                AND tipo_avalia.id = provas.tipo_avalia_id                AND questoes.provas_id = 6                AND opcoes.opcao = '6.NOS (Não sei Opinar)'                AND questoes.id = 31) AS NaoSei FROM  questoes,    provas,eixos WHERE questoes.provas_id = 6        AND questoes.id = 31 and eixos.id = questoes.eixo";
                    Query = Query.Replace("31", "" + rRow.Cells["id"].Value);
                    Query = Query.Replace("6", "" + Provas[nIndex]);

                    

                    DataTable dt = GetData(Query);
                    try
                    {
                        if (dt != null)
                        {

                            string[] xval = { "Pessimo", "Ruim", "Bom", "Regular", "Otimo", "NaoSei" };
                 
                            for (int i = 0; i < 6; i++)
                            {

                                int Valor = int.Parse(dt.Rows[0][xval[i]].ToString());


                                if (i == 0)
                                    Pessimo = Valor;
                                else if (i == 1)
                                    Ruim = Valor;
                                else if (i == 2)
                                    Bom = Valor;
                                else if (i == 3)
                                    Regular = Valor;
                                else if (i == 4)
                                    Otimo = Valor;
                                else if (i == 5)
                                    NaoSei = Valor;
                            }
                          

                          
                            
                        }
                    }
                    catch (Exception Ex)
                    {
                        EixoText.Text = "Nenhum";
                        QuestaoText.Text = "Nenhuma";
                        Pessimol.Text = "0";
                        Ruiml.Text = "0";
                        Boml.Text = "0";

                        Regularl.Text = "0";

                        Otimol.Text = "0";

                        NaoSeil.Text = "0";
                        return;
                    }
                }
            }




            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }
    }
}