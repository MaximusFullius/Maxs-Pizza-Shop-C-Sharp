using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;

namespace MaxsPizzaShop
{
    public partial class Form1 : Form
    {
        const float fltTax = .075f; //class-level variable
        public const Single sngSmallPr = 8.0f;
        public const Single sngRegPr = 10.0f;
        public const Single sngLrgPr = 12.0f;
        public const Single sngTopPr = 1.0f;
        public double dblCost = 0.0f;
        public Single sngQuantity = 1;
        public bool bNameValid = false;
        public bool bPhoneValid = false;
        public bool bAddr1Valid = false;
        public bool bCityValid = false;
        public bool bZipValid = false;
        public string strSize = "";
        public const double dblTaxRate = 0.07;
        public double dblTax = 0;
        public string strFullAddress = "";
        public bool bFullAddressValid = false;
        public string webData = "";
        public int intMonthPlsNine = (DateTime.Now.Month) + 9;


        public string strFoundName, strFoundAddr1, strFoundAddr2, strFoundCity, strFoundState, strFoundZip;

        //bool bPayValid = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOrderNumInt.Text = OrderNum(); // Get new order number
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

            
            CalcPay();
        }

        private void btnOrder_EnabledChanged(object sender, EventArgs e)
        {
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
            else
            { e.Handled = true; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to reset everything? You will need to re-type all of your " +
                "customer information to continue.", "Reset Order Info?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.Yes)
            {
                btnOrder.Enabled = false; // While clearing, temporarily disable the Order button.
                btnOrder.BackColor = Color.Gray;
                btnOrder.ForeColor = Color.Red;
                lblInvalidDataWarning.Visible = true;
                lblCardNum.Visible = false;
                mtbPayCardCode.Visible = false;
                // Clear user info
                txtCustName.Clear();    // Clear Name
                bNameValid = false;
                txtCustName.ForeColor = Color.Black;
                mtbCustPhone.Clear();   // Clear Phone number
                bPhoneValid = false;
                mtbCustPhone.ForeColor = Color.Black;
                txtAddressOne.Clear();  // Clear Address line 1
                bAddr1Valid = false;
                txtAddressOne.ForeColor = Color.Black;
                txtAddressTwo.Clear();  // Clear Address line 2 (optional, uncolored)
                txtCity.Clear();        // Clear City
                bCityValid = false;
                txtCity.ForeColor = Color.Black;
                cbState.Text = "MN";    // Reset State to "MN"
                mtbZip.Clear();         // Reset Zip code
                bZipValid = false;
                mtbZip.ForeColor = Color.Black;
                // Reset Order Info
                radSizeSmall.Checked = false;   // Reset pizza size radio boxes to "Regular"
                radSizeLrg.Checked = false;
                radSizeReg.Checked = true;
                strSize = "Regular";
                nudQuantity.Value = 1;  // Reset quantity nud to 1
                                        //This is a for-loop that clears every topping checkbox when the "Clear" button is clicked
                foreach (Control c in grpOrderToppings.Controls)
                {
                    CheckBox chkbox = c as CheckBox;
                    
                    if (chkbox.Checked)
                    {
                        chkbox.Checked = false; //This is supposed to Un-Check any checkbox the loop finds checked.
                    }
                }
                chkTopChe.Checked = true; // Re-check cheese topping.
                                          // Reset payment info
                cbPayMethod.Text = "[SELECT]";
                mtbPayCardCode.Clear();
                CalcPay();
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (btnOrder.Enabled == true)
            {
                string CustInfo = "";

                dblCost = CalcPay();

                if (txtAddressTwo.Text == "")
                {
                    txtAddressTwo.Text = "[NO ADDRESS LINE 2]";
                }
                
                Customer objCust = new Customer(txtCustName.Text, mtbCustPhone.Text, txtAddressOne.Text, txtAddressTwo.Text, txtCity.Text, cbState.Text, mtbZip.Text);

                // TODO: Add verification steps for Payment info.

                CustInfo = ("\n" + objCust.CustNameProp + "\n" + objCust.CustPhoneProp + "\n" + objCust.CustAddr1Prop + "\n" + objCust.CustAddr2Prop +
                    "\n" + objCust.CustCityProp + "\n" + objCust.CustStateProp + "\n" + objCust.CustZipProp);

                DialogResult dlgResult = MessageBox.Show("If this info looks correct, press 'Yes' to order your pizza:" + CustInfo, "Does this info look correct?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (dlgResult == DialogResult.Yes)
                {
                    //CREATE TRANSACTION LOG 
                    string strLog = Application.StartupPath + "/../../TransLog.txt";
                    FileStream fslog = new FileStream(strLog, FileMode.Append, FileAccess.Write);
                    StreamWriter swLog = new StreamWriter(fslog);
                    swLog.WriteLine("Order Number: " + lblOrderNumInt.Text + "\n" + "Date/Time: " + lblDateTime.Text + "\n" + "Customer Info: " + "\n" + CustInfo + "\n" + 
                        "Total Payment: " + dblCost.ToString("c") + "\n" + "-----------------END OF ORDER " + lblOrderNumInt.Text + "-------------------" + "\n");
                    swLog.Close();
                    //END CREATE TRANSACTION LOG
                    MessageBox.Show("Pizza Ordered. Total payment due is: " + dblCost.ToString("c"));

                    CustDbConnect(); // ~~ APPEND CUSTOMER AND ORDER DATA TO 'Pizza' DATABASE ~~

                    txtAddressTwo.Clear();
                    lblOrderNumInt.Text = OrderNum();
                }
            }
        }
        private void CustDbConnect()
        {
            // Get a connection to the database
            string strDbFileSrc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Pizza.mdf;"; // changed strDataSrc to strDbFileSrc
            string strSQLparms = "Integrated Security=true;Connect Timeout=5";
            string strConnString = strDbFileSrc + strSQLparms;
            SqlConnection cnSQL = new SqlConnection(strConnString);

            string strCustNameDB = txtCustName.Text;
            string strCustPhoneDB = mtbCustPhone.Text;
            string strCustAddr1DB = txtAddressOne.Text;
            string strCustAddr2DB = txtAddressTwo.Text;
            string strCustCityDB = txtCity.Text;
            string strCustStateDB = cbState.Text;
            string strCustZipDB = mtbZip.Text;

            string strDbOrderNum = lblOrderNumInt.Text; // GET ORDER NUMBER
            int intdbOrderNum = int.Parse(strDbOrderNum); // PARSE order nubmer as string

            // SQL COMMAND:
            string strCustSQL = "SELECT * FROM Customers WHERE custname = '" + strCustNameDB + "';";
            DataTable dtCustDataTable = new DataTable();

            try // opening the DB file
            {
                cnSQL.Open();
                MessageBox.Show("DB found. Opening...");
            }
            catch
            {
                MessageBox.Show("Unable to open " + strDbFileSrc + "...Closing application");
                this.Close();
            }
            try // connecting to database
            {
                SqlDataAdapter daCustDataAdapter = new SqlDataAdapter(strCustSQL, cnSQL);
            }
            catch
            {
                MessageBox.Show("Error retrieving customer data");
                dtCustDataTable.Dispose();
            }
            try // adding data
            {
                SqlDataAdapter daCustDataAdapter = new SqlDataAdapter(strCustSQL, cnSQL); // I need this again...?
                daCustDataAdapter.FillSchema(dtCustDataTable, SchemaType.Source);
                DataRow newCust;
                newCust = dtCustDataTable.NewRow();
                newCust["CustPhone"] = strCustPhoneDB;
                newCust["CustName"] = strCustNameDB;
                newCust["CustAddress1"] = strCustAddr1DB;
                newCust["CustAddress2"] = strCustAddr2DB;
                newCust["CustCity"] = strCustCityDB;
                newCust["CustState"] = strCustStateDB;
                newCust["CustZip"] = strCustZipDB;
                newCust["CustOrderNum"] = intdbOrderNum; // ORDER NUMBER

                dtCustDataTable.Rows.Add(newCust);
                SqlCommandBuilder cmdBld = new SqlCommandBuilder(daCustDataAdapter);
                cmdBld.GetUpdateCommand(); // Collect updates to Datatable (generaties SQL "INSERT" command.)
                daCustDataAdapter.Update(dtCustDataTable);

                MessageBox.Show("Customer Added Successfully.");

                daCustDataAdapter.Fill(dtCustDataTable);
                daCustDataAdapter.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show("Customer Add Failed!");
            }
            finally
            {
                cnSQL.Close();
                cnSQL.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrice_Click(object sender, EventArgs e) // CHANGED TO PUBLIC
        {
            double dblTaxRatePercent = dblTaxRate * 100;
            dblCost = CalcPay();

            string strSizeTabs = strSize;
            string strDaTabz = "";

            if (strSizeTabs == "Regular")
            {
                strDaTabz = "\t";
            }
            else // Large or Small pizza 
            {
                strDaTabz = "\t \t";
            }
            //string strPizzaSize = pizza.PizzaSize("size");
            MessageBox.Show("Toppings price: \t \t \t" + PizzaToppings().ToString("c") + "\n" + "Cost per " + strSize + "-sized Pizza: " + strDaTabz +
                PizzaSize().ToString("c") + "\n" + "Quantity: \t \t \t" + sngQuantity + " pizza(s)" + "\n" + "Tax rate: \t \t \t \t" + dblTaxRatePercent + "%" + "\n" +
                "Tax amount: \t \t \t" + dblTax.ToString("c") + "\n" + "-----" + "\n" + "Total amount due: \t \t" + dblCost.ToString("c"), "Price Explaination");
        }

        private void timDateTimeTicker_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + "  |  " + DateTime.Now.ToLongTimeString();
        }

        public void nudQuantity_Validated(object sender, EventArgs e)
        {
            sngQuantity = (float)nudQuantity.Value; //Are you SURE this needs to be a float?
        }

        public void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            sngQuantity = (float)nudQuantity.Value;
            CalcPay();
        }
        
        private void cbPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayMethod.Text == "American Express" || cbPayMethod.Text == "Visa" || cbPayMethod.Text == "Mastercard") // If user selects a card for payment.
            {
                lblCardNum.Visible = true; //show the card number label, too.
                mtbPayCardCode.Visible = true; //show the card code box once the user selected a pay method.
                mtbPayCardCode.Enabled = true;
                lblPaySVC.Visible = true;
                mtbPaySVC.Visible = true;
                mtbPaySVC.Enabled = true;
                lblPayExpirDate.Visible = true;
                mtbPayExpirDate.Visible = true;
                mtbPayExpirDate.Enabled = true;

                if (cbPayMethod.Text == "American Express")
                {
                    mtbPayCardCode.Mask = "9999-999999-99999";
                }
                else if (cbPayMethod.Text == "Visa" || cbPayMethod.Text == "Mastercard")
                {
                    
                    mtbPayCardCode.Mask = "9999-9999-9999-9999";
                }
            }
            
            else if (cbPayMethod.Text == "Cash" || cbPayMethod.Text == "Check") // If user selects "cash" or "check".
            {
                // Disable the mtb's first, to insure that the user doesn't somehow load the data at the last moment.
                mtbPayCardCode.Enabled = false; // Disable card number mtb.
                mtbPaySVC.Enabled = false;  // Disable card SVC number mtb.
                mtbPayExpirDate.Enabled = false;  // Disable expiration date mtb.
                lblCardNum.Visible = false; // Hide card number label.
                mtbPayCardCode.Visible = false; // Hide card number mtb.
                lblPaySVC.Visible = false;  // Hide SVC label.
                mtbPaySVC.Visible = false;  // Hide SVC mtb.
                lblPayExpirDate.Visible = false;    // Hide expiration date label.
                mtbPayExpirDate.Visible = false;    // Hide expireation date mtb.
                MessageBox.Show("You have chosen 'cash' or 'check' as your payment method. Remember to have this physical payment method ready for exchange for when the pizza man arrives.");
            }
        }

        public void txtCustName_Validating(object sender, EventArgs e) //changed "private" to "public"
        {

        }

        public void mtbCustPhone_Validating(object sender, EventArgs e) //changed "private" to "public"
        {
            if (mtbCustPhone.MaskCompleted == true) // phone number validated.
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

        public void txtAddressOne_Validating(object sender, EventArgs e)
        {
            // I was going to set up a Google-Maps lookup to verify if the address exists, but apparently I'd need to pay Google for an API key to do that... 
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

        public void txtCity_Validating(object sender, EventArgs e)
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

        public void mtbZip_Validating(object sender, EventArgs e)
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
            txtCustName_Validating(sender, e);
            mtbCustPhone_Validating(sender, e);
            txtAddressOne_Validating(sender, e);
            txtCity_Validating(sender, e);
            mtbZip_Validating(sender, e);

            if (bNameValid == true && bPhoneValid == true && bAddr1Valid == true && bCityValid == true && bZipValid == true) // && bPayValid == true <-- TODO: Set up "bPayValid" 
            {
                btnOrder.Enabled = true;
                btnOrder.BackColor = Color.OliveDrab;
                btnOrder.ForeColor = Color.Black;
                lblInvalidDataWarning.Visible = false;
                MessageBox.Show("Looks good. Info ready to process!");
            }
            else // If other entered user data is invalid, stop everything before looking if the address exists
            {
                MessageBox.Show("One or more of your informational data are incorrectly formatted and/or incomplete. Please correct and try again.");
                btnOrder.Enabled = false;
                btnOrder.BackColor = Color.Gray;
                btnOrder.ForeColor = Color.Red;
                lblInvalidDataWarning.Visible = true;
            }
        }

        public string OrderNum()
        {
            int intOrderNum;
            string strNewOrderNum = "";
            //CREATE TRANSACTION LOG 
            string strLog = Application.StartupPath + "/../../TransLog.txt";
            FileStream fslog = new FileStream(strLog, FileMode.Open, FileAccess.Read);
            StreamReader swLog = new StreamReader(fslog);
            string line = "";
            string temp = "";
            List<int> lstONArray = new List<int>();
            long lngFileTextLength = new FileInfo(strLog).Length;

            if (lngFileTextLength != 0)
            {
                while (line != null)
                {
                    line = swLog.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains("Order Number: "))
                        {
                            temp = line.Substring(14, 4); // Take the first 4 characters of the order number string,
                            if (temp != "0000")
                            {
                                temp = temp.TrimStart(new char[] { ' ', '0' }); // trim any leftover leading spaces and zeros,
                            }
                            lstONArray.Add(Int32.Parse(temp)); // convert the string into an integer and add the new integer to the list for later comparison.
                        }
                    }
                }
                intOrderNum = lstONArray.Max(); //Get largest (latest) order number.
                intOrderNum += 1; // Add one to the latest order number to get the new order number.
                strNewOrderNum = String.Format("{0:0000}", intOrderNum); // Convert the new order number to a string with proper 4-zero formatting.
                swLog.Close();
                return strNewOrderNum;
                //END CREATE TRANSACTION LOG
            }

            else // If the order-log text file is empty, just use an order number of "0000".
            {
                strNewOrderNum = "0000";
                return strNewOrderNum;
            }
        }

        public float PizzaSize()    // get pizza size and price. 'size' returns size, 'price' returns price.
        {
            float price = 0.0f;
            
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
            return price;
        }

        public float PizzaToppings()   //get pizza toppings and price
        {
            int topCount = 0;           // "topCount" is the total price of the toppings, which is later added to the total price, "dblPrice".
            float TopPr = 0.0f;         // Total cost for toppings.
            bool flag = false;          // Default: no toppings are choosen

            foreach (CheckBox c in grpOrderToppings.Controls) // This is basically a for-loop that adds $1 for every "topping" serving checked.
            {                                                // TODO: Add special prices for certain toppings. (Optional)
                CheckBox chkbox = c as CheckBox;
                if (chkbox.Checked){
                    flag = true;
                    topCount += 1;
                }
            }
            if (flag == true) {
                TopPr = topCount;
                return TopPr;
            }
            else {
                TopPr = 0;
                return TopPr;
            }
        }

        public double CalcPay()
        {
            //RESET PRICE VALUES so that they don't add up when the user presses the "Price" button more than once.
            dblTax = 0.0f;
            double dblPrice = 0.0f;
            // By this point, a pizza size is selected and the user wants to check the price

            dblPrice += PizzaToppings(); //Add toppings price to pizza size price

            dblPrice += PizzaSize(); //get the price for the selected pizza size and add that to the price. 

            dblPrice = dblPrice * sngQuantity; // Multiply the price by the number of (DUPLICATE) pizzas

            lblSubtotalNum.Text = dblPrice.ToString("c"); //set subtotal label text for Price box
            lblSubtotalNum.Refresh();

            dblTax = 0.07f * dblPrice; //Sales tax is 7 percent of whatever the final price would've been otherwise.

            lblTaxNum.Text = dblTax.ToString("c"); //set Tax label text for Price box
            lblTaxNum.Refresh();

            dblPrice += dblTax;

            lblTotalNum.Text = dblPrice.ToString("c"); //set Total label text for Price box  
            lblTotalNum.Refresh();

            return dblPrice;
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you would like to auto-fill the rest of your customer info with the data found?", "Auto-Fill info?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.Yes)
            {
                txtCustName.Text = strFoundName;
                txtAddressOne.Text = strFoundAddr1;
                if (strFoundAddr2 != "")
                {
                    txtAddressTwo.Text = strFoundAddr2;
                }
                txtCity.Text = strFoundCity;
                cbState.Text = strFoundState;
                mtbZip.Text = strFoundZip;
            }

            btnUpdateInfo_Click(sender, e);
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTopChe_CheckedChanged(object sender, EventArgs e)
        {
            CalcPay();
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                DialogResult dlgProcessQuestion = MessageBox.Show("Are you sure you want to cancel processing your information?",
                "Cancel Info Processing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dlgProcessQuestion == DialogResult.Yes)
                {
                    // Cancel the asynchronous operation.
                    backgroundWorker1.CancelAsync();
                }
            }
        }
        
        private void txtCustName_ForeColorChanged(object sender, EventArgs e)
        {
            if (txtCustName.ForeColor == Color.Green) // Capitalize Customer Name, if valid.
            {
                string strCapitalizeName = txtCustName.Text;
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                txtCustName.Text = textInfo.ToTitleCase(strCapitalizeName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Are you sure you want to close? You will lose your order progress!", "Close and cancel order?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No) // Stops closing program if user clicked no
            {
                e.Cancel = true;
            }
        }

        private void mtbCustPhone_ForeColorChanged(object sender, EventArgs e)
        {
            if (mtbCustPhone.ForeColor == Color.Green) // if the number has been validated, check to see if it already exists in the database.
            {
                string strCustPhoneLU = mtbCustPhone.Text;

                string strDbFileSrc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Pizza.mdf;"; // changed strDataSrc to strDbFileSrc
                string strSQLparms = "Integrated Security=true;Connect Timeout=5";
                string strConnString = strDbFileSrc + strSQLparms;

                SqlConnection cnSQL = new SqlConnection(strConnString);

                // SQL COMMAND:
                string strCustSQL = "SELECT TOP 1* FROM Customers WHERE CustPhone = '" + strCustPhoneLU + "' ORDER BY CustOrderNum DESC;";
                DataTable dtCustDataTable2 = new DataTable();

                try // opening the DB file
                {
                    cnSQL.Open();
                    //MessageBox.Show("DB found. Opening...");

                }
                catch
                {
                    //MessageBox.Show("Unable to open " + strDbFileSrc + "...Closing application");
                    Close();
                }

                try // connecting to database
                {
                    SqlDataAdapter daCustDataAdapter = new SqlDataAdapter(strCustSQL, cnSQL);
                    daCustDataAdapter.Fill(dtCustDataTable2); // This uses the data adapter to fill 'dtCustDataTable2', not the other way around!

                    if (dtCustDataTable2.Rows.Count > 0) // if at least one row is returned by the SQL query, then the phone number was found in the database.
                    {
                        MessageBox.Show("Nice to see you again! Your phone number was found in our order records. Press the 'Auto-Fill' button if you want to" +
                            " fill the rest of the info-boxes with the data found.", "Familiar Phone Number Found");

                        strFoundName = dtCustDataTable2.Rows[0]["CustName"].ToString();
                        strFoundAddr1 = dtCustDataTable2.Rows[0]["CustAddress1"].ToString();

                        string strA2Test = dtCustDataTable2.Rows[0]["CustAddress2"].ToString();
                        if (strA2Test == "NULL" || strA2Test == "[NO ADDRESS LINE 2]")
                        {
                            strFoundAddr2 = "";
                        }
                        else
                        {
                            strFoundAddr2 = strA2Test;
                        }
                        strFoundCity = dtCustDataTable2.Rows[0]["CustCity"].ToString();
                        strFoundState = dtCustDataTable2.Rows[0]["CustState"].ToString();
                        strFoundZip = dtCustDataTable2.Rows[0]["CustZip"].ToString();
                        btnAutoFill.Visible = true;
                        btnAutoFill.Enabled = true;
                    }
                    else{
                        // phone number not found: do nothing.
                    }
                }
                catch
                {
                    //MessageBox.Show("Error retrieving customer data");
                    dtCustDataTable2.Dispose();
                }

                finally
                {
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }
        }
    }
}