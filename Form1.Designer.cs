namespace Giyasova_3_
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
            this.baloonsPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zipCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.deliveryInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.deliveryDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.storePickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.homeDeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.dozenRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDozenRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.orderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.extraPriceLabel = new System.Windows.Forms.Label();
            this.halfLabel = new System.Windows.Forms.Label();
            this.singleLabel = new System.Windows.Forms.Label();
            this.dozenLabel = new System.Windows.Forms.Label();
            this.maxWordsLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageCardCheckBox = new System.Windows.Forms.CheckBox();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.occasionsLabel = new System.Windows.Forms.Label();
            this.occasionsComboBox = new System.Windows.Forms.ComboBox();
            this.orderTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.otherTitleTextBox = new System.Windows.Forms.TextBox();
            this.otherLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.summaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baloonsPictureBox)).BeginInit();
            this.customerInfoGroupBox.SuspendLayout();
            this.deliveryInfoGroupBox.SuspendLayout();
            this.orderDetailsGroupBox.SuspendLayout();
            this.orderTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // baloonsPictureBox
            // 
            this.baloonsPictureBox.Image = global::Giyasova_3_.Properties.Resources.pexels_tirachard_kumtanom_574282;
            this.baloonsPictureBox.Location = new System.Drawing.Point(115, -11);
            this.baloonsPictureBox.Name = "baloonsPictureBox";
            this.baloonsPictureBox.Size = new System.Drawing.Size(421, 160);
            this.baloonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baloonsPictureBox.TabIndex = 0;
            this.baloonsPictureBox.TabStop = false;
            this.baloonsPictureBox.Click += new System.EventHandler(this.baloonsPictureBox_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Jokerman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(216, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bonnie’s Balloons ";
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.titleComboBox);
            this.customerInfoGroupBox.Controls.Add(this.otherTitleTextBox);
            this.customerInfoGroupBox.Controls.Add(this.otherLabel);
            this.customerInfoGroupBox.Controls.Add(this.titleLabel);
            this.customerInfoGroupBox.Controls.Add(this.streetTextBox);
            this.customerInfoGroupBox.Controls.Add(this.cityTextBox);
            this.customerInfoGroupBox.Controls.Add(this.stateTextBox);
            this.customerInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.stateLabel);
            this.customerInfoGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.zipCodeMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.streetLabel);
            this.customerInfoGroupBox.Controls.Add(this.numberLabel);
            this.customerInfoGroupBox.Controls.Add(this.cityLabel);
            this.customerInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.zipCodeLabel);
            this.customerInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(26, 175);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(334, 177);
            this.customerInfoGroupBox.TabIndex = 2;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            this.customerInfoGroupBox.Enter += new System.EventHandler(this.customerInfoGroupBox_Enter);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(232, 26);
            this.streetTextBox.MaxLength = 30;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(82, 20);
            this.streetTextBox.TabIndex = 27;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(232, 51);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(82, 20);
            this.cityTextBox.TabIndex = 26;
            // 
            // stateTextBox
            // 
            this.stateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stateTextBox.Location = new System.Drawing.Point(239, 80);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(45, 20);
            this.stateTextBox.TabIndex = 25;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(92, 110);
            this.lastNameTextBox.MaxLength = 30;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(82, 20);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(92, 83);
            this.firstNameTextBox.MaxLength = 30;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(82, 20);
            this.firstNameTextBox.TabIndex = 22;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(191, 83);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 20;
            this.stateLabel.Text = "State:";
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(89, 144);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.phoneNumberMaskedTextBox.TabIndex = 15;
            // 
            // zipCodeMaskedTextBox
            // 
            this.zipCodeMaskedTextBox.Location = new System.Drawing.Point(239, 106);
            this.zipCodeMaskedTextBox.Mask = "00000";
            this.zipCodeMaskedTextBox.Name = "zipCodeMaskedTextBox";
            this.zipCodeMaskedTextBox.Size = new System.Drawing.Size(45, 20);
            this.zipCodeMaskedTextBox.TabIndex = 14;
            this.zipCodeMaskedTextBox.ValidatingType = typeof(int);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(188, 31);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 6;
            this.streetLabel.Text = "Street:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(6, 151);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(81, 13);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Phone Number:";
            this.numberLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(199, 53);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 116);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(180, 113);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLabel.TabIndex = 1;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 87);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // deliveryInfoGroupBox
            // 
            this.deliveryInfoGroupBox.Controls.Add(this.homeLabel);
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryDateMaskedTextBox);
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryDateLabel);
            this.deliveryInfoGroupBox.Controls.Add(this.storePickUpRadioButton);
            this.deliveryInfoGroupBox.Controls.Add(this.homeDeliveryRadioButton);
            this.deliveryInfoGroupBox.Location = new System.Drawing.Point(61, 358);
            this.deliveryInfoGroupBox.Name = "deliveryInfoGroupBox";
            this.deliveryInfoGroupBox.Size = new System.Drawing.Size(249, 129);
            this.deliveryInfoGroupBox.TabIndex = 0;
            this.deliveryInfoGroupBox.TabStop = false;
            this.deliveryInfoGroupBox.Text = "Delivery Information";
            this.deliveryInfoGroupBox.Enter += new System.EventHandler(this.deliveryInfoGroupBox_Enter);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Location = new System.Drawing.Point(152, 94);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(39, 13);
            this.homeLabel.TabIndex = 15;
            this.homeLabel.Text = "PRICE";
            // 
            // deliveryDateMaskedTextBox
            // 
            this.deliveryDateMaskedTextBox.Location = new System.Drawing.Point(138, 19);
            this.deliveryDateMaskedTextBox.Mask = "00/00/0000";
            this.deliveryDateMaskedTextBox.Name = "deliveryDateMaskedTextBox";
            this.deliveryDateMaskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.deliveryDateMaskedTextBox.TabIndex = 3;
            this.deliveryDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(17, 25);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryDateLabel.TabIndex = 2;
            this.deliveryDateLabel.Text = "Delivery Date:";
            // 
            // storePickUpRadioButton
            // 
            this.storePickUpRadioButton.AutoSize = true;
            this.storePickUpRadioButton.Checked = true;
            this.storePickUpRadioButton.Location = new System.Drawing.Point(31, 57);
            this.storePickUpRadioButton.Name = "storePickUpRadioButton";
            this.storePickUpRadioButton.Size = new System.Drawing.Size(89, 17);
            this.storePickUpRadioButton.TabIndex = 0;
            this.storePickUpRadioButton.TabStop = true;
            this.storePickUpRadioButton.Text = "Store Pick-up";
            this.storePickUpRadioButton.UseVisualStyleBackColor = true;
            this.storePickUpRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // homeDeliveryRadioButton
            // 
            this.homeDeliveryRadioButton.AutoSize = true;
            this.homeDeliveryRadioButton.Location = new System.Drawing.Point(31, 94);
            this.homeDeliveryRadioButton.Name = "homeDeliveryRadioButton";
            this.homeDeliveryRadioButton.Size = new System.Drawing.Size(94, 17);
            this.homeDeliveryRadioButton.TabIndex = 1;
            this.homeDeliveryRadioButton.Text = "Home Delivery";
            this.homeDeliveryRadioButton.UseVisualStyleBackColor = true;
            this.homeDeliveryRadioButton.CheckedChanged += new System.EventHandler(this.homeDeliveryRadioButton_CheckedChanged);
            // 
            // dozenRadioButton
            // 
            this.dozenRadioButton.AutoSize = true;
            this.dozenRadioButton.Location = new System.Drawing.Point(6, 83);
            this.dozenRadioButton.Name = "dozenRadioButton";
            this.dozenRadioButton.Size = new System.Drawing.Size(56, 17);
            this.dozenRadioButton.TabIndex = 4;
            this.dozenRadioButton.Text = "Dozen";
            this.dozenRadioButton.UseVisualStyleBackColor = true;
            this.dozenRadioButton.CheckedChanged += new System.EventHandler(this.dozenRadioButton_CheckedChanged);
            // 
            // halfDozenRadioButton
            // 
            this.halfDozenRadioButton.AutoSize = true;
            this.halfDozenRadioButton.Location = new System.Drawing.Point(6, 56);
            this.halfDozenRadioButton.Name = "halfDozenRadioButton";
            this.halfDozenRadioButton.Size = new System.Drawing.Size(76, 17);
            this.halfDozenRadioButton.TabIndex = 5;
            this.halfDozenRadioButton.Text = "Half-dozen";
            this.halfDozenRadioButton.UseVisualStyleBackColor = true;
            this.halfDozenRadioButton.CheckedChanged += new System.EventHandler(this.halfDozenRadioButton_CheckedChanged);
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Checked = true;
            this.singleRadioButton.Location = new System.Drawing.Point(7, 29);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(54, 17);
            this.singleRadioButton.TabIndex = 6;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            this.singleRadioButton.CheckedChanged += new System.EventHandler(this.singleRadioButton_CheckedChanged);
            // 
            // orderDetailsGroupBox
            // 
            this.orderDetailsGroupBox.Controls.Add(this.messageLabel);
            this.orderDetailsGroupBox.Controls.Add(this.extraPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.halfLabel);
            this.orderDetailsGroupBox.Controls.Add(this.singleLabel);
            this.orderDetailsGroupBox.Controls.Add(this.dozenLabel);
            this.orderDetailsGroupBox.Controls.Add(this.maxWordsLabel);
            this.orderDetailsGroupBox.Controls.Add(this.messageTextBox);
            this.orderDetailsGroupBox.Controls.Add(this.messageCardCheckBox);
            this.orderDetailsGroupBox.Controls.Add(this.extrasLabel);
            this.orderDetailsGroupBox.Controls.Add(this.extrasListBox);
            this.orderDetailsGroupBox.Controls.Add(this.occasionsLabel);
            this.orderDetailsGroupBox.Controls.Add(this.occasionsComboBox);
            this.orderDetailsGroupBox.Controls.Add(this.dozenRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.halfDozenRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.singleRadioButton);
            this.orderDetailsGroupBox.Location = new System.Drawing.Point(379, 175);
            this.orderDetailsGroupBox.Name = "orderDetailsGroupBox";
            this.orderDetailsGroupBox.Size = new System.Drawing.Size(239, 344);
            this.orderDetailsGroupBox.TabIndex = 0;
            this.orderDetailsGroupBox.TabStop = false;
            this.orderDetailsGroupBox.Text = "Order Details ";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(159, 267);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(39, 13);
            this.messageLabel.TabIndex = 24;
            this.messageLabel.Text = "PRICE";
            // 
            // extraPriceLabel
            // 
            this.extraPriceLabel.AutoSize = true;
            this.extraPriceLabel.Location = new System.Drawing.Point(23, 183);
            this.extraPriceLabel.Name = "extraPriceLabel";
            this.extraPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.extraPriceLabel.TabIndex = 23;
            this.extraPriceLabel.Text = "PRICE";
            // 
            // halfLabel
            // 
            this.halfLabel.AutoSize = true;
            this.halfLabel.Location = new System.Drawing.Point(121, 55);
            this.halfLabel.Name = "halfLabel";
            this.halfLabel.Size = new System.Drawing.Size(39, 13);
            this.halfLabel.TabIndex = 22;
            this.halfLabel.Text = "PRICE";
            // 
            // singleLabel
            // 
            this.singleLabel.AutoSize = true;
            this.singleLabel.Location = new System.Drawing.Point(121, 26);
            this.singleLabel.Name = "singleLabel";
            this.singleLabel.Size = new System.Drawing.Size(39, 13);
            this.singleLabel.TabIndex = 21;
            this.singleLabel.Text = "PRICE";
            // 
            // dozenLabel
            // 
            this.dozenLabel.AutoSize = true;
            this.dozenLabel.Location = new System.Drawing.Point(121, 85);
            this.dozenLabel.Name = "dozenLabel";
            this.dozenLabel.Size = new System.Drawing.Size(39, 13);
            this.dozenLabel.TabIndex = 20;
            this.dozenLabel.Text = "PRICE";
            this.dozenLabel.Click += new System.EventHandler(this.label20_Click);
            // 
            // maxWordsLabel
            // 
            this.maxWordsLabel.AutoSize = true;
            this.maxWordsLabel.Enabled = false;
            this.maxWordsLabel.Location = new System.Drawing.Point(139, 295);
            this.maxWordsLabel.Name = "maxWordsLabel";
            this.maxWordsLabel.Size = new System.Drawing.Size(73, 13);
            this.maxWordsLabel.TabIndex = 18;
            this.maxWordsLabel.Text = "Max 30 words";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(17, 292);
            this.messageTextBox.MaxLength = 30;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(109, 20);
            this.messageTextBox.TabIndex = 16;
            // 
            // messageCardCheckBox
            // 
            this.messageCardCheckBox.AutoSize = true;
            this.messageCardCheckBox.Location = new System.Drawing.Point(17, 263);
            this.messageCardCheckBox.Name = "messageCardCheckBox";
            this.messageCardCheckBox.Size = new System.Drawing.Size(94, 17);
            this.messageCardCheckBox.TabIndex = 15;
            this.messageCardCheckBox.Text = "Message Card";
            this.messageCardCheckBox.UseVisualStyleBackColor = true;
            this.messageCardCheckBox.CheckedChanged += new System.EventHandler(this.messageCardCheckBox_CheckedChanged);
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Location = new System.Drawing.Point(27, 164);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(34, 13);
            this.extrasLabel.TabIndex = 13;
            this.extrasLabel.Text = "Extra:";
            // 
            // extrasListBox
            // 
            this.extrasListBox.Location = new System.Drawing.Point(78, 162);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.extrasListBox.Size = new System.Drawing.Size(120, 95);
            this.extrasListBox.Sorted = true;
            this.extrasListBox.TabIndex = 12;
            this.extrasListBox.SelectedIndexChanged += new System.EventHandler(this.extrasListBox_SelectedIndexChanged);
            // 
            // occasionsLabel
            // 
            this.occasionsLabel.AutoSize = true;
            this.occasionsLabel.Location = new System.Drawing.Point(6, 125);
            this.occasionsLabel.Name = "occasionsLabel";
            this.occasionsLabel.Size = new System.Drawing.Size(60, 13);
            this.occasionsLabel.TabIndex = 11;
            this.occasionsLabel.Text = "Occasions:";
            // 
            // occasionsComboBox
            // 
            this.occasionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occasionsComboBox.Location = new System.Drawing.Point(90, 117);
            this.occasionsComboBox.Name = "occasionsComboBox";
            this.occasionsComboBox.Size = new System.Drawing.Size(84, 21);
            this.occasionsComboBox.Sorted = true;
            this.occasionsComboBox.TabIndex = 10;
            this.occasionsComboBox.SelectedIndexChanged += new System.EventHandler(this.occasionsComboBox_SelectedIndexChanged);
            // 
            // orderTotalsGroupBox
            // 
            this.orderTotalsGroupBox.Controls.Add(this.totalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.taxLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.label18);
            this.orderTotalsGroupBox.Controls.Add(this.label17);
            this.orderTotalsGroupBox.Controls.Add(this.label14);
            this.orderTotalsGroupBox.Location = new System.Drawing.Point(26, 493);
            this.orderTotalsGroupBox.Name = "orderTotalsGroupBox";
            this.orderTotalsGroupBox.Size = new System.Drawing.Size(334, 117);
            this.orderTotalsGroupBox.TabIndex = 0;
            this.orderTotalsGroupBox.TabStop = false;
            this.orderTotalsGroupBox.Text = "Order Totals";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(156, 76);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(39, 13);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "PRICE";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(156, 51);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(39, 13);
            this.taxLabel.TabIndex = 14;
            this.taxLabel.Text = "PRICE";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(156, 26);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(39, 13);
            this.subtotalLabel.TabIndex = 13;
            this.subtotalLabel.Text = "PRICE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total Order:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Sales Tax Amount (7.00%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Subtotal:";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(385, 624);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit Summary";
            this.exitToolTip.SetToolTip(this.exitButton, "Exit the Form");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.AutoSize = true;
            this.displayButton.Location = new System.Drawing.Point(124, 624);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(97, 23);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Dis&play Su&mmary";
            this.summaryToolTip.SetToolTip(this.displayButton, "Review your Order");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(265, 624);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear Form";
            this.clearToolTip.SetToolTip(this.clearButton, "Clear your Entries");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // otherTitleTextBox
            // 
            this.otherTitleTextBox.Enabled = false;
            this.otherTitleTextBox.Location = new System.Drawing.Point(90, 49);
            this.otherTitleTextBox.MaxLength = 30;
            this.otherTitleTextBox.Name = "otherTitleTextBox";
            this.otherTitleTextBox.Size = new System.Drawing.Size(54, 20);
            this.otherTitleTextBox.TabIndex = 31;
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Enabled = false;
            this.otherLabel.Location = new System.Drawing.Point(7, 56);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(77, 13);
            this.otherLabel.TabIndex = 30;
            this.otherLabel.Text = "Type (if Other):";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(7, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 29;
            this.titleLabel.Text = "Title:";
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev. ",
            "Other"});
            this.titleComboBox.Location = new System.Drawing.Point(89, 19);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(54, 21);
            this.titleComboBox.TabIndex = 32;
            this.titleComboBox.SelectedIndexChanged += new System.EventHandler(this.titleComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 659);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deliveryInfoGroupBox);
            this.Controls.Add(this.orderDetailsGroupBox);
            this.Controls.Add(this.orderTotalsGroupBox);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baloonsPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baloonsPictureBox)).EndInit();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.deliveryInfoGroupBox.ResumeLayout(false);
            this.deliveryInfoGroupBox.PerformLayout();
            this.orderDetailsGroupBox.ResumeLayout(false);
            this.orderDetailsGroupBox.PerformLayout();
            this.orderTotalsGroupBox.ResumeLayout(false);
            this.orderTotalsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox baloonsPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox deliveryInfoGroupBox;
        private System.Windows.Forms.GroupBox orderDetailsGroupBox;
        private System.Windows.Forms.GroupBox orderTotalsGroupBox;
        private System.Windows.Forms.MaskedTextBox zipCodeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.RadioButton homeDeliveryRadioButton;
        private System.Windows.Forms.RadioButton storePickUpRadioButton;
        private System.Windows.Forms.RadioButton dozenRadioButton;
        private System.Windows.Forms.RadioButton halfDozenRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.MaskedTextBox deliveryDateMaskedTextBox;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.Label occasionsLabel;
        private System.Windows.Forms.ComboBox occasionsComboBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.CheckBox messageCardCheckBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label maxWordsLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label halfLabel;
        private System.Windows.Forms.Label singleLabel;
        private System.Windows.Forms.Label dozenLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label extraPriceLabel;
        private System.Windows.Forms.TextBox otherTitleTextBox;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.ToolTip summaryToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
    }
}

