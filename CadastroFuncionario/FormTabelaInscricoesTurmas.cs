﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class FormTabelaInscricoesTurmas : Form
    {
        public FormTabelaInscricoesTurmas()
        {
            InitializeComponent();
        }

        private void FormTabelaInscricoesTurmas_Load(object sender, EventArgs e)
        {
            dgv_TabelaInscricoesTurmas.DataSource = GerenciaBanco.carregaDados("Inscricoes_Turmas", "Id_Inscricao_Turma as 'Código da inscrição turma', " + 
            "Id_Inscricao as 'Código da inscrição', Id_Turma as 'Código da turma'").Tables[0];
        }

        private void dgv_TabelaInscricoesTurmas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_TabelaInscricoesTurmas.RefreshEdit();
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome", "Nome", e, "SysProtected.Funcionarios");
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarAluno_Click(object sender, EventArgs e)
        {
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo aluno!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "InscricoesTurmasFiltro", "Id_Inscricao_Turma") != 0)
            {
                dgv_TabelaInscricoesTurmas.Rows[GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "InscricoesTurmasFiltro", "Id_Inscricao_Turma") - 1].Selected = true;
            }
        }

        private void btn_FiltrarFuncionario_Click(object sender, EventArgs e)
        {
            if (cmb_NomeFuncionario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeFuncionario.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeFuncionario.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "[Nome do funcionário]", "InscricoesTurmasFiltro", "Id_Inscricao_Turma") != 0)
            {
                dgv_TabelaInscricoesTurmas.Rows[GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "[Nome do funcionário]", "InscricoesTurmasFiltro", "Id_Inscricao_Turma") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Inscricoes_Turmas", "Id_Inscricao_Turma as 'Código da inscrição turma', " +
            "Id_Inscricao as 'Código da inscrição', Id_Turma as 'Código da turma'");
            }

            dgv_TabelaInscricoesTurmas.DataSource = GerenciaBanco.carregaDados("Inscricoes_Turmas", "Id_Inscricao_Turma as 'Código da inscrição turma', " +
            "Id_Inscricao as 'Código da inscrição', Id_Turma as 'Código da turma'").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
