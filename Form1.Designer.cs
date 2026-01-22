namespace MaxsPizzaShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCustName = new System.Windows.Forms.Label();
            this.mtbCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddressOne = new System.Windows.Forms.TextBox();
            this.txtAddressTwo = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gboxCustInfo = new System.Windows.Forms.GroupBox();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpOrderToppings = new System.Windows.Forms.GroupBox();
            this.chkTopMsh = new System.Windows.Forms.CheckBox();
            this.chkTopHmb = new System.Windows.Forms.CheckBox();
            this.chkTopOni = new System.Windows.Forms.CheckBox();
            this.chkTopPin = new System.Windows.Forms.CheckBox();
            this.chkTopHam = new System.Windows.Forms.CheckBox();
            this.chkTopBlkOlv = new System.Windows.Forms.CheckBox();
            this.chkTopGrnOlv = new System.Windows.Forms.CheckBox();
            this.chkTopPep = new System.Windows.Forms.CheckBox();
            this.chkTopSsg = new System.Windows.Forms.CheckBox();
            this.chkTopChe = new System.Windows.Forms.CheckBox();
            this.grpOrderSize = new System.Windows.Forms.GroupBox();
            this.radSizeLrg = new System.Windows.Forms.RadioButton();
            this.radSizeReg = new System.Windows.Forms.RadioButton();
            this.radSizeSmall = new System.Windows.Forms.RadioButton();
            this.lblOrderNumInt = new System.Windows.Forms.Label();
            this.lblOrderNumTxt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.timDateTimeTicker = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.grpPayMthd = new System.Windows.Forms.GroupBox();
            this.mtbPayExpirDate = new System.Windows.Forms.MaskedTextBox();
            this.lblPaySVC = new System.Windows.Forms.Label();
            this.lblPayExpirDate = new System.Windows.Forms.Label();
            this.mtbPaySVC = new System.Windows.Forms.MaskedTextBox();
            this.lblPayType = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.mtbPayCardCode = new System.Windows.Forms.MaskedTextBox();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxNum = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotalNum = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ttSizePrice = new System.Windows.Forms.ToolTip(this.components);
            this.ttCheeseTopInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ttQuantityInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.lblInvalidDataWarning = new System.Windows.Forms.Label();
            this.ttAccept = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gboxCustInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpOrderToppings.SuspendLayout();
            this.grpOrderSize.SuspendLayout();
            this.grpPayMthd.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.grpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustName
            // 
            this.lblCustName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCustName.Location = new System.Drawing.Point(44, 19);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(44, 20);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "&Name:";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbCustPhone
            // 
            this.mtbCustPhone.BeepOnError = true;
            this.mtbCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mtbCustPhone.Location = new System.Drawing.Point(101, 45);
            this.mtbCustPhone.Mask = "(999) 000-0000";
            this.mtbCustPhone.Name = "mtbCustPhone";
            this.mtbCustPhone.Size = new System.Drawing.Size(79, 20);
            this.mtbCustPhone.TabIndex = 3;
            this.mtbCustPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCustPhone.ForeColorChanged += new System.EventHandler(this.mtbCustPhone_ForeColorChanged);
            this.mtbCustPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCustPhone_Validating);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(292, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Reset";
            this.ttInfo.SetToolTip(this.btnClear, "Clear all custom entries and reset the order form.");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(683, 16);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(92, 37);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "&Accept";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.EnabledChanged += new System.EventHandler(this.btnOrder_EnabledChanged);
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(41, 44);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "&Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustName
            // 
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCustName.Location = new System.Drawing.Point(101, 19);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(162, 20);
            this.txtCustName.TabIndex = 1;
            this.ttInfo.SetToolTip(this.txtCustName, "Name must be at least 5 characters");
            this.txtCustName.ForeColorChanged += new System.EventHandler(this.txtCustName_ForeColorChanged);
            this.txtCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustName_KeyPress);
            this.txtCustName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustName_Validating);
            // 
            // lblAddress1
            // 
            this.lblAddress1.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblAddress1.Location = new System.Drawing.Point(19, 71);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(69, 20);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address &1:";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddressOne
            // 
            this.txtAddressOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtAddressOne.Location = new System.Drawing.Point(101, 71);
            this.txtAddressOne.MaxLength = 25;
            this.txtAddressOne.Name = "txtAddressOne";
            this.txtAddressOne.Size = new System.Drawing.Size(162, 20);
            this.txtAddressOne.TabIndex = 5;
            this.ttInfo.SetToolTip(this.txtAddressOne, "Address must be at least 5 characters");
            this.txtAddressOne.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressOne_Validating);
            // 
            // txtAddressTwo
            // 
            this.txtAddressTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtAddressTwo.Location = new System.Drawing.Point(101, 97);
            this.txtAddressTwo.MaxLength = 25;
            this.txtAddressTwo.Name = "txtAddressTwo";
            this.txtAddressTwo.Size = new System.Drawing.Size(162, 20);
            this.txtAddressTwo.TabIndex = 7;
            this.ttInfo.SetToolTip(this.txtAddressTwo, "Address line 2 is optional!");
            // 
            // lblAddress2
            // 
            this.lblAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblAddress2.Location = new System.Drawing.Point(19, 97);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(69, 20);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address &2:";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCity.Location = new System.Drawing.Point(54, 123);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 20);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "&City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCity
            // 
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCity.Location = new System.Drawing.Point(101, 123);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(162, 20);
            this.txtCity.TabIndex = 9;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustName_KeyPress);
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblState.Location = new System.Drawing.Point(46, 150);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 20);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "&State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbState
            // 
            this.cbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(101, 149);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(49, 21);
            this.cbState.Sorted = true;
            this.cbState.TabIndex = 11;
            // 
            // lblZip
            // 
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblZip.Location = new System.Drawing.Point(22, 176);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(66, 20);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "&Zip Code:";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbZip
            // 
            this.mtbZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mtbZip.Location = new System.Drawing.Point(101, 176);
            this.mtbZip.Mask = "00000";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(36, 20);
            this.mtbZip.TabIndex = 13;
            this.mtbZip.Validating += new System.ComponentModel.CancelEventHandler(this.mtbZip_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(822, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // gboxCustInfo
            // 
            this.gboxCustInfo.BackColor = System.Drawing.Color.Transparent;
            this.gboxCustInfo.Controls.Add(this.btnAutoFill);
            this.gboxCustInfo.Controls.Add(this.btnUpdateInfo);
            this.gboxCustInfo.Controls.Add(this.lblCustName);
            this.gboxCustInfo.Controls.Add(this.txtCustName);
            this.gboxCustInfo.Controls.Add(this.mtbZip);
            this.gboxCustInfo.Controls.Add(this.mtbCustPhone);
            this.gboxCustInfo.Controls.Add(this.lblZip);
            this.gboxCustInfo.Controls.Add(this.lblPhone);
            this.gboxCustInfo.Controls.Add(this.cbState);
            this.gboxCustInfo.Controls.Add(this.lblAddress1);
            this.gboxCustInfo.Controls.Add(this.lblState);
            this.gboxCustInfo.Controls.Add(this.txtAddressOne);
            this.gboxCustInfo.Controls.Add(this.lblCity);
            this.gboxCustInfo.Controls.Add(this.lblAddress2);
            this.gboxCustInfo.Controls.Add(this.txtCity);
            this.gboxCustInfo.Controls.Add(this.txtAddressTwo);
            this.gboxCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCustInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboxCustInfo.Location = new System.Drawing.Point(95, 108);
            this.gboxCustInfo.Name = "gboxCustInfo";
            this.gboxCustInfo.Size = new System.Drawing.Size(286, 217);
            this.gboxCustInfo.TabIndex = 18;
            this.gboxCustInfo.TabStop = false;
            this.gboxCustInfo.Text = "Customer Information";
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Enabled = false;
            this.btnAutoFill.Location = new System.Drawing.Point(188, 44);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(75, 23);
            this.btnAutoFill.TabIndex = 15;
            this.btnAutoFill.Text = "Auto-Fill!";
            this.ttInfo.SetToolTip(this.btnAutoFill, resources.GetString("btnAutoFill.ToolTip"));
            this.btnAutoFill.UseVisualStyleBackColor = true;
            this.btnAutoFill.Visible = false;
            this.btnAutoFill.Click += new System.EventHandler(this.btnAutoFill_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdateInfo.Location = new System.Drawing.Point(174, 170);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(89, 26);
            this.btnUpdateInfo.TabIndex = 14;
            this.btnUpdateInfo.Text = "Update Info";
            this.ttInfo.SetToolTip(this.btnUpdateInfo, "Process info and see if its all correct. This might take a moment, so please wait" +
        "");
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Black;
            this.lblLogo.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Red;
            this.lblLogo.Location = new System.Drawing.Point(1, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(244, 57);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "Fuller\'s Pizza";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(112, 373);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(235, 25);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Current Date and Time:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpOrderInfo.Controls.Add(this.nudQuantity);
            this.grpOrderInfo.Controls.Add(this.lblQuantity);
            this.grpOrderInfo.Controls.Add(this.grpOrderToppings);
            this.grpOrderInfo.Controls.Add(this.grpOrderSize);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumInt);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumTxt);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(387, 108);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(214, 259);
            this.grpOrderInfo.TabIndex = 21;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Info";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(77, 85);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(36, 20);
            this.nudQuantity.TabIndex = 5;
            this.ttQuantityInfo.SetToolTip(this.nudQuantity, "Change this number to indicate how many of the same kind of pizza you want.");
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            this.nudQuantity.Validated += new System.EventHandler(this.nudQuantity_Validated);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(13, 85);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // grpOrderToppings
            // 
            this.grpOrderToppings.Controls.Add(this.chkTopMsh);
            this.grpOrderToppings.Controls.Add(this.chkTopHmb);
            this.grpOrderToppings.Controls.Add(this.chkTopOni);
            this.grpOrderToppings.Controls.Add(this.chkTopPin);
            this.grpOrderToppings.Controls.Add(this.chkTopHam);
            this.grpOrderToppings.Controls.Add(this.chkTopBlkOlv);
            this.grpOrderToppings.Controls.Add(this.chkTopGrnOlv);
            this.grpOrderToppings.Controls.Add(this.chkTopPep);
            this.grpOrderToppings.Controls.Add(this.chkTopSsg);
            this.grpOrderToppings.Controls.Add(this.chkTopChe);
            this.grpOrderToppings.Location = new System.Drawing.Point(12, 111);
            this.grpOrderToppings.Name = "grpOrderToppings";
            this.grpOrderToppings.Size = new System.Drawing.Size(196, 141);
            this.grpOrderToppings.TabIndex = 3;
            this.grpOrderToppings.TabStop = false;
            this.grpOrderToppings.Text = "&Toppings ($1.00 each)";
            // 
            // chkTopMsh
            // 
            this.chkTopMsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopMsh.Location = new System.Drawing.Point(103, 112);
            this.chkTopMsh.Name = "chkTopMsh";
            this.chkTopMsh.Size = new System.Drawing.Size(80, 17);
            this.chkTopMsh.TabIndex = 19;
            this.chkTopMsh.Text = "Mushrooms";
            this.chkTopMsh.UseVisualStyleBackColor = true;
            this.chkTopMsh.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopHmb
            // 
            this.chkTopHmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopHmb.Location = new System.Drawing.Point(103, 91);
            this.chkTopHmb.Name = "chkTopHmb";
            this.chkTopHmb.Size = new System.Drawing.Size(78, 17);
            this.chkTopHmb.TabIndex = 18;
            this.chkTopHmb.Text = "Hamburger";
            this.chkTopHmb.UseVisualStyleBackColor = true;
            this.chkTopHmb.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopOni
            // 
            this.chkTopOni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopOni.Location = new System.Drawing.Point(103, 68);
            this.chkTopOni.Name = "chkTopOni";
            this.chkTopOni.Size = new System.Drawing.Size(59, 17);
            this.chkTopOni.TabIndex = 17;
            this.chkTopOni.Text = "Onions";
            this.chkTopOni.UseVisualStyleBackColor = true;
            this.chkTopOni.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopPin
            // 
            this.chkTopPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopPin.Location = new System.Drawing.Point(103, 43);
            this.chkTopPin.Name = "chkTopPin";
            this.chkTopPin.Size = new System.Drawing.Size(73, 17);
            this.chkTopPin.TabIndex = 16;
            this.chkTopPin.Text = "Pineapple";
            this.chkTopPin.UseVisualStyleBackColor = true;
            this.chkTopPin.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopHam
            // 
            this.chkTopHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopHam.Location = new System.Drawing.Point(103, 20);
            this.chkTopHam.Name = "chkTopHam";
            this.chkTopHam.Size = new System.Drawing.Size(48, 17);
            this.chkTopHam.TabIndex = 15;
            this.chkTopHam.Text = "Ham";
            this.chkTopHam.UseVisualStyleBackColor = true;
            this.chkTopHam.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopBlkOlv
            // 
            this.chkTopBlkOlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopBlkOlv.Location = new System.Drawing.Point(6, 112);
            this.chkTopBlkOlv.Name = "chkTopBlkOlv";
            this.chkTopBlkOlv.Size = new System.Drawing.Size(85, 17);
            this.chkTopBlkOlv.TabIndex = 14;
            this.chkTopBlkOlv.Text = "Black Olives";
            this.chkTopBlkOlv.UseVisualStyleBackColor = true;
            this.chkTopBlkOlv.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopGrnOlv
            // 
            this.chkTopGrnOlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopGrnOlv.Location = new System.Drawing.Point(6, 89);
            this.chkTopGrnOlv.Name = "chkTopGrnOlv";
            this.chkTopGrnOlv.Size = new System.Drawing.Size(87, 17);
            this.chkTopGrnOlv.TabIndex = 13;
            this.chkTopGrnOlv.Text = "Green Olives";
            this.chkTopGrnOlv.UseVisualStyleBackColor = true;
            this.chkTopGrnOlv.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopPep
            // 
            this.chkTopPep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopPep.Location = new System.Drawing.Point(6, 66);
            this.chkTopPep.Name = "chkTopPep";
            this.chkTopPep.Size = new System.Drawing.Size(74, 17);
            this.chkTopPep.TabIndex = 12;
            this.chkTopPep.Text = "Pepperoni";
            this.chkTopPep.UseVisualStyleBackColor = true;
            this.chkTopPep.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopSsg
            // 
            this.chkTopSsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopSsg.Location = new System.Drawing.Point(6, 43);
            this.chkTopSsg.Name = "chkTopSsg";
            this.chkTopSsg.Size = new System.Drawing.Size(68, 17);
            this.chkTopSsg.TabIndex = 11;
            this.chkTopSsg.Text = "Sausage";
            this.chkTopSsg.UseVisualStyleBackColor = true;
            this.chkTopSsg.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // chkTopChe
            // 
            this.chkTopChe.Checked = true;
            this.chkTopChe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTopChe.Location = new System.Drawing.Point(6, 20);
            this.chkTopChe.Name = "chkTopChe";
            this.chkTopChe.Size = new System.Drawing.Size(62, 17);
            this.chkTopChe.TabIndex = 10;
            this.chkTopChe.Text = "Cheese";
            this.ttCheeseTopInfo.SetToolTip(this.chkTopChe, "Submit as marked if you want any cheese (not extra cheese) on your pizza.");
            this.chkTopChe.UseVisualStyleBackColor = true;
            this.chkTopChe.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // grpOrderSize
            // 
            this.grpOrderSize.Controls.Add(this.radSizeLrg);
            this.grpOrderSize.Controls.Add(this.radSizeReg);
            this.grpOrderSize.Controls.Add(this.radSizeSmall);
            this.grpOrderSize.Location = new System.Drawing.Point(10, 35);
            this.grpOrderSize.Name = "grpOrderSize";
            this.grpOrderSize.Size = new System.Drawing.Size(195, 47);
            this.grpOrderSize.TabIndex = 2;
            this.grpOrderSize.TabStop = false;
            this.grpOrderSize.Text = "Size (hover for info)";
            // 
            // radSizeLrg
            // 
            this.radSizeLrg.AutoSize = true;
            this.radSizeLrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSizeLrg.Location = new System.Drawing.Point(131, 19);
            this.radSizeLrg.Name = "radSizeLrg";
            this.radSizeLrg.Size = new System.Drawing.Size(52, 17);
            this.radSizeLrg.TabIndex = 9;
            this.radSizeLrg.Text = "Large";
            this.ttSizePrice.SetToolTip(this.radSizeLrg, "Large Pizzas are $12 each");
            this.radSizeLrg.UseVisualStyleBackColor = true;
            // 
            // radSizeReg
            // 
            this.radSizeReg.AutoSize = true;
            this.radSizeReg.Checked = true;
            this.radSizeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSizeReg.Location = new System.Drawing.Point(63, 19);
            this.radSizeReg.Name = "radSizeReg";
            this.radSizeReg.Size = new System.Drawing.Size(62, 17);
            this.radSizeReg.TabIndex = 8;
            this.radSizeReg.TabStop = true;
            this.radSizeReg.Text = "Regular";
            this.ttSizePrice.SetToolTip(this.radSizeReg, "Regular size pizzas are $10 each");
            this.radSizeReg.UseVisualStyleBackColor = true;
            this.radSizeReg.CheckedChanged += new System.EventHandler(this.chkTopChe_CheckedChanged);
            // 
            // radSizeSmall
            // 
            this.radSizeSmall.AutoSize = true;
            this.radSizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSizeSmall.Location = new System.Drawing.Point(7, 19);
            this.radSizeSmall.Name = "radSizeSmall";
            this.radSizeSmall.Size = new System.Drawing.Size(50, 17);
            this.radSizeSmall.TabIndex = 7;
            this.radSizeSmall.Text = "Small";
            this.ttSizePrice.SetToolTip(this.radSizeSmall, "Small Pizzas are $9.00 each");
            this.radSizeSmall.UseVisualStyleBackColor = true;
            // 
            // lblOrderNumInt
            // 
            this.lblOrderNumInt.AutoSize = true;
            this.lblOrderNumInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumInt.Location = new System.Drawing.Point(166, 16);
            this.lblOrderNumInt.Name = "lblOrderNumInt";
            this.lblOrderNumInt.Size = new System.Drawing.Size(40, 16);
            this.lblOrderNumInt.TabIndex = 1;
            this.lblOrderNumInt.Text = "0001";
            // 
            // lblOrderNumTxt
            // 
            this.lblOrderNumTxt.AutoSize = true;
            this.lblOrderNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderNumTxt.Location = new System.Drawing.Point(7, 16);
            this.lblOrderNumTxt.Name = "lblOrderNumTxt";
            this.lblOrderNumTxt.Size = new System.Drawing.Size(102, 15);
            this.lblOrderNumTxt.TabIndex = 0;
            this.lblOrderNumTxt.Text = "Order Number:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(80, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Clos&e";
            this.ttInfo.SetToolTip(this.btnClose, "Exit order form");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.Gold;
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.ForeColor = System.Drawing.Color.Black;
            this.btnPrice.Location = new System.Drawing.Point(512, 16);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(82, 37);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "&Price";
            this.ttInfo.SetToolTip(this.btnPrice, "Calculate the estimated total price so far.");
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // timDateTimeTicker
            // 
            this.timDateTimeTicker.Enabled = true;
            this.timDateTimeTicker.Interval = 1;
            this.timDateTimeTicker.Tick += new System.EventHandler(this.timDateTimeTicker_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblDateTime.Location = new System.Drawing.Point(112, 398);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(329, 25);
            this.lblDateTime.TabIndex = 24;
            this.lblDateTime.Text = "[current date and time goes here]";
            // 
            // grpPayMthd
            // 
            this.grpPayMthd.BackColor = System.Drawing.Color.Transparent;
            this.grpPayMthd.Controls.Add(this.mtbPayExpirDate);
            this.grpPayMthd.Controls.Add(this.lblPaySVC);
            this.grpPayMthd.Controls.Add(this.lblPayExpirDate);
            this.grpPayMthd.Controls.Add(this.mtbPaySVC);
            this.grpPayMthd.Controls.Add(this.lblPayType);
            this.grpPayMthd.Controls.Add(this.lblCardNum);
            this.grpPayMthd.Controls.Add(this.mtbPayCardCode);
            this.grpPayMthd.Controls.Add(this.cbPayMethod);
            this.grpPayMthd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayMthd.Location = new System.Drawing.Point(601, 301);
            this.grpPayMthd.Name = "grpPayMthd";
            this.grpPayMthd.Size = new System.Drawing.Size(257, 130);
            this.grpPayMthd.TabIndex = 25;
            this.grpPayMthd.TabStop = false;
            this.grpPayMthd.Text = "Payment Method";
            // 
            // mtbPayExpirDate
            // 
            this.mtbPayExpirDate.Enabled = false;
            this.mtbPayExpirDate.Location = new System.Drawing.Point(110, 98);
            this.mtbPayExpirDate.Mask = "00/0000";
            this.mtbPayExpirDate.Name = "mtbPayExpirDate";
            this.mtbPayExpirDate.Size = new System.Drawing.Size(60, 20);
            this.mtbPayExpirDate.TabIndex = 7;
            this.mtbPayExpirDate.ValidatingType = typeof(System.DateTime);
            this.mtbPayExpirDate.Visible = false;
            // 
            // lblPaySVC
            // 
            this.lblPaySVC.AutoSize = true;
            this.lblPaySVC.Location = new System.Drawing.Point(65, 72);
            this.lblPaySVC.Name = "lblPaySVC";
            this.lblPaySVC.Size = new System.Drawing.Size(39, 13);
            this.lblPaySVC.TabIndex = 6;
            this.lblPaySVC.Text = "SVC: ";
            this.lblPaySVC.Visible = false;
            // 
            // lblPayExpirDate
            // 
            this.lblPayExpirDate.AutoSize = true;
            this.lblPayExpirDate.Location = new System.Drawing.Point(2, 98);
            this.lblPayExpirDate.Name = "lblPayExpirDate";
            this.lblPayExpirDate.Size = new System.Drawing.Size(102, 13);
            this.lblPayExpirDate.TabIndex = 5;
            this.lblPayExpirDate.Text = "Expiration Date: ";
            this.lblPayExpirDate.Visible = false;
            // 
            // mtbPaySVC
            // 
            this.mtbPaySVC.Enabled = false;
            this.mtbPaySVC.Location = new System.Drawing.Point(110, 72);
            this.mtbPaySVC.Mask = "999";
            this.mtbPaySVC.Name = "mtbPaySVC";
            this.mtbPaySVC.Size = new System.Drawing.Size(31, 20);
            this.mtbPaySVC.TabIndex = 4;
            this.mtbPaySVC.Visible = false;
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Location = new System.Drawing.Point(61, 19);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(43, 13);
            this.lblPayType.TabIndex = 3;
            this.lblPayType.Text = "Type: ";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(20, 46);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(84, 13);
            this.lblCardNum.TabIndex = 2;
            this.lblCardNum.Text = "Card Number:";
            this.lblCardNum.Visible = false;
            // 
            // mtbPayCardCode
            // 
            this.mtbPayCardCode.Location = new System.Drawing.Point(110, 46);
            this.mtbPayCardCode.Mask = "9999-9999-9999";
            this.mtbPayCardCode.Name = "mtbPayCardCode";
            this.mtbPayCardCode.Size = new System.Drawing.Size(141, 20);
            this.mtbPayCardCode.TabIndex = 1;
            this.mtbPayCardCode.Visible = false;
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express",
            "Check",
            "Cash"});
            this.cbPayMethod.Location = new System.Drawing.Point(110, 19);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(141, 21);
            this.cbPayMethod.TabIndex = 0;
            this.cbPayMethod.SelectedIndexChanged += new System.EventHandler(this.cbPayMethod_SelectedIndexChanged);
            // 
            // grpPricing
            // 
            this.grpPricing.BackColor = System.Drawing.Color.Transparent;
            this.grpPricing.Controls.Add(this.lblTotalNum);
            this.grpPricing.Controls.Add(this.lblTotal);
            this.grpPricing.Controls.Add(this.lblTaxNum);
            this.grpPricing.Controls.Add(this.lblTax);
            this.grpPricing.Controls.Add(this.lblSubtotalNum);
            this.grpPricing.Controls.Add(this.lblSubtotal);
            this.grpPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPricing.Location = new System.Drawing.Point(607, 212);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(135, 83);
            this.grpPricing.TabIndex = 26;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "Pricing";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(81, 64);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(51, 13);
            this.lblTotalNum.TabIndex = 5;
            this.lblTotalNum.Text = "\"$0.00\"";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(22, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: ";
            // 
            // lblTaxNum
            // 
            this.lblTaxNum.AutoSize = true;
            this.lblTaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxNum.Location = new System.Drawing.Point(81, 45);
            this.lblTaxNum.Name = "lblTaxNum";
            this.lblTaxNum.Size = new System.Drawing.Size(44, 13);
            this.lblTaxNum.TabIndex = 3;
            this.lblTaxNum.Text = "\"$0.00\"";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(35, 45);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 13);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax: ";
            // 
            // lblSubtotalNum
            // 
            this.lblSubtotalNum.AutoSize = true;
            this.lblSubtotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalNum.Location = new System.Drawing.Point(81, 24);
            this.lblSubtotalNum.Name = "lblSubtotalNum";
            this.lblSubtotalNum.Size = new System.Drawing.Size(44, 13);
            this.lblSubtotalNum.TabIndex = 1;
            this.lblSubtotalNum.Text = "\"$0.00\"";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(14, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // grpButtons
            // 
            this.grpButtons.BackColor = System.Drawing.Color.Transparent;
            this.grpButtons.Controls.Add(this.btnClose);
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Controls.Add(this.btnPrice);
            this.grpButtons.Controls.Add(this.btnOrder);
            this.grpButtons.ForeColor = System.Drawing.Color.White;
            this.grpButtons.Location = new System.Drawing.Point(95, 448);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(795, 59);
            this.grpButtons.TabIndex = 27;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Actions";
            // 
            // ttSizePrice
            // 
            this.ttSizePrice.IsBalloon = true;
            this.ttSizePrice.Tag = "";
            this.ttSizePrice.ToolTipTitle = "Pizza Size Price";
            // 
            // ttCheeseTopInfo
            // 
            this.ttCheeseTopInfo.IsBalloon = true;
            this.ttCheeseTopInfo.ToolTipTitle = "Cheese Topping";
            // 
            // ttQuantityInfo
            // 
            this.ttQuantityInfo.IsBalloon = true;
            this.ttQuantityInfo.ToolTipTitle = "# of Identical Pizzas";
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            this.ttInfo.ToolTipTitle = "General Info";
            // 
            // lblInvalidDataWarning
            // 
            this.lblInvalidDataWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidDataWarning.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDataWarning.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDataWarning.Location = new System.Drawing.Point(876, 448);
            this.lblInvalidDataWarning.Name = "lblInvalidDataWarning";
            this.lblInvalidDataWarning.Size = new System.Drawing.Size(107, 65);
            this.lblInvalidDataWarning.TabIndex = 28;
            this.lblInvalidDataWarning.Text = "Please enter all data before submiting order form";
            this.lblInvalidDataWarning.Visible = false;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(980, 24);
            this.mnuMain.TabIndex = 29;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(103, 22);
            this.mnuFileClose.Text = "Close";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(980, 507);
            this.Controls.Add(this.lblInvalidDataWarning);
            this.Controls.Add(this.grpPricing);
            this.Controls.Add(this.grpPayMthd);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.gboxCustInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Form1";
            this.Text = "Fuller\'s Pizza Order Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gboxCustInfo.ResumeLayout(false);
            this.gboxCustInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpOrderToppings.ResumeLayout(false);
            this.grpOrderSize.ResumeLayout(false);
            this.grpOrderSize.PerformLayout();
            this.grpPayMthd.ResumeLayout(false);
            this.grpPayMthd.PerformLayout();
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.MaskedTextBox mtbCustPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddressOne;
        private System.Windows.Forms.TextBox txtAddressTwo;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gboxCustInfo;
        private System.Windows.Forms.Label lblLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblOrderNumTxt;
        private System.Windows.Forms.Label lblOrderNumInt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Timer timDateTimeTicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpPayMthd;
        private System.Windows.Forms.GroupBox grpPricing;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.ComboBox cbPayMethod;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox mtbPayCardCode;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.ToolTip ttSizePrice;
        private System.Windows.Forms.ToolTip ttCheeseTopInfo;
        private System.Windows.Forms.ToolTip ttQuantityInfo;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label lblInvalidDataWarning;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.ToolTip ttAccept;
        public System.Windows.Forms.CheckBox chkTopPin;
        public System.Windows.Forms.CheckBox chkTopMsh;
        public System.Windows.Forms.CheckBox chkTopHmb;
        public System.Windows.Forms.CheckBox chkTopOni;
        public System.Windows.Forms.CheckBox chkTopHam;
        public System.Windows.Forms.CheckBox chkTopBlkOlv;
        public System.Windows.Forms.CheckBox chkTopGrnOlv;
        public System.Windows.Forms.CheckBox chkTopPep;
        public System.Windows.Forms.CheckBox chkTopSsg;
        public System.Windows.Forms.CheckBox chkTopChe;
        public System.Windows.Forms.GroupBox grpOrderToppings;
        public System.Windows.Forms.GroupBox grpOrderInfo;
        public System.Windows.Forms.GroupBox grpOrderSize;
        public System.Windows.Forms.RadioButton radSizeLrg;
        public System.Windows.Forms.RadioButton radSizeReg;
        public System.Windows.Forms.RadioButton radSizeSmall;
        public System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.NumericUpDown nudQuantity;
        public System.Windows.Forms.Label lblSubtotalNum;
        public System.Windows.Forms.Label lblTotalNum;
        public System.Windows.Forms.Label lblTaxNum;
        private System.Windows.Forms.Label lblPaySVC;
        private System.Windows.Forms.Label lblPayExpirDate;
        private System.Windows.Forms.MaskedTextBox mtbPaySVC;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.MaskedTextBox mtbPayExpirDate;
        private System.Windows.Forms.Button btnAutoFill;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
    }
}

