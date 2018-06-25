using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Atelie.Model
{
    class ConectaBanco
    {
        private string servidor;
        private string bancoDados;
        private string usuario;
        private string senha;
        private string porta;
        private MySqlConnection conexao;

        public ConectaBanco(string bd, string usr, string pss, string svr = "localhost", string porta = "3306")
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
            foreach (string item in campos)
            {
                query += item;
                query += ", ";
            }
            query = query.Remove(query.Length - 2);
            query += ") VALUES(";
            foreach (string item in valores)
            {
                if (int.TryParse(item, out temp)) {
                    query += item;
                    query += ", ";
                }
                else {
                    query += "'";
                    query += item;
                    query += "',";
                }
            }
            query = query.Remove(query.Length - 1);
            query += ")";
            if (this.AbreConexao() == true)
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
            if (this.AbreConexao() == true)
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
            if (this.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }
        public List<string>[] Select(string tabela, List<string> campos, string filtro = "", string outrosParam = "")
        {
            string query = "SELECT * FROM " + tabela;
            int qtReg = campos.Count;
            if (filtro != "")
                query += " WHERE " + filtro;
            if (outrosParam != "")
                query += " " + outrosParam;
            List<string>[] list = new List<string>[qtReg];
            for (int i = 0; i < qtReg; i++)
            {
                list[i] = new List<string>();
            }
            if (this.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                switch (tabela)
                {
                    case "table_cliente":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id"] + "");
                            list[1].Add(dataReader["nome"] + "");
                            list[2].Add(dataReader["CPF"] + "");
                            list[3].Add(dataReader["cel_num"] + "");
                            list[4].Add(dataReader["data_cadastro"] + "");
                            list[5].Add(dataReader["endereco_cod"] + "");
                            list[6].Add(dataReader["data_criacao"] + "");
                            list[7].Add(dataReader["data_alteracao"] + "");
                            list[8].Add(dataReader["situacao"] + "");
                        }
                    break;
                    case "table_medida":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id_medida"] + "");
                            list[1].Add(dataReader["clientecod"] + "");
                            list[2].Add(dataReader["medida"] + "");
                            list[3].Add(dataReader["tipo"] + "");
                            list[4].Add(dataReader["data_criacao"] + "");
                            list[5].Add(dataReader["data_alteracao"] + "");
                            list[6].Add(dataReader["situacao"] + "");
                        }
                        break;
                    case "table_endereco":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id_endereco"] + "");
                            list[1].Add(dataReader["logradouro"] + "");
                            list[2].Add(dataReader["bairro"] + "");
                            list[3].Add(dataReader["CEP"] + "");
                            list[4].Add(dataReader["data_criacao"] + "");
                            list[5].Add(dataReader["data_alteracao"] + "");
                            list[6].Add(dataReader["situacao"] + "");
                        }
                        break;
                    case "table_clienteendereco":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["clienteend_cod"] + "");
                            list[1].Add(dataReader["enderecod"] + "");
                            list[2].Add(dataReader["numero"] + "");
                            list[3].Add(dataReader["complemento"] + "");
                            list[4].Add(dataReader["data_criacao"] + "");
                            list[5].Add(dataReader["data_alteracao"] + "");
                            list[6].Add(dataReader["situacao"] + "");
                        }
                        break;
                    case "table_encomenda":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id_encomenda"] + "");
                            list[1].Add(dataReader["clientecod"] + "");
                            list[2].Add(dataReader["preco"] + "");
                            list[3].Add(dataReader["anotacao"] + "");
                            list[4].Add(dataReader["data_pagamento"] + "");
                            list[5].Add(dataReader["data_entrega_prevista"] + "");
                            list[6].Add(dataReader["data_entrega_efetiva"] + "");
                            list[7].Add(dataReader["data_criacao"] + "");
                            list[8].Add(dataReader["data_alteracao"] + "");
                            list[9].Add(dataReader["situacao"] + "");
                        }
                        break;
                    case "table_prova":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id_prova"] + "");
                            list[1].Add(dataReader["encomendacod"] + "");
                            list[2].Add(dataReader["dia"] + "");
                            list[3].Add(dataReader["horario"] + "");
                            list[4].Add(dataReader["anotacao"] + "");
                            list[5].Add(dataReader["data_criacao"] + "");
                            list[6].Add(dataReader["data_alteracao"] + "");
                            list[7].Add(dataReader["situacao"] + "");
                        }
                        break;
                    case "table_material":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id_material"] + "");
                            list[1].Add(dataReader["encomendacod"] + "");
                            list[2].Add(dataReader["descricao"] + "");
                            list[3].Add(dataReader["quantidade"] + "");
                            list[4].Add(dataReader["uni_medida"] + "");
                            list[5].Add(dataReader["data_criacao"] + "");
                            list[6].Add(dataReader["data_alteracao"] + "");
                            list[7].Add(dataReader["situacao"] + "");
                        }
                    default:
                        throw new Exception("Tabela não tratada no programa!");
                    
                }
                dataReader.Close();
                this.FechaConexao();
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}