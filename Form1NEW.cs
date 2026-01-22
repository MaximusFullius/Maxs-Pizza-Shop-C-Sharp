using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MaxsPizzaShop
{
    public partial class Form1 : Form
    {
        const float fltTax = .075f; //class-level variable
        const Single sngSmallPr = 8.0f;
        const Single sngRegPr = 10.0f;
        const Single sngLrgPr = 12.0f;
        const Single sngTopPr = 1.0f;
        public Single sngPrice = 0.0f;
        public Single sngCost = 0.0f;
        public Single sngQuantity = 0;
        public Single sngTax = 0.0f;
        public bool bNameValid = false;
        public bool bPhoneValid = false;
        public bool bAddr1Valid = false;
        public bool bCityValid = false;
        public bool bZipValid = false;
        //bool bPayValid = false;

        //Single sngArrivEst = 0.0f;


        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            btnOrder.Enabled = false;
            btnOrder.BackColor = Color.Gray;
            btnOrder.ForeColor = Color.Red;
            lblInvalidDataWarning.Visible = true;
            radSizeReg.Checked = true;
            chkTopChe.Checked = true;
            sngQuantity = 1;
            cbState.Items.AddRange(File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "StateAbbrev.txt")).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
            //Above this comment is a way to import the contents of a .txt list into a ComboBox's option-list, found via StackOverflow. It appears to work decently.
            cbState.Text = "MN";
            cbPayMethod.Text = "[SELECT]";
            Payment pay = new Payment();
            sngCost = pay.CalcPay();

        }
        
        public void Form1_KeyPress(object sender, KeyPressEventArgs e) //check for valid data after every key press
        {
            
            
        }

        private void btnOrder_EnabledChanged(object sender, EventArgs e)
        {
            if (btnOrder.Enabled == false)
            {
                ttAccept.ToolTipTitle = "Please enter all info before ordering.";
                ttAccept.SetToolTip(btnOrder, "You have not filled-out all of the neccesary info to order. If you are having issues with this app, please contact the developer.");
            }
            if (btnOrder.Enabled == true)
            {
                ttAccept.ToolTipTitle = "Order your Pizza Now!";
                ttAccept.SetToolTip(btnOrder, "It will come in about an hour!");
            }
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90) //allow A-Z uppercase
            { }
            else if (e.KeyChar >= 97 && e.KeyChar <= 122) //allow a-z lowercase
            { }
            else if (e.KeyChar == 8) //allow backspace
            { }
            else if (e.KeyChar == 32) //allow space
            { }
            //else if (e.KeyChar )

            else
            { e.Handled = true; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset user info
            txtCustName.Clear();
            mtbCustPhone.Clear();
            txtAddressOne.Clear();
            txtAddressTwo.Clear();
            txtCity.Clear();
            mtbZip.Clear();
            sngQuantity = 1;

            foreach (Control c in grpOrderToppings.Controls) //This is a for-loop that clears every topping checkbox when the "Clear" button is clicked
            {
                CheckBox chkbox = c as CheckBox;
                if (chkbox.Name != "chkTopChe" && chkbox.Checked)
                {
                    chkbox.Checked = false; //This is supposed to Un-Check any checkbox the loop finds checked.
                }
            }
            chkTopChe.Checked = true; //re-check cheese topping

            //reset payment info
            cbPayMethod.Text = "[SELECT]";
            mtbPayCardCode.Clear();

            btnOrder.Enabled = false;
            bNameValid = false;
            bPhoneValid = false;
            bAddr1Valid = false;
            bCityValid = false;
            bZipValid = false;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (btnOrder.Enabled == true)
            {
                string CustInfo = "";
                Payment payment = new Payment(); //calculate payment
                sngCost = payment.CalcPay();
                MessageBox.Show("Pizza Ordered. Total payment due is: " + sngCost);
                
                Customer objCust = new Customer(txtCustName.Text, mtbCustPhone.Text, txtAddressOne.Text, txtAddressTwo.Text, txtCity.Text, cbState.Text, mtbZip.Text);
                CustInfo = ("\n" + objCust.CustNameProp + " | " + objCust.CustPhoneProp + " | " + objCust.CustAddr1Prop + " | " + objCust.CustAddr2Prop +
                    " | " + objCust.CustCityProp + " | " + objCust.CustStateProp + " | " + objCust.CustZipProp);

                MessageBox.Show("Does this info look correct?" + CustInfo);

                

                //CREATE TRANSACTION LOG 
                string strLog = Application.StartupPath + "/../../TransLog.txt";
                FileStream fslog = new FileStream(strLog, FileMode.Append, FileAccess.Write);
                StreamWriter swLog = new StreamWriter(fslog);

                // TODO: Update this WriteLine output format for database compatability.
                // TODO: Make 
                swLog.WriteLine(txtCustName.Text + "\t" + lblDateTime.Text + CustInfo + "\n" + sngCost + "\n" + "------------------------------------");

                swLog.Close();

                //END CREATE TRANSACTION LOG
            }
            else
            {

            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Are you sure you want to close? You will lose your order progress!", "Close and cancel order?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.Yes) // Closes program if user clicked yes
            {
                this.Close();
            }

        }

        public void btnPrice_Click(object sender, EventArgs e) // CHANGED TO PUBLIC
        {
            if (btnOrder.Enabled == true)
            {
                float sngCost = 0;
                Payment pizza = new Payment();
                sngCost = pizza.CalcPay();

                string strPizzaSize = pizza.PizzaSize("size");

                DialogResult resPriceBox = MessageBox.Show(strPizzaSize + " Pizza Selected. The Total Price: " + sngCost.ToString("c")); //Print out the price after calculation

                //RESET PRICE VALUES so that they don't add up when the user presses the "Price" button more than once.
                if (resPriceBox == DialogResult.OK || resPriceBox == DialogResult.Cancel)
                {
                    //sngPrice = 0.0f;
                    //topCount = 0.0f;
                }
            }
        }

        private void timDateTimeTicker_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + "  |  " + DateTime.Now.ToLongTimeString();
        }


        private void nudQuantity_Validated(object sender, EventArgs e)
        {
            sngQuantity = (float)nudQuantity.Value; //Are you SURE this needs to be a float?
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            sngQuantity = (float)nudQuantity.Value;
        }

        
        
        private void cbPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayMethod.Text == "American Express")
            {
                mtbPayCardCode.Visible = true; //show the card code box once the user selected a pay method.
                lblCardNum.Visible = true; //show the card number label, too.
                mtbPayCardCode.Mask = "9999-999999-99999";
            }
            else if (cbPayMethod.Text == "Visa" || cbPayMethod.Text == "Mastercard")
            {
                mtbPayCardCode.Visible = true; //show the card code box once the user selected a pay method.
                lblCardNum.Visible = true; //show the card number label, too.
                mtbPayCardCode.Mask = "9999-9999-9999-9999";
            }
            else if (cbPayMethod.Text == "Cash" || cbPayMethod.Text == "Check")
            {
                mtbPayCardCode.Visible = false; //hide the card code box if the user selects "cash" or "check".
                MessageBox.Show("You have chosen 'cash' or 'check' as your payment method. Remember to have this physical payment method ready for exchange for when the pizza man arrives.");
            }
        }
        

        public void txtCustName_Validating(object sender, CancelEventArgs e) //changed "private" to "public"
        {
            if (txtCustName.Text.Length > 4)
            {
                //e.Cancel = false;
                bNameValid = true;
                txtCustName.ForeColor = Color.Green;
            }
            else
            {
                //e.Cancel = true;
                bNameValid = false;
                txtCustName.ForeColor = Color.Red;

            }
        }

        public void mtbCustPhone_Validating(object sender, CancelEventArgs e) //changed "private" to "public"
        {
            if (mtbCustPhone.MaskCompleted == true)
            {
                //e.Cancel = false;
                bPhoneValid = true;
                mtbCustPhone.ForeColor = Color.Green;
            }
            else
            {
                //e.Cancel = true;
                bPhoneValid = false;
                mtbCustPhone.ForeColor = Color.Red;

            }
        }
        
        
        public void txtAddressOne_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddressOne.Text.Length > 4)
            {
                //e.Cancel = false;
                bAddr1Valid = true;
                txtAddressOne.ForeColor = Color.Green;
            }
            else
            {
                //e.Cancel = true;
                bAddr1Valid = false;
                txtAddressOne.ForeColor = Color.Red;

            }
        }

        public void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtCity.Text.Length > 1)
            {
                //e.Cancel = false;
                bCityValid = true;
                txtCity.ForeColor = Color.Green;
            }
            else
            {
                //e.Cancel = true;
                bCityValid = false;
                txtCity.ForeColor = Color.Red;

            }
        }

        public void mtbZip_Validating(object sender, CancelEventArgs e)
        {
            if (mtbZip.MaskFull == true)
            {
                //e.Cancel = false;
                bZipValid = true;
                mtbZip.ForeColor = Color.Green;
            }
            else
            {
                //e.Cancel = true;
                bZipValid = false;
                mtbZip.ForeColor = Color.Red;

            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (bNameValid == true && bPhoneValid == true && bAddr1Valid == true && bCityValid == true && bZipValid == true) // && bPayValid == true <-- TODO: Set up "bPayValid" 
            {
                btnOrder.Enabled = true;
                btnOrder.BackColor = Color.OliveDrab;
                btnOrder.ForeColor = Color.Black;
                lblInvalidDataWarning.Visible = false;
            }
            else
            {
                MessageBox.Show("One or more of your informational data are incorrectly formatted and/or incomplete. Please correct and try again.");
                btnOrder.Enabled = false;
                btnOrder.BackColor = Color.Gray;
                btnOrder.ForeColor = Color.Red;
                lblInvalidDataWarning.Visible = true;
            }
        }

        private void grpOrderInfo_Click(object sender, System.EventArgs e)
        {
            
        }

       public class Payment : Form1
        {
            public string PizzaSize(string what)    // get pizza size and price
            {                                       // 'size' returns size, 'price' returns price.
                float price = 0.0f;
                string strSize = "";
                // Check pizza size selection
                if (radSizeSmall.Checked)
                {
                    strSize = "Small";
                    price += sngSmallPr;
                }
                else if (radSizeLrg.Checked)
                {
                    strSize = "Large";
                    price += sngLrgPr;
                }
                else if (radSizeReg.Checked)
                {
                    strSize = "Regular";
                    price += sngRegPr;
                }

                if (what == "size")
                {
                    return strSize;
                }
                else if (what == "price")
                {
                    return price.ToString(); // I don't want to have to convert the Single to a string just to return it
                }
                else
                {
                    return "ERROR: 'PizzaSize' can only return a 'size' or a 'price'!";
                }
            }

            public float PizzaToppings()   //get pizza toppings and price
            {                               
                int topCount = 0;           //"topCount" is the total price of the toppings, which is later added to the total price, "sngPrice".
                float TopPr = 0.0f;     // Total cost for toppings.
                bool flag = false;          //Default: no toppings are choosen

                foreach (Control c in grpOrderToppings.Controls) // This is basically a for-loop that adds $1 for every "topping" serving checked.
                {                                                // TODO: Add special prices for certain toppings.
                    CheckBox chkbox = c as CheckBox;
                    if (chkbox != null && chkbox.Checked)
                    {
                        flag = true;
                        topCount += 1;
                    }
                }
                if (flag == true)
                {
                    TopPr = topCount;
                    return TopPr;
                }
                else
                {
                    TopPr = 0;
                    return TopPr;
                }
                
            }

            public float CalcPay()
            {
                //RESET PRICE VALUES so that they don't add up when the user presses the "Price" button more than once.
                Single sngTax = 0.0f;
                Single sngPrice = 0.0f;
                // By this point, a pizza size is selected and the user wants to check the price

                sngPrice += PizzaToppings(); //Add toppings price to pizza size price

                sngPrice += float.Parse(PizzaSize("price")); //get the price for the selected pizza size and add that to the price. 

                sngPrice = sngPrice * sngQuantity; // Multiply the price by the number of (DUPLICATE) pizzas

                lblSubtotalNum.Text = sngPrice.ToString(); //set subtotal label text for Price box

                sngTax = 0.07f * sngPrice; //Sales tax is 7 percent of whatever the final price would've been otherwise.

                lblTaxNum.Text = sngTax.ToString(); //set Tax label text for Price box

                sngPrice += sngTax;

                lblTotalNum.Text = sngPrice.ToString(); //set Total label text for Price box  

                return sngPrice;
            }
          
            
        }
    }    
}

