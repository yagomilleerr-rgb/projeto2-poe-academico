using ReaLTaiizor.Forms;

namespace AcademicoAppV1
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void rel�toriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();


        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
