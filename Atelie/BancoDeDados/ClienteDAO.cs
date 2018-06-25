using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atelie.BancoDeDados
{
    class DAO
    {
        private string servidor;
        private string bancoDados;
        private string usuario;
        private string senha;
        private string porta;
        private MySqlConnection conexao;

        private bool exibeQuery = true;

        public DAO(string bd = "ateliecostura", string usr = "root", string pss = "1234", string svr = "localhost", string porta = "3306")
        {
            PreparaConexao(bd, usr, pss, svr, porta);
            servidor = svr;
            bancoDados = bd;
            usuario = usr;
            senha = pss;
            this.porta = porta;
        }

        private void PreparaConexao(string bd, string usr, string pss, string svr = "localhost", string port = "3306")
        {
            string connectionString = "Server=" + svr + ";" + "Port=" + port + ";Database=" + bd + ";" + "User=" + usr + ";" + "pwd=" + pss + ";";
            conexao = new MySqlConnection(connectionString);
        }

        private bool AbreConexao()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                {
                    switch (ex.ErrorCode)
                    {
                        case 0:
                            MessageBox.Show("Falha ao conectar no servidor de dados.");
                            break;
                        case 1045:
                            MessageBox.Show("A combinacao de usuario e senha nao existe. Tente novamente.");
                            break;
                        default:
                            MessageBox.Show("Erro" + ex.Code.ToString() + ex.Message);
                            break;
                    }
                   
                }
                return false;
            }
        }

        private bool FechaConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void InsereLinha(string tabela, List<string> campos, List<string> valores)
        {
            int temp = 0;
            string query = "INSERT INTO " + tabela + " (";
            query += string.Join(",", campos.ToArray());
            query += ") VALUES(";
            query += string.Join(",", valores.ToArray());
            query += ")";

            if (exibeQuery)
                MessageBox.Show(query);

            if (!exibeQuery && this.AbreConexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }

        public void UpdateLine(string tabela, List<string> campos, List<string> valores, string filtro = "")
        {
            string query = "UPDATE " + tabela + " SET ";
            string temp1, temp2;
            while (campos.Count > 0)
            {
                temp1 = campos.First();
                temp2 = valores.First();
                query += temp1 + "=" + "'" + temp2 + "'";
                campos.RemoveAt(0);
                valores.RemoveAt(0);
                if (campos.Count > 0)
                    query += ", ";
            }
            if (filtro != "")
                query += "WHERE " + filtro;

            if (exibeQuery)
                MessageBox.Show(query);

            if (!exibeQuery && this.AbreConexao())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conexao;
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }

        public void ApagaLinha(string tabela, string filtro)
        {
            string query = "DELETE FROM " + tabela + " WHERE " + filtro;

            if (exibeQuery)
                MessageBox.Show(query);

            if (!exibeQuery && this.AbreConexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }

        public List<Dictionary<string, string>> Select(string tabela, string filtro = "", string outrosParam = "")
        {
            string query = "SELECT * FROM " + tabela;
            if (filtro != "")
                query += " WHERE " + filtro;
            if (outrosParam != "")
                query += " " + outrosParam;

            if (exibeQuery)
                MessageBox.Show(query);

            List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
            Dictionary<string, string> entidade = new Dictionary<string, string>();

            if (!exibeQuery && this.AbreConexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                switch (tabela)
                {
                    case "table_cliente":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("id", dataReader["id"] + "");
                            entidade.Add("nome", dataReader["nome"] + "");
                            entidade.Add("CPF", dataReader["CPF"] + "");
                            entidade.Add("cel_num", dataReader["cel_num"] + "");
                            entidade.Add("data_cadastro", dataReader["data_cadastro"] + "");
                            entidade.Add("endereco_cod", dataReader["enderecocod"] + "");
                            lista.Add(entidade);
                        }
                    break;
                    case "table_medida":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("id", dataReader["id"] + "");
                            entidade.Add("clientecod", dataReader["clientecod"] + "");
                            entidade.Add("medida", dataReader["medida"] + "");
                            entidade.Add("tipo", dataReader["tipo"] + "");
                            lista.Add(entidade);
                        }
                        break;
                    case "table_endereco":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("id", dataReader["id"] + "");
                            entidade.Add("logradouro", dataReader["logradouro"] + "");
                            entidade.Add("bairro", dataReader["bairro"] + "");
                            entidade.Add("CEP", dataReader["CEP"] + "");
                            lista.Add(entidade);
                        }
                        break;
                    case "table_clienteendereco":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("clientecod", dataReader["clientecod"] + "");
                            entidade.Add("enderecocod", dataReader["enderecocod"] + "");
                            entidade.Add("numero", dataReader["numero"] + "");
                            entidade.Add("complemento", dataReader["complemento"] + "");
                            lista.Add(entidade);
                        }
                        break;
                    case "table_encomenda":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("id", dataReader["id"] + "");
                            entidade.Add("clientecod", dataReader["clientecod"] + "");
                            entidade.Add("preco", dataReader["preco"] + "");
                            entidade.Add("anotacao", dataReader["anotacao"] + "");
                            entidade.Add("data_pagamento", dataReader["data_pagamento"] + "");
                            entidade.Add("data_entrega_prevista", dataReader["data_entrega_prevista"] + "");
                            entidade.Add("data_entrega_efetiva", dataReader["data_entrega_efetiva"] + "");
                            lista.Add(entidade);
                        }
                        break;
                    case "table_prova":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("id", dataReader["id"] + "");
                            entidade.Add("encomendacod", dataReader["encomendacod"] + "");
                            entidade.Add("dia", dataReader["dia"] + "");
                            entidade.Add("horario", dataReader["horario"] + "");
                            entidade.Add("anotacao", dataReader["anotacao"] + "");
                            lista.Add(entidade);
                        }
                        break;
                    case "table_material":
                        while (dataReader.Read())
                        {
                            entidade = new Dictionary<string, string>();
                            entidade.Add("id", dataReader["id"] + "");
                            entidade.Add("encomendacod", dataReader["encomendacod"] + "");
                            entidade.Add("descricao", dataReader["descricao"] + "");
                            entidade.Add("quantidade", dataReader["quantidade"] + "");
                            entidade.Add("uni_medida", dataReader["uni_medida"] + "");
                            lista.Add(entidade);
                        }
                        break;
                    default:
                        throw new Exception("Tabela não tratada no programa!");
                    
                }
                dataReader.Close();
                this.FechaConexao();
                return lista;
            }
            else
            {
                return null;
            }
        }
    }
}