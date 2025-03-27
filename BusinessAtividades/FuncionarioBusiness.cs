using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModelAtividades;
using DatabaseAtividades;

namespace BusinessAtividades
{
    public class FuncionarioBusiness
    {
        public static void Salvar(FuncionarioModel funcionario)
        {
            new FuncionarioDatabase().Salvar(funcionario.Nome, funcionario.Idade, funcionario.CPF);
        }

        public static DataTable Mostrar()
        {
            return new FuncionarioDatabase().Mostrar();
        }
    }
}
