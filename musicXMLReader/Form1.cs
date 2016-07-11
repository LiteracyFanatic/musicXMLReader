using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace musicXMLReader
{
    public partial class Form1 : Form
    {
        Piece myPiece;

        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openMusicDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openMusicDialog.FileName;

                myPiece = new Piece(file);

                partsListBox.Items.Clear();

                foreach (Part myPart in myPiece.PartList)
                {
                    partsListBox.Items.Add(myPart.ID + " - " + myPart.Name);
                }

                partsListBox.SelectedIndex = 0;
                copyButton.Enabled = true;
            }
        }

        private void partsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part curPart = myPiece.PartList.ElementAt(partsListBox.SelectedIndex);

            tempoBox.Text = curPart.Tempo.ToString();
            divisionBox.Text = curPart.Division.ToString();

            notesBox.Text = String.Join(", ", curPart.Notes);
            timesBox.Text = String.Join(", ", curPart.Times);
            durationsBox.Text = String.Join(", ", curPart.Durations);
            rawBox.Text = curPart.Raw;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Part curPart = myPiece.PartList.ElementAt(partsListBox.SelectedIndex);
            StringBuilder sb = new StringBuilder();
            string text = sb.AppendLine("const unsigned int " + nameBox.Text + "Notes[] PROGMEM =")
                .AppendLine("{")
                .AppendLine(String.Join(", ", curPart.Notes))
                .AppendLine("};")
                .AppendLine()
                .AppendLine("const unsigned int " + nameBox.Text + "Times[] PROGMEM =")
                .AppendLine("{")
                .AppendLine(String.Join(", ", curPart.Times))
                .AppendLine("};").ToString();

            Clipboard.SetText(text);
        }

    }
}
