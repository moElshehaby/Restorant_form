using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        // declare unit price to different meals and drinks  
        double firesup = 30, burgerup = 80, saladup = 20, sandwichup = 50, cheeseup = 40;
        double teaup = 10, chocolataup = 90, colaup = 25, pancakesup = 70, orangeup = 30;
        // declare variable to hold total price for each drinks and meals
        double firestp, burgertp, saladtp, sandwichtp, cheesetp, teatp, chocolatatp, colatp, pancakestp, orangetp;
        double subtotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriesTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaladTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void Subtotallbl_Click(object sender, EventArgs e)
        {

        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            CheeseCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            ChocolateCb.Checked = false;
            PancakesCb.Checked = false;
            OrangeCb.Checked = false;

            

        }

        private void Grdtotaible_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //String ReceipTb = "";
            e.Graphics.DrawString(richTextBox1.Text+ "subtotal" + Subtotallbl.Text + "\nTax:" + taxlbl.Text + "\nGrand Total" + Grdtotallbl.Text, new Font("Century Gothic", 10, FontStyle.Regular),Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void SandwichTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheeseTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrangeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PancakesTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColaTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChocolateTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeaTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firestp = firesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            chocolatatp = chocolataup * Convert.ToDouble(ChocolateTb.Text);
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            richTextBox1.Clear();
            //tax = 0;
            //grdtotal = 0;
            subtotal = 0;
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("\t\t\tCODESPACE RESTAURENT\t\t" +Datelbl.Text+ Environment.NewLine);
            richTextBox1.AppendText("\t\t\t*****************************" + Environment.NewLine);
            if (FriesCb.Checked == true)
            {
                richTextBox1.AppendText("\tFries:\t" + firestp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + firestp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (BurgerCb.Checked == true)
            {
                richTextBox1.AppendText("\tburger:\t" + burgertp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (SaladCb.Checked == true)
            {
                richTextBox1.AppendText("\tsalad:\t" + saladtp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + saladtp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (SandwichCb.Checked == true)
            {
                richTextBox1.AppendText("\tsandwich:\t" + sandwichtp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (CheeseCb.Checked == true)
            {
                richTextBox1.AppendText("\tcheese:\t" + cheesetp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + cheesetp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (TeaCb.Checked == true)
            {
                richTextBox1.AppendText("\ttea:\t" + teatp + "  EG Bound" + Environment.NewLine);
                subtotal = subtotal + teatp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (ChocolateCb.Checked == true)
            {
                richTextBox1.AppendText("\tchocolata:\t" + chocolatatp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + chocolatatp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (ColaCb.Checked == true)
            {
                richTextBox1.AppendText("\tcola:\t" + colatp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + colatp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (PancakesCb.Checked == true)
            {
                richTextBox1.AppendText("\tpancakes:\t" + pancakestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + pancakestp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (OrangeCb.Checked == true)
            {
                richTextBox1.AppendText("\torange:\t" + orangetp + " EG Bound" + Environment.NewLine);
                subtotal = subtotal + orangetp;
                Subtotallbl.Text = "" + subtotal;
            }
            double tax = subtotal * 0.16;
            double grdtotal = subtotal + tax ;
            taxlbl.Text = "  EG Bound" + tax;
            Grdtotallbl.Text = "  EG Bound" + grdtotal;
        }
        private void ReceipTb_TextChange(object sender, EventArgs e)
        {

        }
    
    }
}
