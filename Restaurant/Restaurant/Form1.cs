using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormRest : Form
    {
        public FormRest()
        {
            InitializeComponent();
        }

        private void bMenuAdd_Click(object sender, EventArgs e)
        {
            if (tbMenuDesk.Text != "")
            {
                string newitem = "";
                string[] tempa;
                for (int i = lbFood.SelectedItems.Count - 1; i >= 0; i--)
                {
                    newitem = lbFood.SelectedItems[i].ToString();
                    tempa = newitem.Split('#');
                    lbOrder.Items.Add(tempa[0]);
                    lbPrice.Items.Add(tempa[1]);
                    lbDesk.Items.Add(tbMenuDesk.Text);
                    if (cbDesk.Items.IndexOf(tbMenuDesk.Text) == -1)
                    {
                        cbDesk.Items.Add(tbMenuDesk.Text);
                        cbDesk.Text = tbMenuDesk.Text;
                    }
                }
                lbEvents.Items.Add("Order items (num: " + lbFood.SelectedItems.Count + ").");
                lbFood.SelectedItems.Clear();
            }
            else
            {
                lbEvents.Items.Add("Empty Desk.");
            }
        }

        private void bAddNewFood_Click(object sender, EventArgs e)
        {
            string food = tbFood.Text;
            string price = tbPrice.Text;
            int iPrice = 0;
            string newitem;
            food = food.Replace('#', '_');
            if (food.Length > 0)
            {
                try
                {
                    iPrice = Convert.ToInt32(price);
                    newitem = food + '#' + price;
                    if (lbFood.Items.IndexOf(newitem) == -1)
                    {
                        lbFood.Items.Add(newitem);
                    }
                    else
                    {
                        lbEvents.Items.Add("This food and price combo is already exists.");
                    }
                }
                catch (Exception ex)
                {
                    lbEvents.Items.Add("Not a number.");
                }                
            }
            else
            {
                lbEvents.Items.Add("Empty food name.");
            }
        }

        private void bOrderRemove_Click(object sender, EventArgs e)
        {
            lbPrice.Items.RemoveAt(lbOrder.SelectedIndex);
            lbDesk.Items.RemoveAt(lbOrder.SelectedIndex);
            lbOrder.Items.RemoveAt(lbOrder.SelectedIndex);
            lbEvents.Items.Add("Storno order item.");
        }

        private void lbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPrice.SelectedIndex = lbOrder.SelectedIndex;
            lbDesk.SelectedIndex = lbOrder.SelectedIndex;
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            int total = 0;
            bool next = true;
            double tip = 0;
            try
            {
                tip = Convert.ToDouble(tbTip.Text);
            }
            catch (Exception ex)
            {
                next = false;
                lbEvents.Items.Add("Error while converting Tip.");
            }
            if ((cbDesk.Text != "") && (next))
            {
                lbBill.Items.Clear();
                lbBill.Items.Add("RESTAURANT BILL");
                lbBill.Items.Add("Desk identity: " + cbDesk.Text);
                lbBill.Items.Add("======================================");
                for (int i = 0; i < lbOrder.Items.Count; i++)
                {                    
                    if (lbDesk.Items[i].ToString().Equals(cbDesk.Text))
                    {
                        lbBill.Items.Add(lbOrder.Items[i].ToString().PadRight(20,'.') + lbPrice.Items[i].ToString().PadLeft(10,'.'));
                        total += Convert.ToInt32(lbPrice.Items[i]);
                    }
                }
                lbBill.Items.Add("======================================");
                lbBill.Items.Add("Tip...................." + tip +"%");
                lbBill.Items.Add("Total sum.............." + total);
                total = Convert.ToInt32( total * (1 + (tip / 100)));
                lbBill.Items.Add("Total sum with tip....." + total);
                lbBill.Items.Add("");
                lbBill.Items.Add("Thank you for entering!");

            }
            else
            {
                lbEvents.Items.Add("No selected Desk.");
            }
        }
       
    }
}