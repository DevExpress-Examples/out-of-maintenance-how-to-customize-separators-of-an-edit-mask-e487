using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomCulture {
    public partial class Form1 : Form {
        [STAThread]
        static void Main() {
            // set the modified culture globally
            //System.Globalization.CultureInfo culture;
            //culture = System.Threading.Thread.CurrentThread.CurrentCulture.Clone() as System.Globalization.CultureInfo;
            //culture.NumberFormat.NumberDecimalSeparator = ",";
            //culture.NumberFormat.NumberGroupSeparator = " ";
            //System.Threading.Thread.CurrentThread.CurrentCulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            textEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            textEdit1.EditValue = 1234.56789m;
            textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            textEdit2.Properties.Mask.UseMaskAsDisplayFormat = true;
            textEdit2.EditValue = 1234.56789m;

            //assign the modified culture only to a given editor
            System.Globalization.CultureInfo culture;
            culture = System.Threading.Thread.CurrentThread.CurrentCulture.Clone() as System.Globalization.CultureInfo;
            culture.NumberFormat.NumberDecimalSeparator = ",";
            culture.NumberFormat.NumberGroupSeparator = " ";
            textEdit1.Properties.Mask.Culture = culture;
        }
    }
}