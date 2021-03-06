﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumTransformer
{
    public partial class numberTransformer : Form
    {
        public numberTransformer()
        {
            InitializeComponent();
        }

        private void romanTransformerBTN_Click(object sender, EventArgs e)
        {
            string Arabic;
            Arabic = arabicToRoman.ArabicConverter(int.Parse(inArabicNumTB.Text));
            outRomanNumLB.Text = Arabic.ToString();
        }

        private void arabicTransformerBTN_Click(object sender, EventArgs e)
        {
            int Roman;
            Roman = romanToArabic.RomanConverter(inRomanNumTB.Text);
            outArabicNumLB.Text = Roman.ToString();
        }
    }
}
