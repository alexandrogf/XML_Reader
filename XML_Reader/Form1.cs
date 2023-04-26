// +---------------------------------------------+
// | Desenvolvedor: Alex Coisão                  |
// | Objetivo.....: Aprender a trabalhar com XML |
// | Fonte........: Site do Macoratti            |
// +---------------------------------------------+

using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace XML_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string caminhoArquivo = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        private void btnLeXml_Click(object sender, EventArgs e)
        {
            //monta o caminho do arquivo na raiz do projeto
            caminhoArquivo = Directory.GetParent(Directory.GetParent(caminhoArquivo).FullName).FullName;
            caminhoArquivo += @"\produtos.xml";
            XmlTextReader xmlReader = new XmlTextReader(caminhoArquivo);
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        lbDados.Items.Add("Elemento: " + xmlReader.Name);
                        txtDados.Text += "<" + xmlReader.Name + ">" + Environment.NewLine;
                        break;
                    case XmlNodeType.Text:
                        lbDados.Items.Add("Texto: " + xmlReader.Value);
                        txtDados.Text += xmlReader.Value + Environment.NewLine;
                        break;
                    case XmlNodeType.EndElement:
                        lbDados.Items.Add("End Elemento: " + xmlReader.Name);
                        txtDados.Text += "<" + xmlReader.Name + ">" + Environment.NewLine;
                        break;
                }
            }
        }
    }
}
