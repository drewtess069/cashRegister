using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace cashRegister
{
    public partial class Form1 : Form
    {
        //Set variables needed multiple times as global variables

        double hotdogPrice = 5;
        double hotdog;
        double sausagePrice = 6;
        double sausage;
        double drinkPrice = 2;
        double drink;

        double hotdogs;
        double sausages;
        double drinks;

        double subtotal;
        double taxRate = 0.13;
        double tax;
        double tendered;

        double total;
        double change;

        int time = 300;

        Random randGen = new Random();
        int randomNumber;

        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                //Play sound when button is clicked
                SoundPlayer kachingPlayer = new SoundPlayer(Properties.Resources.kaching);
                kachingPlayer.Play();

                //Convert text box inputs to variable type: double
                hotdog = Convert.ToDouble(hotdogInput.Text);
                sausage = Convert.ToDouble(sausageInput.Text);
                drink = Convert.ToDouble(drinkInput.Text);

                //Do the math to find the total price spent on each food item
                hotdogs = hotdog * hotdogPrice;
                sausages = sausage * sausagePrice;
                drinks = drink * drinkPrice;

                //More math to calculate subtotat, tax and total
                subtotal = hotdogs + sausages + drinks;
                tax = subtotal * taxRate;
                total = subtotal + tax;

                //Display the subtotal, tax and total values
                subtotalOutput.Text = subtotal.ToString("C");
                taxOutput.Text = tax.ToString("C");
                totalOutput.Text = total.ToString("C");

                //Enable the change button
                changeButton.Enabled = true;
                tenderedInput.Enabled = true;
            }
            catch
            {
                //If any input boxes aren't filled, they will be set to zero,
                //button gets reclicked so program can continue
                if ((hotdogInput.Text == "") && (sausageInput.Text == ""))
                {
                    hotdogInput.Text = "0";
                    sausageInput.Text = "0";
                    calculateButton_Click(sender, e);
                }
                else if ((hotdogInput.Text == "") && (drinkInput.Text == ""))
                {
                    hotdogInput.Text = "0";
                    drinkInput.Text = "0";
                    calculateButton_Click(sender, e);
                }
                else if ((sausageInput.Text == "") && (drinkInput.Text == ""))
                {
                    sausageInput.Text = "0";
                    drinkInput.Text = "0";
                    calculateButton_Click(sender, e);
                }
                else if (hotdogInput.Text == "")
                {
                    hotdogInput.Text = "0";
                    calculateButton_Click(sender, e);
                }
                else if (sausageInput.Text == "")
                {
                    sausageInput.Text = "0";
                    calculateButton_Click(sender, e);
                }
                else if (drinkInput.Text == "")
                {
                    drinkInput.Text = "0";
                    calculateButton_Click(sender, e);
                }
                else
                {
                    //If the computer encounters an error when trying to execute code above
                    //display "error" and reset program
                    hotdogInput.Clear();
                    sausageInput.Clear();
                    drinkInput.Clear();

                    totalOutput.Text = "";
                    tenderedInput.Clear();
                    changeOutput.Text = "";

                    subtotalOutput.Text = "ERROR";
                    taxOutput.Text = "";
                    tenderedInput.Enabled = false;
                    Refresh();
                    Thread.Sleep(1000);

                    subtotalOutput.Text = "";
                    tenderedInput.Enabled = true;
                }
            }
        }
        private void changeButton_Click(object sender, EventArgs e)
        {

            try
            {
                //play sound when button pressed
                SoundPlayer kachingPlayer = new SoundPlayer(Properties.Resources.kaching);
                kachingPlayer.Play();

                //do variable conversions to type: double
                tendered = Convert.ToDouble(tenderedInput.Text);

                //If the buyer puts in less money than the total they will get a transaction failed message
                if (tendered < total)
                {
                    changeOutput.Text = "ERROR";
                    Refresh();
                    Thread.Sleep(1000);

                    receiptButton_Click(sender, e);
                    nameReceiptLabel.Text = "TRANSACTION\nFAILED";
                }
                else
                {
                    //do math to find change. Store as variable
                    change = tendered - total;
                    //display change value
                    changeOutput.Text = change.ToString("C");

                    //enable receipt button
                    receiptButton.Enabled = true;
                }
            }
            catch
            {
                if (tenderedInput.Text == "")
                {
                    tenderedInput.Text = "0";
                    changeButton_Click(sender, e);
                }
                //If code above is failed to execute, display error and reset program
                hotdogInput.Clear();
                sausageInput.Clear();
                drinkInput.Clear();

                subtotalOutput.Text = "";
                taxOutput.Text = "";
                tenderedInput.Text = "";

                changeOutput.Text = "ERROR";
                Refresh();
                Thread.Sleep(1000);

                changeOutput.Text = "";
                changeButton.Enabled = false;
            }
        }
        private void receiptButton_Click(object sender, EventArgs e)
        {
            if (tendered >= total)
            {
                //play receipt sound
                SoundPlayer receiptPlayer = new SoundPlayer(Properties.Resources.receipt);
                receiptPlayer.Play();

                //Display name of company at top of receipt
                nameReceiptLabel.Text = "Drew's Dogs";
                Refresh();
                Thread.Sleep(time);

                //Display individual prices for hotdogs, drinks and sausages
                itemLabel.Text = $"   Hotdogs x{hotdog.ToString()}";
                receiptLabel.Text = hotdogs.ToString("C");
                Refresh();
                Thread.Sleep(time);

                itemLabel.Text += $"\n\n   Sausages x{sausage.ToString()}";
                receiptLabel.Text += $"\n\n{sausages.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                itemLabel.Text += $"\n\n   Drinks x{drink.ToString()}";
                receiptLabel.Text += $"\n\n{drinks.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                //display all final prices: subtotal, change, tendered, tax, total
                itemLabel.Text += "\n\n\n   Subtotal";
                receiptLabel.Text += $"\n\n\n{subtotal.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                itemLabel.Text += "\n\n   Tax";
                receiptLabel.Text += $"\n\n{tax.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                itemLabel.Text += "\n\n   Total";
                receiptLabel.Text += $"\n\n{total.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                itemLabel.Text += "\n\n   Tendered";
                receiptLabel.Text += $"\n\n{tendered.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                itemLabel.Text += "\n\n   Change Due";
                receiptLabel.Text += $"\n\n{change.ToString("C")}";
                Refresh();
                Thread.Sleep(time);

                //create a random variable for the order number
                randomNumber = randGen.Next(0, 1000);
                itemLabel.Text += $"\n\n   Order #{randomNumber}";
            }
            else
            {
                //If the amount tendered is less than the total price, transaction is unsuccessful
                nameReceiptLabel.Text = "TRANSACTION\nFAILED";
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            //clear all inputs and outputs
            hotdogInput.Clear();
            sausageInput.Clear();
            drinkInput.Clear();

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Clear();
            changeOutput.Text = "";

            nameReceiptLabel.Text = "";
            itemLabel.Text = "";
            receiptLabel.Text = "";

            //disable buttons that aren't needed at the beginning of the program
            changeButton.Enabled = false;
            receiptButton.Enabled = false;

            //reset variables to 0
            hotdog = 0;
            sausage = 0;
            drink = 0;

            hotdogs = 0;
            sausages = 0;
            drinks = 0;

            subtotal = 0;
            tax = 0;
            tendered = 0;

            total = 0;
            change = 0;
        }
    }
}