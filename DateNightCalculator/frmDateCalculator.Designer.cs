namespace DateNightCalculator {
    partial class frmDateCalculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpTravelCost = new System.Windows.Forms.GroupBox();
            this.lblInvalidTravel = new System.Windows.Forms.Label();
            this.rbCarriageRide = new System.Windows.Forms.RadioButton();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbBicycle = new System.Windows.Forms.RadioButton();
            this.rbBus = new System.Windows.Forms.RadioButton();
            this.grpDinnerCost = new System.Windows.Forms.GroupBox();
            this.lblInvalidDinner = new System.Windows.Forms.Label();
            this.rbSandPipers = new System.Windows.Forms.RadioButton();
            this.rbApplebees = new System.Windows.Forms.RadioButton();
            this.rbMcDonalds = new System.Windows.Forms.RadioButton();
            this.rbNoDinner = new System.Windows.Forms.RadioButton();
            this.grpDessertCost = new System.Windows.Forms.GroupBox();
            this.lblInvalidDessert = new System.Windows.Forms.Label();
            this.rbSmores = new System.Windows.Forms.RadioButton();
            this.rbShakes = new System.Windows.Forms.RadioButton();
            this.rbIceCreamCones = new System.Windows.Forms.RadioButton();
            this.rbNoDessert = new System.Windows.Forms.RadioButton();
            this.grpEntertainmentCost = new System.Windows.Forms.GroupBox();
            this.lblInvalidEntertainment = new System.Windows.Forms.Label();
            this.rbMiniGolf = new System.Windows.Forms.RadioButton();
            this.rbMovie = new System.Windows.Forms.RadioButton();
            this.rbBowling = new System.Windows.Forms.RadioButton();
            this.rbWalk = new System.Windows.Forms.RadioButton();
            this.grpTip = new System.Windows.Forms.GroupBox();
            this.lblInvalidTip = new System.Windows.Forms.Label();
            this.chkNoTip = new System.Windows.Forms.CheckBox();
            this.lblOutputTipValue = new System.Windows.Forms.Label();
            this.lblTipValue = new System.Windows.Forms.Label();
            this.trTip = new System.Windows.Forms.TrackBar();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblOutputTotalCost = new System.Windows.Forms.Label();
            this.lblInvalidTaxRate = new System.Windows.Forms.Label();
            this.lblInvalidMessage = new System.Windows.Forms.Label();
            this.chkRandomize = new System.Windows.Forms.CheckBox();
            this.grpTravelCost.SuspendLayout();
            this.grpDinnerCost.SuspendLayout();
            this.grpDessertCost.SuspendLayout();
            this.grpEntertainmentCost.SuspendLayout();
            this.grpTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trTip)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTravelCost
            // 
            this.grpTravelCost.Controls.Add(this.lblInvalidTravel);
            this.grpTravelCost.Controls.Add(this.rbCarriageRide);
            this.grpTravelCost.Controls.Add(this.rbCar);
            this.grpTravelCost.Controls.Add(this.rbBicycle);
            this.grpTravelCost.Controls.Add(this.rbBus);
            this.grpTravelCost.Location = new System.Drawing.Point(16, 36);
            this.grpTravelCost.Name = "grpTravelCost";
            this.grpTravelCost.Size = new System.Drawing.Size(125, 112);
            this.grpTravelCost.TabIndex = 0;
            this.grpTravelCost.TabStop = false;
            this.grpTravelCost.Text = "Travel";
            // 
            // lblInvalidTravel
            // 
            this.lblInvalidTravel.AutoSize = true;
            this.lblInvalidTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidTravel.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidTravel.Location = new System.Drawing.Point(40, 0);
            this.lblInvalidTravel.Name = "lblInvalidTravel";
            this.lblInvalidTravel.Size = new System.Drawing.Size(15, 20);
            this.lblInvalidTravel.TabIndex = 4;
            this.lblInvalidTravel.Text = "*";
            this.lblInvalidTravel.Visible = false;
            // 
            // rbCarriageRide
            // 
            this.rbCarriageRide.AutoSize = true;
            this.rbCarriageRide.Location = new System.Drawing.Point(6, 88);
            this.rbCarriageRide.Name = "rbCarriageRide";
            this.rbCarriageRide.Size = new System.Drawing.Size(116, 17);
            this.rbCarriageRide.TabIndex = 3;
            this.rbCarriageRide.Text = "Carriage Ride ($50)";
            this.rbCarriageRide.UseVisualStyleBackColor = true;
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(6, 65);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(62, 17);
            this.rbCar.TabIndex = 2;
            this.rbCar.Text = "Car ($5)";
            this.rbCar.UseVisualStyleBackColor = true;
            // 
            // rbBicycle
            // 
            this.rbBicycle.AutoSize = true;
            this.rbBicycle.Location = new System.Drawing.Point(6, 42);
            this.rbBicycle.Name = "rbBicycle";
            this.rbBicycle.Size = new System.Drawing.Size(86, 17);
            this.rbBicycle.TabIndex = 1;
            this.rbBicycle.Text = "Bicycle ($20)";
            this.rbBicycle.UseVisualStyleBackColor = true;
            // 
            // rbBus
            // 
            this.rbBus.AutoSize = true;
            this.rbBus.Location = new System.Drawing.Point(6, 19);
            this.rbBus.Name = "rbBus";
            this.rbBus.Size = new System.Drawing.Size(64, 17);
            this.rbBus.TabIndex = 0;
            this.rbBus.Text = "Bus ($1)";
            this.rbBus.UseVisualStyleBackColor = true;
            // 
            // grpDinnerCost
            // 
            this.grpDinnerCost.Controls.Add(this.lblInvalidDinner);
            this.grpDinnerCost.Controls.Add(this.rbSandPipers);
            this.grpDinnerCost.Controls.Add(this.rbApplebees);
            this.grpDinnerCost.Controls.Add(this.rbMcDonalds);
            this.grpDinnerCost.Controls.Add(this.rbNoDinner);
            this.grpDinnerCost.Location = new System.Drawing.Point(147, 36);
            this.grpDinnerCost.Name = "grpDinnerCost";
            this.grpDinnerCost.Size = new System.Drawing.Size(119, 112);
            this.grpDinnerCost.TabIndex = 1;
            this.grpDinnerCost.TabStop = false;
            this.grpDinnerCost.Text = "Dinner";
            // 
            // lblInvalidDinner
            // 
            this.lblInvalidDinner.AutoSize = true;
            this.lblInvalidDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDinner.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDinner.Location = new System.Drawing.Point(41, 0);
            this.lblInvalidDinner.Name = "lblInvalidDinner";
            this.lblInvalidDinner.Size = new System.Drawing.Size(15, 20);
            this.lblInvalidDinner.TabIndex = 4;
            this.lblInvalidDinner.Text = "*";
            this.lblInvalidDinner.Visible = false;
            // 
            // rbSandPipers
            // 
            this.rbSandPipers.AutoSize = true;
            this.rbSandPipers.Location = new System.Drawing.Point(7, 88);
            this.rbSandPipers.Name = "rbSandPipers";
            this.rbSandPipers.Size = new System.Drawing.Size(108, 17);
            this.rbSandPipers.TabIndex = 3;
            this.rbSandPipers.Text = "SandPiper\'s ($50)";
            this.rbSandPipers.UseVisualStyleBackColor = true;
            // 
            // rbApplebees
            // 
            this.rbApplebees.AutoSize = true;
            this.rbApplebees.Location = new System.Drawing.Point(7, 65);
            this.rbApplebees.Name = "rbApplebees";
            this.rbApplebees.Size = new System.Drawing.Size(104, 17);
            this.rbApplebees.TabIndex = 2;
            this.rbApplebees.Text = "Applebee\'s ($25)";
            this.rbApplebees.UseVisualStyleBackColor = true;
            // 
            // rbMcDonalds
            // 
            this.rbMcDonalds.AutoSize = true;
            this.rbMcDonalds.Location = new System.Drawing.Point(7, 42);
            this.rbMcDonalds.Name = "rbMcDonalds";
            this.rbMcDonalds.Size = new System.Drawing.Size(106, 17);
            this.rbMcDonalds.TabIndex = 1;
            this.rbMcDonalds.Text = "McDonalds ($10)";
            this.rbMcDonalds.UseVisualStyleBackColor = true;
            // 
            // rbNoDinner
            // 
            this.rbNoDinner.AutoSize = true;
            this.rbNoDinner.Location = new System.Drawing.Point(7, 19);
            this.rbNoDinner.Name = "rbNoDinner";
            this.rbNoDinner.Size = new System.Drawing.Size(72, 17);
            this.rbNoDinner.TabIndex = 0;
            this.rbNoDinner.Text = "None ($0)";
            this.rbNoDinner.UseVisualStyleBackColor = true;
            // 
            // grpDessertCost
            // 
            this.grpDessertCost.Controls.Add(this.lblInvalidDessert);
            this.grpDessertCost.Controls.Add(this.rbSmores);
            this.grpDessertCost.Controls.Add(this.rbShakes);
            this.grpDessertCost.Controls.Add(this.rbIceCreamCones);
            this.grpDessertCost.Controls.Add(this.rbNoDessert);
            this.grpDessertCost.Location = new System.Drawing.Point(272, 36);
            this.grpDessertCost.Name = "grpDessertCost";
            this.grpDessertCost.Size = new System.Drawing.Size(137, 112);
            this.grpDessertCost.TabIndex = 2;
            this.grpDessertCost.TabStop = false;
            this.grpDessertCost.Text = "Dessert";
            // 
            // lblInvalidDessert
            // 
            this.lblInvalidDessert.AutoSize = true;
            this.lblInvalidDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDessert.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDessert.Location = new System.Drawing.Point(47, 0);
            this.lblInvalidDessert.Name = "lblInvalidDessert";
            this.lblInvalidDessert.Size = new System.Drawing.Size(15, 20);
            this.lblInvalidDessert.TabIndex = 4;
            this.lblInvalidDessert.Text = "*";
            this.lblInvalidDessert.Visible = false;
            // 
            // rbSmores
            // 
            this.rbSmores.AutoSize = true;
            this.rbSmores.Location = new System.Drawing.Point(7, 88);
            this.rbSmores.Name = "rbSmores";
            this.rbSmores.Size = new System.Drawing.Size(83, 17);
            this.rbSmores.TabIndex = 3;
            this.rbSmores.Text = "S\'mores ($4)";
            this.rbSmores.UseVisualStyleBackColor = true;
            // 
            // rbShakes
            // 
            this.rbShakes.AutoSize = true;
            this.rbShakes.Location = new System.Drawing.Point(7, 65);
            this.rbShakes.Name = "rbShakes";
            this.rbShakes.Size = new System.Drawing.Size(82, 17);
            this.rbShakes.TabIndex = 2;
            this.rbShakes.Text = "Shakes ($8)";
            this.rbShakes.UseVisualStyleBackColor = true;
            // 
            // rbIceCreamCones
            // 
            this.rbIceCreamCones.AutoSize = true;
            this.rbIceCreamCones.Location = new System.Drawing.Point(7, 42);
            this.rbIceCreamCones.Name = "rbIceCreamCones";
            this.rbIceCreamCones.Size = new System.Drawing.Size(127, 17);
            this.rbIceCreamCones.TabIndex = 1;
            this.rbIceCreamCones.Text = "Ice Cream Cones ($3)";
            this.rbIceCreamCones.UseVisualStyleBackColor = true;
            // 
            // rbNoDessert
            // 
            this.rbNoDessert.AutoSize = true;
            this.rbNoDessert.Location = new System.Drawing.Point(7, 19);
            this.rbNoDessert.Name = "rbNoDessert";
            this.rbNoDessert.Size = new System.Drawing.Size(72, 17);
            this.rbNoDessert.TabIndex = 0;
            this.rbNoDessert.Text = "None ($0)";
            this.rbNoDessert.UseVisualStyleBackColor = true;
            // 
            // grpEntertainmentCost
            // 
            this.grpEntertainmentCost.Controls.Add(this.lblInvalidEntertainment);
            this.grpEntertainmentCost.Controls.Add(this.rbMiniGolf);
            this.grpEntertainmentCost.Controls.Add(this.rbMovie);
            this.grpEntertainmentCost.Controls.Add(this.rbBowling);
            this.grpEntertainmentCost.Controls.Add(this.rbWalk);
            this.grpEntertainmentCost.Location = new System.Drawing.Point(16, 154);
            this.grpEntertainmentCost.Name = "grpEntertainmentCost";
            this.grpEntertainmentCost.Size = new System.Drawing.Size(125, 117);
            this.grpEntertainmentCost.TabIndex = 3;
            this.grpEntertainmentCost.TabStop = false;
            this.grpEntertainmentCost.Text = "Entertainment";
            // 
            // lblInvalidEntertainment
            // 
            this.lblInvalidEntertainment.AutoSize = true;
            this.lblInvalidEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidEntertainment.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEntertainment.Location = new System.Drawing.Point(74, 0);
            this.lblInvalidEntertainment.Name = "lblInvalidEntertainment";
            this.lblInvalidEntertainment.Size = new System.Drawing.Size(15, 20);
            this.lblInvalidEntertainment.TabIndex = 4;
            this.lblInvalidEntertainment.Text = "*";
            this.lblInvalidEntertainment.Visible = false;
            // 
            // rbMiniGolf
            // 
            this.rbMiniGolf.AutoSize = true;
            this.rbMiniGolf.Location = new System.Drawing.Point(7, 92);
            this.rbMiniGolf.Name = "rbMiniGolf";
            this.rbMiniGolf.Size = new System.Drawing.Size(117, 17);
            this.rbMiniGolf.TabIndex = 3;
            this.rbMiniGolf.Text = "Miniature Golf ($10)";
            this.rbMiniGolf.UseVisualStyleBackColor = true;
            // 
            // rbMovie
            // 
            this.rbMovie.AutoSize = true;
            this.rbMovie.Location = new System.Drawing.Point(7, 68);
            this.rbMovie.Name = "rbMovie";
            this.rbMovie.Size = new System.Drawing.Size(81, 17);
            this.rbMovie.TabIndex = 2;
            this.rbMovie.Text = "Movie ($26)";
            this.rbMovie.UseVisualStyleBackColor = true;
            // 
            // rbBowling
            // 
            this.rbBowling.AutoSize = true;
            this.rbBowling.Location = new System.Drawing.Point(7, 44);
            this.rbBowling.Name = "rbBowling";
            this.rbBowling.Size = new System.Drawing.Size(83, 17);
            this.rbBowling.TabIndex = 1;
            this.rbBowling.Text = "Bowling ($6)";
            this.rbBowling.UseVisualStyleBackColor = true;
            // 
            // rbWalk
            // 
            this.rbWalk.AutoSize = true;
            this.rbWalk.Location = new System.Drawing.Point(7, 20);
            this.rbWalk.Name = "rbWalk";
            this.rbWalk.Size = new System.Drawing.Size(105, 17);
            this.rbWalk.TabIndex = 0;
            this.rbWalk.Text = "Take a walk ($0)";
            this.rbWalk.UseVisualStyleBackColor = true;
            // 
            // grpTip
            // 
            this.grpTip.Controls.Add(this.lblInvalidTip);
            this.grpTip.Controls.Add(this.chkNoTip);
            this.grpTip.Controls.Add(this.lblOutputTipValue);
            this.grpTip.Controls.Add(this.lblTipValue);
            this.grpTip.Controls.Add(this.trTip);
            this.grpTip.Location = new System.Drawing.Point(154, 155);
            this.grpTip.Name = "grpTip";
            this.grpTip.Size = new System.Drawing.Size(252, 77);
            this.grpTip.TabIndex = 4;
            this.grpTip.TabStop = false;
            this.grpTip.Text = "Tip";
            // 
            // lblInvalidTip
            // 
            this.lblInvalidTip.AutoSize = true;
            this.lblInvalidTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidTip.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidTip.Location = new System.Drawing.Point(237, 8);
            this.lblInvalidTip.Name = "lblInvalidTip";
            this.lblInvalidTip.Size = new System.Drawing.Size(15, 20);
            this.lblInvalidTip.TabIndex = 4;
            this.lblInvalidTip.Text = "*";
            this.lblInvalidTip.Visible = false;
            // 
            // chkNoTip
            // 
            this.chkNoTip.AutoSize = true;
            this.chkNoTip.Location = new System.Drawing.Point(46, 56);
            this.chkNoTip.Name = "chkNoTip";
            this.chkNoTip.Size = new System.Drawing.Size(58, 17);
            this.chkNoTip.TabIndex = 3;
            this.chkNoTip.Text = "No Tip";
            this.chkNoTip.UseVisualStyleBackColor = true;
            this.chkNoTip.CheckedChanged += new System.EventHandler(this.chkNoTip_CheckedChanged);
            // 
            // lblOutputTipValue
            // 
            this.lblOutputTipValue.AutoSize = true;
            this.lblOutputTipValue.Location = new System.Drawing.Point(187, 57);
            this.lblOutputTipValue.Name = "lblOutputTipValue";
            this.lblOutputTipValue.Size = new System.Drawing.Size(0, 13);
            this.lblOutputTipValue.TabIndex = 2;
            // 
            // lblTipValue
            // 
            this.lblTipValue.AutoSize = true;
            this.lblTipValue.Location = new System.Drawing.Point(144, 57);
            this.lblTipValue.Name = "lblTipValue";
            this.lblTipValue.Size = new System.Drawing.Size(37, 13);
            this.lblTipValue.TabIndex = 1;
            this.lblTipValue.Text = "Value:";
            // 
            // trTip
            // 
            this.trTip.Location = new System.Drawing.Point(7, 19);
            this.trTip.Maximum = 35;
            this.trTip.Minimum = 5;
            this.trTip.Name = "trTip";
            this.trTip.Size = new System.Drawing.Size(239, 45);
            this.trTip.TabIndex = 0;
            this.trTip.Value = 20;
            this.trTip.Scroll += new System.EventHandler(this.trTip_Scroll);
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(261, 243);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(54, 13);
            this.lblTaxRate.TabIndex = 5;
            this.lblTaxRate.Text = "Tax Rate:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(321, 240);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(60, 20);
            this.txtTaxRate.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(141, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 25);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(68, 333);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(147, 31);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblOutputTotalCost
            // 
            this.lblOutputTotalCost.AutoSize = true;
            this.lblOutputTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTotalCost.Location = new System.Drawing.Point(221, 333);
            this.lblOutputTotalCost.Name = "lblOutputTotalCost";
            this.lblOutputTotalCost.Size = new System.Drawing.Size(0, 31);
            this.lblOutputTotalCost.TabIndex = 11;
            // 
            // lblInvalidTaxRate
            // 
            this.lblInvalidTaxRate.AutoSize = true;
            this.lblInvalidTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidTaxRate.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidTaxRate.Location = new System.Drawing.Point(382, 242);
            this.lblInvalidTaxRate.Name = "lblInvalidTaxRate";
            this.lblInvalidTaxRate.Size = new System.Drawing.Size(15, 20);
            this.lblInvalidTaxRate.TabIndex = 13;
            this.lblInvalidTaxRate.Text = "*";
            this.lblInvalidTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidTaxRate.Visible = false;
            // 
            // lblInvalidMessage
            // 
            this.lblInvalidMessage.AutoSize = true;
            this.lblInvalidMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidMessage.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidMessage.Location = new System.Drawing.Point(152, 10);
            this.lblInvalidMessage.Name = "lblInvalidMessage";
            this.lblInvalidMessage.Size = new System.Drawing.Size(109, 15);
            this.lblInvalidMessage.TabIndex = 14;
            this.lblInvalidMessage.Text = "Fill in the asterisk *";
            this.lblInvalidMessage.Visible = false;
            // 
            // chkRandomize
            // 
            this.chkRandomize.AutoSize = true;
            this.chkRandomize.Location = new System.Drawing.Point(161, 242);
            this.chkRandomize.Name = "chkRandomize";
            this.chkRandomize.Size = new System.Drawing.Size(87, 17);
            this.chkRandomize.TabIndex = 15;
            this.chkRandomize.Text = "Plan my date";
            this.chkRandomize.UseVisualStyleBackColor = true;
            // 
            // frmDateCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 393);
            this.Controls.Add(this.chkRandomize);
            this.Controls.Add(this.lblInvalidMessage);
            this.Controls.Add(this.lblInvalidTaxRate);
            this.Controls.Add(this.lblOutputTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.grpTip);
            this.Controls.Add(this.grpEntertainmentCost);
            this.Controls.Add(this.grpDessertCost);
            this.Controls.Add(this.grpDinnerCost);
            this.Controls.Add(this.grpTravelCost);
            this.Name = "frmDateCalculator";
            this.Text = "Date Calculator";
            this.grpTravelCost.ResumeLayout(false);
            this.grpTravelCost.PerformLayout();
            this.grpDinnerCost.ResumeLayout(false);
            this.grpDinnerCost.PerformLayout();
            this.grpDessertCost.ResumeLayout(false);
            this.grpDessertCost.PerformLayout();
            this.grpEntertainmentCost.ResumeLayout(false);
            this.grpEntertainmentCost.PerformLayout();
            this.grpTip.ResumeLayout(false);
            this.grpTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTravelCost;
        private System.Windows.Forms.GroupBox grpDinnerCost;
        private System.Windows.Forms.GroupBox grpDessertCost;
        private System.Windows.Forms.GroupBox grpEntertainmentCost;
        private System.Windows.Forms.RadioButton rbBus;
        private System.Windows.Forms.RadioButton rbCarriageRide;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbBicycle;
        private System.Windows.Forms.RadioButton rbSandPipers;
        private System.Windows.Forms.RadioButton rbApplebees;
        private System.Windows.Forms.RadioButton rbMcDonalds;
        private System.Windows.Forms.RadioButton rbNoDinner;
        private System.Windows.Forms.RadioButton rbSmores;
        private System.Windows.Forms.RadioButton rbShakes;
        private System.Windows.Forms.RadioButton rbIceCreamCones;
        private System.Windows.Forms.RadioButton rbNoDessert;
        private System.Windows.Forms.RadioButton rbMiniGolf;
        private System.Windows.Forms.RadioButton rbMovie;
        private System.Windows.Forms.RadioButton rbBowling;
        private System.Windows.Forms.RadioButton rbWalk;
        private System.Windows.Forms.GroupBox grpTip;
        private System.Windows.Forms.Label lblOutputTipValue;
        private System.Windows.Forms.Label lblTipValue;
        private System.Windows.Forms.TrackBar trTip;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblOutputTotalCost;
        private System.Windows.Forms.CheckBox chkNoTip;
        private System.Windows.Forms.Label lblInvalidTravel;
        private System.Windows.Forms.Label lblInvalidDinner;
        private System.Windows.Forms.Label lblInvalidDessert;
        private System.Windows.Forms.Label lblInvalidEntertainment;
        private System.Windows.Forms.Label lblInvalidTip;
        private System.Windows.Forms.Label lblInvalidTaxRate;
        private System.Windows.Forms.Label lblInvalidMessage;
        private System.Windows.Forms.CheckBox chkRandomize;
    }
}

