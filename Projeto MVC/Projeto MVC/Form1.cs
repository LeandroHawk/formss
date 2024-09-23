using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_MVC
{
    public partial class Form1 : Form
    {
        private Escola escola = new Escola();
        private ComboBox optionsComboBox;
        private Button executeButton;

        public Form1()
        {
            optionsComboBox = new ComboBox();
            optionsComboBox.Items.AddRange(new object[]
            {
            "0. Sair",
            "1. Adicionar curso",
            "2. Pesquisar curso",
            "3. Remover curso",
            "4. Adicionar disciplina no curso",
            "5. Pesquisar disciplina",
            "6. Remover disciplina do curso",
            "7. Matricular aluno na disciplina",
            "8. Remover aluno da disciplina",
            "9. Pesquisar aluno"
            });
            optionsComboBox.SelectedIndex = 0;

            executeButton = new Button { Text = "Executar" };
            executeButton.Click += ExecuteButton_Click;

            Controls.Add(optionsComboBox);
            Controls.Add(executeButton);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            switch (optionsComboBox.SelectedIndex)
            {
                case 0:
                    Close();
                    break;
                case 1:
                    // Lógica para adicionar curso
                    break;
                case 2:
                    // Lógica para pesquisar curso
                    break;
                case 3:
                    // Lógica para remover curso
                    break;
                case 4:
                    // Lógica para adicionar disciplina
                    break;
                case 5:
                    // Lógica para pesquisar disciplina
                    break;
                case 6:
                    // Lógica para remover disciplina
                    break;
                case 7:
                    // Lógica para matricular aluno
                    break;
                case 8:
                    // Lógica para remover aluno
                    break;
                case 9:
                    // Lógica para pesquisar aluno
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(919, 583);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
