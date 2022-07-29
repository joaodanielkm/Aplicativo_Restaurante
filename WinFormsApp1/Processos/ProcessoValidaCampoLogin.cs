using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Processos
{
    internal class ProcessoValidaCampoLogin
    {
        //public bool EhValidaInformacaoDeLoguin(string username, string senha) =>
        //!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(senha) && !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(senha);

        public void EhDigitadoLogin(string username, string senha)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Favor digitar o usuario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //cbx_username.Focus();
                //return true;
            }
            else if (!string.IsNullOrEmpty(senha) && !string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Favor digite a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //tb_senha.Focus();
                //return false;
            }
        }
    }
}
