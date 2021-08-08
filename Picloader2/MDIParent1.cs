using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picloader2
{
    public partial class MDIpic : Form
    {
        public int childFormNumber = 0;

        public MDIpic()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }
        /*
        //string FileName;
        public int _indiceImagem = 0;
        public string[] _imagens = ?;

        public void PassarParaProximaFoto()
        {
            _indiceImagem++;

            if (_indiceImagem > _imagens.Length - 1)
                _indiceImagem = 0;

            pictureBox.Image = Image.FromFile(_imagens[_indiceImagem]);
        }

        public void VoltarParaFotoAnterior()
        {
            _indiceImagem--;

            if (_indiceImagem < 0)
                _indiceImagem = _imagens.Length - 1;

            pictureBox.Image = Image.FromFile(_imagens[_indiceImagem]);
        
        }
        */
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Imagens PNG (*.png)|*.png|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                //seleciona a imagem e vincula a mesma ao pictureBox
                pictureBox.ImageLocation = openFileDialog.FileName;
                //carrega a imagem selecionada no Picture box "exibirImagem"
                pictureBox.Load();
                /*
                FolderBrowserDialog fbd = new FolderBrowserDialog(); 
                fbd.ShowDialog(); 
                string caminho = fbd.SelectedPath;
                */
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Imagens PNG (*.png)|*.png|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
            //verifica se a imagem foi carregada 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //seleciona a imgaem e vincula a mesma ao pictureBox chamado "exibirImagem"
                pictureBox.ImageLocation = openFileDialog.FileName;
                //carrega a imagem selecionada no Picture box "exibirImagem"
                pictureBox.Load();
                //salva o caminho da imagem selecionada em uma string
                caminhoImagem = openFileDialog.FileName;
                
                FolderBrowserDialog: FolderBrowserDialog fbd = new FolderBrowserDialog(); fbd.ShowDialog(); string caminho = fbd.SelectedPath
            
            }
            */
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
            
    }
}
