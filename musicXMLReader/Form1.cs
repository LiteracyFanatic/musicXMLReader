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
using System.Text.RegularExpressions;

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

                if (!String.Equals(Path.GetExtension(openMusicDialog.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Please select a valid Music XML file.", "Incompatible file type",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    XDocument doc = XDocument.Load(file);
                    myPiece = Piece.Create(doc);

                    partsListBox.Items.Clear();

                    foreach (Part myPart in myPiece.PartList)
                    {
                        partsListBox.Items.Add(myPart.ID + " - " + myPart.Name);
                    }

                    partsListBox.SelectedIndex = 0;
                    copyButton.Enabled = true;
                }

            }
        }

        private void partsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part curPart = myPiece.PartList.ElementAt(partsListBox.SelectedIndex);

            //tempoBox.Text = curPart.Tempo.ToString();
            divisionBox.Text = curPart.Division.ToString();

            notesBox.Text = String.Join(", ", curPart.Notes);
            timesBox.Text = String.Join(", ", curPart.Times);
            durationsBox.Text = String.Join(", ", curPart.Durations);
            rawBox.Text = curPart.Raw;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Part curPart = myPiece.PartList.ElementAt(partsListBox.SelectedIndex);

            string text = $@"
                |const unsigned int {nameBox.Text}Notes[] PROGMEM =
                |{{
                |   {String.Join(", ", curPart.Notes)}
                |}};
                |
                |const unsigned int {nameBox.Text}Times[] PROGMEM =
                |{{
                |    {String.Join(", ", curPart.Times)}
                |}};"
                .StripLeadingWhitespace();

            Clipboard.SetText(text);
        }

    }
}