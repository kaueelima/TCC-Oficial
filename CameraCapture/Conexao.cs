using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Conexao
/// </summary>
public class Conexao
{
    //--------------------------------------------------------------------------------
    // Variaveis para conexão
    //--------------------------------------------------------------------------------



    // classe sqlConnection  serve para estabelecer, abrir e fechar a conexão com o banco de dados através da string de conexão
    // Classe SqlCommand executa o comando SQL
    // Classe sqlDataReader permite obter os dados retornados



    public SqlConnection CONEXAO; //declara a variável CONEXAO do tipo SqlConnection

    public SqlCommand COMANDO;    //declara a variável COMANDO do tipo SqlCommand

    public SqlDataReader DR;      //declara a variável DR do tipo SqlDataReader


    //Construtor para inicializar as variáveis
    public Conexao()
    {

        CONEXAO = new SqlConnection();
        COMANDO = new SqlCommand();
    }



    public void Open()
    {
        try
        {

            CONEXAO.ConnectionString = ("Data Source=REGULUS;Initial Catalog=BDu14281;User ID=BDu14281;Password=BDu14281");
            COMANDO.Connection = CONEXAO;
            CONEXAO.Open();
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
}
