using WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication.Resources
{
    public class RegraNegocio
    {
        string string_conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\Banco.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Pessoa> Get_Pessoa(string nome)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa aux = new Pessoa();
            DataTable datatable = new DataTable();
            Banco banco = new Banco();
            banco.str_conn = string_conexao;

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "nome like '%" + nome + "%'", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.Email = datareader["email"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }
            return lista;
        }

        public Pessoa Get_Pessoa(int id)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa aux = new Pessoa();
            DataTable datatable = new DataTable();
            Banco banco = new Banco();
            banco.str_conn = string_conexao;

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "Id = " + id.ToString(), true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();                
                aux.Email = datareader["Email"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }
            return lista.Count > 0 ? lista[0] : null;
        }


        public bool Insert_Pessoa(Pessoa pessoa)
        {
            bool result = false;
            Banco banco = new Banco();
            banco.str_conn = string_conexao;

            if (banco.conectar())
            {
                result = banco.Executar(string.Format("insert into TableAgenda " +
                                " (Nome,Sobrenome,Email,DataNascimento) " +
                                " values " +
                                " ('{0}','{1}','{2}','{3}')",
                                pessoa.Nome,
                                pessoa.Sobrenome,
                                pessoa.Email,
                                pessoa.DataNascimento.ToString("yyyy-MM-dd")  
                                ), false);

                banco.desconectar();
            }

            return result;
        }

        public bool UPDATE_Pessoa(Pessoa pessoa)
        {
            bool result = false;
            Banco banco = new Banco();
            banco.str_conn = string_conexao;

            if (banco.conectar())
            {
                result = banco.Executar(string.Format("update TableAgenda " +
                                " set Nome = '{0}', " +
                                " Sobrenome = '{1}'," +
                                " Email = '{2}'," +
                                " DataNascimento = '{3}' " +
                                " where Id = {4}",
                                pessoa.Nome,
                                pessoa.Sobrenome,
                                pessoa.Email,
                                pessoa.DataNascimento.ToString("yyyy-MM-dd"),
                                pessoa.Id), false);

                banco.desconectar();
            }

            return result;
        }

        public bool delete_Pessoa(int id)
        {
            bool result = false;
            Banco banco = new Banco();
            banco.str_conn = string_conexao;

            if (banco.conectar())
            {
                result = banco.Executar(string.Format(
                                "delete TableAgenda " +
                                " where Id = {0}",
                                id.ToString()), false);

                banco.desconectar();
            }

            return result;
        }
    }
}