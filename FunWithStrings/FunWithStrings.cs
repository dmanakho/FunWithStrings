using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithStrings
{
    public partial class FunWithStrings : Form
    {
        public FunWithStrings()
        {
            InitializeComponent();
        }

        private void buttonMonogram_Click(object sender, EventArgs e)
        {
            var monogram = new Monogram(textFirstName.Text, textLastName.Text, textMiddleName.Text);
            labelMonogram.Text = monogram.GetMonogram();
            
        }

        private void buttonVowels_Click(object sender, EventArgs e)
        {
            var vowels = new VowelCounter();
            vowels.Sentence = textSentence.Text.ToLower();
            labelVowels.Text = vowels.GetVowelNo().ToString();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            var rev = new StringReverser();
            rev.Sentence = textReverse.Text;
            labelReversed.Text = rev.Reverse();
        }
    }
}
