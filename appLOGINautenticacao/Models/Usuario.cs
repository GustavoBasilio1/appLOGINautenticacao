using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace appLOGINautenticacao.Models
{
    public class Usuario
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(100, ErrorMessage = "O nome deve conter no máximo 100 caracteres")]
        public string UsuNome { get; set; }

        [Required(ErrorMessage = "Informe o login")]
        [MaxLength(50, ErrorMessage = "O login deve conter no máximo 50 caracteres")]
        //[Remote("Action", "Autenticacao", ErrorMessage ="O login já existe!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [MaxLength(50, ErrorMessage = "a senha deve conter no máximo 50 caracteres")]
        [MinLength(6, ErrorMessage = "a senha deve conter no mínimo 6 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Confirme a senha")]
        [Required(ErrorMessage = "confirme a senha")]
        [DataType(DataType.Password)]
        [CompareAttribute(nameof(Senha))]
        public string ConfirmarSenha { get; set; }

        MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        MySqlCommand comand = new MySqlCommand();

        public void InsertUsuario(Usuario usuario)
        {
            conexao.Open();
            comand.CommandText = "call InsertUsu (@UsuNome, @Login, @Senha);";
            comand.Parameters.Add("@UsuNome", MySqlDbType.VarChar).Value = usuario.UsuNome;
            comand.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usuario.Login;
            comand.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usuario.Senha;
            comand.Connection = conexao;
            comand.ExecuteNonQuery();
            conexao.Close();

        }



    }
}