using LIB_Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Resources
{
    public class RegraNegocio
    {
        string string_conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Andre_Lancelotte_DR2_AT\WebApplication\App_Data\Banco.mdf;Integrated Security=True";

        List<Pessoa> lista = new List<Pessoa>();
        Pessoa aux = new Pessoa();
        
        public List<Pessoa> BirthDay(string nome)
        {
            List<Pessoa> listaview = new List<Pessoa>();
            Pessoa aux = new Pessoa();
            DataTable datatable = new DataTable();
            Banco banco = new Banco();
            banco.str_conn = string_conexao;

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "MONTH(DataNascimento)=MONTH(CURRENT_TIMESTAMP) " +
                                "AND DAY(DataNascimento)=DAY(CURRENT_TIMESTAMP)" +
                                "ORDER BY YEAR(DataNascimento)", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();

                lista.Add(aux);
            }


            return lista;
        }       
       

        public List<Pessoa> Aniversariantes(string nome)
        {
            DataTable datatable = new DataTable();
            Banco banco = new Banco();
            banco.str_conn = string_conexao;


            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "DAY(DataNascimento) > DAY(CURRENT_TIMESTAMP)  AND " +
                                "MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "MONTH(DataNascimento) > MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY MONTH(DataNascimento), DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "MONTH(DataNascimento) < MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY MONTH(DataNascimento), DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }


            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "DAY(DataNascimento) < DAY(CURRENT_TIMESTAMP)  AND " +
                                "MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "DAY( DataNascimento) = DAY(CURRENT_TIMESTAMP) AND " +
                                "MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY YEAR(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            return lista;
        }



        public List<Pessoa> Amigos(string nome)
        {
            DataTable datatable = new DataTable();
            Banco banco = new Banco();
            banco.str_conn = string_conexao;


            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "DAY(DataNascimento) > DAY(CURRENT_TIMESTAMP)  AND " +
                                "MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "MONTH(DataNascimento) > MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY MONTH(DataNascimento), DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "MONTH(DataNascimento) < MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY MONTH(DataNascimento), DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }


            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "DAY(DataNascimento) < DAY(CURRENT_TIMESTAMP)  AND " +
                                "MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY DAY(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            if (banco.conectar())
            {
                banco.Executar("select * " +
                                "from TableAgenda " +
                                "where " +
                                "DAY( DataNascimento) = DAY(CURRENT_TIMESTAMP) AND " +
                                "MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) " +
                                "ORDER BY YEAR(DataNascimento)ASC", true);

                datatable = banco.Get_Values("TableAgenda");

                banco.desconectar();
            }

            foreach (DataRow datareader in datatable.Rows)
            {
                aux = new Pessoa();
                aux.Id = (int)datareader["Id"];
                aux.Nome = datareader["Nome"].ToString();
                aux.Sobrenome = datareader["Sobrenome"].ToString();
                aux.DataNascimento = (DateTime)datareader["DataNascimento"];

                lista.Add(aux);
            }

            return lista;
        }

        public Pessoa Get_Pessoa(int id)
        {
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
                                " (Nome,Sobrenome,DataNascimento) " +
                                " values " +
                                " ('{0}','{1}','{2}')",
                                pessoa.Nome,
                                pessoa.Sobrenome,
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
                                " DataNascimento = '{2}' " +
                                " where Id = {3}",
                                pessoa.Nome,
                                pessoa.Sobrenome,
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


