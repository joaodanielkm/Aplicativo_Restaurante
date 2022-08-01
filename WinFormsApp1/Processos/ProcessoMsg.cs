using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Processos
{
    internal class ProcessoMsg
    {
        public DialogResult DesejaAlterar()
        {
            var desejaAlterar = MessageBox.Show("Ja existe lancamento para essa data! Deseja Alterar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return desejaAlterar;
        }
        public DialogResult Salvo()
        {
            var salvo = MessageBox.Show("Salvo!", "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return salvo;
        }
        public DialogResult Bye()
        {
            var bye = MessageBox.Show("Até logo!", "Bye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return bye;
        }
    }
}
