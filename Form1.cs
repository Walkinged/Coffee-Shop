//Student 20140842
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 

namespace WindowsFormsApplication1
{
    public partial class starclucks : Form                    // Name of this form.
    {
        private string name;

        public string passname                                // Carries and displays the ID number from form 3.
        {
            get { return name; }

            set
            {
                name = value;
                idnumLBL.Text = name;                         // Displays the ID number inputted by the user in form 1.
            }
        }

        public double Coffee = 1.25;                           // Public doubles to arrange prices for each item individually.
        public double Tea = 1.10;
        public double Latte = 1.20;
        public double GBLatte = 2.00;
        public double CaramelLatte = 1.50;
        public double WHChocolate = 1.50;
        public double BFHChocolate = 2.00;
        public double Coke = 1.20;
        public double Sprite = 1.20;
        public double Water = 1.00;
        public double HamSandwich = 1.25;
        public double CheeseSandwich = 1.25;
        public double TunaSandwich = 1.25;
        public double CnPSandwich = 1.35;
        public double BeefSandwich = 1.25;
        public double MarsBar = 0.50;
        public double SnickersBar = 0.50;
        public double YorkieBar = 0.50;
        public double LionBar = 0.50;
        public double OrderTotal = 0;                       // Start orderTotal at 0 for total cost to be added on as the customer selects their items.
        
        public int    ordernumber=1;                        // Start the order number at 1 and incremenst by one with each new order.
        public string appPath = AppDomain.CurrentDomain.BaseDirectory;        // Declares variables set to the application path.
        public string salesfilename;                        // Creates an empty variable and stores each new sales list as it is created. Each sales list will be stored in a seperate file name e.g. 1.sal. 
        public string pricefilename;                        // Creates and empty variable and stores each new price list  as it is created. Each price list will be stored in a seperate file name e.g. 1.prc.

        private StringReader myReader;

        public starclucks()
        {
            InitializeComponent();
        }

       
        private void coffeeBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Coffee ");                                   // Enables each  button to add the assigned name to the SalesLST.
            priceLST.Items.Add(String.Format("{0:0.00}", Coffee));           // The assigned cost to the PriceLST.
            OrderTotal = OrderTotal + Coffee;                                // Retrieves the variable which holds both the name and the price of the button and adds total so far in the OrderTotal variable.
            totalTXT.Text = OrderTotal.ToString();                           // Updates the order total text box to include the new total after it has updated and converted it to a string.
        }

        private void teaBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Tea ");
            priceLST.Items.Add(String.Format("{0:0.00}", Tea));
            OrderTotal = OrderTotal + Tea;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void LatteBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Latte ");
            priceLST.Items.Add(String.Format("{0:0.00}", Latte));
            OrderTotal = OrderTotal + Latte;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void gingerBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Gingerbread Latte ");
            priceLST.Items.Add(String.Format("{0:0.00}", GBLatte));
            OrderTotal = OrderTotal + GBLatte;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void caramelBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Caramel Latte ");
            priceLST.Items.Add(String.Format("{0:0.00}", CaramelLatte));
            OrderTotal = OrderTotal + CaramelLatte;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void whiteBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("White Hot Chocolate ");
            priceLST.Items.Add(String.Format("{0:0.00}", WHChocolate));
            OrderTotal = OrderTotal + WHChocolate;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void hcBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Black Forrest Hot Chocolate ");
            priceLST.Items.Add(String.Format("{0:0.00}", BFHChocolate));
            OrderTotal = OrderTotal + BFHChocolate;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void cokeBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Coke ");
            priceLST.Items.Add(String.Format("{0:0.00}", Coke));
            OrderTotal = OrderTotal + Coke;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void spriteBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Sprite ");
            priceLST.Items.Add(String.Format("{0:0.00}", Sprite));
            OrderTotal = OrderTotal + Sprite;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void waterBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Water ");
            priceLST.Items.Add(String.Format("{0:0.00}", Water));
            OrderTotal = OrderTotal + Water;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void hamBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Ham Sandwich ");
            priceLST.Items.Add(String.Format("{0:0.00}", HamSandwich));
            OrderTotal = OrderTotal + HamSandwich;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void cheeseBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Cheese Sandwich ");
            priceLST.Items.Add(String.Format("{0:0.00}", CheeseSandwich));
            OrderTotal = OrderTotal + CheeseSandwich;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void tunaBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Tuna Sandwich ");
            priceLST.Items.Add(String.Format("{0:0.00}", TunaSandwich));
            OrderTotal = OrderTotal + TunaSandwich;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void pickleBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Cheese n' Pickle Sandwich ");
            priceLST.Items.Add(String.Format("{0:0.00}", CnPSandwich));
            OrderTotal = OrderTotal + CnPSandwich;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void beefBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Beef Sandwich ");
            priceLST.Items.Add(String.Format("{0:0.00}", BeefSandwich));
            OrderTotal = OrderTotal + BeefSandwich;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void marsBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Mars bar ");
            priceLST.Items.Add(String.Format("{0:0.00}", MarsBar));
            OrderTotal = OrderTotal + MarsBar;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void snickersBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Snickers Bar ");
            priceLST.Items.Add(String.Format("{0:0.00}", SnickersBar));
            OrderTotal = OrderTotal + SnickersBar;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void yorkieBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Yorkie Bar ");
            priceLST.Items.Add(String.Format("{0:0.00}", YorkieBar));
            OrderTotal = OrderTotal + YorkieBar;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void lionBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Lion Bar ");
            priceLST.Items.Add(String.Format("{0:0.00}", LionBar));
            OrderTotal = OrderTotal + LionBar;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            if (this.priceLST.SelectedIndex >= 0)                                                  // Only run code if an item is selected.
            {
                double deductions = Convert.ToDouble(priceLST.GetItemText(priceLST.SelectedItem));   // Deducts selected item from the order list.

                OrderTotal = OrderTotal - deductions;                                              // Order total deducts cost of removed item price.

                totalTXT.Text = String.Format("{0:0.00}", OrderTotal).ToString();                  // Format then place the new orser total in the totalTXT box.

                this.salesLST.Items.RemoveAt(this.priceLST.SelectedIndex);                         // Removes items from the sales list.
                this.priceLST.Items.RemoveAt(this.priceLST.SelectedIndex);                         // Removes items from the price list.
                
            }
        }

        private void Checkdiscount()
        {
            if (OrderTotal > 7)                                                                    //Applies the 5% off discount required if the total is greater than 7.
            {
                                                                                                   //Allows the programme to edit the total should the user decide to remove items from thier order.
                double returnedvalue = 0;

                salesLST.Items.Add("5% Discount ");                                                // Adds item name to salesLST.
                returnedvalue = discount(OrderTotal);                                              // Calls the custom method discount sending the current sales total and returining the discounted sales total.
                priceLST.Items.Add(string.Format("{0:0.00}", "-" + returnedvalue));                 
                OrderTotal = OrderTotal - returnedvalue;                                           // Deducts discount amount.
                totalTXT.Text = string.Format("{0:0.00}", OrderTotal).ToString();                  // Displays total after discount has been applied.
                discountBTN.Enabled = false;                                                       // Disables discount button after use to prevent multiple discounts being applied.
            }
        }

        private void discountBTN_Click(object sender, EventArgs e)
        {
            Checkdiscount();
        }

        #region Custom Methods

        private double discount(double currentsalestotal)
        {
            double answer;                                                                   // Here the discount is calculated so that it can be applied.

            answer = (currentsalestotal / 100) * 5;

            return answer;
        }

        private void SaveOrder()
        {                                                                                    // Creates a file all=owing orders along with thier ordernumbers to be stored in files that can be recalled through the 'recall Order' button.
            int loopcount = salesLST.Items.Count;

            salesfilename = appPath + "\\" + ordernumber.ToString() + ".sal";
            pricefilename = appPath + "\\" + ordernumber.ToString() + ".prc";

            System.IO.StreamWriter salesobjWriter;
            System.IO.StreamWriter PriceobjWriter;

            salesobjWriter = new System.IO.StreamWriter(salesfilename);
            PriceobjWriter = new System.IO.StreamWriter(pricefilename);

            

            foreach (var item in salesLST.Items)
            {
                salesobjWriter.WriteLine(item);
            }

            foreach (var item in priceLST.Items)
            {
                PriceobjWriter.WriteLine(item);
            }

            salesobjWriter.Close();
            PriceobjWriter.Close();
        }

        private void Vieworder()                                                           // Allows the programme to fetch and execute the file wanted by the user 
        {
            string pastordernum = ordernumTXT.Text;                                        // Retrieves order number inputted by the user from the text box.

            salesfilename = appPath + "\\" + pastordernum + ".sal";                        // Sets the file path for the sales to open.
            pricefilename = appPath + "\\" + pastordernum + ".prc";                       // sets the file path for the price to open.

            if (System.IO.File.Exists(salesfilename) == true)                             // Checks the file exists
            {
                System.IO.StreamReader salesobjReader;                                   // Creates an instance of the reader object.

                using (salesobjReader = new System.IO.StreamReader(salesfilename))
                {
                    while (salesobjReader.Peek() >= 0)                                    // Reads the file line by line until the end of teh file.
                    {
                        salesLST.Items.Add(salesobjReader.ReadLine());                    // Adds each line to the sales list.
                    }
                }
            }

            else                                                                           
            {
                MessageBox.Show("File Not found");                                       // If the file does not exsist then a message box will appear showing the message 'File Not Found'.
            }

            if (System.IO.File.Exists(pricefilename) == true)
            {
                System.IO.StreamReader priceobjreader;

                using (priceobjreader = new System.IO.StreamReader(pricefilename))
                {
                    while (priceobjreader.Peek() >= 1)
                    {
                        priceLST.Items.Add(priceobjreader.ReadLine());
                    }
                }
            }
            else
            {
                MessageBox.Show("File Not Found");
            }


            string fred;
            double subtotal = 0;

            for (int i = 0; i != (priceLST.Items.Count); i++)                            // Totals price items from priceLST as it reads them line by line.                          
            {
                fred = priceLST.Items[i].ToString();                                     // Read all the items in the file as they appear.
                subtotal = subtotal + Convert.ToDouble(fred);                            // Converts total to a double as it totals the items.

                totalTXT.Text = subtotal.ToString();                                     // Present the total after it has been converted back to a string value.
            }

            OrderTotal = 0;                                                              // Reset the totalTXT box value back to 0 to stop the total carrying over to the next order.

        }


        private void startnoBTN_Click(object sender, EventArgs e)
        {
            SaveOrder();
            OrderTotal = 0;                                                          //This operation allows the start New Order button to clear both the Price and sales columns as well as the total order box and will reset the discount button. 
            salesLST.Items.Clear();
            priceLST.Items.Clear();
            totalTXT.Text = "";
            Newordernum();
            
        }

        private void Newordernum()
        {
            ordernumber++;                                                          // This allows the order number to be increased by one each time an order is stored.
            ordernumLBL.Text = ordernumber.ToString();                              // Displays the new order number  on screen.
            discountBTN.Enabled = true;                                             // Enables the discount buttonto be applied.

        }

        private void starclucks_Load(object sender, EventArgs e)
        {
            ordernumLBL.Text = ordernumber.ToString();
        }

        protected void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;                                              // This creates a print function for the customer so the user can print a receipt. This also sets the layout and text for the receipt for when each receipt is printed. 
            float yPosition = 0;                                                 // The print function is stored in the Designer.cs view of the programme. This can easily be tested using a downlaodable cute PDF writer. Other printers can be added to print out receipts. 
            int count = 0;                                                       // Creates lines per page and boundaries and margins for the layoit of the receipt.
            float leftmargin = ev.MarginBounds.Left;
            float topmargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.priceLST.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);   // Calculates lines per page.

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))      

            {
                yPosition = topmargin + (count * printFont.GetHeight(ev.Graphics));    // Calculates the next line positions based on height of the font.

                ev.Graphics.DrawString(line, printFont,myBrush, leftmargin,yPosition, new StringFormat());  // Draws the next line in the rich edit control.
                count++;
            }

            if (line != null)                                                          // If there are too many lines print more than one page.
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

            myBrush.Dispose();
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)             // This event runs when the application is closing.
        {                                                                                // Saves your application and order number when the programme is closing.
            Properties.Settings.Default.cordernum = ordernumber;                         // Writes the last order number to user settings.
            Properties.Settings.Default.Save();
        }

        


        private void printReceiptToolStripMenuItem_Click(object sender, EventArgs e)      // Print Button.
        {                                                                                 // Creates the information and layout required for the receipt along with the order number. T
            {                                                                             // This will print out a receipt listing all items and prices, the order number, order total and dsicount if it has been applied. 
            printDialog1.Document = printDocument1;
            string strText = "";

            strText = strText + "Your Receipt" + "\n" + "\n";                             // Adds Text to the top of the receipt.
            strText = strText + "Order Number: " + ordernumLBL.Text + "\n" + "\n";

            for (int i = 0; i != (priceLST.Items.Count); i++)                             // Loop through each listed item from both lists adding them to the receipt.
            {
                strText = strText + salesLST.Items[i].ToString() + " £ " + priceLST.Items[i].ToString() + "\n";
            }

            strText = strText + "Order Total: " + totalTXT.Text + "\n" + "\n";           // This will display the order total on the receipt. 
            strText = strText + "Thanks for Visiting!" + "\n";                           // This will display the message 'Thanks for Visiting' on the reciept.

            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }

        }
        }

        private void recallBTN_Click(object sender, EventArgs e)
        {
            salesLST.Items.Clear();                                                        // Recall button clears both lists and allows the user to view the order they have recalled.
            priceLST.Items.Clear(); 
            Vieworder();
            ordernumLBL.Text = ordernumTXT.Text;
            
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();                                                            // This allows the user to exit the application without locking it in the debugging phase

        }

        private void totalTXT_TextChanged(object sender, EventArgs e)
        {
            CheckTotal();
        }

        private void CheckTotal()
        {
            totalTXT.Enabled = false;                                                      // Disables the totalTXT box from being edited.
        }

        private void totalTXT_TextChanged_1(object sender, EventArgs e)
        {

        }

            
    }

    }
