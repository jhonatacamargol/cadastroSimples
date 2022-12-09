using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cadastroSimples
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Cadastro(string nome, string telefone)
        {
            //comando Sql 
            cmd.CommandText = "insert into Cliente (nome_cliente, tlf_cliente) values(@nome, @telefone)";


            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            //conectar com banco
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!";
            }

            catch (SqlException e)
            {
                this.mensagem = "ERRO ao se conectar com BD!";
            }

        }
    }
}
